using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    class Adapter
    {
        Core core = new Core();
        public List<string> chuanhoalistchuoi(List<string> ds)
        {
            List<string> ls = new List<string>();
            foreach(string item in ds)
            {
                ls.Add(core.chuanhoachuoi(item));
            }
            return ls;
        }
    }
}
