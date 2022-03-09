using System.Security.AccessControl;
namespace jogoRPG.SRC.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public string Name { get; set; }
        
        public int Level { get; set; }
        
        public string HeroType { get; set; }

        public int HP { get; set; }

        public int MP { get; set; }
        

        public override string ToString()
        {
            return ($"{this.Name} {this.Level} {this.HeroType} {this.MP} {this.HP}");
        }
        
        public virtual string Attack()
        {
            return this.Name;
        }


    }
}