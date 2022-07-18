namespace Projeto1GFT.src.Models
{
    public class Beserker : Champion
    {
        public Beserker(string Name, int Level, string ChampionType)
        {
            this.Name = Name;
            this.Level = Level;
            this.ChampionType = ChampionType;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com o machado!";
        }

        public string Attack(int Bonus)
        {
          if(Bonus > 5)
            {
                return this.Name + "Acertou um golpe de machado inflingindo dano crítico: " + Bonus + " de dano adicional!";
            }
            else 
            {
                return this.Name + "Acertou um golpe de machado comum: " + Bonus + " de dano adicional.";
            }
        }
    }
}