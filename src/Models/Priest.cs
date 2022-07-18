namespace Projeto1GFT.src.Models
{
    public class Priest : Champion
    {
        public Priest(string Name, int Level, string ChampionType)
        {
            this.Name = Name;
            this.Level = Level;
            this.ChampionType = ChampionType;
        }
        public override string Attack()
        {
            return this.Name + " Usou magia de cura!";
        }

        public string Attack(int Bonus)
        {
          if(Bonus > 5)
            {
                return this.Name + "Recebeu proteção e curou seus aliados: " + Bonus + " de cura adicional!";
            }
            else 
            {
                return this.Name + "Curou-se com bonus de: " + Bonus + " de cura adicional.";
            }
        }
    }
}