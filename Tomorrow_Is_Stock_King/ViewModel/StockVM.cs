using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tomorrow_Is_Stock_King.Model;
using Tomorrow_Is_Stock_King.View.Usercontrol;

namespace Tomorrow_Is_Stock_King.ViewModel
{
    public class StockVM
    {
        private List<List<Item>> turnList;
        public List<List<Item>> TurnList
        {
            get { return turnList; }
            set { turnList = value; }
        }
        private Item item;
        public Item Item
        {
            get { return item; }
            set { item = value; OnPropertyChanged("Item"); }
        }
        public List<Item> StockDataToShow { get; set; }
        public ObservableCollection<string> Companies { get; set; }
        public StockGraphChartUserControl StockGraphChart { get; set; }
        private string selectedStock;   //ex> 삼성전자string
        public string SelectedStock
        {
            get { return selectedStock; }
            set { selectedStock = value; GetStockGraph(); }
        }


        public StockVM()
        {
            StockDataToShow = new List<Item>();
            TurnList = new List<List<Item>>();
            Companies = new ObservableCollection<string>();
            
        }
        public void GetCompanies()
        {
            Companies.Add("삼성전자");
            Companies.Add("카카오");
            Companies.Add("SK하이닉스");
        }
        public void GetStock(string stock_date)  //턴종료마다 발동
        {
            for (int i = 0; i < Companies.Count; i++)
            {
                var stock = StockAPI.GetStockData(stock_date, Companies[i]);
                StockDataToShow.Add(stock);

            }
            Item = StockDataToShow[0];
            List<Item> temp = new List<Item>();
            for(int i=0; i<StockDataToShow.Count; i++)
            {
                temp.Add(StockDataToShow[i]);
            }
            TurnList.Add(temp);  //1턴 완성
            StockDataToShow.Clear();
            
        }
        public void GetStockGraph()
        {
            
            int index = Companies.IndexOf(selectedStock);
            if(index < 0)
            {
                index = 0;
            }
            for(int i=0; i<TurnList.Count; i++)
            {
                var temp = TurnList[i][index];
                Item.Clpr = temp.Clpr;
                Item.ItmsNm = temp.ItmsNm;
                item.SrtnCd = temp.SrtnCd;
            }
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
