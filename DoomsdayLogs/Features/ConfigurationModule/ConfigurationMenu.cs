using DoomsdayLogs.WindowsForms.Shared;
using System.Configuration;
using System.Net.Http.Headers;
using WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;

namespace DoomsdayLogs.WindowsForms.Features.ConfigurationModule
{
    public partial class ConfigurationMenu : UserControl
    {
        public static List<string> checkBoxToSave;
        static string? apiKey;
        private static readonly HttpClient client = new HttpClient();
        private const string usageUrl = "https://api.openai.com/v1/dashboard/billing/subscription";

        public ConfigurationMenu()
        {
            checkBoxToSave = new List<string>();
            InitializeComponent();
            SetNotePadFields();
        }

        private void SetNotePadFields()
        {
            string? notePadOptionsSelected = JsonConvert.SerializeObject(ConfigurationManager.AppSettings["NotePadOptionSelected"]);

            if (notePadOptionsSelected == "\"\"")
            {
                NameCB.Checked = true;
                DescriptionCB.Checked = true;
                DateTimeCB.Checked = true;
                TypeCB.Checked = true;
                ClassNameCB.Checked = true;
                DataNameCB.Checked = true;
                DataCB.Checked = true;
                ProjectIdCB.Checked = true;
            }
            else
            {
                if (notePadOptionsSelected.Contains("Name"))
                    NameCB.Checked = true;

                if (notePadOptionsSelected.Contains("Description"))
                    DescriptionCB.Checked = true;

                if (notePadOptionsSelected.Contains("DateTime"))
                    DateTimeCB.Checked = true;

                if (notePadOptionsSelected.Contains("Type"))
                    TypeCB.Checked = true;

                if (notePadOptionsSelected.Contains("ClassName"))
                    ClassNameCB.Checked = true;

                if (notePadOptionsSelected.Contains("DataName"))
                    DataNameCB.Checked = true;

                if (notePadOptionsSelected.Contains("Data"))
                    DataCB.Checked = true;

                if (notePadOptionsSelected.Contains("ProjectId"))
                    ProjectIdCB.Checked = true;
            }
        }

        private void NotePadOptions_Click(object sender, EventArgs e)
        {
            NameCB.Checked = true;
        }

        private void NameCB_CheckedChanged(object sender, EventArgs e)
        {
            if (NameCB.Checked == true)
                checkBoxToSave.Add("Name");
            else
                checkBoxToSave.Remove("Name");
        }

        private void DescriptionCB_CheckedChanged(object sender, EventArgs e)
        {
            if (DescriptionCB.Checked == true)
                checkBoxToSave.Add("Description");
            else
                checkBoxToSave.Remove("Description");
        }

        private void DateTimeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (DateTimeCB.Checked == true)
                checkBoxToSave.Add("DateTime");
            else
                checkBoxToSave.Remove("DateTime");
        }

        private void TypeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (TypeCB.Checked == true)
                checkBoxToSave.Add("Type");
            else
                checkBoxToSave.Remove("Type");
        }

        private void ClassNameCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ClassNameCB.Checked == true)
                checkBoxToSave.Add("ClassName");
            else
                checkBoxToSave.Remove("ClassName");
        }

        private void DataCB_CheckedChanged(object sender, EventArgs e)
        {
            if (DataCB.Checked == true)
                checkBoxToSave.Add("Data");
            else
                checkBoxToSave.Remove("Data");
        }

        private void ProjectIdCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ProjectIdCB.Checked == true)
                checkBoxToSave.Add("ProjectId");
            else
                checkBoxToSave.Remove("ProjectId");
        }

        private void DataNameCB_CheckedChanged(object sender, EventArgs e)
        {
            if (DataNameCB.Checked == true)
                checkBoxToSave.Add("DataName");
            else
                checkBoxToSave.Remove("DataName");
        }

        private void SelectLocalPathLog_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["LocalPathLog"].Value = dialog.FileName;

                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private async Task LoadUsageDataAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var usage = await GetUsageAsync();
            if (usage != null)
            {
                TotalGrantedValue.Text = $"Total Granted: {usage.TotalGranted}";
                TotalUsedValue.Text = $"Total Used: {usage.TotalUsed}";
                TotalAvailableValue.Text = $"Total Available: {usage.TotalAvailable}";

                config.AppSettings.Settings["ApiKey"].Value = apiKey;

                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
            }
            else
            {
                TotalGrantedValue.Text = "Error fetching data.";
                TotalUsedValue.Text = "Error fetching data.";
                TotalAvailableValue.Text = "Error fetching data.";

                if (!String.IsNullOrEmpty(config.AppSettings.Settings["ApiKey"].Value))
                {
                    config.AppSettings.Settings["ApiKey"].Value = "";

                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                }
            }
        }

        private static async Task<CreditUsageResponse> GetUsageAsync()
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue($"Bearer", apiKey);

            try
            {
                var response = await client.GetAsync(usageUrl);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                return System.Text.Json.JsonSerializer.Deserialize<CreditUsageResponse>(responseContent);
            }
            catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                MessageBox.Show("Access forbidden: Please check your API key and account permissions.");
                return null;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request error: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return null;
            }
        }

        private void CheckKeyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(apiKey))
            {
                apiKey = APIKeyText.Text;
                LoadUsageDataAsync().ConfigureAwait(false);
            }
        }
    }
}
