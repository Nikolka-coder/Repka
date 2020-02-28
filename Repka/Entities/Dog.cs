using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Dog : Animal
    {
        public Dog(string alies, int damage)
            : base(alies, damage) { }
        public override void DoSomething()
        {
            Console.WriteLine($"{Alies} за внучку, внучка за бабку, бабка за дедку, дедка за репку: тянут-потянут, вытянуть не могут!");
        }
        public override void CallHelp()
        {
            Console.WriteLine($"Bark bark woof bark (Кликнула собачка {Alies} кошку Машку.)");
        }
        public void Win()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Alies} за внучку, внучка за бабку, бабка за дедку, дедка за репку: тянут-потянут - Вытащили репку");
        }
    }
}
