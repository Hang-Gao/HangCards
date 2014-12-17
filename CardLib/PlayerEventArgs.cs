using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
  public class PlayerEventArgs : EventArgs
  {
    public Player Player { get; set; }
    public PlayerState State { get; set; }
  }
}
