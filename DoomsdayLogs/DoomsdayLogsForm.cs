using DoomsdayLogs.WindowsForms;

namespace DoomsdayLogs
{
    public partial class DoomsdayLogsForm : Form
    {
        public static DoomsdayLogsForm? instance;

        public DoomsdayLogsForm()
        {
            InitializeComponent();

            instance = this;

            WelcomeScreen welcomeScreen = new WelcomeScreen();

            MainPanel.Controls.Add(welcomeScreen);
        }

        #region ScreensSetUp

        public void SetTheMainScreen(string soldierName)
        {
            MainPanel.Controls.Clear();

            MainScreen mainScreen = new MainScreen();

            MainPanel.Controls.Add(mainScreen);

            mainScreen.ChangeSoldierSelected(soldierName);
        }

        public void SetTheWelcomeScreen()
        {
            MainPanel.Controls.Clear();

            WelcomeScreen welcomeScreen = new WelcomeScreen();

            MainPanel.Controls.Add(welcomeScreen);
        }

        public void SetTheWelcomeScreen2()
        {
            MainPanel.Controls.Clear();

            WelcomeScreen2 welcomeScreen = new WelcomeScreen2();

            MainPanel.Controls.Add(welcomeScreen);
        }

        #endregion
    }
}