/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/

using System.Collections.Generic;

namespace WHSAArmyPlanner.ModelClasses
{
    public class Slot
    {
        public BattleRole BattleRole { get; set; }
        public int MinimumUnits { get; set; }
        public int MaximumUnits { get; set; }
        public List<Unit> UnitTemplates { get; set; }
        public Units CreatedUnits { get; set; }

        public Slot()
        {
            UnitTemplates = new List<Unit>();
            CreatedUnits = new Units();
        }

        public Slot(Slot copySlot)
        {
            UnitTemplates = new List<Unit>();
            if (copySlot.UnitTemplates != null)
            {
                UnitTemplates.AddRange(copySlot.UnitTemplates);
            }

            BattleRole = copySlot.BattleRole;
            MaximumUnits = copySlot.MaximumUnits;
            MinimumUnits = copySlot.MinimumUnits;
            CreatedUnits = new Units();
        }

        public override string ToString()
        {
            return BattleRole.Name + " ("  + MinimumUnits + "-" + MaximumUnits + ")";
        }
    }
}
