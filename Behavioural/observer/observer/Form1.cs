using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product sanpham = new Product("Alien where 999");
            Custemor cus1 = new Custemor("Action1", "123912931");
            Custemor cus2 = new Custemor("Action2", "29312131");
            sanpham.AddCustomer(cus1);
            sanpham.AddCustomer(cus2);
            sanpham.ObserverInfo("ok");

        }
    }
}
