/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHSAArmyPlanner.ModelClasses
{
    public class Unit
    {
        public String Name { get; set; }
        public Faction Faction { get; set; }
        public BattleRole BattleRole { get; set; }
        public List<Rule> SpecialRules { get; set; }
        public Upgrades WargearUpgrades { get; set; }
        public String Keywords { get; set; }
        public String Abilities { get; set; }
        public UnitModels ListEntries { get; set; }
        public int CurrentPowerLevel { get { return GetPowerLevel(); } }
        public int CurrentPoints { get { return GetPoints(); } }
        public int MinimumUnitCount { get; set; }
        public int MaximumUnitCount { get; set; }
        
        public int Powerlevel { get; set; }
        public int MatchedPoints { get; set; }
        public int BonusCp { get; set; }

        public bool IsUnique { get; set; }

        public string Id { get; set; }
        
        public Unit()
        {
            SpecialRules = new List<Rule>();
            ListEntries = new UnitModels();
            WargearUpgrades = new Upgrades();
            Id = Guid.NewGuid().ToString();
        }

        public Unit(Unit copy)
        {
            if (copy != null)
            {
                Name = copy.Name;
                Faction = copy.Faction;
                Keywords = copy.Keywords;
                Abilities = copy.Abilities;
                MinimumUnitCount = copy.MinimumUnitCount;
                MaximumUnitCount = copy.MaximumUnitCount;
                Powerlevel = copy.Powerlevel;
                MatchedPoints = copy.MatchedPoints;
                BonusCp = copy.BonusCp;
                BattleRole = copy.BattleRole;

                SpecialRules = new List<Rule>();
                ListEntries = new UnitModels();
                WargearUpgrades = new Upgrades();

                foreach (Rule rule in copy.SpecialRules)
                {
                    SpecialRules.Add(new Rule(rule));
                }

                foreach (UnitModel unitMod in copy.ListEntries)
                {
                    ListEntries.Add(new UnitModel(unitMod));
                }

                IsUnique = copy.IsUnique;

                Id = Guid.NewGuid().ToString();
            }
        }
        
        public override string ToString()
        {
            return Faction.Name + "- " + Name;
        }

        public ActionResult InsertEntry(UnitModel newEntry)
        {
            ActionResult res = new ActionResult();

            if (!CheckMaxModelcount(newEntry))
            {
                res.Success = false;
                res.Message = "Die Einheit ist voll, es können keine neuen Modelle mehr hinzugefügt werden (außer reine Upgrades...)";
                return res;
            }

            if (!CheckMinimumRequirement(newEntry))
            {
                res.Success = false;
                res.Message = "Es sind noch nicht genügend Modelle enthalten, um dieses Upgrade auszuwählen.";
                return res;
            }

            if (!CheckMForN(newEntry))
            {
                res.Success = false;
                res.Message = "Es sind noch nicht genügend Modelle enthalten, um dieses Upgrade (_n_ für je _x_ Modelle) auszuwählen.";
                return res;
            }

            if (ListEntries.Any(x => x.Id == newEntry.Id))
            {
                UnitModel exitstingEntry = (UnitModel)ListEntries.Where(x => x.Id == newEntry.Id).Distinct();
                exitstingEntry = newEntry;
            }
            else
            {
                ListEntries.Add(newEntry);
            }

            res.Success = true;
            
            return res;
        }

        public ActionResult TestUpgrade(UnitModel upgrade)
        {
            ActionResult res = new ActionResult();

            if (!CheckMaxModelcount(upgrade))
            {
                res.Success = false;
                res.Message = "Die Einheit ist voll, es können keine neuen Modelle mehr hinzugefügt werden (außer reine Upgrades...)";
                return res;
            }

            if (!CheckMinimumRequirement(upgrade))
            {
                res.Success = false;
                res.Message = "Es sind noch nicht genügend Modelle enthalten, um dieses Upgrade auszuwählen.";
                return res;
            }

            if (!CheckMForN(upgrade))
            {
                res.Success = false;
                res.Message = "Es sind noch nicht genügend Modelle enthalten, um dieses Upgrade (" + upgrade.Count +" für je " + upgrade.ReplacesEveryNcount + " Modelle) auszuwählen.";
                return res;
            }

            res.Success = true;
            return res;
        }

        public String GetSummary(bool includeProfile, bool includeWargear)
        {
            StringBuilder sbSummary = new StringBuilder();
            if(IsUnique)
            {
                sbSummary.Append("# Einzigartig # ");
            }
            sbSummary.Append(Name);
            sbSummary.Append(" [");
            sbSummary.Append(CurrentPowerLevel);
            sbSummary.Append(" Powerlvl, ");
            sbSummary.Append(CurrentPoints);
            sbSummary.Append(" Pkt.]");
            if (BonusCp > 0)
            {
                sbSummary.Append(" [+");
                sbSummary.Append(BonusCp);
                sbSummary.Append(" CP]");
            }

            sbSummary.AppendLine();
            sbSummary.AppendLine("-------------");
            foreach (UnitModel umod in ListEntries)
            {
                sbSummary.Append(umod.CurrentModelCount + "x " + umod.Name);
                if (umod.IsReplacement)
                {
                    sbSummary.Append("   [ Ersatz - ");
                    if (umod.ModelToReplace != null)
                    {
                        sbSummary.Append(umod.ModelToReplace.Name);
                    }

                    sbSummary.Append("]");
                }

                if (umod.IsWargearReplacment && umod.WargearToReplace != null)
                {
                    sbSummary.Append("   [ Ersetzt - ");
                    sbSummary.Append(umod.WargearToReplace.Name);
                    sbSummary.Append("]");
                }

                sbSummary.AppendLine();

                if (includeProfile && umod.IsWargear)
                {

                }
                else if (includeProfile && umod.Miniature != null)
                {
                    #region Profile
                    int spacingChars = 6;
                    int spacingTwoChars = 7;
                    sbSummary.AppendLine("  M     WS     BS     S     T     W     A     Ld     Sv");
                    string movement;
                    string weaponskill;
                    string ballisticskill;
                    string strength;
                    string toughness;
                    string wounds;
                    string attacks;
                    string leadership;
                    string save;

                    sbSummary.Append("  ");
                    movement = umod.Miniature.Movement;
                    sbSummary.Append(movement);
                    sbSummary.Append(new string(' ', spacingChars - movement.Length));
                    weaponskill = umod.Miniature.Weaponskill;
                    sbSummary.Append(weaponskill);
                    sbSummary.Append(new string(' ', spacingTwoChars - weaponskill.Length));
                    ballisticskill = umod.Miniature.BallisticSkill;
                    sbSummary.Append(ballisticskill);
                    sbSummary.Append(new string(' ', spacingTwoChars - weaponskill.Length));
                    strength = umod.Miniature.Strength;
                    sbSummary.Append(strength);
                    sbSummary.Append(new string(' ', spacingChars - strength.Length));
                    toughness = umod.Miniature.Toughness;
                    sbSummary.Append(toughness);
                    sbSummary.Append(new string(' ', spacingChars - toughness.Length));
                    wounds = umod.Miniature.Wounds;
                    sbSummary.Append(wounds);
                    sbSummary.Append(new string(' ', spacingChars - wounds.Length));
                    attacks = umod.Miniature.Attacks;
                    sbSummary.Append(attacks);
                    sbSummary.Append(new string(' ', spacingChars - attacks.Length));
                    leadership = umod.Miniature.LeaderShip;
                    sbSummary.Append(leadership);
                    sbSummary.Append(new string(' ', spacingTwoChars - leadership.Length));
                    save = umod.Miniature.Save;
                    sbSummary.Append(save);
                    sbSummary.AppendLine();
                    if (umod.Miniature.Abilities != null && !String.IsNullOrWhiteSpace(umod.Miniature.Abilities))
                    {
                        sbSummary.Append(" >>");
                        sbSummary.Append(umod.Miniature.Abilities);
                        sbSummary.Append("<<");
                        sbSummary.AppendLine();
                    }
                    #endregion Profile
                }

                #region Wargear (Equipment, Weapons, Items...)
                if (includeWargear && umod.IsWargear && umod.Wargear != null)
                {
                    sbSummary.Append(umod.Wargear.GetSummary());
                }
                else if (includeWargear && umod.Miniature != null)
                {
                    foreach (ModelClasses.Item gear in umod.Miniature.StandardEquip)
                    {
                        sbSummary.Append(gear.GetSummary());
                    }
                }
                sbSummary.AppendLine();
                #endregion Wargear (Equipment, Weapons, Items...)

            }

            return sbSummary.ToString();
        }

        private int GetPowerLevel()
        {
            int pl = 0;
            pl += Powerlevel;

            foreach (ModelClasses.UnitModel entry in ListEntries)
            {
                pl += entry.CurrentPowerlevel;
            }

            return pl;
        }

        private int GetPoints()
        {
            int points = 0;
            points += MatchedPoints;

            foreach (ModelClasses.UnitModel entry in ListEntries)
            {
                points += entry.CurrentPoints;
            }

            return points;
        }

        private bool CheckMaxModelcount(UnitModel newEntry)
        {
            bool allowed = false;
            int currentCount = 0;

            if (!EntryDoesCount(newEntry))
            {
                allowed = true;
            }
            else
            {
                foreach (UnitModel entry in ListEntries)
                {
                    if (EntryDoesCount(entry))
                    {
                        currentCount += entry.CurrentModelCount;
                    }
                }

                allowed = currentCount < MaximumUnitCount;
            }

            return allowed;
        }

        private bool CheckMinimumRequirement(UnitModel newEntry)
        {
            if (newEntry.DoesRequireMinimumCount)
            {
                int currentCount = 0;
                foreach (UnitModel entry in ListEntries)
                {
                    if (EntryDoesCount(entry))
                    {
                        currentCount += entry.CurrentModelCount;
                    }
                }

                return  newEntry.RequiredMinimumCount <= currentCount;
            }
            else
            {
                return true;
            }
        }
        
        private bool CheckMForN(UnitModel newEntry)
        {
            if (newEntry.IsAllowedForEachNumberUnits)
            {
                int requiredModels = 0;
                int currentCount = 0;

                requiredModels = newEntry.CurrentModelCount * newEntry.ReplacesEveryNcount;
                foreach (UnitModel entry in ListEntries)
                {
                    if (EntryDoesCount(entry))
                    {
                        currentCount += entry.CurrentModelCount;
                    }
                }

                return requiredModels <= currentCount;
            }
            else
            {
                return true;
            }
        }

        private bool EntryDoesCount(UnitModel entry)
        {
            if (entry.DoesNotCount)
            {
                return false;
            }

            if (entry.IsReplacement)
            {
                return false;
            }

            return true;
        }
    }

    public class Units: List<Unit>
    {
        public void AddUnit(Unit newUnit)
        {
            bool alreadyExists = false;

            if (newUnit != null)
            {
                foreach (Unit existingUnit in this)
                {
                    if (existingUnit.ToString() == newUnit.ToString())
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                {
                    this.Add(newUnit);
                }
            }
        }
    }
}
