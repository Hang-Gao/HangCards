using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
  public class CardEventArgs : EventArgs
  {
    public Card Card { get; set; }
  }
}
