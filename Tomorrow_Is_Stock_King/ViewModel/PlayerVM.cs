using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tomorrow_Is_Stock_King.Model;
using Tomorrow_Is_Stock_King.ViewModel.Commands.StartSettingWindowCommands;

namespace Tomorrow_Is_Stock_King.ViewModel
{
    public class PlayerVM
    {
        public PlayerData PlayerDataToShow { get; set; }
        public StartBtnCommand StartBtnCommand { get; set; }

        public PlayerVM()
        {
            PlayerDataToShow = new PlayerData();
            StartBtnCommand = new StartBtnCommand(this);
        }

        public void setName(string name)
        {
            PlayerDataToShow.Name = name;
        }
    }
}
