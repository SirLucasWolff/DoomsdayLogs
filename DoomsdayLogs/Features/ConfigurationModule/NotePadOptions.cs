using DoomsdayLogs.Domain.LogModule;
using Newtonsoft.Json;
using System.Configuration;

namespace DoomsdayLogs.WindowsForms.Features.ConfigurationModule
{
    public class NotePadOptions
    {
        public string SetNotePadFields(Log logSelected)
        {
            string? notePadOptionsSelected = JsonConvert.SerializeObject(ConfigurationManager.AppSettings["NotePadOptionSelected"]);

            string finalResult = string.Empty;

            if (notePadOptionsSelected.Contains("Name"))
                finalResult += $"Name = {logSelected.LogName}\n";

            if (notePadOptionsSelected.Contains("Description"))
                finalResult += $"Description = {logSelected.LogDescription}\n";

            if (notePadOptionsSelected.Contains("DateTime"))
                finalResult += $"Date Time = {logSelected.LogDateTime}\n";

            if (notePadOptionsSelected.Contains("Type"))
                finalResult += $"Type = {logSelected.LogType}\n";

            if (notePadOptionsSelected.Contains("ClassName"))
                finalResult += $"Class Name = {logSelected.LogClassName}\n";

            if (notePadOptionsSelected.Contains("Data"))
                finalResult += $"Data = {logSelected.LogData}\n";

            if (notePadOptionsSelected.Contains("ProjectId"))
                finalResult += $"Project Id = {logSelected.ProjectId}\n";

            if (notePadOptionsSelected.Contains("DataName"))
                finalResult += $"Data name = {logSelected.LogDataName}\n";

            return finalResult;
        }
    }
}
