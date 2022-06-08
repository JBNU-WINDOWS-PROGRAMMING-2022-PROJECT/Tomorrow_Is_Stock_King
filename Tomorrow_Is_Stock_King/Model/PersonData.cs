using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Tomorrow_Is_Stock_King.Model
{
    public class PersonData : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Pair> stocks;

        public List<Pair> Stocks
        {
            get { return stocks; }
            set { stocks = value; }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        // 추후의 사용을 위해 미리 구현
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public PersonData()
        {
            Name = "";
            Stocks = new List<Pair>();
        }
    }
}
