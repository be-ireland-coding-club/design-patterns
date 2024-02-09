using RPGAbstractFactory.Factories;
using RPGAbstractFactory.Enums;

var characterFactory = new CharacterFactory();

Console.WriteLine(characterFactory.GetCharacterFactory(Race.Elf, RPGClass.Mage).CreateCharacter().ToString());
Console.WriteLine(characterFactory.GetCharacterFactory(Race.Elf, RPGClass.Warrior).CreateCharacter().ToString());
Console.WriteLine(characterFactory.GetCharacterFactory(Race.Elf, RPGClass.Cleric).CreateCharacter().ToString());
Console.WriteLine(characterFactory.GetCharacterFactory(Race.Human, RPGClass.Mage).CreateCharacter().ToString());
Console.WriteLine(characterFactory.GetCharacterFactory(Race.Human, RPGClass.Warrior).CreateCharacter().ToString());
Console.WriteLine(characterFactory.GetCharacterFactory(Race.Human, RPGClass.Cleric).CreateCharacter().ToString());