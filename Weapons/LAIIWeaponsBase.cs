using System;
using System.Collections.Generic;
using System.Text;

namespace FemaleFriendsHousbandsHomework.Weapons
{
    class LAIIWeaponsBase
    {
        string _name;
        int _damage;
        string _damageType;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }
        public string DamageType
        {
            get => _damageType;
            set => _damageType = value;
        }
        public LAIIWeaponsBase(string name, int damage, string damageType)
        {
            Name = name;
            Damage = damage;
            DamageType = damageType;
        }

        protected bool CheckWeaponParameter(int paramInt, int min = 0, int max = 100)
        {
            return paramInt >= min && paramInt <= max;
        }
    }
}
