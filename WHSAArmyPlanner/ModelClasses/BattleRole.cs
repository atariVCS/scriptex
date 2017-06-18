using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHSAArmyPlanner.ModelClasses
{
    public class BattleRole
    {
        public String Name { get; set; }
        public Image Icon { get; set; }
        public String ImageFileName { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }


    public class BattleRoles: List<BattleRole>
    {
        public void AddRole(BattleRole role)
        {
            if (role != null)
            {
                Boolean DoesAlreadyExist = false;

                foreach (BattleRole battleRole in this)
                {
                    if (battleRole.Name == role.Name)
                    {
                        DoesAlreadyExist = true;
                    }
                }

                if (!DoesAlreadyExist)
                {
                    this.Add(role);
                }
            }
        }
    }
}
