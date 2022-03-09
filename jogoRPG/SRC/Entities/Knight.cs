namespace jogoRPG.SRC.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP)
                        : base(Name, Level, HeroType, HP, MP){}
        
        public override string Attack()
        {
            return ($"{this.Name} - Atacou com sua espada");
        }


        public string Attack(int Bonus)
        {
            if(Bonus>10){
                return ($"{this.Name} - Super bonus de {Bonus}. \n\n{this.Name} venceu!");
            }
            else if(Bonus>6)
            {
                return ($"{this.Name} - Atacou com sua espada super efetivamente com bonus de{Bonus}.");
            }else{
                return ($"{this.Name} - Atacou com sua espada com força fraca com bonus de {Bonus}.");
            }
            
        }
    }
}