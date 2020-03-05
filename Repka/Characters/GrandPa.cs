﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repka
{
    class GrandPa : ICharacter
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public GrandPa(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}
