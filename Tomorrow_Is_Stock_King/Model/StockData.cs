using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomorrow_Is_Stock_King.Model
{


    public class Item : INotifyPropertyChanged
    {
        private string srtnCd;
        public string SrtnCd
        {
            get { return srtnCd; }
            set { srtnCd = value; OnPropertyChanged("SrtnCd"); }
        }
        private string clpr;
        public string Clpr
        {
            get { return clpr; }
            set { clpr = value; OnPropertyChanged("Clpr"); }
        }
        private string itmsNm;
        public string ItmsNm
        {
            get { return itmsNm; }
            set { itmsNm = value; OnPropertyChanged("ItmsNm"); }
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

    public class Items : INotifyPropertyChanged
    {
        private IList<Item> item;
        public IList<Item> Item
        {
            get { return item; }
            set { item = value; OnPropertyChanged("item"); }
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

    public class Body : INotifyPropertyChanged
    {
        private Items items;
        public Items Items
        {
            get { return items; }
            set { items = value; OnPropertyChanged("Items"); }
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

    public class Response : INotifyPropertyChanged
    {
        private Body body;
        public Body Body
        {
            get { return body; }
            set { body = value; OnPropertyChanged("Body"); }
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

    public class Example : INotifyPropertyChanged
    {
        private Response response;
        public Response Response
        {
            get { return response; }
            set { response = value; OnPropertyChanged("Response"); }
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
