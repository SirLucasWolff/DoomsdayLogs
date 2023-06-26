using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.WindowsForms.Features.ConfigurationModule;
using DoomsdayLogs.WindowsForms.Features.FilterModule;
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

        public MainScreen()
        {
            InitializeComponent();
            SetProjectName();
            ConfigPanelRegisters();
            SetOpenLogButtonConfig();
            Instance = this;
            FilterOptions.filterLogType = 0;
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

        public void ConfigPanelRegisters()
        {
            UserControl table = AutoFacBuilder.Register.GetLogTable();
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
            }
            else
            {
                OpenLogSelectedButton.Name = "Select Log";

                OpenLogSelectedButton.Image = Resources.Right;

                ConfigPanelRegisters();
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();

            settingsForm.SetSettingsOption("Filter");

            settingsForm.Text = "Filter options";

            settingsForm.ShowDialog();
        }
    }
}
