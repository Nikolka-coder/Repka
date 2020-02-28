using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repka.Entities
{
    sealed class Repka
    {
        public int HP { get; set; }
        public Repka(int hp)
        {
            HP = hp;
        }
    }
}
