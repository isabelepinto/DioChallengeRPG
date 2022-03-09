namespace jogoRPG.SRC.Entities
{
    public class Ninja: Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP)
                        : base(Name, Level, HeroType, HP, MP){}
        
        public override string Attack()
        {
            return ($"{this.Name} - Lançou fogo");
        }

        public string Attack(int Bonus)
        {
            if(Bonus>10){
                return ($"{this.Name} - Super bonus de {Bonus}. \n\n{this.Name} venceu!");
            }
            else if(Bonus>6)
            {
                return ($"{this.Name} - Lançou fogo super efetivo com bonus de {Bonus}.");
            }else{
                return ($"{this.Name} - Lançou fogo com força fraca com bonus de {Bonus}.");
            }
            
        }
    }
}