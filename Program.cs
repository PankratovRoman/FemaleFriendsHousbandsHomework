using System;

namespace FemaleFriendsHousbandsHomework
{
    abstract class LAIICharacter
    {
        protected string name;
        protected string gender;
        protected float height;
        protected int healthPoints;
        protected string namePostfix;
        //weight, manaPoints, weaponPtiority
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    name = value ?? string.Empty; // ?? - если Null, то даст string.Empty
                }
                else
                {
                    name = value.Substring(0, 1).ToUpper() + value[1..].ToLower() + namePostfix;
                }
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
                namePostfix = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value != "male" && value != "female")
                    Console.WriteLine("Gender is not defined, and we dont like such creatures. Recreate your character.");
                else
                    gender = value;
            }
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
        protected LAIICharacter()
        {
        }
        protected LAIICharacter(string namePostfix)
        {
            if (namePostfix.Length != 3)
                throw new Exception("Be true! Use 3-chars postfixes! Re-create your character.");
            NamePostfix = namePostfix;
        }
        protected LAIICharacter(string name, string gender, float height, int healthPoints, string namePostfix) : this(namePostfix)
        {
            Name = name;
            Gender = gender;
            Height = height;
            HealpPoints = healthPoints;
        }
        protected bool CheckParameter(int paramInt, int min = 0, int max = 100)
        {
            return paramInt >= min && paramInt <= max;
        }

    }

    class Human : LAIICharacter
    {
        int _diplomacyLevel;
        public int Diplomacy
        {
            get { return _diplomacyLevel + 20 * Convert.ToInt32(HaveDragon); } //True и False по сути 1 и 0, можно сделать вот так. Круто!; 
            set { _diplomacyLevel = value; }
        }
        public bool HaveDragon { get; set; }

        public Human(string name, string gender, float height, int diplomacyLevel, bool haveDragon) : base(name, gender, height, 100, "mir")
        {
            if (!CheckParameter(diplomacyLevel))
                throw new Exception("Diplomacy level can only be between 0 and 100");
            HaveDragon = haveDragon;
        }
    }

    class Elf : LAIICharacter
    {
        float _earLength;
        int _sexuality;
        public float EarLength { get { return _earLength; } set { _earLength = value; } }
        /// <summary>
        /// Уровень сексуальности
        /// </summary>
        public int SexualityLevel
        {
            get { return _sexuality; }
            set { _sexuality = value; }
        }
        public Elf() : base("iel")
        {
        }
        /// <summary>
        /// Эльфонструктор!
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="height"></param>
        /// <param name="healthPoints"></param>
        /// <param name="earLength">Длина уха</param>
        /// <param name="sexuality">Уровень сексуальности</param>
        public Elf(string name, string gender, float height, int healthPoints, float earLength, int sexuality) : base(name, gender, height, healthPoints, "iel")
        {
            if (!CheckParameter(sexuality))
                throw new Exception("Sexuality level can only be between 0 and 100");
            EarLength = earLength;
            SexualityLevel = sexuality;
        }
    }

    class Dwarf : LAIICharacter
    {
        bool _canCraft;
        bool _canTrade;
        public bool CanCraft { get { return _canCraft; } set { _canCraft = value; } }
        public bool CanTrade { get { return _canTrade; } set { _canTrade = value; } }

        private static readonly Random _rnd = new Random();
        public Dwarf() : base()
        {
            string[] dwarfPostfixes = { "ori", "fur", "lin" };
            int namePostfixIndex = _rnd.Next(dwarfPostfixes.Length);
            NamePostfix = dwarfPostfixes[namePostfixIndex];
        }

        public Dwarf(string name, string gender, float height, int healthPoints, string namePostfix, bool canCraft, bool canTrade) : base(name, gender, height, healthPoints, namePostfix)
        {
            CanCraft = canCraft;
            CanTrade = canTrade;
        }
    }

    class Program
    {
        static void Main()
        {
            Human sergey = new Human("seRGEy", "male", 1.8f, 100, true);
            Console.WriteLine($"Race Human, name {sergey.Name}, gender {sergey.Gender}, diplomacy {sergey.Diplomacy}, HP {sergey.HealpPoints}");

            Human john = new Human("johnik", "male", 1.8f, 0, false);
            Console.WriteLine($"Race Human, name {john.Name}, gender {john.Gender}, diplomacy {john.Diplomacy}, HP {sergey.HealpPoints}");

            Elf roman = new Elf("roman", "male", 1.8f, 80, 5.2f, 100);
            Console.WriteLine($"Now we have The Elf, name {roman.Name}, gender {roman.Gender}, sexuality is {roman.SexualityLevel}, HP {roman.HealpPoints}");

            Dwarf kapkanec = new Dwarf();
            kapkanec.Name = "sasha";
            Console.WriteLine($"Dwarf {kapkanec.Name} is in da house!");

        }
    }
}
