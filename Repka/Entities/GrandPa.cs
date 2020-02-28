using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class GrandPa : Human
    {
        public GrandPa(string name, int damage)
            : base(name, damage) { }
        public override void DoSomething()
        {
            Console.WriteLine($"Стал {Name} репку из земли тащить: тянет-потянет, вытянуть не может!");
        }

        public override void CallHelp()
        {
            Console.WriteLine($"Позвал  {Name} на помощь бабку!");
        }
        public void Create()
        {
            Console.WriteLine($"Посадил {Name} репку. выросла репка большая-пребольшая");
        }
    }
}
