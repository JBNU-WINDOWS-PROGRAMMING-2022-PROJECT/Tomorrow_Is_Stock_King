using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomorrow_Is_Stock_King.Model;
using Tomorrow_Is_Stock_King.ViewModel.Commands;

namespace Tomorrow_Is_Stock_King.ViewModel
{
    public class SettingVM
    {
        public SettingData SettingDataToShow { get; set; }
        public LevelBtnCommand LevelBtnCommand { get; set; }
        public UpdateTimeCommand UpdateTimeCommand { get; set; }

        public SettingVM()
        {
            SettingDataToShow = new SettingData();
            LevelBtnCommand = new LevelBtnCommand(this);
            UpdateTimeCommand = new UpdateTimeCommand(this);
        }

        public void setLevel(int lev)
       {
            SettingDataToShow.Level = lev;
        }

        public void setUpdateTime(int time)
        {
            SettingDataToShow.UpdateTime = time;
        }
    }
}
