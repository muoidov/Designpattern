using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Hinhchunhat:Core
    {
        private float dai;  

        public float Dai { get => dai; set => dai = value; }
        public float Rong { get => rong; set => rong = value; }

        private float rong;
        public override float TheTich()
        {
            return dai * rong;
        }
        public Hinhchunhat(float dai,float rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
    }
}
