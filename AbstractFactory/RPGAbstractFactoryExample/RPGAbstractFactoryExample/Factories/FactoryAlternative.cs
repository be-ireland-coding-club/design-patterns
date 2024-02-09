using RPGAbstractFactory.Characters;
using RPGAbstractFactory.Enums;

namespace RPGAbstractFactory.NoFactory{
    public class NoFactoryCharacterCreater{
        public Character CreateCharacter(Race race, RPGClass rpgClass){
            switch(race){
                case Race.Elf:
                    if(rpgClass == RPGClass.Mage){
                        return new ElfMage();
                    }
                    else if(rpgClass == RPGClass.Cleric){
                        return new ElfCleric();
                    }
                    else{
                        return new ElfWarrior();
                    }
                case Race.Human:
                    if(rpgClass == RPGClass.Mage){
                        return new HumanMage();
                    }
                    else if(rpgClass == RPGClass.Cleric){
                        return new HumanCleric();
                    }
                    else{
                        return new HumanWarrior();
                    }
                default:
                    throw new NotImplementedException();
            }
        }
    }
}