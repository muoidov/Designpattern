using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        hinhduocghep newDg = new hinhduocghep();
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(newDg.TheTich().ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox selected = sender as CheckBox;
            if (selected.Name == "checkBox1")
            {
                if (selected.Checked)
                {
                    newDg.AddShap(new Hinhchunhat((float)numericUpDown1.Value, (float)numericUpDown2.Value));
                }
                else
                {
                    newDg.RemoveShap(new Hinhchunhat((float)numericUpDown1.Value, (float)numericUpDown2.Value));
                }
        }else if (selected.Name == "checkBox2")
            {
                if (selected.Checked)
                {
                    newDg.AddShap(new Elip((float)numericUpDown3.Value));
                }
                else
                {
                    newDg.RemoveShap(new Elip((float)numericUpDown3.Value));
                }
            }

        }
    }
}
