using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class hinhduocghep:Core
    {
        List<Core> list = new List<Core>();
            public override float TheTich()
        {
            float TongThetich = 0;
            foreach(var item in list)
            {
                TongThetich += item.TheTich();
            }
            return TongThetich;
        }
        public void AddShap(Core hinh)
        {
            if (hinh != null)
            {
                list.Add(hinh);
            }
        }
        public void RemoveShap(Core hinh)
        {
            if (hinh != null)
            {
                list.Remove(hinh);
            }
           
            

            
        }
        
    }
}
