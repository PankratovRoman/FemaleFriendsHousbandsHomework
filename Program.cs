using System;

namespace FemaleFriendsHousbandsHomework
{
   
    abstract class LAIICharacter
    {
        string name;
        string gender;
        float height;
        int healthPoints;
        string namePostfix;
        //weight, manaPoints, weaponPtiority
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                {
                    return name;
                }
                else
                {
                    return name.Substring(0, 1).ToUpper() + name[1..].ToLower() + namePostfix;
                }
            }
            set
            {
                name = value;
            }
        }
        public string NamePostfix
        {
            get
            {
                return namePostfix;
            }
            set
            {
                if (value.Length != 3) Console.WriteLine("Be true! Use 3-chars postfixes! Recreate your character.");
                else namePostfix = value;
            }
        }
        public string Gender
        {
            get { return gender;
            }
            set {
                if (value != "male" && value != "female")
                    Console.WriteLine("Gender is not defined, and we dont like such creatures. Recreate your character.");
                else
                    gender = value; }
        }
        public float Height
        {
            get { return height; }
            set
            {
                if (value > 2.2f || value < 1.1f)
                {
                    Console.WriteLine("Height limits are 1.1 to 2.2");
                }
                else height = value;
            }
        }
        public int HealpPoints
        {
            get { return healthPoints; }
            set
            {
                if (value < 80 || value > 120)
                {
                    Console.WriteLine("HP limits are 80 to 120");
                }
                else healthPoints = value;
            }
        }
        protected LAIICharacter(string namePostfix)
        {
            NamePostfix = namePostfix;
        }
        protected LAIICharacter(string name, string gender, float height, int healthPoints, string namePostfix)
        {
            Name = name;
            Gender = gender;
            Height = height;
            HealpPoints = healthPoints;
            NamePostfix = namePostfix;
        }
    }

    class Human : LAIICharacter
    {
        int diplomacyLavel;
        bool haveDragon;
        public int Diplomacy
        {
            get { return diplomacyLavel; }
            set
            {
                if (value > 100 || value < 0) Console.WriteLine("Diplomacy lavel can be from 0 to 100");
                //if (haveDragon) diplomacyLavel = value + 20;
                else diplomacyLavel = value;
            }
        }
        public bool HaveDragon { get { return haveDragon; } set { haveDragon = value; } }
        public Human():base("mir")
        {

        }
        public Human(string name, string gender, float height, int diplomacyLavel, bool haveDragon) : base(name, gender, height, 100, "mir")
        {
            Diplomacy = diplomacyLavel;
            HaveDragon = haveDragon;
        }
    }

    class Elf : LAIICharacter
    {
        float earLenght;
        int sexuality;
        public float EarLenght { get { return earLenght; } set { earLenght = value; } }
        public int SexualityLevel
        {
            get { return sexuality; }
            set
            {
                if (value > 100 || value < 0) Console.WriteLine("Sexuality lavel can be from 0 to 100");
                else sexuality = value;
            }
        }
        public Elf() : base("el")
        {
        }
        public Elf(string name, string gender, float height, int healthPoints, float earLenght, int sexuality) : base(name, gender, height, healthPoints, "el'")
        {
            EarLenght = earLenght;
            SexualityLevel = sexuality;
        }
    }


    class Program
    {
        static void Main()
        {
            Human sergey = new Human("seRGEy", "male", 1.8f, 100, true);
            Console.WriteLine( $"Race Human, name {sergey.Name}, gender {sergey.Gender}, diplomacy {sergey.Diplomacy}, HP {sergey.HealpPoints}");
            Human john = new Human
            {
                Name = "johnik",
                Gender = "male",
                Height = 1.8f,
                HealpPoints = 100,
                HaveDragon = false
            };
            Console.WriteLine($"Race Human, name {john.Name}, gender {john.Gender}, diplomacy {john.Diplomacy}, HP {sergey.HealpPoints}");

            Elf roman = new Elf("roman", "male", 1.8f, 80, 5.2f, 100);
            Console.WriteLine($"Now we have The Elf, name {roman.Name}, gender {roman.Gender}, sexuality is {roman.SexualityLevel}, HP {roman.HealpPoints}");
        }
    }
}
