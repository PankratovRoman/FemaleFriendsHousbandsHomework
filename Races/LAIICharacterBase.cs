using FemaleFriendsHusbandsHomework.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemaleFriendsHusbandsHomework
{
    abstract class LAIICharacterBase
    {
        #region Fields
        protected string name;
        protected string gender;
        protected float height;
        protected int healthPoints;
        protected DamageType typeMastery;
        protected const int Penalty = 20;
        //weight, manaPoints, weaponPtiority
        #endregion

        #region Properties
        public LAIIWeaponBase Weapon { get; protected set; }

        public int TotalDamage => (Weapon?.Damage - (Weapon?.DamageType == typeMastery ? 0 : Penalty)) ?? 5; //?. - если не Null, тогда вызываем свойство
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
                    name = value.Substring(0, 1).ToUpper() + value[1..].ToLower();
                }
            }
        }
        public string FullName => Name + NamePostfix;

        public string NamePostfix
        {
            get; protected set;
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
        public int HealthPoints
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
        #endregion

        #region Ctors
        public LAIICharacterBase()
        {

        }

        protected LAIICharacterBase(string name, string gender, float height, int healthPoints, DamageType mastery)
        {
            typeMastery = mastery;
            Name = name;
            Gender = gender;
            Height = height;
            HealthPoints = healthPoints;
        }
        protected LAIICharacterBase(string name, string gender, float height, int healthPoints, DamageType mastery, string namePostfix) : this(name, gender, height, healthPoints, mastery)
        {
            if (namePostfix.Length != 3)
                throw new Exception("Be true! Use 3-chars postfixes! Re-create your character.");
            NamePostfix = namePostfix;
            typeMastery = mastery;
        }
        #endregion

        #region Methods
        protected bool CheckRaceParameter(int paramInt, int min = 0, int max = 100)
        {
            return paramInt >= min && paramInt <= max;
        }

        public void Equip(LAIIWeaponBase weapon)
        {
            Weapon = weapon;
        }
        #endregion

    }
}
