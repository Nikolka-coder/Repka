using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Cat : Animal
    {
        public Cat(string alies, int damage)
            : base(alies, damage) { }
        public override void DoSomething()
        {
            Console.WriteLine($"{Alies} за Жучку, Жучка за внучку, внучка за бабку, бабка за дедку, дедка за репку: тянут-потянут, вытянуть не могут! ");
        }
        public override void CallHelp()
        {
            Console.WriteLine($"MEOW MEEEOOOW MEE-WOOOW (Кликнула кошка {Alies} мышку)");
        }
        public void Win()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Alies} за Жучку, Жучка за внучку, внучка за бабку, бабка за дедку, дедка за репку: тянут-потянут - Вытащили репку");
        }
    }
}
