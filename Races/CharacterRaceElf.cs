using System;
using System.Collections.Generic;
using System.Text;

namespace FemaleFriendsHusbandsHomework
{
    class CharacterRaceElf : LAIICharacterBase
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

        /// <summary>
        /// Эльфонструктор!
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="height"></param>
        /// <param name="healthPoints"></param>
        /// <param name="earLength">Длина уха</param>
        /// <param name="sexuality">Уровень сексуальности</param>
        public CharacterRaceElf(string name, string gender, float height, float earLength, int sexuality) : base(name, gender, height, 80, Weapons.DamageType.Piercing,  "iel")
        {
            if (!CheckRaceParameter(sexuality))
                throw new Exception("Sexuality level can only be between 0 and 100");
            EarLength = earLength;
            SexualityLevel = sexuality;
        }
    }
}
