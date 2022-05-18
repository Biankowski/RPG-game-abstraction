namespace RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight()
        {
        }
        public Knight(string Name, string HeroType, int Level, int HP, int MP)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
            this.HP = HP;
            this.HP = MP;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public override string Attack()
        {
            return "Knight attacked you with his Knife!! ->. Your demage was 5 HP";
        }

        public override string Attack(int power)
        {
            if (power > 99)
            {
                return "Knight attacked you with his sword!! --->. Your demage was 100 HP. You died!";
            }
            return "Knight attacked you with his sword!! --->. Your demage was " + power + "HP";
        }

    }
}
