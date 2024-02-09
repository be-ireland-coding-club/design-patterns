using RPGAbstractFactory.Enums;

namespace RPGAbstractFactory.Factories{
    public interface ICharacterFactory{
        ICharacterRaceFactory GetCharacterFactory(Race race, RPGClass rpgClass);
    }
}