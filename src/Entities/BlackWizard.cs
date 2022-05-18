namespace RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard()
        {
        }

        public BlackWizard(string Name, string HeroType, int Level, int HP, int MP)
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
            return "Wizard put a spell on you! Your demage was 5 HP";
        }

        public override string Attack(int power)
        {
            if (power > 99)
            {
                return "Wizard put a spell on you! ^/^. Your demage was 100 HP. You died!";
            }
            return "Wizard put a spell on you! ^/^. Your demage was " + power + "HP";
        }

    }
}
