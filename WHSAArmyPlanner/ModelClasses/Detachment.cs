/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WHSAArmyPlanner.ModelClasses
{
    [XmlRootAttribute("Detachment", IsNullable = false)]
    public class Detachment
    {
        public String Name { get; set; }
        public int CommandPoints { get; set; }
        public String Faction { get; set; }
        public Boolean DoesContainTransports { get; set; }
        public Boolean AllowsSingleFactionOnly { get; set; }
        public List<Slot> Slots { get; set; }

        public int CurrentPowerlevel { get { return GetCurrentPowerlevel(); } }
        public int CurrentPoints { get { return  GetCurrentMatchedPoints(); } }
        public int CurrentCommandPoints { get { return GetCurrentCommandPoints();  } }

        public Detachment()
        {
            Slots = new List<Slot>();
            AllowsSingleFactionOnly = true;
            DoesContainTransports = true;
        }

        public Detachment(Detachment copyDetachment)
        {
            if (copyDetachment != null)
            {
                Name = copyDetachment.Name;
                CommandPoints = copyDetachment.CommandPoints;
                Faction = copyDetachment.Faction;
                DoesContainTransports = copyDetachment.DoesContainTransports;
                AllowsSingleFactionOnly = copyDetachment.AllowsSingleFactionOnly;
                Slots = new List<Slot>();
                foreach (Slot slt in copyDetachment.Slots)
                {
                    Slot newSlot = new Slot(slt);
                    Slots.Add(newSlot);
                }
            }
        }

        public Detachment(String Name)
        {
            this.Name = Name;
            Slots = new List<Slot>();
            AllowsSingleFactionOnly = true;
            DoesContainTransports = true;
        }

        public override string ToString()
        {
            return Name;
        }

        public void InsertUpdateUnit(Unit unit)
        {
            if (unit.BattleRole == null) { return; }

            Slot currentSlot = Slots.Where(x => x.BattleRole.Name == unit.BattleRole.Name).Distinct().First();

            if (currentSlot != null && currentSlot.CreatedUnits != null && currentSlot.CreatedUnits.Any(x => x.Id.Equals(unit.Id)))
            {
                Unit existingUnit = currentSlot.CreatedUnits.Where(y => y.Id.Equals(unit.Id)).Distinct().First();
                if (existingUnit != null)
                {
                    existingUnit = unit;
                }
            }
            else
            {
                currentSlot.CreatedUnits.Add(unit);
            }
        }

        public void RemoveUnit(Unit unit)
        {
            Slot currentSlot = Slots.Where(x => x.BattleRole.Name == unit.BattleRole.Name).Distinct().First();

            if (currentSlot != null 
                && currentSlot.CreatedUnits != null 
                && currentSlot.CreatedUnits.Any(x => x.Id.Equals(unit.Id)))
            {
                currentSlot.CreatedUnits.Remove(unit);
            }
        }

        public int GetNumberOfTransportSlots()
        {
            int maximumTransports = 0;
            if (DoesContainTransports)
            {
                foreach (ModelClasses.Slot slot in Slots)
                {
                    if (slot.BattleRole.Name != "Transport")
                    {
                        if (slot.CreatedUnits != null)
                        {
                            maximumTransports += slot.CreatedUnits.Count();
                        }
                    }
                }
            }
            else
            {
                maximumTransports = 0;
            }

            return maximumTransports;
        }

        public ActionResult ValidateSlotsNumberOfUnits()
        {
            ActionResult res = new ActionResult();

            res.Success = true;

            if (Slots != null)
            {
                foreach (Slot slot in Slots)
                {
                    int requiredSlots = slot.MinimumUnits;
                    int filledSlots = 0;

                    if (requiredSlots > 0)
                    {
                        if (slot.CreatedUnits != null)
                        {
                            filledSlots = slot.CreatedUnits.Count;
                        }
                        else
                        {
                            filledSlots = 0;
                        }
                        
                        if (filledSlots < requiredSlots)
                        {
                            res.Success = false;
                            res.Message += "Slot " + slot.BattleRole.Name + ": Einheiten fehlen (erst " + filledSlots + " von " + requiredSlots + ")" + Environment.NewLine;
                        }
                    }
                }
            }
            else
            {
                // No check possible, broken detachment definition
                res.Success = true;
            }

            return res;
        }

        public String GetBasicInfoString()
        {
            StringBuilder sbBasic = new StringBuilder();
            sbBasic.Append(Name);
            sbBasic.Append(" [");
            sbBasic.Append(CommandPoints);
            sbBasic.Append(" CP]");
            foreach (ModelClasses.Slot slot in Slots)
            {
                sbBasic.Append(", ");
                sbBasic.Append(slot.MinimumUnits);
                sbBasic.Append("-");
                sbBasic.Append(slot.MaximumUnits);
                sbBasic.Append(" ");
                sbBasic.Append(slot.BattleRole.Name);
            }

            return sbBasic.ToString();
        }

        public String GetSummary(bool includeProfile, bool includeWargear)
        {
            StringBuilder sbSummary = new StringBuilder();
            string helpString = Name + " [+" + CommandPoints + " CP] [" + CurrentPowerlevel + " Powerlvl, " + CurrentPoints + " Pkt.]";


            sbSummary.AppendLine(new String('.', helpString.Length));
            sbSummary.AppendLine(helpString);
            sbSummary.AppendLine(new String('.', helpString.Length));

            #region quick summary <number> <slot>
            if (Slots != null && Slots.Any())
            {
                foreach (Slot slot in Slots)
                {
                    if (slot.CreatedUnits != null && slot.CreatedUnits.Any())
                    {
                        int numberOfEntries = 0;
                        foreach (Unit unit in slot.CreatedUnits)
                        {
                            numberOfEntries += 1;
                        }

                        sbSummary.AppendLine(numberOfEntries + " " + slot.BattleRole.Name);
                    }
                }
            }
            #endregion

            sbSummary.AppendLine();

            if (Slots != null && Slots.Any())
            {
                foreach (Slot slot in Slots)
                {
                    if (slot.CreatedUnits != null && slot.CreatedUnits.Any())
                    {
                        String slotHeadline = "[" + slot.BattleRole.Name.ToUpper() + "]";
                        sbSummary.AppendLine(slotHeadline);
                        sbSummary.AppendLine(new String('=', slotHeadline.Length));
                        foreach (Unit unit in slot.CreatedUnits)
                        {
                            sbSummary.AppendLine(unit.GetSummary(includeProfile, includeWargear));
                        }
                    }
                }
            }

            return sbSummary.ToString();
        }

        private Int32 GetCurrentPowerlevel()
        {
            Int32 pl = 0;

            foreach (Slot slot in Slots)
            {
                if (slot.CreatedUnits != null)
                {
                    foreach (Unit unit in slot.CreatedUnits)
                    {
                        pl += unit.CurrentPowerLevel;
                    }
                }
            }

            return pl;
        }

        private Int32 GetCurrentMatchedPoints()
        {
            Int32 mp = 0;

            foreach (Slot slot in Slots)
            {
                if (slot.CreatedUnits != null)
                {
                    foreach (Unit unit in slot.CreatedUnits)
                    {
                        mp += unit.CurrentPoints;
                    }
                }
            }

            return mp;
        }

        private Int32 GetCurrentCommandPoints()
        {
            Int32 cp = CommandPoints;

            foreach (Slot slot in Slots)
            {
                if (slot.CreatedUnits != null)
                {
                    foreach (Unit unit in slot.CreatedUnits)
                    {
                        cp += unit.BonusCp;
                    }
                }
            }

            return cp;
        }
    }

    public class Detachments : List<Detachment>
    {
        public void AddDetachment(Detachment detachment)
        {
            if (detachment != null)
            {
                Boolean DoesAlreadyExist = false;

                foreach (Detachment det in this)
                {
                    if (det.Name == detachment.Name)
                    {
                        DoesAlreadyExist = true;
                    }
                }

                if (!DoesAlreadyExist)
                {
                    this.Add(detachment);
                }
            }
        }
    }
}
