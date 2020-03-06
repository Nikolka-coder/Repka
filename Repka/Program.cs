using Repka;
using Repka.Entities;
using Repka.Services;
using System;

namespace Turnip
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var list = new MyList<ICharacter>();
            list.Add(new GrandPa("Дед", rnd.Next(33, 40)));
            list.Add(new GrandMa("Бабка", rnd.Next(24, 30)));
            list.Add(new GrandDaughter("Внучка", rnd.Next(14, 19)));
            list.Add(new Dog("Жучка", rnd.Next(3, 8)));
            list.Add(new Cat("Мурка", rnd.Next(7, 14)));
            list.Add(new Mouse("Мышка", rnd.Next(1, 5)));
            var repa = new Repa(100);
            var fary = new FaryTale(list, repa);
            fary.Messages += DisplayMessage;
            fary.Play();   
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}


