using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repka.Entities
{
    public sealed class Repa
    {
        public int HP { get; set; }
        public Repa(int hp)
        {
            HP = hp;
        }
    }
}
