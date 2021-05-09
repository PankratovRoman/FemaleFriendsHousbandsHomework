using System;
using System.Collections.Generic;
using System.Text;

namespace FemaleFriendsHusbandsHomework
{
    class CharacterRaceHuman: LAIICharacterBase
    {
        int _diplomacyLevel;
        public int Diplomacy
        {
            get { return _diplomacyLevel + 20 * Convert.ToInt32(HaveDragon); } //True и False по сути 1 и 0, можно сделать вот так. Круто!; 
            set { _diplomacyLevel = value; }
        }
        public bool HaveDragon { get; set; }

        public CharacterRaceHuman(string name, string gender, float height, int diplomacyLevel, bool haveDragon) : base(name, gender, height, 100, Weapons.DamageType.Slashing,"mir")
        {
            if (!CheckRaceParameter(diplomacyLevel))
                throw new Exception("Diplomacy level can only be between 0 and 100");
            HaveDragon = haveDragon;
        }
    }
}
