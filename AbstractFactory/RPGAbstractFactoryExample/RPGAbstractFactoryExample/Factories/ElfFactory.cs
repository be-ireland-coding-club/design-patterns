using RPGAbstractFactory.Characters;
using RPGAbstractFactory.Enums;

namespace RPGAbstractFactory.Factories{
    public class ElfFactory : ICharacterRaceFactory{
        private RPGClass _class;

        public ElfFactory(RPGClass rpgClass){
            _class = rpgClass;
        }
        public Character CreateCharacter(){
            return _class switch
            {
                RPGClass.Mage => new ElfMage(),
                RPGClass.Warrior => new ElfWarrior(),
                RPGClass.Cleric => new ElfCleric(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}