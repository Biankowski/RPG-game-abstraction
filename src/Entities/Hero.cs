namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public string? Name;
        public string? HeroType;
        public int Level;
        public int HP;
        public int MP;

        public virtual string Attack()
        {
            return "";
        }
        public virtual string Attack(int power)
        {
            return "";
        }
    }
}