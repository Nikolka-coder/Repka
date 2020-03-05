using Repka.Entities;
using System;
using System.Collections.Generic;

namespace Repka
{
    public class FaryTale
    {
        private readonly Repa _repa;
        private readonly IEnumerable<ICharacter> _characters;

        public delegate void Message(string message);
        public event Message Messages;

        public FaryTale(IEnumerable<ICharacter> characters, Repa repa)
        {
            _characters = characters;
            _repa = repa;
        }

        public void Play()
        {
            foreach (var i in _characters)
            {
                _repa.HP -= i.Damage;
            }
            if (_repa.HP <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Messages?.Invoke("Мышка за Машку, Машка за Жучку, Жучка за внучку, внучка за бабку, бабка за дедку, дедка за репку: тянут-потянут - Вытащили репку!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Messages?.Invoke("Мышка за Машку, Машка за Жучку, Жучка за внучку, внучка за бабку, бабка за дедку, дедка за репку: тянут-потянут - Всеровно вытянуть не могут:(");
                Console.ResetColor();
            }
        }
    }
}
