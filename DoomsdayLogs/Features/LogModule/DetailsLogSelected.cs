using DoomsdayLogs.Domain.LogModule;
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
        }

        private void SetLogInformations()
        {
            LogNameText.Text = LogSelected.LogName;

            LogTypeText.Text = LogSelected.LogType.ToString();

            LogDateText.Text = LogSelected.LogDateTime.ToString();

            LogHelpText.Text = LogSelected.LogHelp;

            LogDescriptionTextBox.Text = LogSelected.LogDescription;
        }

        private void CreateNotePadButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                StreamWriter file = new StreamWriter(dialog.FileName + "\\" + LogSelected.LogName);
                file.Write($"Name = {LogSelected.LogName}\n" +
                           $"Description = {LogSelected.LogDescription}\n" +
                           $"Date time = {LogSelected.LogDateTime}\n" +
                           $"Type = {LogSelected.LogType}\n" +
                           $"Line = {LogSelected.LogLine}\n" +
                           $"Class Name = {LogSelected.LogClassName}\n" +
                           $"Method Name = {LogSelected.LogClassName}\n" +
                           $"Help = {LogSelected.LogHelp}\n" +
                           $"Data = {LogSelected.LogData}\n" +
                           $"Project ID = {LogSelected.ProjectId}");
                file.Close();

            }
        }

        private void ChangeTextBoxButton_Click(object sender, EventArgs e)
        {
            if (ChangeTextBoxButton.Text == "See log datas")
            {
                ChangeTextBoxButton.Text = "See log description";
                LogDescriptionTextBox.Clear();
                LogDescriptionTextBox.Text = LogSelected.LogData;
            }

            else
            {
                ChangeTextBoxButton.Text = "See log datas";
                LogDescriptionTextBox.Clear();
                LogDescriptionTextBox.Text = LogSelected.LogDescription;
            }
        }
    }
}
