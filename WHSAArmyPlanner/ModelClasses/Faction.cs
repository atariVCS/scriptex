/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/
using System;
using System.Collections.Generic;

namespace WHSAArmyPlanner.ModelClasses
{
    public class Faction
    {
        public String Name { get; set; }
        public String MainFaction { get; set; }           // bind multiple Factions to one (e.g. Astartes to Terran Empire...)
        public String SubFactionKeywords { get; set; }    // For clans etc. 

        public Faction()
        {
            SubFactionKeywords = "";
            MainFaction = "";
        }

        public override string ToString()
        {
            return Name;
        }

        public Boolean CheckIfAllied(Faction CompareFaction)
        {
            if (CompareFaction != null)
            {
                return CompareFaction.Name == MainFaction;
            }
            else
            {
                return false;
            }
        }
    }
    
    public class Factions: List<Faction>
    {
        public Boolean AddFaction(Faction newFaction)
        {
            Boolean alreadyExists = false;
            Boolean added = false;

            if (newFaction != null)
            {
                foreach (Faction faction in this)
                {
                    if (faction.Name == newFaction.Name)
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                {
                    this.Add(newFaction);
                    added = true;
                }
            }

            return added;
        }
    }
    
}
