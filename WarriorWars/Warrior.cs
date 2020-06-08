using WarriorWars.Enum;
using WarriorWars.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;

        private readonly Faction FACTION;

        private int _health;
        private string _name;
        private bool _isAlive;

        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this._name = name;
            FACTION = faction;
            _isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    _health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    _health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemyWarrior)
        {
            int damage = weapon.Damage / enemyWarrior.armor.ArmourPoints;

            enemyWarrior._health -= damage;

            AttackResult(enemyWarrior, damage);
        }

        private void AttackResult(Warrior enemyWarrior, int damage)
        {
            if (enemyWarrior._health <= 0)
            {
                enemyWarrior._isAlive = false;

                Tools.ColorWriteLine($"{enemyWarrior._name} is dead!", ConsoleColor.Red);
                Tools.ColorWriteLine($"{_name} is victorious!", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{_name} attacked {enemyWarrior._name} for {damage}.\n" +
                    $"{_name} current health: {_health}\n" +
                    $"{ enemyWarrior._name} current health: { enemyWarrior._health}\n" +
                    new string('-', 40) + "\n");
            }
        }
    }
}
