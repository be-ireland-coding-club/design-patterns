namespace RPGAbstractFactory.Characters{
    public abstract class Character{
        protected string Class {get;set;}
        protected string Race {get;set;}

        public Character(string race, string characterClass){
            Class = characterClass;
            Race = race;
        }

        public override string ToString(){
            return $"{Race} {Class}";
        }
    }
}