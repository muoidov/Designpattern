using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class Form1 : Form
    {//Tao ra 1 thuc the do chinh la ky thuat singleton duoc tao ra tu 1 cai gi do co the tao ra bat cu noi nao

        public Form1()
        {
            InitializeComponent();
            Singleton.Instance.Demo();
            Singleton.Instance.Printstring("sadad");
            //o cho constructor public
            //muon su dung phai thong qua 1 thuc the
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
