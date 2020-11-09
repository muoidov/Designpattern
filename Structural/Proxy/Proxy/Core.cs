using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Core:ACore
    {

        private string name;
        public override string GetName()
        {
            return this.name;
        }
        public Core(string name)
        {
            this.name = name;
        }
    }
}
