﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class PeopleWithDog:People
    {
        public override void SetPet()
        {
            myPet = new Dog("googogo");
        }
    }
}
