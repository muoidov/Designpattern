using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Elip:Core
    {
        private float r;

        public float R { get => r; set => r = value; }
        public override float TheTich()
        {
            return r * 3.14f;
        }
        public Elip(float r)
        {
            this.r = r;
        }
    }
}
