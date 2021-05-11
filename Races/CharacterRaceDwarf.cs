using System;
using System.Collections.Generic;
using System.Text;

namespace FemaleFriendsHusbandsHomework
{
    class CharacterRaceDwarf : LAIICharacterBase
    {
        bool _canCraft;
        bool _canTrade;
        public bool CanCraft { get { return _canCraft; } set { _canCraft = value; } }
        public bool CanTrade { get { return _canTrade; } set { _canTrade = value; } }

        private static readonly Random _rnd = new Random();

        //public CharacterRaceDwarf() //: base() - нужно ли тут это?
        //{
        //    string[] dwarfPostfixes = { "ori", "fur", "lin" };
        //    int namePostfixIndex = _rnd.Next(dwarfPostfixes.Length);
        //    NamePostfix = dwarfPostfixes[namePostfixIndex];
        //}

        /// <summary>
        /// Dwarf CTOR
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="gender">Gender</param>
        /// <param name="height">Height</param>
        /// <param name="healthPoints">HP</param>
        /// <param name="canCraft">Craft</param>
        /// <param name="canTrade">Trade</param>
        public CharacterRaceDwarf(string name, string gender, float height, bool canCraft, bool canTrade) : base(name, gender, height, 120, Weapons.DamageType.Blunt)
        {
            CanCraft = canCraft;
            CanTrade = canTrade;
            string[] dwarfPostfixes = { "ori", "fur", "lin" };
            int namePostfixIndex = _rnd.Next(dwarfPostfixes.Length);
            NamePostfix = dwarfPostfixes[namePostfixIndex];
        }
    }
}
