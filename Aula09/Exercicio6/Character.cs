namespace Aula09
{
    public abstract class Character
    {
        public string Name { get; }

        public abstract char Move();

        public Character(string name)
        {
            Name = name;
        }
    }
}
