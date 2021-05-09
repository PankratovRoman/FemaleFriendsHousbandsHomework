using System;
using System.Collections.Generic;
using System.Text;

namespace FemaleFriendsHusbandsHomework.Weapons
{
    class Bow : LAIIWeaponBase
    {
        public Bow(string name, int damage) : base(name, damage, DamageType.Piercing)
        {

        }
    }
}
