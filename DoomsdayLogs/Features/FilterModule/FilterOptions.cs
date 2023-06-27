using DoomsdayLogs.Domain.LogModule;

namespace DoomsdayLogs.WindowsForms.Features.FilterModule
{
    public partial class FilterOptions : UserControl
    {
        public static EnumLogType filterLogType { get; set; }

        public FilterOptions()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (WarningRb.Checked)
                filterLogType = EnumLogType.Warning;

            if (ErrorRb.Checked)
                filterLogType = EnumLogType.Error;

            if (InfoRb.Checked)
                filterLogType = EnumLogType.Info;

            if (SelectAllRb.Checked)
                filterLogType = 0;

            MainScreen.Instance.ConfigPanelRegisters();
        }
    }
}
