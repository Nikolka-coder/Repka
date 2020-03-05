using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repka
{
    public interface ICharacter
    {
        string Name { get; set; }
        int Damage { get; set; }
    }
}
