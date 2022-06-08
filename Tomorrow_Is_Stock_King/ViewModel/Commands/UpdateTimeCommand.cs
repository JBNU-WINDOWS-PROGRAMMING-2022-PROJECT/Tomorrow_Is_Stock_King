using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tomorrow_Is_Stock_King.ViewModel.Commands
{
    public class UpdateTimeCommand : ICommand
    {
        SettingVM VM { get; set; }
        public UpdateTimeCommand(SettingVM vm)
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
            VM.setUpdateTime(int.Parse((string)parameter));
        }
    }
}
