
namespace DoomsdayLogs.WindowsForms.Features.LogModule
{
    public partial class OpenIAMessager : Form
    {
        public OpenIAMessager(string? openAIResponse)
        {
            InitializeComponent();
            LogDescriptionText.Text = openAIResponse;
        }
    }
}
