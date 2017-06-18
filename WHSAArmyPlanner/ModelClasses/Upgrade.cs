using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
