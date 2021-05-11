using FemaleFriendsHusbandsHomework.Weapons;
using System;

namespace FemaleFriendsHusbandsHomework
{
    class Program
    {
        //CharacterRaceHuman sergey = new CharacterRaceHuman("seRGEy", "male", 1.8f, 100, true);
        public static CharacterRaceHuman john = new CharacterRaceHuman("johnik", "male", 1.8f, 0, false);
        public static CharacterRaceElf roman = new CharacterRaceElf("roman", "male", 1.8f, 5.2f, 100);
        public static CharacterRaceDwarf kapkanec = new CharacterRaceDwarf("sasha", "male", 1.1f, true, true);
        public static LAIICharacterBase GetCharacter(int selectedIndex)
        {
            return selectedIndex switch
            {
                1 => john,
                2 => roman,
                3 => kapkanec,
                _ => throw new Exception("Select 1, 2 or 3"),
            };
        }
        static void Main()
        {


            Bow peril = new Bow("Bow of Peril", 70);
            Sword damascus = new Sword("Sword of Damascus", 50);
            Blunt battlehammer = new Blunt("Battlehammer", 40);

            

            //sergey.Equip(damascus);
            //roman.Equip(peril);
            //kapkanec.Equip(battlehammer);

            //Console.WriteLine($"Race Human, name Sir {sergey.FullName}, HP {sergey.HealthPoints}");
            Console.WriteLine($"Race Human, name Sir {john.FullName}, HP {john.HealthPoints}");
            Console.WriteLine($"Now we have The Elf, name {roman.FullName} The Beauty, sexuality is {roman.SexualityLevel}, HP {roman.HealthPoints}");
            Console.WriteLine($"Dwarf {kapkanec.FullName} is in da house! HP is {kapkanec.HealthPoints}");
            Console.WriteLine();
            Console.WriteLine($"{john.FullName}'s total damage: {john.TotalDamage}");
            Console.WriteLine($"{roman.FullName}'s total damage: {roman.TotalDamage}");
            Console.WriteLine($"{kapkanec.FullName}'s total damage: {kapkanec.TotalDamage}");
            Console.WriteLine();
            Console.WriteLine($"The {peril.Name} has dropped.");
            Console.WriteLine($"The {damascus.Name} has dropped.");
            Console.WriteLine($"The {battlehammer.Name} has dropped.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Select your character: ");
            int selectIndex = Convert.ToInt32(Console.ReadLine());
            var selectedCaracter = GetCharacter(selectIndex);
            Console.WriteLine(selectedCaracter.Name);

            Console.WriteLine($"{kapkanec.FullName}'s HP before HIT {kapkanec.HealthPoints}");
            selectedCaracter.Hit(kapkanec);
            Console.WriteLine($"{kapkanec.FullName}'s HP after HIT {kapkanec.HealthPoints} ");
            selectedCaracter.Hit(kapkanec);
            Console.WriteLine($"{kapkanec.FullName}'s HP after HIT {kapkanec.HealthPoints} ");

        }
    }
}
