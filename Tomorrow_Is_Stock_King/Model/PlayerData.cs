﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomorrow_Is_Stock_King.Model
{
    internal class PlayerData : PersonData, INotifyPropertyChanged
    {
        private long curMoney;

        public long CurMoney
        {
            get { return curMoney; }
            set { curMoney = value; }
        }

        private long stockMoney;

        public long StockMoney
        {
            get { return stockMoney; }
            set { stockMoney = value; }
        }

        private long totalMoney;

        public long TotalMoney
        {
            get { return totalMoney; }
            set { totalMoney = value; }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}