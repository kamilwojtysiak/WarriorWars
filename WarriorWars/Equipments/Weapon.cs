using System;
using WarriorWars.Enu;
using System.Collections.Generic;
using System.Text;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        private int goodGuyDamage;
        private int badGuyDamage;

        private int damage;

        public int Demage
        {
            get
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = goodGuyDamage;
                    break;
                case Faction.BadGuy:
                    damage = badGuyDamage;
                    break;
                default:
                    break;
            }
        }
    }
}
