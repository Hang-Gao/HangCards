using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
  [Serializable]
  public enum PlayerState
  {
    Inactive,
    Active,
    MustDiscard,
    Winner,
    Loser
  }
}
