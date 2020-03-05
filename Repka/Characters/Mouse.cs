using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repka
{
    class Mouse : ICharacter
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Mouse(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}
