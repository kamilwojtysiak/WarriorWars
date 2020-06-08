using WarriorWars.Enu;

namespace WarriorWars.Equipment
{
    class Armor
    {
        private const int GOOD_GUY_ARMOUR = 5;
        private const int BAD_GUY_ARMOR = 5;

        private int armourPoints;

        public int ArmourPoints
        {
            get
            {
                return armourPoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armourPoints = GOOD_GUY_ARMOUR;
                    break;
                case Faction.BadGuy:
                    armourPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}