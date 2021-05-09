using System;
using System.Collections.Generic;
using System.Text;

namespace FemaleFriendsHusbandsHomework.Weapons
{
    class Sword : LAIIWeaponBase
    {
        public Sword(string name, int damage) : base(name, damage, DamageType.Slashing)
        {

        }
    }
}
