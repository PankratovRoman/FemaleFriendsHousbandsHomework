using System;
using System.Collections.Generic;
using System.Text;

namespace FemaleFriendsHousbandsHomework
{
    abstract class LAIICharacterBase
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
        //Спроси у Сергея за автосвойства. Вот тут, например, у нас есть поле и свойство, в которое не заложено логики. Надо ли создавать сокрытое поле?
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

        //Проверки перенести в конструктор?
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
        protected LAIICharacterBase(string namePostfix)
        {
            if (namePostfix.Length != 3)
                throw new Exception("Be true! Use 3-chars postfixes! Re-create your character.");
            NamePostfix = namePostfix;
        }
        protected LAIICharacterBase(string name, string gender, float height, int healthPoints, string namePostfix) : this(namePostfix)
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
}
