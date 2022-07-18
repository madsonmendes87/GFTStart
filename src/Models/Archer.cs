namespace Projeto1GFT.src.Models
{
    public class Archer : Champion
    {
        public Archer(string Name, int Level, string ChampionType)
        {
            this.Name = Name;
            this.Level = Level;
            this.ChampionType = ChampionType;
        }
        public override string Attack()
        {
            return this.Name + " Atirou uma flecha!";
        }

        public string Attack(int Bonus)
        {
          if(Bonus > 5)
            {
                return this.Name + "Acertou uma flechada inflingindo dano crítico: " + Bonus + " de dano adicional!";
            }
            else 
            {
                return this.Name + "Acertou uma flechada: " + Bonus + " de dano adicional.";
            }
        }
    }
}