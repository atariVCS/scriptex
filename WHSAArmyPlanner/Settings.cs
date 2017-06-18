/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/

using System;
using System.IO;

namespace WHSAArmyPlanner
{
    /// <summary>
    /// Singleton Class to store some basic settings. So far the user's template path is stored here
    /// The settings are stored in the user's Document Folder (of the specific environment)
    /// </summary>
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
