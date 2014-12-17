using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.ComponentModel;

namespace HangCards_GUI
{
    [Serializable]
    public class GameOptions : INotifyPropertyChanged
    {
        private ObservableCollection<string> _playerNames = new ObservableCollection<string>();
        public List<string> SelectedPlayers { get; set; }

        //public bool PlayAgainstComputer { get; set; }
        //public int NumOfPlayers { get; set; }
        //public int MinutesBeforeLoss { get; set; }
        //public ComputerSkillLevel ComputerSkill { get; set; }

        private bool _playAgainstComputer = true;
        private int _numberOfPlayers = 2;
        private int _minutedBeforeLoss = 10;
        private ComputerSkillLevel _computerSkill = ComputerSkillLevel.Dumb;

        public int NumberOfPlayers
        {
            get
            {
                return _numberOfPlayers;
            }
            set
            {
                _numberOfPlayers = value;
                OnPropertyChanged("NumberOfPlayers");
            }
        }

        public bool PlayAgainstComputer
        {
            get
            {
                return _playAgainstComputer;
            }
            set
            {
                _playAgainstComputer = value;
                OnPropertyChanged("PlayAgainstComputer");
            }
        }

        public int MinutedBeforeLoss
        {
            get
            {
                return _minutedBeforeLoss;
            }
            set
            {
                _minutedBeforeLoss = value;
                OnPropertyChanged("MinutedBeforeLoss");
            }
        }

        public ComputerSkillLevel ComputerSkill
        {
            get
            {
                return _computerSkill;
            }
            set
            {
                _computerSkill = value;
                OnPropertyChanged("ComputerSkill");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;      //event关键字用于在发行者类中声明事件；PropertyChangedEventHandler表示将处理PropertyChanged事件的方法；PropertyChanged事件在更改组件上的属性时引发
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public GameOptions()
        {
            SelectedPlayers = new List<string>();
        }

        public ObservableCollection<string> PlayerNames
        {
            get
            {
                return _playerNames;
            }
            set
            {
                _playerNames = value;
                OnPropertyChanged("PlayerNames");
            }
        }

        public void AddPlayer(string playerName)
        {
            if (_playerNames.Contains(playerName))
                return;
            _playerNames.Add(playerName);
            OnPropertyChanged("PlayerNames");
        }
    }

    [Serializable]
    public enum ComputerSkillLevel
    {
        Dumb,
        Good,
        Cheats
    }
}
