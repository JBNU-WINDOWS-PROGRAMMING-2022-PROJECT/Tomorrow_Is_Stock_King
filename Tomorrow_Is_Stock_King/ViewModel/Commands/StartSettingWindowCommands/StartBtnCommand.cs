using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Tomorrow_Is_Stock_King.Windows;

namespace Tomorrow_Is_Stock_King.ViewModel.Commands.StartSettingWindowCommands
{
    public class StartBtnCommand : ICommand
    {
        PlayerVM VM { get; set; }
        public StartBtnCommand(PlayerVM vm)
        {
            VM = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            GameMainWindow gamemainwindow = new GameMainWindow();
            gamemainwindow.Show();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = gamemainwindow;

            VM.setName((string)parameter);
        }
    }
}
