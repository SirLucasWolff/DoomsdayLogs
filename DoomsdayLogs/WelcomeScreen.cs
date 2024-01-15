namespace DoomsdayLogs.WindowsForms
{
    public partial class WelcomeScreen : UserControl
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void BrunoSelectedButton_Click(object sender, EventArgs e)
        {
            DoomsdayLogsForm.instance.SetTheMainScreen("Bruno");
        }

        private void DanielSelectedButton_Click(object sender, EventArgs e)
        {
            DoomsdayLogsForm.instance.SetTheMainScreen("Daniel");
        }

        private void FelipeSelectedButton_Click(object sender, EventArgs e)
        {
            DoomsdayLogsForm.instance.SetTheMainScreen("Felipe");
        }

        private void LucasSelectedButton_Click(object sender, EventArgs e)
        {
            DoomsdayLogsForm.instance.SetTheMainScreen("Lucas");
        }

        private void SamuelSelectedButton_Click(object sender, EventArgs e)
        {
            DoomsdayLogsForm.instance.SetTheMainScreen("Samuel");
        }

        private void NextSoldierScreen_Click(object sender, EventArgs e)
        {
            DoomsdayLogsForm.instance.SetTheWelcomeScreen2();
        }
    }
}
