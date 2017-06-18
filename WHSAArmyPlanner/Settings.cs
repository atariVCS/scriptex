using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WHSAArmyPlanner
{
    public sealed class Settings
    {
        private static readonly Lazy<Settings> lazy = new Lazy<Settings>(() => new Settings());
        public static Settings Instance { get { return lazy.Value; } }
        
        private string templatepath = "";

        public string TemplateBasePath { get { return templatepath; } set { SetTemplateFile(value); } }
        public string MiniatureFile { get { return TemplateBasePath + Const.minisFile; } }
        public string UnitsFile { get { return TemplateBasePath + Const.unitsFile; } }
        public string ItemsFile { get { return TemplateBasePath + Const.itemsFile; } }
        public string FactionsFile { get { return TemplateBasePath + Const.factionsFile; } }
        public string BattlerolesFile { get { return TemplateBasePath + Const.battlerolesFile; } }
        public string DetachmentsFile { get { return TemplateBasePath + Const.detachmentsFile; } }

        public bool DoSettingsExist { get { return CheckIfSettingsExist(); } }

        private Settings()
        {
            if (CheckIfSettingsExist())
            {
                string settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                if (settingsPath.EndsWith("\\"))
                {
                    settingsPath += Const.settingsFile;
                }
                else
                {
                    settingsPath += "\\" + Const.settingsFile;
                }

                templatepath = File.ReadAllText(settingsPath);
            }
        }
        
        public void Save()
        {
            string settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (settingsPath.EndsWith("\\"))
            {
                settingsPath += Const.settingsFile;
            }
            else
            {
                settingsPath += "\\" + Const.settingsFile;
            }

            try
            {
                File.WriteAllText(settingsPath, templatepath);
            }
            catch
            {
                templatepath = "";
                settingsPath = "";
            }
        }

        private void SetTemplateFile(string val)
        {
            if (val != null)
            {
                if (val.EndsWith("\\"))
                {
                    templatepath = val;
                }
                else
                {
                    templatepath = val + "\\";
                }
            }
        }

        private bool CheckIfSettingsExist()
        {
            bool doExist = false;
            
            string settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (settingsPath.EndsWith("\\"))
            {
                settingsPath += Const.settingsFile;
            }
            else
            {
                settingsPath += "\\" + Const.settingsFile;
            }

            if (File.Exists(settingsPath))
            {
                doExist = true;
            }

            return doExist;
        }
    }
}
