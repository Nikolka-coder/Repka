using Repka;
using System;

namespace Turnip
{
    class Program
    {
        delegate void Message();
        static void Main(string[] args)
        {
            
            GrandPa grandpa = new GrandPa("Дед", Randomizer(33, 40));
            Message mes =  grandpa.Create;
            Repka.Entities.Repka rep = new Repka.Entities.Repka(100);
            mes += grandpa.DoSomething;
            rep.HP -= grandpa.Damage;
            mes += grandpa.CallHelp;

            GrandMa grandma = new GrandMa("Бабка", Randomizer(24, 30));
            mes += grandma.DoSomething;
            rep.HP -= grandma.Damage;
            mes += grandma.CallHelp;

            GrandDaughter granddot = new GrandDaughter("Внучка", Randomizer(14, 19));
            mes += granddot.DoSomething;
            rep.HP -= granddot.Damage;
            mes += granddot.CallHelp;

            Dog dog = new Dog("Жучка", Randomizer(7, 14));
            rep.HP -= dog.Damage;
            if (rep.HP <= 0)
            {
                mes += dog.Win;
                mes();
                goto end;
            }
            mes += dog.DoSomething;
            mes += dog.CallHelp;

            Cat cat = new Cat("Машка", Randomizer(3, 8));
            rep.HP -= cat.Damage;
            if (rep.HP <= 0)
            {
                mes += cat.Win;
                mes();
                goto end;
            }
            mes += cat.DoSomething;
            mes += cat.CallHelp;

            Mouse mou = new Mouse("Мышка", Randomizer(1, 5));
            rep.HP -= mou.Damage;
            if (rep.HP <= 0)
            {
                mes += mou.DoSomething;
                mes();
            }
            else
            {
                mes += mou.Lose;
                mes();
            }

            end:
            Console.ReadKey();
        }
        public static int Randomizer(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
    }
    }

