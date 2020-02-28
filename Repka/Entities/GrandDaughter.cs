using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repka
{
    class GrandDaughter : Character
    {
        public GrandDaughter(string name, int damage)
           : base(name, damage) { }
        public override void DoSomething()
        {
            Console.WriteLine($"{Name} за бабку, бабка за дедку, дедка за репку: тянут-потянут, вытянуть не могут!");
        }
        public override void CallHelp()
        {
            Console.WriteLine($"Позвала {Name} собачку Жучку");
        }
    }
}
