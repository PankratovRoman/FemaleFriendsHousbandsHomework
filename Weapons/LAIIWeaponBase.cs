using System;
using System.Collections.Generic;
using System.Text;

namespace FemaleFriendsHusbandsHomework.Weapons
{
    enum DamageType
    {
        Piercing,
        Slashing,
        Blunt
    }
    class LAIIWeaponBase
    {
        public string Name { get; protected set; }
        public int Damage { get; protected set; }
        public DamageType DamageType { get; protected set; }
        public LAIIWeaponBase(string name, int damage, DamageType damageType)
        {
            Name = name;
            Damage = damage;
            DamageType = damageType;
            //DamageType = (DamageType)Enum.Parse(typeof(DamageType),damageType);
        }

        protected bool CheckWeaponParameter(int paramInt, int min = 50, int max = 100)
        {
            return paramInt >= min && paramInt <= max;
        }
    }
}
