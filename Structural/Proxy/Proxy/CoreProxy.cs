using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CoreProxy:ACore
    {
        bool isAdmin = false;
        public override string GetName()
        {
            if (isAdmin)
            {
                Core core = new Core("Deo the tin duoc");
               return core.GetName();
            }
            return null; 
        }
        public CoreProxy(bool isadmin)
        {
            this.isAdmin = isadmin;
        }
    }
}
