using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.WindowsForms.Shared;
using System.Windows.Forms;

namespace DoomsdayLogs.WindowsForms.Features.LogModule
{
    public partial class DataGridViewLog : UserControl
    {
        public DataGridViewLog()
        {
            InitializeComponent();
            DataGridView.ConfigGridChekered();
            DataGridView.ConfigGridOnlyRead();
            DataGridView.Columns.AddRange(GetColumns());
        }

        public DataGridViewColumn[] GetColumns()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "LogName", HeaderText = "Log Name"},

                new DataGridViewTextBoxColumn { DataPropertyName = "LogDateTime", HeaderText = "Log Date"},

                new DataGridViewImageColumn { DataPropertyName = "LogTypeImage", HeaderText = "Log Type"},
            };

            return colunas;
        }

        public object GetObjectSelected()
        {
            return DataGridView.SelectTheValueObject();
        }

        public void UpdateRegisters(List<Log> logs)
        {
            LoadTable(logs);
        }

        public List<string> GetLogData()
        {
            List<string> rowList = new List<string>();

            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string logName = (string)row.Cells[0].Value;

                    rowList.Add(logName);
                }
            }

            return rowList;
        }

        private void LoadTable(List<Log> logs)
        {
            DataGridView.DataSource = logs;
        }
    }
}
