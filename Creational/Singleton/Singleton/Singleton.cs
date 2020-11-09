using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    class Singleton
    {
        private static volatile Singleton instance;//tranh dung do thread
       static object key = new object();
        public static Singleton Instance
        {
            get {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Singleton();
                    }
                }
                return instance; }
           
        }
        private Singleton()
        {

        }
        public void Demo()
        {
            MessageBox.Show("okok");
        }
        public void Printstring(string s)
        {
            { MessageBox.Show(s); }
        }
        public string whoami = "Muoi";
        

        
    }
}
