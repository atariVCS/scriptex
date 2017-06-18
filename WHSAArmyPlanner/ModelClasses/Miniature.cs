/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/

using System;
using System.Collections.Generic;

namespace WHSAArmyPlanner.ModelClasses
{
    public class Miniature
    {
        public String Name { get; set; }
        public Faction Faction { get; set; }
        public Items StandardEquip { get; set; }
        public String Wounds { get; set; }
        public String LeaderShip { get; set; }
        public String Movement { get; set; }
        public String Weaponskill { get; set; }
        public String BallisticSkill { get; set; }
        public String Strength { get; set; }
        public String Toughness { get; set; }
        public String Attacks { get; set; }
        public String Save { get; set; }
        public String Keywords { get; set; }
        public String Abilities { get; set; }

        public Miniature()
        {
            StandardEquip = new Items();
            Faction = new Faction();
        }

        public Miniature(Miniature copy)
        {
            if (copy != null)
            {
                Name = copy.Name;
                Faction = copy.Faction;
                StandardEquip = copy.StandardEquip;
                Wounds = copy.Wounds;
                LeaderShip = copy.LeaderShip;
                Movement = copy.Movement;
                Weaponskill = copy.Weaponskill;
                BallisticSkill = copy.BallisticSkill;
                Strength = copy.Strength;
                Toughness = copy.Toughness;
                Attacks = copy.Attacks;
                Save = copy.Save;
                Keywords = copy.Keywords;
                Abilities = copy.Abilities;
            }
        }

        public override string ToString()
        {
            return Faction.Name + "- " + Name;
        }

    }

    public class Miniatures : List<Miniature>
    {
        public Boolean AddMiniature(Miniature newMini)
        {
            Boolean added = false;

            if (newMini != null)
            {
                bool alreadyExists = false;

                foreach (Miniature mini in this)
                {
                    if (mini.ToString() == newMini.ToString())
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                {
                    this.Add(newMini);
                    added = true;
                }
            }
            else
            {
                added = false;
            }

            return added;
        }
    }
}
