namespace Projeto1GFT.src.Models
{
    public abstract class Champion
    {
        public Champion(string Name, int Level, string ChampionType)
        {
            this.Name = Name;
            this.Level = Level;
            this.ChampionType = ChampionType;
        }

        public Champion()
        {

        }
        public string Name;
        public int Level;
        public string ChampionType;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.ChampionType;
        }
        
        public virtual string Attack()
        {
            return this.Name + " Atacou!";
        }
    }
}