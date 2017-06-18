/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/
using System.Collections.Generic;

namespace WHSAArmyPlanner.ModelClasses
{
    public class Upgrade
    {
        public string Name { get; set; }
        public Faction Faction { get; set; }
        public Item Wargear { get; set; }
        public int PerHowManyModels { get; set; }
        public int Count { get; set; }
        public int NumberAllowed { get; set; }
        public bool IsUnique { get; set; }
        public int Points { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Upgrades:List<Upgrade>
    {

    }
}
