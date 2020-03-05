using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repka
{
    class GrandDaughter : ICharacter
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public GrandDaughter(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}
