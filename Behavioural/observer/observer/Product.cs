using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace observer
{
    class Product: Observer
    {
        
       private List<Custemor> cl = new List<Custemor>();
        private string name;
        public string Name { get => name; set => name = value; }  

        public override void ObserverInfo(string info)
        {
            foreach(Custemor item in cl)
            {
                if (item != null)
                {
                    item.ObserverInfo(name);
                }
            }
        }
        public Product(string name)
        {
            this.Name = name;
        }
        public void AddCustomer(Custemor cus)
        {
            if (cus != null)
            {
                cl.Add(cus);
            }
        }
        public void RemoveCustomer(Custemor cus)
        {
            if (cus != null)
            {
                cl.Remove(cus);
            }
        }
    }
}
