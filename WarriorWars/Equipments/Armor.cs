using WarriorWars.Enu;

namespace WarriorWars.Equipment
{
    class Armor
    {
        private int goodGuyArmourPoints;
        private int badGuyArmourPoints;

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
                    armourPoints = goodGuyArmourPoints;
                    break;
                case Faction.BadGuy:
                    armourPoints = badGuyArmourPoints;
                    break;
                default:
                    break;
            }
        }
    }
}