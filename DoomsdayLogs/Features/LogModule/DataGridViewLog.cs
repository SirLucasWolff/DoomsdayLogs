using DoomsdayLogs.Application.LogModule;
using DoomsdayLogs.Application.ProjectModule;
using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.WindowsForms.Shared;

namespace DoomsdayLogs.WindowsForms.Features.LogModule
{
    public partial class DataGridViewLog : UserControl
    {
        private readonly LogAppService logAppService;

        public DataGridViewLog(LogAppService logAppService)
        {
            InitializeComponent();
            DataGridView.ConfigGridChekered();
            DataGridView.ConfigGridOnlyRead();
            DataGridView.Columns.AddRange(GetColumns());
            this.logAppService = logAppService;
        }

        public DataGridViewColumn[] GetColumns()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "LogName", HeaderText = "Log Name"},
            };

            return colunas;
        }

        public int GetIdSelected()
        {
            return DataGridView.SelectId<int>();
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
