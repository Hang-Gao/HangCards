using CardLib;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

namespace HangCards_GUI
{
    public partial class CardControl : UserControl
    {
        public static DependencyProperty SuitProperty = DependencyProperty.Register(
           "Suit",
           typeof(CardLib.Suit),
           typeof(CardControl),
           new PropertyMetadata(CardLib.Suit.Club, new PropertyChangedCallback(OnSuitChanged)));

        public static DependencyProperty RankProperty = DependencyProperty.Register(
           "Rank",
           typeof(CardLib.Rank),
           typeof(CardControl),
           new PropertyMetadata(CardLib.Rank.Ace));

        public static DependencyProperty IsFaceUpProperty = DependencyProperty.Register(
       "IsFaceUp",
       typeof(bool),
       typeof(CardControl),
       new PropertyMetadata(true, new PropertyChangedCallback(OnIsFaceUpChanged)));

        private CardLib.Card _card;
        public CardLib.Card Card
        {
            get { return _card; }
            private set { _card = value; Suit = _card.suit; Rank = _card.rank; }
        }

        public CardControl()
        {
            InitializeComponent();
        }

        public CardControl(Card card)
        {
            InitializeComponent();

            Card = card;
        }

        public bool IsFaceUp
        {
            get { return (bool)GetValue(IsFaceUpProperty); }
            set { SetValue(IsFaceUpProperty, value); }
        }

        public CardLib.Suit Suit
        {
            get { return (CardLib.Suit)GetValue(SuitProperty); }
            set { SetValue(SuitProperty, value); }
        }

        public CardLib.Rank Rank
        {
            get { return (CardLib.Rank)GetValue(RankProperty); }
            set { SetValue(RankProperty, value); }
        }


        private void SetTextColor()
        {
            var color = (Suit == CardLib.Suit.Club || Suit == CardLib.Suit.Spade) ?
              new SolidColorBrush(Color.FromRgb(0, 0, 0)) :
              new SolidColorBrush(Color.FromRgb(255, 0, 0));
            RankLabel.Foreground = SuitLabel.Foreground = RankLabelInverted.Foreground = color;
        }

        public static void OnSuitChanged(DependencyObject source,
           DependencyPropertyChangedEventArgs args)
        {
            var control = source as CardControl;
            control.SetTextColor();
        }

        private static void OnIsFaceUpChanged(DependencyObject source, DependencyPropertyChangedEventArgs args)
        {
            var control = source as CardControl;
            control.RankLabel.Visibility = control.SuitLabel.Visibility = control.RankLabelInverted.Visibility =
              control.TopRightImage.Visibility = control.BottomLeftImage.Visibility = control.IsFaceUp ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
