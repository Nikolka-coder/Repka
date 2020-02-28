using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    abstract class Animal : IAnimal
    {
        public string Alies { get; set; }
        public int Damage { get; set; }
        public Animal(string alies, int damage)
        {
            Alies = alies;
            Damage = damage;
        }
        public abstract void DoSomething();
        public abstract void CallHelp();
        public Human Human { get; set; }
    }
}
