using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            People fisrt = new PeopleWithDog();
            fisrt.SetPet();
            People second = new PeopleWithCat();
            second.SetPet();
            fisrt.PetInfo();
            second.PetInfo();
        }
    }
}
