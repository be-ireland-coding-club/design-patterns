using RPGAbstractFactory.Characters;

namespace RPGAbstractFactory.Factories{
    public interface ICharacterRaceFactory{
        Character CreateCharacter();
    }
}