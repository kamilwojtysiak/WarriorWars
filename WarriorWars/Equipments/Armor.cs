using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor
    {
        private const int GOOD_GUY_ARMOUR = 5;
        private const int BAD_GUY_ARMOR = 5;

        private int _armourPoints;

        public int ArmourPoints
        {
            get
            {
                return _armourPoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    _armourPoints = GOOD_GUY_ARMOUR;
                    break;
                case Faction.BadGuy:
                    _armourPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}