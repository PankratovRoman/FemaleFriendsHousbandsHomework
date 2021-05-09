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

        public CharacterRaceDwarf(string name, string gender, float height, int healthPoints, bool canCraft, bool canTrade) : base(name, gender, height, healthPoints, Weapons.DamageType.Blunt)
        {
            CanCraft = canCraft;
            CanTrade = canTrade;
            string[] dwarfPostfixes = { "ori", "fur", "lin" };
            int namePostfixIndex = _rnd.Next(dwarfPostfixes.Length);
            NamePostfix = dwarfPostfixes[namePostfixIndex];
        }
    }
}
