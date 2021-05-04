using System;

namespace FemaleFriendsHousbandsHomework
{
    class Program
    {
        static void Main()
        {
            CharacterRaceHuman sergey = new CharacterRaceHuman("seRGEy", "male", 1.8f, 100, true);
            Console.WriteLine($"Race Human, name {sergey.Name}, gender {sergey.Gender}, diplomacy {sergey.Diplomacy}, HP {sergey.HealpPoints}");

            CharacterRaceHuman john = new CharacterRaceHuman("johnik", "male", 1.8f, 0, false);
            Console.WriteLine($"Race Human, name {john.Name}, gender {john.Gender}, diplomacy {john.Diplomacy}, HP {sergey.HealpPoints}");

            CharacterRaceElf roman = new CharacterRaceElf("roman", "male", 1.8f, 80, 5.2f, 100);
            Console.WriteLine($"Now we have The Elf, name {roman.Name}, gender {roman.Gender}, sexuality is {roman.SexualityLevel}, HP {roman.HealpPoints}");

            CharacterRaceDwarf kapkanec = new CharacterRaceDwarf("sasha", "male", 1.1f, 100, "xxx", true, true);

            Console.WriteLine($"Dwarf {kapkanec.Name} is in da house!");

        }
    }
}
