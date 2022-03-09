namespace jogoRPG.SRC.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP)
                        : base(Name, Level, HeroType, HP, MP){}
        
        public override string Attack()
        {
            return ($"{this.Name} - Lançou magia");
        }

        public string Attack(int Bonus)
        {
            
            if(Bonus>10){
                return ($"{this.Name} - Super bonus de {Bonus}. \n\n{this.Name} venceu!");
            }
            else if(Bonus>6)
            {
                return ($"{this.Name} - Lançou magia super efetiva com bonus de {Bonus}.");
            }else{
                return ($"{this.Name} - Lançou magia com força fraca com bonus de {Bonus}.");
            }
            
        }
    }
}