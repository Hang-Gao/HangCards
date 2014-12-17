using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Xml.Serialization;

namespace HangCards_GUI
{
    /// <summary>
    /// Interaction logic for StartGame.xaml (标记应当用于描述类型或类型成员)
    /// </summary>
    public partial class StartGame : Window
    {
        private GameOptions _gameOptions;

        public StartGame()
        {
            if (_gameOptions == null)
            {
                if (File.Exists("GameOptions.xml"))
                {
                    using (var stream = File.OpenRead("GameOptions.xml"))                 //var此处为FileStream类型
                    {
                        var serializer = new XmlSerializer(typeof(GameOptions));          //可将指定类型的对象序列化为XML文档                       
                        _gameOptions = serializer.Deserialize(stream) as GameOptions;     //反序列化指定stream包含的XML文档
                    }
                }
                else
                    _gameOptions = new GameOptions();
            }

            DataContext = _gameOptions;

            InitializeComponent();

            if (_gameOptions.PlayAgainstComputer)
                playerNamesListBox.SelectionMode = SelectionMode.Single;
            else
                playerNamesListBox.SelectionMode = SelectionMode.Extended;

        }

        private void playerNamesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_gameOptions.PlayAgainstComputer)
                okButton.IsEnabled = (playerNamesListBox.SelectedItems.Count == 1);
            else
                okButton.IsEnabled = (playerNamesListBox.SelectedItems.Count == _gameOptions.NumberOfPlayers);

        }

        private void addNewPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newPlayerTextBox.Text))
                _gameOptions.AddPlayer(newPlayerTextBox.Text);
            newPlayerTextBox.Text = string.Empty;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (string item in playerNamesListBox.SelectedItems)
            {
                _gameOptions.SelectedPlayers.Add(item);
            }

            using (var stream = File.Open("GameOptions.xml", FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(GameOptions));
                serializer.Serialize(stream, _gameOptions);
            }
            this.Close();
        }

        private void cancleButton_Click(object sender, RoutedEventArgs e)
        {
            _gameOptions = null;
            this.Close();
        }
    }
}
