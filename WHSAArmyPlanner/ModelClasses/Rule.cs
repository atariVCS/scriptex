/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/

using System;

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
