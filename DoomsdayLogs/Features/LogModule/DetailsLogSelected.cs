using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.WindowsForms.Features.ConfigurationModule;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DoomsdayLogs.WindowsForms.Features.LogModule
{
    public partial class DetailsLogSelected : UserControl
    {
        private Log LogSelected;

        public DetailsLogSelected(Log logSelected)
        {
            InitializeComponent();
            this.LogSelected = logSelected;
            SetLogInformations();
            JsonViewer.Visible = false;
        }

        private void SetLogInformations()
        {
            LogNameText.Text = LogSelected.LogName;

            LogTypeText.Text = LogSelected.LogType.ToString();

            LogDateText.Text = LogSelected.LogDateTime.ToString();

            LogHelpText.Text = LogSelected.LogHelp;

            LogDescriptionText.Text = LogSelected.LogDescription;
        }

        private void CreateNotePadButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                StreamWriter file = new StreamWriter(dialog.FileName + "\\" + LogSelected.LogName);
                file.Write(new NotePadOptions().SetNotePadFields(LogSelected));
                file.Close();
            }
        }

        private void ChangeTextBoxButton_Click(object sender, EventArgs e)
        {
            if (ChangeTextBoxButton.Text == "See log datas")
            {
                JsonViewer.Visible = true;
                ChangeTextBoxButton.Text = "See log description";
                LogDescriptionText.Text = LogSelected.LogData;
            }
            else
            {
                ChangeTextBoxButton.Text = "See log datas";
                JsonViewer.Visible = false;
                LogDescriptionText.Text = LogSelected.LogDescription;
            }
        }
    }
}
