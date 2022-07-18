namespace Projeto1GFT.src.Models
{
    public class Knight : Champion
    {

        public Knight(string Name, int Level, string ChampionType)
        {
            this.Name = Name;
            this.Level = Level;
            this.ChampionType = ChampionType;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com sua espada!";
        }

       public string Attack(int Bonus)
        {
          if(Bonus > 5)
            {
                return this.Name + "Acertou um golpe de espada inflingindo dano crítico: " + Bonus + " de dano adicional!";
            }
            else 
            {
                return this.Name + "Acertou um golpe normal " + Bonus + " de dano adicional.";
            }
        }
    }
}