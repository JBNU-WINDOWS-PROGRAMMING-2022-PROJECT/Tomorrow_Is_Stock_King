﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Tomorrow_Is_Stock_King.ViewModel.Commands.GameMainWindowCommands
{
    public class SellStockCommand : ICommand
    {
        GameTurnVM GameTurnVM { get; set; }
        public SellStockCommand(GameTurnVM vm)
        {
            GameTurnVM = vm;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (parameter == null) return true;
            if ((string)parameter == "" || (string)parameter == "0") return false;

            if (!GameTurnVM.SettingVM.PlayerVM.PlayerDataToShow.Stocks.ContainsKey(GameTurnVM.StockVM.Item.ItmsNm))
            {
                return false;
            }

            return true;
        }

        public void Execute(object parameter)
        {
            GameTurnVM.SellStock((string)parameter);
        }
    }
}