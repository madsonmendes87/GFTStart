namespace Projeto1GFT.src.Models
{
    public class Wizard : Champion
    {
        public Wizard(string Name, int Level, string ChampionType)
        {
            this.Name = Name;
            this.Level = Level;
            this.ChampionType = ChampionType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou uma bola de fogo!";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 5)
            {
                return this.Name + "Acertou uma bola de fogo inflingindo queimação: " + Bonus + " de dano por queimação!";
            }
            else 
            {
                return this.Name + "Acertou uma bola de fogo comum: " + Bonus + " de dano adicional.";
            }
        }
    }
}