namespace Football
{
    abstract class Human : IHuman
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public Human(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
        public abstract void DoSomething();
        public abstract void CallHelp();
        public Animal Animal { get; set; }
    }
}
