using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.WindowsForms.Features.ConfigurationModule;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http.Headers;
using WindowsAPICodePack.Dialogs;
using static System.Net.WebRequestMethods;

namespace DoomsdayLogs.WindowsForms.Features.LogModule
{
    public partial class DetailsLogSelected : UserControl
    {
        private Log LogSelected;
        private static readonly HttpClient client = new HttpClient();
        private const string apiUrl = "https://api.openai.com/v1/engines/davinci/completions";

        public DetailsLogSelected(Log logSelected)
        {
            InitializeComponent();
            this.LogSelected = logSelected;
            SetLogInformations();
            treeViewJson.Visible = false;
            LogsButtonValidation();
        }

        private void LogsButtonValidation()
        {
            string logLocalPath = ConfigurationManager.AppSettings["LocalPathLog"] + "\\" + LogSelected.LogName + ".txt";

            if (System.IO.File.Exists(logLocalPath))
                OpenLogSavedButton.Enabled = true;
            else
                OpenLogSavedButton.Enabled = false;
        }

        public void ConfigChangeLogDescriptionButton(bool hasData)
        {
            if (hasData)
            {
                ChangeTextBoxButton.Visible = true;
                TextPanel.Size = new Size(988, 215);
            }
            else
            {
                ChangeTextBoxButton.Visible = false;
                TextPanel.Size = new Size(988, 259);
            }
        }

        private void SetLogInformations()
        {
            LogNameText.Text = LogSelected.LogName;

            LogTypeText.Text = LogSelected.LogType.ToString();

            LogDateText.Text = LogSelected.LogDateTime.ToString();

            LogHelpText.Text = "OpenAI Helper";

            LogDescriptionText.Text = LogSelected.LogDescription;

            if (LogSelected.LogType == EnumLogType.Error && !String.IsNullOrEmpty(ConfigurationManager.AppSettings["ApiKey"]))
                LogHelpText.Enabled = true;
        }

        private void CreateNotePadButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["LocalPathLog"]))
            {
                StreamWriter file = new StreamWriter(ConfigurationManager.AppSettings["LocalPathLog"] + "\\" + LogSelected.LogName + ".txt");
                file.Write(new NotePadOptions().SetNotePadFields(LogSelected));
                file.Close();
                OpenLogSavedButton.Enabled = true;
            }
            else
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.IsFolderPicker = true;

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    StreamWriter file = new StreamWriter(dialog.FileName + "\\" + LogSelected.LogName + ".txt");
                    file.Write(new NotePadOptions().SetNotePadFields(LogSelected));
                    file.Close();
                    OpenLogSavedButton.Enabled = true;

                    if (MessageBox.Show("Do you want to save this local path?", "Log information",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        config.AppSettings.Settings["LocalPathLog"].Value = dialog.FileName;

                        config.Save(ConfigurationSaveMode.Modified);

                        ConfigurationManager.RefreshSection("appSettings");
                    }
                }
            }
        }

        private void ChangeTextBoxButton_Click(object sender, EventArgs e)
        {
            if (ChangeTextBoxButton.Text == "See log datas")
            {
                treeViewJson.Visible = true;
                TextPanel.Visible = false;
                treeViewJson.Size = new Size(988, 215);
                treeViewJson.Location = new Point(95, 149);
                ChangeTextBoxButton.Text = "See log description";
                LogDescriptionText.Text = LogSelected.LogData;
            }
            else
            {
                ChangeTextBoxButton.Text = "See log datas";
                treeViewJson.Visible = false;
                TextPanel.Visible = true;
                LogDescriptionText.Text = LogSelected.LogDescription;
            }
        }

        private void DetailsLogSelected_Load(object sender, EventArgs e)
        {
            if (LogSelected.LogData != null)
            {
                try
                {
                    JToken parsedJson = JToken.Parse(LogSelected.LogData);

                    treeViewJson.Nodes.Clear();
                    TreeNode rootNode = treeViewJson.Nodes.Add(LogSelected.LogDataName);
                    AddJsonNodeToTreeView(parsedJson, rootNode);

                    treeViewJson.Nodes[0].Expand();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddJsonNodeToTreeView(JToken token, TreeNode parentNode)
        {
            if (token.Type == JTokenType.Object)
            {
                foreach (var property in token.Children<JProperty>())
                {
                    TreeNode newNode = parentNode.Nodes.Add(property.Name);
                    AddJsonNodeToTreeView(property.Value, newNode);
                }
            }
            else if (token.Type == JTokenType.Array)
            {
                int index = 0;
                foreach (var item in token)
                {
                    TreeNode newNode = parentNode.Nodes.Add($"[{index}]");
                    AddJsonNodeToTreeView(item, newNode);
                    index++;
                }
            }
            else
            {
                parentNode.Nodes.Add(token.ToString());
            }
        }

        private void OpenLogSavedButton_Click(object sender, EventArgs e)
        {
            string folderPath = ConfigurationManager.AppSettings["LocalPathLog"];
            Process.Start("explorer.exe", folderPath);
        }

        private async Task<string> GetResponseAsync(string prompt)
        {
            var requestBody = new
            {
                prompt = prompt,
                max_tokens = 50
            };

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ConfigurationManager.AppSettings["ApiKey"]);

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(requestBody), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(apiUrl, content);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);
                return jsonResponse.choices[0].text;
            }
            catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                return "Access forbidden: Please check your API key and account permissions.";
            }
            catch (HttpRequestException ex)
            {
                return $"Request error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }

        private async void LogHelpText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string responseMessage = await GetResponseAsync(LogSelected.LogDescription);

            OpenIAMessager openIAMessager = new OpenIAMessager(responseMessage);

            openIAMessager.Show();
        }
    }
}
