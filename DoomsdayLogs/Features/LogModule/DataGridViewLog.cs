using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.WindowsForms.Shared;

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

        private void LoadTable(List<Log> logs)
        {
            DataGridView.DataSource = logs;
        }
    }
}
