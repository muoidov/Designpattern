using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace observer
{
    class Custemor:Observer
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string phoneNumber;
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        
        public override void ObserverInfo(string info)
        {
            MessageBox.Show("Thong bao toi khach hang"+Name+"Co sdt"+PhoneNumber+"Thong tin san pham"+info);
        } 
        public Custemor(string name, string phone)
        {
            this.Name = name;
            this.PhoneNumber = phone;
        }

    }
}
