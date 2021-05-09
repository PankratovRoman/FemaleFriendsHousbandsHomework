using FemaleFriendsHusbandsHomework.Weapons;
using System;

namespace FemaleFriendsHusbandsHomework
{
    class Program
    {
        static void Main()
        {
            CharacterRaceHuman sergey = new CharacterRaceHuman("seRGEy", "male", 1.8f, 100, true);
            Console.WriteLine($"Race Human, name {sergey.FullName}, gender {sergey.Gender}, diplomacy {sergey.Diplomacy}, HP {sergey.HealthPoints}");

            CharacterRaceHuman john = new CharacterRaceHuman("johnik", "male", 1.8f, 0, false);
            Console.WriteLine($"Race Human, name {john.FullName}, gender {john.Gender}, diplomacy {john.Diplomacy}, HP {sergey.HealthPoints}");

            CharacterRaceElf roman = new CharacterRaceElf("roman", "male", 1.8f, 80, 5.2f, 100);
            Console.WriteLine($"Now we have The Elf, name {roman.FullName}, gender {roman.Gender}, sexuality is {roman.SexualityLevel}, HP {roman.HealthPoints}");

            CharacterRaceDwarf kapkanec = new CharacterRaceDwarf("sasha", "male", 1.1f, 100, true, true);

            Console.WriteLine($"Dwarf {kapkanec.FullName} is in da house!");
            Console.WriteLine();

            Bow peril = new Bow("Bow of Peril", 100);
            Sword damascus = new Sword("Sword of Damascus", 100);
            Blunt battlehammer = new Blunt("Battlehammer", 100);
            sergey.Equip(damascus);
            roman.Equip(peril);
            kapkanec.Equip(battlehammer);
            Console.WriteLine($"{sergey.FullName}'s total damage: {sergey.TotalDamage}");
            Console.WriteLine($"{roman.FullName}'s total damage: {roman.TotalDamage}");
            Console.WriteLine($"{kapkanec.FullName}'s total damage: {kapkanec.TotalDamage}");


        }
    }
}
