using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tomorrow_Is_Stock_King.ViewModel
{
    public class GameTurnVM : INotifyPropertyChanged
    {
        public StockVM StockVM { get; set; }
        private BackgroundWorker _bgworker = new BackgroundWorker();
        private int timerValue;

        public int TimerValue
        {
            get { return timerValue; }
            set 
            {
                timerValue = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TimerValue"));
                }
            }
        }

        public GameTurnVM()
        {
            StockVM = new StockVM();
            StockVM.GetCompanies();
            StockVM.GetStock("20220603");

            
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
