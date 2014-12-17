using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
  #region Delegate added in section "Expanding and Using CardLib"
  public delegate void LastCardDrawnHandler(Deck currentDeck);
  #endregion

  public class Deck : ICloneable
  {
    #region Event added in section "Expanding and Using CardLib"
    public event LastCardDrawnHandler LastCardDrawn;
    #endregion

    private Cards cards = new Cards();

    public Deck()
    {
      InsertAllCards();
    }

    private void InsertAllCards()
    {
      for (int suitVal = 0; suitVal < 4; suitVal++)
      {
        for (int rankVal = 1; rankVal < 14; rankVal++)
        {
          cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
        }
      }
    }

    private void InsertAllCards(List<Card> except)
    {
      for (int suitVal = 0; suitVal < 4; suitVal++)
      {
        for (int rankVal = 1; rankVal < 14; rankVal++)
        {
          var card = new Card((Suit)suitVal, (Rank)rankVal);
          if (except.Contains(card))
            continue;
          cards.Add(card);
        }
      }
    }

    public int CardsInDeck
    {
      get { return cards.Count; }
    }

    private Deck(Cards newCards)
    {
      cards = newCards;
    }

    /// <summary>
    /// Nondefault constructor. Allows aces to be set high.
    /// </summary>
    public Deck(bool isAceHigh)
      : this()
    {
      Card.isAceHigh = isAceHigh;
    }

    /// <summary>
    /// Nondefault constructor. Allows a trump suit to be used.
    /// </summary>
    public Deck(bool useTrumps, Suit trump)
      : this()
    {
      Card.useTrumps = useTrumps;
      Card.trump = trump;
    }

    /// <summary>
    /// Nondefault constructor. Allows aces to be set high and a trump suit
    /// to be used.
    /// </summary>
    public Deck(bool isAceHigh, bool useTrumps, Suit trump)
      : this()
    {
      Card.isAceHigh = isAceHigh;
      Card.useTrumps = useTrumps;
      Card.trump = trump;
    }

    public Card GetCard(int cardNum)
    {
      if (cardNum >= 0 && cardNum <= 51)
      {
        // Code modified in section "Expanding and Using CardLib"
        if ((cardNum == 51) && (LastCardDrawn != null))
          LastCardDrawn(this);
        return cards[cardNum];
      }
      else
        throw new CardOutOfRangeException(cards.Clone() as Cards);
    }

    public void Shuffle()
    {
      Cards newDeck = new Cards();
      bool[] assigned = new bool[cards.Count ];
      Random sourceGen = new Random();
      for (int i = 0; i < cards.Count ; i++)
      {
        int sourceCard = 0;
        bool foundCard = false;
        while (foundCard == false)
        {
          sourceCard = sourceGen.Next(cards.Count );
          if (assigned[sourceCard] == false)
            foundCard = true;
        }
        assigned[sourceCard] = true;
        newDeck.Add(cards[sourceCard]);
      }
      newDeck.CopyTo(cards);
    }

    public void ReshuffleDiscarded(List<Card> cardsInPlay)
    {
      InsertAllCards(cardsInPlay);
      Shuffle();
    }
    public Card Draw()
    {
      if (cards.Count == 0)
        return null;
      else
      {
        var card = cards[0];
        cards.RemoveAt(0);
        return card;
      }
    }

    public Card SelectCardOfSpecificSuit(Suit suit)
    {
      Card selectedCard = null;

      foreach (Card card in cards)
      {
        if (card.suit == suit)
        {
          selectedCard = card;
          break;
        }
      }
      if (selectedCard == null)
        return Draw(); // Can't cheat, no cards of the correct Suit
      else
      {
        cards.Remove(selectedCard);
      }
      return selectedCard;
    }

    public object Clone()
    {
      Deck newDeck = new Deck(cards.Clone() as Cards);
      return newDeck;
    }
  }
}
