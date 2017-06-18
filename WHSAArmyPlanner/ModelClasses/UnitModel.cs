/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/
using System;
using System.Collections.Generic;

namespace WHSAArmyPlanner.ModelClasses
{
    public class UnitModel
    {
        public String Name { get; set; }
        public Miniature Miniature { get; set; }
        public Faction Faction { get; set; }
        public Item Wargear { get; set; }
        public Item WargearToReplace { get; set; }
        public UnitModel ModelToReplace { get; set; }
        public int Count { get; set; }
        public int CountLimit { get; set; }
        public int PowerLevel { get; set; }
        public int Points { get; set; }
        public int CurrentPoints { get { return GetCurrentMatchedPoints(); } }
        public int CurrentPowerlevel { get { return GetCurrentPowerLevel(); } }
        public int RequiredMinimumCount { get; set; }
        public int ReplacesEveryNcount { get; set; }
        public bool IsWargear { get; set; }
        public bool IsReplacement { get; set; }
        public bool IsWargearReplacment { get; set; } 
        public bool IsAllowedForEachNumberUnits { get; set; }
        public bool DoesRequireMinimumCount { get; set; }
        public bool DoesNotCount { get; set; }
        public bool IsUpgradeOnly { get; set; }
        public int ExtraPowerLevel { get; set; }
        public int ExtraPLForHowManyModels { get; set; }
        public int ExtraPoints { get; set; }
        public int ExtraPointsForHowManyModels { get; set; }
        public int CurrentModelCount { get { return Count + ExtraModelsCount; } }
        public int ExtraModelsCount { get; set; }
        //public string ReplacementInfo { get; set; }

        public string Id { get { return id; } }
        private string id = "";
        
        public UnitModel() { id = Guid.NewGuid().ToString(); }

        public UnitModel(UnitModel copy)
        {
            if (copy != null)
            {
                Name = copy.Name;
                Miniature = new Miniature(copy.Miniature);
                Faction = copy.Faction;
                Count = copy.Count;
                CountLimit = copy.CountLimit;
                PowerLevel = copy.PowerLevel;
                Points = copy.Points;
                RequiredMinimumCount = copy.RequiredMinimumCount;
                ReplacesEveryNcount = copy.ReplacesEveryNcount;
                IsReplacement = copy.IsReplacement;
                ModelToReplace = copy.ModelToReplace;
                IsAllowedForEachNumberUnits = copy.IsAllowedForEachNumberUnits;
                DoesRequireMinimumCount = copy.DoesRequireMinimumCount;
                DoesNotCount = copy.DoesNotCount;
                IsUpgradeOnly = copy.IsUpgradeOnly;
                ExtraPLForHowManyModels = copy.ExtraPLForHowManyModels;
                ExtraPoints = copy.ExtraPoints;
                ExtraPointsForHowManyModels = copy.ExtraPointsForHowManyModels;
                ExtraPowerLevel = copy.ExtraPowerLevel;
                IsWargear = copy.IsWargear;
                Wargear = copy.Wargear;
                IsWargearReplacment = copy.IsWargearReplacment;
                WargearToReplace = copy.WargearToReplace;
                id = Guid.NewGuid().ToString();
            }
        }
        
        public bool DidModelCountChange(int modelCount)
        {
            return (ExtraModelsCount != modelCount);
        }

        public override string ToString()
        {
            if (Miniature != null)
            {
                String optionUpgrade = "";
                String optionReplacement = "";

                if (IsUpgradeOnly)
                {
                    optionUpgrade = " [U]";
                }

                if (IsReplacement)
                {
                    optionReplacement = " [R]";
                }

                return Name + " [" + Miniature.Name + "] (" + Count + ")" + optionUpgrade + optionReplacement;
            }
            else
            {
                return Name;
            }
        }

        private int GetCurrentPowerLevel()
        {
            int pl = 0;
            int fullExtraSlot = 0;
            int begunExtraSlot = 0;
            pl += PowerLevel;
            if (ExtraModelsCount > 0)
            {
                if (ExtraPLForHowManyModels > 0)
                {
                    fullExtraSlot = ExtraModelsCount / ExtraPLForHowManyModels;
                    begunExtraSlot = ExtraModelsCount % ExtraPLForHowManyModels;

                    if (begunExtraSlot > 0)
                    {
                        fullExtraSlot += 1;
                    }

                    pl += (fullExtraSlot * ExtraPowerLevel);
                }
            }

            return pl;
        }

        private int GetCurrentMatchedPoints()
        {
            int mp = 0;
            int fullExtraSlot = 0;
            int begunExtraSlot = 0;

            #region Miniatures Points Count
            if (Miniature != null && IsReplacement && ModelToReplace != null)
            {
                
            }
            else
            {
                mp += Points;

                if (ExtraModelsCount > 0)
                {
                    if (ExtraPointsForHowManyModels > 0)
                    {
                        fullExtraSlot = ExtraModelsCount / ExtraPointsForHowManyModels;
                        begunExtraSlot = ExtraModelsCount % ExtraPointsForHowManyModels;

                        if (begunExtraSlot > 0)
                        {
                            fullExtraSlot += 1;
                        }

                        mp += (fullExtraSlot * ExtraPoints);
                    }
                }
            }
            #endregion Miniatures Points Count

            #region Stnadrad Euipment + Upgrade Costs
            if (Miniature != null && Miniature.StandardEquip != null)
            {
                int equipmentPoints = 0;    // individual Model cost
                int equipmentCost = 0;      // sum for all current Models 

                foreach (ModelClasses.Item stdItem in Miniature.StandardEquip)
                {
                    equipmentPoints += stdItem.Points;
                }

                equipmentCost = (Count + ExtraModelsCount) * equipmentPoints;
                mp += equipmentCost;
            }
            
            if (IsWargear && !IsWargearReplacment)
            {
                int upgradePoints = 0;      // individual Model cost
                int upgradeCost = 0;        // sum for all current Models 
                upgradePoints = Wargear.Points;
                upgradeCost = (Count + ExtraModelsCount) * upgradePoints;
                mp += upgradeCost;
            }
            else if (IsWargear && IsWargearReplacment && Wargear != null && WargearToReplace != null)
            {
                int upgradePoints = 0;      // individual Model cost
                int upgradeCost = 0;        // sum for all current Models 

                upgradePoints = Wargear.Points;
                if (WargearToReplace != null)
                {
                    upgradePoints -= WargearToReplace.Points;
                }

                upgradeCost = (Count + ExtraModelsCount) * upgradePoints;

                mp += upgradeCost;
            }
            #endregion Stnadrad Euipment + Upgrade Costs

            return mp;
        }
    }

    public class UnitModels : List<UnitModel>
    {
    }
}
