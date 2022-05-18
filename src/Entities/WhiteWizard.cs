namespace RPG.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard()
        {
        }
        public WhiteWizard(string Name, string HeroType, int Level, int HP, int MP)
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

        public string Recover()
        {
            return "You recoverd you HP to 100%";
        }

    }
}