/*"scriptex" Scriptorum Exercitus - Armylist planning tool for tabletop games
* (c) 2017 by Matthias Breiter. Licensed under the Terms of the Apache 2.0 License
*/

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace WHSAArmyPlanner.Forms
{
    public partial class DialogShareWithFriends : Form
    {
        enum ToolRunningMode { none, battlerole, faction, detachment, item, miniature, unit };

        #region data

        ToolRunningMode currentRunMode = ToolRunningMode.none;

        Boolean imported = false;
        Boolean isEdited = false;
        Boolean DoDisplayNewEntriesOnly = false;

        String importedTemplatesPath = "";

        String miniaturesFile = Settings.Instance.MiniatureFile;
        String factionsFile = Settings.Instance.FactionsFile;
        String itemsFile = Settings.Instance.ItemsFile;
        String unitsFile = Settings.Instance.UnitsFile;
        String battleRolesFile = Settings.Instance.BattlerolesFile;
        String detachmentsFile = Settings.Instance.DetachmentsFile;
        
        String importedMiniaturesFile = "";
        String importedFactionsFile = "";
        String importedItemsFile = "";
        String importedunitsFile = "";
        String importedBattleRolesFile = "";
        String importedDetachmentsFile = "";

        private ModelClasses.Miniatures existingMiniatures = new ModelClasses.Miniatures();
        private ModelClasses.Factions existingFactions = new ModelClasses.Factions();
        private ModelClasses.Detachments existingDetachments = new ModelClasses.Detachments();
        private ModelClasses.Units existingUnits = new ModelClasses.Units();
        private ModelClasses.Items existingItems = new ModelClasses.Items();
        private ModelClasses.BattleRoles existingBattleroles = new ModelClasses.BattleRoles();

        private ModelClasses.Miniatures importedMiniatures = new ModelClasses.Miniatures();
        private ModelClasses.Factions importedFactions = new ModelClasses.Factions();
        private ModelClasses.Detachments importedDetachments = new ModelClasses.Detachments();
        private ModelClasses.Units importedUnits = new ModelClasses.Units();
        private ModelClasses.Items importedItems = new ModelClasses.Items();
        private ModelClasses.BattleRoles importedBattleroles = new ModelClasses.BattleRoles();

        private ModelClasses.Miniatures newMiniatures = new ModelClasses.Miniatures();
        private ModelClasses.Factions newFactions = new ModelClasses.Factions();
        private ModelClasses.Detachments newDetachments = new ModelClasses.Detachments();
        private ModelClasses.Units newUnits = new ModelClasses.Units();
        private ModelClasses.Items newItems = new ModelClasses.Items();
        private ModelClasses.BattleRoles newBattleroles = new ModelClasses.BattleRoles();

        #endregion data

        public DialogShareWithFriends()
        {
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
            BuildCmbImportTopicsDE();
            LoadExistingTemplates();
            Cursor.Current = Cursors.Default;
        }

        private void DialogShareWithFriends_Load(object sender, EventArgs e)
        {
            ShowTemplatePath(Settings.Instance.TemplateBasePath);
        }
        
        private void BuildCmbImportTopicsDE()
        {
            cmbTemplate.Items.Clear();
            cmbTemplate.Items.Add(new ImportTopic("Battleroles/Slots",ToolRunningMode.battlerole));
            cmbTemplate.Items.Add(new ImportTopic("Fraktionen", ToolRunningMode.faction));
            cmbTemplate.Items.Add(new ImportTopic("Waffen / Wargear", ToolRunningMode.item));
            cmbTemplate.Items.Add(new ImportTopic("Miniaturen", ToolRunningMode.miniature));
            cmbTemplate.Items.Add(new ImportTopic("Einheiten", ToolRunningMode.unit));
            cmbTemplate.Items.Add(new ImportTopic("Detachments", ToolRunningMode.detachment));

        }

        #region Save Stuff
        public void Save()
        {
            SaveUnits(unitsFile);
            SaveBattleroles(battleRolesFile);
            SaveDetachments(detachmentsFile);
            SaveItems(itemsFile);
            SaveFactions(factionsFile);
            SaveMiniatures(miniaturesFile);
            isEdited = false;
        }

        public void Export(string targetPath)
        {
            Cursor.Current = Cursors.WaitCursor;
            string targetItems = "";
            string targetUnits = "";
            string targetFactions = "";
            string targetMinis = "";
            string targetDetachments = "";
            string targetBattleRoles = "";

            if (targetPath != null && targetPath.Any())
            {
                if (!targetPath.EndsWith("\\"))
                {
                    targetPath += "\\";
                }

                targetPath += "Templates\\";
                try
                {
                    Directory.CreateDirectory(targetPath);
                    targetItems = targetPath + Const.itemsFile;
                    targetMinis = targetPath + Const.minisFile;
                    targetUnits = targetPath + Const.unitsFile;
                    targetBattleRoles = targetPath + Const.battlerolesFile;
                    targetFactions = targetPath + Const.factionsFile;
                    targetDetachments = targetPath + Const.detachmentsFile;

                    SaveUnits(targetUnits);
                    SaveBattleroles(targetBattleRoles);
                    SaveDetachments(targetDetachments);
                    SaveItems(targetItems);
                    SaveFactions(targetFactions);
                    SaveMiniatures(targetMinis);

                    Cursor.Current = Cursors.Default;

                    MessageBox.Show("Export erfolgreich, die Templates liegen unter: " + targetPath);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Kann das Zielverzeichnis \'" + targetPath + "\' nicht erstellen: " + e.Message);
                }
            }
        }

        public void SaveUnits(string targetFile)
        {
            isEdited = false;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Units));
                TextWriter writer = new StreamWriter(targetFile);

                if (existingUnits != null && existingUnits.Any())
                {
                    serializer.Serialize(writer, existingUnits);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh Oh, ich kann nicht speichern: " + e.Message);
            }
        }

        public void SaveBattleroles(string targetFile)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.BattleRoles));
                TextWriter writer = new StreamWriter(targetFile);

                if (existingBattleroles != null && existingBattleroles.Any())
                {
                    serializer.Serialize(writer, existingBattleroles);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh Oh, ich kann nicht speichern: " + e.Message);
            }
        }

        //detachmentsFile
        public void SaveDetachments(string targetFile)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Detachments));
                TextWriter writer = new StreamWriter(targetFile);

                if (existingItems != null && existingDetachments.Any())
                {
                    serializer.Serialize(writer, existingDetachments);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh Oh, ich kann nicht speichern: " + e.Message);
            }
        }

        //itemsFile
        public void SaveItems(string targetFile)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Items));
                TextWriter writer = new StreamWriter(targetFile);

                if (existingItems != null && existingItems.Any())
                {
                    serializer.Serialize(writer, existingItems);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh Oh, ich kann nicht speichern: " + e.Message);
            }
        }

        //factionsFile
        public void SaveFactions(string targetFile)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Factions));
                TextWriter writer = new StreamWriter(targetFile);

                if (existingFactions != null && existingFactions.Any())
                {
                    serializer.Serialize(writer, existingFactions);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh Oh, ich kann nicht speichern: " + e.Message);
            }
        }

        //miniaturesFile
        public void SaveMiniatures(string targetFile)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Miniatures));
                TextWriter writer = new StreamWriter(targetFile);

                if (existingMiniatures != null && existingMiniatures.Any())
                {
                    serializer.Serialize(writer, existingMiniatures);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh Oh, ich kann nicht speichern: " + e.Message);
            }
        }
        #endregion

        #region Adding all Imports 

        private void AddAll()
        {
            switch (currentRunMode)
            {
                case ToolRunningMode.battlerole:
                    AddAllBattleRoles();
                    break;
                case ToolRunningMode.detachment:
                    AddAllDetachments();
                    break;
                case ToolRunningMode.faction:
                    AddAllFactions();
                    break;
                case ToolRunningMode.item:
                    AddAllItems();
                    break;
                case ToolRunningMode.miniature:
                    AddAllMiniatures();
                    break;
                case ToolRunningMode.none:
                    break;
                case ToolRunningMode.unit:
                    AddAllUnits();
                    break;
            }
        }

        private void AddAllBattleRoles()
        {
            foreach (ModelClasses.BattleRole entry in importedBattleroles)
            {
                AddBattleRole(entry);
            }
        }

        private void AddAllDetachments()
        {
            foreach (ModelClasses.Detachment entry in importedDetachments)
            {
                AddDetachment(entry);
            }
        }

        private void AddAllFactions()
        {
            foreach (ModelClasses.Faction entry in importedFactions)
            {
                AddFaction(entry);
            }
        }

        private void AddAllItems()
        {
            foreach(ModelClasses.Item entry in importedItems)
            {
                AddItem(entry);
            }

        }

        private void AddAllMiniatures()
        {
            foreach(ModelClasses.Miniature entry in importedMiniatures)
            {
                AddMiniature(entry);
            }
        }

        private void AddAllUnits()
        {
            foreach (ModelClasses.Unit entry in importedUnits)
            {
                AddUnit(entry);
            }
        }

        #endregion Adding all Imports 

        #region Add Selections

        private void AddSelected(object newEntry)
        {
            switch(currentRunMode)
            {
                case ToolRunningMode.battlerole:
                    AddBattleRole(newEntry);
                    break;
                case ToolRunningMode.detachment:
                    AddDetachment(newEntry);
                    break;
                case ToolRunningMode.faction:
                    AddFaction(newEntry);
                    break;
                case ToolRunningMode.item:
                    AddItem(newEntry);
                    break;
                case ToolRunningMode.miniature:
                    AddMiniature(newEntry);
                    break;
                case ToolRunningMode.none:
                    break;
                case ToolRunningMode.unit:
                    AddUnit(newEntry);
                    break;
            }
        }

        private void AddBattleRole(object newEntry)
        {
            try
            {
                if (newEntry != null)
                {
                    ModelClasses.BattleRole newRole = (ModelClasses.BattleRole)newEntry;
                    if (newBattleroles.Contains(newRole))
                    {
                        existingBattleroles.Add(newRole);
                        lbExistingTemplates.Items.Add(newRole);
                        isEdited = true;
                    }
                    else
                    {
                        int idx = existingBattleroles.FindIndex(x => x.Name == newRole.Name);
                        if (idx > -1)
                        {
                            existingBattleroles[idx].ImageFileName = newRole.ImageFileName;
                            existingBattleroles[idx].Icon = newRole.Icon;
                            isEdited = true;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void AddDetachment(object newEntry)
        {
            try
            {
                if (newEntry != null)
                {
                    ModelClasses.Detachment newDet = (ModelClasses.Detachment)newEntry;
                    if (newDetachments.Contains(newDet))
                    {
                        existingDetachments.Add(newDet);
                        lbExistingTemplates.Items.Add(newDet);
                        isEdited = true;
                    }
                    else
                    {
                        int idx = existingDetachments.FindIndex(x => x.Name == newDet.Name);
                        if (idx > -1)
                        {
                            existingDetachments[idx] = new ModelClasses.Detachment(newDet);
                            isEdited = true;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void AddFaction(object newEntry)
        {
            try
            {
                if (newEntry != null)
                {
                    ModelClasses.Faction tmpEntry = (ModelClasses.Faction)newEntry;
                    if (newFactions.Contains(tmpEntry))
                    {
                        existingFactions.Add(tmpEntry);
                        lbExistingTemplates.Items.Add(tmpEntry);
                        isEdited = true;
                    }
                    else
                    {
                        int idx = existingFactions.FindIndex(x => x.Name == tmpEntry.Name);
                        if (idx > -1)
                        {
                            existingFactions[idx].MainFaction = tmpEntry.MainFaction;
                            existingFactions[idx].SubFactionKeywords = tmpEntry.SubFactionKeywords;
                            isEdited = true;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void AddItem(object newEntry)
        {
            try
            {
                if (newEntry != null)
                {
                    ModelClasses.Item tmpEntry = (ModelClasses.Item)newEntry;
                    if (newItems.Contains(tmpEntry))
                    {
                        existingItems.Add(tmpEntry);
                        lbExistingTemplates.Items.Add(tmpEntry);
                        isEdited = true;
                    }
                    else
                    {
                        int idx = existingItems.FindIndex(x => x.Name == tmpEntry.Name);
                        if (idx > -1)
                        {
                            existingItems[idx] = new ModelClasses.Item(tmpEntry);
                            isEdited = true;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void AddMiniature(object newEntry)
        {
            try
            {
                if (newEntry != null)
                {
                    ModelClasses.Miniature tmpEntry = (ModelClasses.Miniature)newEntry;
                    if (newMiniatures.Contains(tmpEntry))
                    {
                        existingMiniatures.Add(tmpEntry);
                        lbExistingTemplates.Items.Add(tmpEntry);
                        isEdited = true;
                    }
                    else
                    {
                        int idx = existingMiniatures.FindIndex(x => x.Name == tmpEntry.Name);
                        if (idx > -1)
                        {
                            existingMiniatures[idx] = new ModelClasses.Miniature(tmpEntry);
                            isEdited = true;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void AddUnit(object newEntry)
        {
            try
            {
                if (newEntry != null)
                {
                    ModelClasses.Unit tmpEntry = (ModelClasses.Unit)newEntry;
                    if (newUnits.Contains(tmpEntry))
                    {
                        existingUnits.Add(tmpEntry);
                        lbExistingTemplates.Items.Add(tmpEntry);
                        isEdited = true;
                    }
                    else
                    {
                        int idx = existingUnits.FindIndex(x => x.Name == tmpEntry.Name);
                        if (idx > -1)
                        {
                            existingUnits[idx] = new ModelClasses.Unit(tmpEntry);
                            isEdited = true;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        #endregion Add Selections
        
        #region Loading / Imported Stuff

        private void SetImportedFilePaths()
        {
            if (!String.IsNullOrWhiteSpace(importedTemplatesPath))
            {
                importedMiniaturesFile = importedTemplatesPath + Const.minisFile;
                importedDetachmentsFile = importedTemplatesPath + Const.detachmentsFile;
                importedFactionsFile = importedTemplatesPath + Const.factionsFile;
                importedItemsFile = importedTemplatesPath + Const.itemsFile;
                importedunitsFile = importedTemplatesPath + Const.unitsFile;
                importedBattleRolesFile = importedTemplatesPath + Const.battlerolesFile;
            }
        }

        private void LoadImportMinis()
        {
            FileStream fs = null;
            importedMiniatures.Clear();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Miniatures));
                fs = new FileStream(importedMiniaturesFile, FileMode.Open);
                importedMiniatures = (ModelClasses.Miniatures)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        private void LoadImportBattleRoles()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer battleRoleSerializer = new XmlSerializer(typeof(ModelClasses.BattleRoles));
                fs = new FileStream(importedBattleRolesFile, FileMode.Open);
                importedBattleroles = (ModelClasses.BattleRoles)battleRoleSerializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        private void LoadImportDetachments()
        {
            FileStream fsDetachment = null;
            importedDetachments = new ModelClasses.Detachments();
            importedDetachments.Clear();

            try
            {
                XmlSerializer detachmentSerializer = new XmlSerializer(typeof(ModelClasses.Detachments));
                fsDetachment = new FileStream(importedDetachmentsFile, FileMode.Open);
                importedDetachments = (ModelClasses.Detachments)detachmentSerializer.Deserialize(fsDetachment);
                fsDetachment.Close();
            }
            catch (Exception excp)
            {
                if (fsDetachment != null)
                {
                    fsDetachment.Dispose();
                }
            }
        }

        private void LoadImportFactions()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Factions));
                fs = new FileStream(importedFactionsFile, FileMode.Open);
                importedFactions = (ModelClasses.Factions)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        private void LoadImportItems()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Items));
                fs = new FileStream(importedItemsFile, FileMode.Open);
                importedItems = (ModelClasses.Items)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        private void LoadImportUnits()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Units));
                fs = new FileStream(importedunitsFile, FileMode.Open);
                importedUnits = (ModelClasses.Units)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        private void LoadImported()
        {
            LoadImportMinis();
            LoadImportFactions();
            LoadImportItems();
            LoadImportUnits();
            LoadImportBattleRoles();
            LoadImportDetachments();
            
        }

        #endregion Loading / Imported Stuff

        #region Find new Stuff

        private void DetermineNewEntries()
        {
            GetNewMinis();
            GetNewBattleRoles();
            GetNewUnits();
            GetNewFactions();
            GetNewDetachments();
            GetNewItems();
        }

        private void GetNewMinis()
        {
            if (importedMiniatures != null && existingMiniatures != null)
            {
                newMiniatures.Clear();
                foreach (ModelClasses.Miniature mini in importedMiniatures)
                {
                    if (!existingMiniatures.Where(x => x.ToString() == mini.ToString()).Any())
                    {
                        newMiniatures.Add(mini);
                    }
                }
            }
        }

        private void GetNewBattleRoles()
        {
            if (importedBattleroles != null && existingBattleroles != null)
            {
                newBattleroles.Clear();
                foreach (ModelClasses.BattleRole role in importedBattleroles)
                {
                    if (!existingBattleroles.Where(x => x.ToString() == role.ToString()).Any())
                    {
                        newBattleroles.Add(role);
                    }
                }
            }
        }

        private void GetNewUnits()
        {
            if (importedUnits != null && existingUnits != null)
            {
                newUnits.Clear();
                foreach (ModelClasses.Unit entry in importedUnits)
                {
                    if (!existingUnits.Where(x => x.ToString() == entry.ToString()).Any())
                    {
                        newUnits.Add(entry);
                    }
                }
            }
        }

        private void GetNewDetachments()
        {
            if (importedDetachments != null && existingDetachments != null)
            {
                newDetachments.Clear();
                foreach (ModelClasses.Detachment entry in importedDetachments)
                {
                    if (!existingDetachments.Where(x => x.ToString() == entry.ToString()).Any())
                    {
                        newDetachments.Add(entry);
                    }
                }
            }
        }

        private void GetNewFactions()
        {
            if (importedFactions != null && existingFactions != null)
            {
                newFactions.Clear();
                foreach (ModelClasses.Faction entry in importedFactions)
                {
                    if (!existingFactions.Where(x => x.ToString() == entry.ToString()).Any())
                    {
                        newFactions.Add(entry);
                    }
                }
            }
        }
        
        private void GetNewItems()
        {
            if (importedItems != null && existingItems != null)
            {
                newItems.Clear();
                foreach (ModelClasses.Item entry in importedItems)
                {
                    if (!existingItems.Where(x => x.ToString() == entry.ToString()).Any())
                    {
                        newItems.Add(entry);
                    }
                }
            }
        }


        #endregion Find new Stuff

        #region Loading / Existing Stuff

        private void LoadExistingTemplates()
        {
            LoadExistingBattleRoles();
            LoadExistingMiniatures();
            LoadExistingFactions();
            LoadExistingUnits();
            LoadExistingItems();
            LoadExistingDetachments();
        }

        private void LoadExistingBattleRoles()
        {

            FileStream fs = null;

            try
            {
                XmlSerializer battleRoleSerializer = new XmlSerializer(typeof(ModelClasses.BattleRoles));
                fs = new FileStream(battleRolesFile, FileMode.Open);
                existingBattleroles = (ModelClasses.BattleRoles)battleRoleSerializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        private void LoadExistingMiniatures()
        {
            FileStream fs = null;
            existingMiniatures.Clear();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Miniatures));
                fs = new FileStream(miniaturesFile, FileMode.Open);
                existingMiniatures = (ModelClasses.Miniatures)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        private void LoadExistingFactions()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Factions));
                fs = new FileStream(factionsFile, FileMode.Open);
                existingFactions = (ModelClasses.Factions)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        private void LoadExistingUnits()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Units));
                fs = new FileStream(unitsFile, FileMode.Open);
                existingUnits = (ModelClasses.Units)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        private void LoadExistingItems()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Items));
                fs = new FileStream(itemsFile, FileMode.Open);
                existingItems = (ModelClasses.Items)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        private void LoadExistingDetachments()
        {
            FileStream fs = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModelClasses.Detachments));
                fs = new FileStream(detachmentsFile, FileMode.Open);
                existingDetachments = (ModelClasses.Detachments)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception excp)
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        #endregion Loading / Existing Stuff

        #region Regfreshs / Refills

        private void FillBattleRoles()
        {
            if (DoDisplayNewEntriesOnly)
            {
                foreach (ModelClasses.BattleRole entry in newBattleroles)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }
            else
            {
                foreach (ModelClasses.BattleRole entry in importedBattleroles)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }

            foreach (ModelClasses.BattleRole entry in existingBattleroles)
            {
                lbExistingTemplates.Items.Add(entry);
            }


        }

        private void FillFactions()
        {
            if (DoDisplayNewEntriesOnly)
            {
                foreach (ModelClasses.Faction entry in newFactions)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }
            else
            {
                foreach (ModelClasses.Faction entry in importedFactions)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }

            foreach (ModelClasses.Faction entry in existingFactions)
            {
                lbExistingTemplates.Items.Add(entry);
            }


        }

        private void FillMinis()
        {
            if (DoDisplayNewEntriesOnly)
            {
                foreach (ModelClasses.Miniature entry in newMiniatures)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }
            else
            {
                foreach (ModelClasses.Miniature entry in importedMiniatures)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }

            foreach (ModelClasses.Miniature entry in existingMiniatures)
            {
                lbExistingTemplates.Items.Add(entry);
            }
        }

        private void FillDetachments()
        {
            if (DoDisplayNewEntriesOnly)
            {
                foreach (ModelClasses.Detachment entry in newDetachments)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }
            else
            {
                foreach (ModelClasses.Detachment entry in importedDetachments)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }

            foreach (ModelClasses.Detachment entry in existingDetachments)
            {
                lbExistingTemplates.Items.Add(entry);
            }
        }

        private void FillItems()
        {
            if (DoDisplayNewEntriesOnly)
            {
                foreach (ModelClasses.Item entry in newItems)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }
            else
            {
                foreach (ModelClasses.Item entry in importedItems)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }

            foreach (ModelClasses.Item entry in existingItems)
            {
                lbExistingTemplates.Items.Add(entry);
            }
        }

        private void FillUnits()
        {
            if (DoDisplayNewEntriesOnly)
            {
                foreach (ModelClasses.Unit entry in newUnits)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }
            else
            {
                foreach (ModelClasses.Unit entry in importedUnits)
                {
                    lbImportedEntries.Items.Add(entry);
                }
            }

            foreach (ModelClasses.Unit entry in existingUnits)
            {
                lbExistingTemplates.Items.Add(entry);
            }
        }
        
        private void RefreshView()
        {
            if (imported)
            {
                lbImportedEntries.Enabled = true;
                btnAdd.Enabled = true;
                btnAddAll.Enabled = true;
                cbDisplayNewOnly.Enabled = true;
                // TODO: Filter
                txtFilter.Enabled = false;
                btnFilter.Enabled = false;
            }
            else
            {
                lbImportedEntries.Enabled = false;
                btnAdd.Enabled = false;
                btnAddAll.Enabled = false;
                cbDisplayNewOnly.Enabled = false;
                txtFilter.Enabled = false;
                btnFilter.Enabled = false;
            }

            switch (currentRunMode)
            {
                case ToolRunningMode.none:
                    lbImportedEntries.Items.Clear();
                    lbExistingTemplates.Items.Clear();
                    break;
                case ToolRunningMode.battlerole:
                    lbImportedEntries.Items.Clear();
                    lbExistingTemplates.Items.Clear();
                    FillBattleRoles();
                    break;
                case ToolRunningMode.detachment:
                    lbImportedEntries.Items.Clear();
                    lbExistingTemplates.Items.Clear();
                    FillDetachments();
                    break;
                case ToolRunningMode.faction:
                    lbImportedEntries.Items.Clear();
                    lbExistingTemplates.Items.Clear();
                    FillFactions();
                    break;
                case ToolRunningMode.item:
                    lbImportedEntries.Items.Clear();
                    lbExistingTemplates.Items.Clear();
                    FillItems();
                    break;
                case ToolRunningMode.miniature:
                    lbImportedEntries.Items.Clear();
                    lbExistingTemplates.Items.Clear();
                    FillMinis();
                    break;
                case ToolRunningMode.unit:
                    lbImportedEntries.Items.Clear();
                    lbExistingTemplates.Items.Clear();
                    FillUnits();
                    break;
            }
        }

        private void ShowTemplatePath(String path)
        {
            if (path.Length > 50)
            {
                path = path.Substring(0,47);
                path += "...";
            }

            lblCurrentTemplatePath.Text = path;
        }

        #endregion Regfreshs / Refills

        private bool TestIfTemplatePath(String path)
        {
            if (Directory.Exists(path))
            {
                int foundFiles = 0;

                foreach (String fileName in Directory.EnumerateFiles(path))
                {
                    if (Path.GetFileName(fileName) == Const.battlerolesFile)
                    {
                        foundFiles += 1;
                    }

                    if (Path.GetFileName(fileName) == Const.detachmentsFile)
                    {
                        foundFiles += 1;
                    }

                    if (Path.GetFileName(fileName) == Const.factionsFile)
                    {
                        foundFiles += 1;
                    }

                    if (Path.GetFileName(fileName) == Const.itemsFile)
                    {
                        foundFiles += 1;
                    }

                    if (Path.GetFileName(fileName) == Const.minisFile)
                    {
                        foundFiles += 1;
                    }

                    if (Path.GetFileName(fileName) == Const.unitsFile)
                    {
                        foundFiles += 1;
                    }
                }

                if (foundFiles > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            DialogResult usersChoice = fbSearchTemplates.ShowDialog(this);
            if (usersChoice == DialogResult.OK)
            {
                if (TestIfTemplatePath(fbSearchTemplates.SelectedPath))
                {
                    importedTemplatesPath = fbSearchTemplates.SelectedPath;
                    btnGo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Das Verzeichnis \'" + fbSearchTemplates.SelectedPath + "\' enthält keine Vorlagen oder es kann nicht darauf zugegriffen werden.");
                    importedTemplatesPath = "";
                    btnGo.Enabled = false;
                }

                txtImportedTemplates.Text = importedTemplatesPath;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(importedTemplatesPath))
            {
                if (!importedTemplatesPath.EndsWith("\\"))
                {
                    importedTemplatesPath += "\\";
                }

                if (importedTemplatesPath == Settings.Instance.TemplateBasePath)
                {
                    MessageBox.Show("Dies ist Dein eigenes Template- Verzeichnis. Bitte wähle ein anderes Verzeichnis.");
                    return;
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    SetImportedFilePaths();
                    LoadImported();
                    DetermineNewEntries();
                    cmbTemplate.Enabled = true;
                    Cursor.Current = Cursors.Default;
                    RefreshView();
                }
            }
        }

        private void cmbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTemplate.SelectedItem != null)
            {
                ImportTopic choice = (ImportTopic)cmbTemplate.SelectedItem;
                currentRunMode = choice.runningMode;
                lblSelectedTopic.Text = choice.caption;
                imported = true;
                DetermineNewEntries();
                RefreshView();
            }
            else
            {
                imported = false;
            }
        }
        
        private void cmbDisplayNewOnly_CheckedChanged(object sender, EventArgs e)
        {
            DoDisplayNewEntriesOnly = cbDisplayNewOnly.Checked;
            RefreshView();
        }

        private class ImportTopic
        {
            public String caption = "";
            public ToolRunningMode runningMode;

            public ImportTopic() { }

            public ImportTopic(String caption, ToolRunningMode runningMode)
            {
                this.caption = caption;
                this.runningMode = runningMode;
            }

            public override string ToString()
            {
                return caption;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbImportedEntries.SelectedItem != null)
            {
                AddSelected(lbImportedEntries.SelectedItem);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (imported)
            {
                DialogResult usersChoice = MessageBox.Show(this, "Sollen alle importierten " + lblCurrentTemplateCaption.Text + " übernommen werden? Dabei werden neue Einträge ergänzt und vorhandene Einträge überschrieben.", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (usersChoice == DialogResult.Yes)
                {
                    AddAll();
                }
            }
        }

        private void btnExportTemplates_Click(object sender, EventArgs e)
        {
            DialogResult usersChoice = fbExportTemplates.ShowDialog(this);
            if (usersChoice == DialogResult.OK)
            {
                Export(fbExportTemplates.SelectedPath);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Save();
            this.DialogResult = DialogResult.OK;
        }

        private void DialogShareWithFriends_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isEdited && this.DialogResult != DialogResult.Abort)
            {
                DialogResult userChoice = MessageBox.Show(this, "Es gibt ungespeicherte Änderungen. Sollen diese vor dem schließen gespeichert werden?", "Achtung - ungesicherte Änderungen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (userChoice == DialogResult.Yes)
                {
                    Save();
                }
            }
        }

        private void lbImportedEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbImportedEntries.SelectedItem != null)
            {
                txtDetails.Text = lbImportedEntries.SelectedItem.ToString();
            }
        }
    }
}
