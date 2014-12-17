using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CardLib
{
  [Serializable]
  public class Player : INotifyPropertyChanged
  {
    public int Index { get; set; }
    protected Cards Hand { get; set; }
    private string _name;
    private PlayerState _state;

    public event EventHandler<CardEventArgs> OnCardDiscarded;
    public event EventHandler<PlayerEventArgs> OnPlayerHasWon;

    public PlayerState State
    {
      get
      {
        return _state;
      }
      set
      {
        _state = value;
        OnPropertyChanged("State");
      }
    }

    public virtual string PlayerName
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
        OnPropertyChanged("PlayerName");
      }
    }

    public void AddCard(Card card)
    {
      Hand.Add(card);
      if (Hand.Count > 7)
        State = PlayerState.MustDiscard;
    }

    public void DrawCard(Deck deck)
    {
      AddCard(deck.Draw());
    }

    public void DiscardCard(Card card)
    {
      Hand.Remove(card);
      if (HasWon && OnPlayerHasWon != null)
        OnPlayerHasWon(this, new PlayerEventArgs { Player = this, State = PlayerState.Winner });
      if (OnCardDiscarded != null)
        OnCardDiscarded(this, new CardEventArgs { Card = card });
    }

    public void DrawNewHand(Deck deck)
    {
      Hand = new Cards();
      for (int i = 0; i < 7; i++)
        Hand.Add(deck.Draw());
    }


    public bool HasWon
    {
      get
      {
        if (Hand.Count == 7)
        {
          var suit = Hand[0].suit;
          for (int i = 1; i < Hand.Count; i++)
            if (suit != Hand[i].suit)
              return false;
          return true;
        }
        return false;
      }
    }

    public Cards GetCards()
    {
      return Hand.Clone() as Cards;
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
  }

}
