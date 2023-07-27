using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.WindowsForms.Features.ConfigurationModule;
using DoomsdayLogs.WindowsForms.Features.LogModule;
using DoomsdayLogs.WindowsForms.Properties;
using DoomsdayLogs.WindowsForms.Shared;
using Newtonsoft.Json;
using System.Configuration;

namespace DoomsdayLogs.WindowsForms
{
    public partial class MainScreen : UserControl
    {
        public static MainScreen Instance;

        public static EnumLogType filterLogType { get; set; }

        public MainScreen()
        {
            InitializeComponent();
            ConfigPanelRegisters(false);
            SetProjectName();
            SetOpenLogButtonConfig();
            Instance = this;
            filterLogType = 0;
            FilterPanel.Visible = false;
        }

        private void ProjectButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();

            settingsForm.SetSettingsOption("Project");

            settingsForm.Text = "Project Menu";

            settingsForm.ShowDialog();
        }

        private void SetOpenLogButtonConfig()
        {
            OpenLogSelectedButton.Name = "Select Log";
        }

        public void ConfigPanelRegisters(bool isSearchByReference)
        {
            UserControl table = null;

            if (isSearchByReference)
            {
                table = AutoFacBuilder.Register.GetLogTable(SearchText.Text);
            }
            else
                table = AutoFacBuilder.Register.GetLogTable("");

            table.Dock = DockStyle.Fill;

            DataGridViewPanel.Controls.Clear();

            DataGridViewPanel.Controls.Add(table);
        }

        public void SetProjectName()
        {
            ProjectNameSelected.Text = ProjectSelected.ProjectName;
        }

        public void ChangeSoldierSelected(string soldierName)
        {
            if (soldierName == "Lucas")
            {
                this.SoldierSelectedImage.Image = Resources.Lucas_The_Shining;
                SoldierSelectedName.Text = "Lucas The Shining";
            }

            if (soldierName == "Daniel")
            {
                this.SoldierSelectedImage.Image = Resources.Daniel_The_Metal_Soldier;
                SoldierSelectedName.Text = "Daniel The Metal Soldier";
            }

            if (soldierName == "Felipe")
            {
                this.SoldierSelectedImage.Image = Resources.Felipe_The_Galaxies_eater;
                SoldierSelectedName.Text = "Felipe The Galaxies Eater";
            }

            if (soldierName == "Bruno")
            {
                this.SoldierSelectedImage.Image = Resources.Bruno_The_BadFather;
                SoldierSelectedName.Text = "Bruno The BadFather";
            }

            if (soldierName == "Samuel")
            {
                this.SoldierSelectedImage.Image = Resources.Samuel_The_Pig_Killer;
                SoldierSelectedName.Text = "Samuel The Pig Killer";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DoomsdayLogsForm.instance.SetTheWelcomeScreen();
        }

        private void ConfigurationButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();

            settingsForm.SetSettingsOption("Configuration");

            settingsForm.Text = "Configuration Menu";

            settingsForm.ShowDialog();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["NotePadOptionSelected"].Value = JsonConvert.SerializeObject(ConfigurationMenu.checkBoxToSave);

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void OpenLogSelectedButton_Click(object sender, EventArgs e)
        {
            Log logSelected = AutoFacBuilder.Register.GetLogSelected();

            DetailsLogSelected? detailsLogSelected = null;

            if (logSelected != null)
            {
                detailsLogSelected = new DetailsLogSelected(logSelected);
            }
            else return;

            if (OpenLogSelectedButton.Name == "Select Log")
            {
                DataGridViewPanel.Controls.Clear();

                DataGridViewPanel.Controls.Add(detailsLogSelected);

                OpenLogSelectedButton.Image = Resources.Left;

                OpenLogSelectedButton.Name = "Back log";

                SearchText.Enabled = false;

                SearchButton.Enabled = false;

                FilterButton.Enabled = false;

                ProjectButton.Enabled = false;
            }
            else
            {
                OpenLogSelectedButton.Name = "Select Log";

                OpenLogSelectedButton.Image = Resources.Right;

                SearchText.Enabled = true;

                SearchButton.Enabled = true;

                FilterButton.Enabled = true;

                ProjectButton.Enabled = true;

                ConfigPanelRegisters(false);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterPanel.Visible == false)
                FilterPanel.Visible = true;
            else
                FilterPanel.Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ConfigPanelRegisters(true);
        }

        private void SelectAllRb_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllRb.Checked)
            {
                filterLogType = 0;
                ConfigPanelRegisters(false);
            }
        }

        private void WarningRb_CheckedChanged(object sender, EventArgs e)
        {
            if (WarningRb.Checked)
            {
                filterLogType = EnumLogType.Warning;
                ConfigPanelRegisters(false);
            }
        }

        private void ErrorRb_CheckedChanged(object sender, EventArgs e)
        {
            if (ErrorRb.Checked)
            {
                filterLogType = EnumLogType.Error;
                ConfigPanelRegisters(false);
            }
        }

        private void InfoRb_CheckedChanged(object sender, EventArgs e)
        {
            if (InfoRb.Checked)
            {
                filterLogType = EnumLogType.Info;
                ConfigPanelRegisters(false);
            }
        }

        private void LastDateRb_CheckedChanged(object sender, EventArgs e)
        {
            FilterDateTime.filterDateTime = FilterDateTime.FilterDateTimeEnum.LastDateTime;

            ConfigPanelRegisters(false);
        }

        private void OldDateRb_CheckedChanged(object sender, EventArgs e)
        {
            FilterDateTime.filterDateTime = FilterDateTime.FilterDateTimeEnum.OldDateTime;

            ConfigPanelRegisters(false);
        }
    }
}
