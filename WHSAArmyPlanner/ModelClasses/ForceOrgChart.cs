/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/
using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WHSAArmyPlanner.ModelClasses
{
    [XmlRootAttribute("ForceOrgChart", IsNullable = false)]
    public class ForceOrgChart
    {
        public String Name { get; set; }
        public ModelClasses.Detachments Detachments { get; set; }
        public Boolean IsStrictMatchPlay { get; set; }
        public Faction ArmyFactionForMatchedPlay { get; set; }
        public Boolean ExistingFile { get; set; }
        public Boolean DoCheckPowerlevel { get; set; }
        public Boolean DoCheckPointLimt { get; set; }
        public Int32 Powerlevel { get; set; }
        public Int32 PointLimit { get; set; }
        public Int32 CurrentPowerLevel { get { return GetCurrentPowerlevel(); } }
        public Int32 CurrentPoints { get { return GetCurrentMatchedPoints(); } }
        public Int32 CurrentCommandPoints { get { return GetCurrentCommandPoints(); } }
        public Int32 BaseCommandPoints { get; set; }

        public ForceOrgChart()
        {
            Detachments = new Detachments();
            BaseCommandPoints = 3;
        }
       
        public String GetSummary(bool includeProfile, bool includeWargear)
        {
            StringBuilder sbSummary = new StringBuilder();
            if (IsStrictMatchPlay)
            {
                sbSummary.Append("Matched Game Armylist - Fraktion ");
                sbSummary.Append(ArmyFactionForMatchedPlay.Name);
                sbSummary.Append(" ");
            }
            else
            {
                sbSummary.Append("Battleforged Armylist - ohne Fraktionszwang ");
            }
            sbSummary.Append("\'" + Name + "\'");
            sbSummary.AppendLine();
            sbSummary.AppendLine(new String('-', sbSummary.Length));
            
            sbSummary.Append("Matched Game Points: ");
            sbSummary.Append(CurrentPoints);
            if (DoCheckPointLimt)
            {
                sbSummary.Append(" / ");
                sbSummary.Append(PointLimit);
            }

            sbSummary.Append("   Powerlevel: " );
            sbSummary.Append(CurrentPowerLevel);
            if (DoCheckPowerlevel)
            {
                sbSummary.Append(" / ");
                sbSummary.Append(Powerlevel);
            }

            sbSummary.Append("   Commandpoints: ");
            sbSummary.Append(CurrentCommandPoints);
            sbSummary.AppendLine();
            sbSummary.AppendLine();
            if (Detachments != null && Detachments.Any())
            {
                sbSummary.Append(Detachments.Count);
                sbSummary.Append(" Detachments enthalten:");
                sbSummary.AppendLine();

                foreach (ModelClasses.Detachment detach in Detachments)
                {
                    sbSummary.AppendLine("- " + detach.ToString());
                }
            }

            sbSummary.AppendLine();

            if (Detachments != null && Detachments.Any())
            {
                foreach (ModelClasses.Detachment detach in Detachments)
                {
                    sbSummary.AppendLine(detach.GetSummary(includeProfile,includeWargear));
                }
            }

            sbSummary.AppendLine();
            sbSummary.AppendLine(new string('-',80));
            sbSummary.AppendLine("Created with WHSA ArmyPlanner. (c) 2017 by Matthias Breiter. www.ibbreiter.de");
            return sbSummary.ToString();
        }

        private Int32 GetCurrentCommandPoints()
        {
            Int32 commandpoints = 0;

            commandpoints += BaseCommandPoints;

            foreach (ModelClasses.Detachment det in Detachments)
            {
                commandpoints += det.CurrentCommandPoints;
            }

            return commandpoints;
        }

        private Int32 GetCurrentPowerlevel()
        {
            Int32 pl = 0;
            
            foreach (Detachment det in Detachments)
            {
                pl += det.CurrentPowerlevel;
            }

            return pl;
        }

        private Int32 GetCurrentMatchedPoints()
        {
            Int32 mp = 0;

            foreach (Detachment det in Detachments)
            {
                mp += det.CurrentPoints;
            }

            return mp;
        }
    }
}
