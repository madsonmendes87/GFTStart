namespace Projeto1GFT.src.Models
{
    public class Paladino : Champion
    {
        public Priest(string Name, int Level, string ChampionType)
        {
            this.Name = Name;
            this.Level = Level;
            this.ChampionType = ChampionType;
        }
        public override string Attack()
        {
            return this.Name + " Usou arma da fé!";
        }

        public string Attack(int Bonus)
        {
          if(Bonus > 5)
            {
                return this.Name + "Canalizou energia positiva: " + Bonus + " de cura pelas mãos!";
            }
            else 
            {
                return this.Name + "Curou-se com bonus de: " + Bonus + " de cura adicional.";
            }
        }
    }
}