using RPGAbstractFactory.Characters;
using RPGAbstractFactory.Enums;

namespace RPGAbstractFactory.Factories{
    public class HumanFactory : ICharacterRaceFactory{
        private RPGClass _class;

        public HumanFactory(RPGClass rpgClass){
            _class = rpgClass;
        }
        public Character CreateCharacter(){
            return _class switch
            {
                RPGClass.Mage => new HumanMage(),
                RPGClass.Warrior => new HumanWarrior(),
                RPGClass.Cleric => new HumanCleric(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}