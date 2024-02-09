using RPGAbstractFactory.Characters;
using RPGAbstractFactory.Enums;

namespace RPGAbstractFactory.Factories{
    public class CharacterFactory : ICharacterFactory{
        public ICharacterRaceFactory GetCharacterFactory(Race race, RPGClass rpgClass){
            return race switch
            {
                Race.Human => new HumanFactory(rpgClass),
                Race.Elf => new ElfFactory(rpgClass),
                _ => throw new NotImplementedException(),
            };
        }
    }
}