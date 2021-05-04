using System;
using System.Collections.Generic;
using System.Text;

namespace FemaleFriendsHousbandsHomework
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
        public CharacterRaceElf() : base("iel")
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
        public CharacterRaceElf(string name, string gender, float height, int healthPoints, float earLength, int sexuality) : base(name, gender, height, healthPoints, "iel")
        {
            if (!CheckParameter(sexuality))
                throw new Exception("Sexuality level can only be between 0 and 100");
            EarLength = earLength;
            SexualityLevel = sexuality;
        }
    }
}
