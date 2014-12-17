//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HangCards_GUI
{
    public class NumberOfPlayers : ObservableCollection<int>
    {
        public NumberOfPlayers() : base()
        {
            Add(2);
            Add(3);
            Add(4);
        }
    }
}
