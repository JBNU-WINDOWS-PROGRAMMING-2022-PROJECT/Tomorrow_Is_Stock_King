using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tomorrow_Is_Stock_King.ViewModel.Commands
{
    public class LevelBtnCommand : ICommand
    {
        public SettingVM VM { get; set; }
        public LevelBtnCommand(SettingVM vm)
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
            VM.setLevel(int.Parse((string)parameter));
        }
    }
}
