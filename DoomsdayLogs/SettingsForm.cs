using DoomsdayLogs.WindowsForms.Features.ConfigurationModule;
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

            if (option == "Project")
                SettingsPanel.Controls.Add(AutoFacBuilder.Register.SelectProjectOperation());

            if (option == "Configuration")
                SettingsPanel.Controls.Add(configurationMenu);
        }
    }
}
