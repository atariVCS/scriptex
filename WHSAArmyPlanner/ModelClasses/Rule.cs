using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHSAArmyPlanner.ModelClasses
{
    public class Rule
    {
        public String Name { get; set; }
        public String Text { get; set; }

        public Rule()
        {
            Name = "";
            Text = "";
        }

        public Rule(Rule copy)
        {
            Name = copy.Name;
            Text = copy.Text;
        }
    }
}
