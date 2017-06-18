/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace WHSAArmyPlanner.ModelClasses
{
    public enum GearType { ranged, melee, universal, combi, artifact, stratagem }

    public class Item
    {
        public String Name { get; set; }
        public Faction AllowedFaction { get; set; }

        public int Points { get; set; }
        public GearType ItemType { get; set; }

        public String Range { get; set; }
        public String RangedType { get; set; }
        public String RangedStrength { get; set; }
        public int RangedAp { get; set; }
        public String RangedDamage { get; set; }
        public String RangedAbility { get; set; }

        public String MeleeType { get; set; }
        public String MeleeStrength { get; set; }
        public int MeleeAP { get; set; }
        public String MeleeDamage{ get; set; }
        public String MeleeAbility { get; set; }

        public List<Rule> SpecialRules { get; set; }
        public List<String> Keywords { get; set; }
        public String ExtraText { get; set; }

        public Item()
        {
            SpecialRules = new List<Rule>();
            Keywords = new List<string>();
            RangedAbility = "-";
            MeleeAbility = "-";
            MeleeType = "Melee";
        }

        public Item(Item copy)
        {
            SpecialRules = copy.SpecialRules;
            Keywords = copy.Keywords;
            Name = copy.Name;
            AllowedFaction = copy.AllowedFaction;
            Points = copy.Points;
            Range = copy.Range;
            RangedAbility = copy.RangedAbility;
            RangedAp = copy.RangedAp;
            RangedDamage = copy.RangedDamage;
            RangedStrength = copy.RangedStrength;
            RangedType = copy.RangedType;
            SpecialRules = copy.SpecialRules;
            ItemType = copy.ItemType;
            
            MeleeAbility = copy.MeleeAbility;
            MeleeType = "Melee";
            MeleeAP = copy.MeleeAP;
            MeleeDamage = copy.MeleeDamage;
            MeleeStrength = copy.MeleeStrength;
        }

        public string GetSummary()
        {
            int nameSpacer = 25;
            string entryName = " °" + Name;
            StringBuilder sbSummary = new StringBuilder();
            if (entryName.Length > nameSpacer)
            {
                sbSummary.Append(entryName.Substring(0, nameSpacer));
            }
            else
            {
                sbSummary.Append(entryName.PadRight(nameSpacer));
            }

            sbSummary.Append("   ");
            if (RangedType != null && RangedType.Length > 1)
            {
                sbSummary.Append(Range);
                sbSummary.Append("\"");
                sbSummary.Append("  ");
                sbSummary.Append(RangedType);
                sbSummary.Append("  ");
                sbSummary.Append(RangedStrength);
                sbSummary.Append("  ");
                sbSummary.Append(RangedAp);
                sbSummary.Append("  ");
                sbSummary.Append(RangedDamage);
                sbSummary.Append("  | ");
                sbSummary.Append(RangedAbility);
                sbSummary.AppendLine();
            }

            if (MeleeStrength != null && MeleeStrength.Length > 0)
            {
                sbSummary.Append(MeleeType);
                sbSummary.Append("  ");
                sbSummary.Append(MeleeStrength);
                sbSummary.Append("  ");
                sbSummary.Append(MeleeAP);
                sbSummary.Append("  ");
                sbSummary.Append(MeleeDamage);
                sbSummary.Append("  | ");
                sbSummary.Append(MeleeAbility);
                sbSummary.AppendLine() ;
            }
            
            return sbSummary.ToString();
        }

        public override string ToString()
        {
            return AllowedFaction + "- " + Name;
        }
    }

    public class Items : List<Item>
    {
        public Boolean AddItem(Item item)
        {
            Boolean added = false;

            if (item != null)
            {
                Boolean AlreadyExists = false;

                foreach (Item existingItem in this)
                {
                    if (existingItem.ToString().Equals(item.ToString()))
                    {
                        AlreadyExists = true;
                        break;
                    }
                }

                if (!AlreadyExists)
                {
                    this.Add(item);
                    added = true;
                }
            }

            return added;
        }
    }
}
