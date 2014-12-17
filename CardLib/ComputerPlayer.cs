using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
  [Serializable]
  public class ComputerPlayer : Player
  {
    private Random _random = new Random();

    public ComputerSkillLevel Skill { get; set; }

    public override string PlayerName
    {
      get { return string.Format("Computer {0}", Index); }
      set { /* Do nothing, name is calculated */ }
    }

    public void PerformDraw(Deck deck, Card availableCard)
    {
      switch (Skill)
      {
        case ComputerSkillLevel.Dumb:
          DrawCard(deck);
          break;
        default:
          DrawBestCard(deck, availableCard, (Skill == ComputerSkillLevel.Cheats));
          break;
      }
    }

    public void PerformDiscard(Deck deck)
    {
      switch (Skill)
      {
        case ComputerSkillLevel.Dumb:
          int discardIndex = _random.Next(Hand.Count);
          DiscardCard(Hand[discardIndex]);
          break;
        default:
          DiscardWorstCard();
          break;
      }
    }

    private void DrawBestCard(Deck deck, Card availableCard, bool cheat = false)
    {
      var bestSuit = CalculateBestSuit();
      if (availableCard.suit == bestSuit)
        AddCard(availableCard);
      else if (cheat == false)
        DrawCard(deck);
      else
        AddCard(deck.SelectCardOfSpecificSuit(bestSuit));
    }

    private void DiscardWorstCard()
    {
      var worstSuit = CalculateWorstSuit();
      foreach (Card card in Hand)
      {
        if (card.suit == worstSuit)
        {
          DiscardCard(card);
          break;
        }
      }
    }

    private Suit CalculateBestSuit()
    {
      Dictionary<Suit, List<Card>> cardSuits = new Dictionary<Suit, List<Card>>();
      cardSuits.Add(Suit.Club, new List<Card>());
      cardSuits.Add(Suit.Diamond, new List<Card>());
      cardSuits.Add(Suit.Heart, new List<Card>());
      cardSuits.Add(Suit.Spade, new List<Card>());
      int max = 0;
      Suit currentSuit = Suit.Club;

      foreach (Card card in Hand)
      {
        cardSuits[card.suit].Add(card);
        if (cardSuits[card.suit].Count > max)
        {
          max = cardSuits[card.suit].Count;
          currentSuit = card.suit;
        }
      }
      return currentSuit;
    }

    private Suit CalculateWorstSuit()
    {
      Dictionary<Suit, List<Card>> cardSuits = new Dictionary<Suit, List<Card>>();
      cardSuits.Add(Suit.Club, new List<Card>());
      cardSuits.Add(Suit.Diamond, new List<Card>());
      cardSuits.Add(Suit.Heart, new List<Card>());
      cardSuits.Add(Suit.Spade, new List<Card>());
      int min = Hand.Count;
      Suit currentSuit = Suit.Club;

      foreach (Card card in Hand)
      {
        cardSuits[card.suit].Add(card);
      }
      foreach (var item in cardSuits)
      {
        if (item.Value.Count > 0 && item.Value.Count < min)
        {
          min = item.Value.Count;
          currentSuit = item.Key;
        }
      }
      return currentSuit;
    }
  }

}
