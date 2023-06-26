using Autofac;
using DoomsdayLogs.WindowsForms.Features.ConfigurationModule;
using DoomsdayLogs.WindowsForms.Features.FilterModule;
using DoomsdayLogs.WindowsForms.Features.ProjectModule;
using DoomsdayLogs.WindowsForms.Shared;

namespace DoomsdayLogs.WindowsForms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public void SetSettingsOption(string option)
        {
            ConfigurationMenu configurationMenu = new ConfigurationMenu();

            FilterOptions filterOptions = new FilterOptions();

            if (option == "Project")
                SettingsPanel.Controls.Add(AutoFacBuilder.Register.SelectProjectOperation());

            if (option == "Configuration")
                SettingsPanel.Controls.Add(configurationMenu);

            if (option == "Filter")
                SettingsPanel.Controls.Add(filterOptions);
        }
    }
}
