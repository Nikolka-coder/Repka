namespace Repka
{
    abstract class Character : ICharacter
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public Character(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
        public abstract void DoSomething();
        public abstract void CallHelp();
    }
}
