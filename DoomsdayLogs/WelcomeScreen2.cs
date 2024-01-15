using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoomsdayLogs.WindowsForms
{
    public partial class WelcomeScreen2 : UserControl
    {
        public WelcomeScreen2()
        {
            InitializeComponent();
        }

        private void BackSoldierScreen_Click(object sender, EventArgs e)
        {
            DoomsdayLogsForm.instance.SetTheWelcomeScreen();
        }

        private void MarceloSelectedButton_Click(object sender, EventArgs e)
        {
            DoomsdayLogsForm.instance.SetTheMainScreen("Marcelo");
        }
    }
}
