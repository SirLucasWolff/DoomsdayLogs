using System.Text.Json.Serialization;

namespace DoomsdayLogs.WindowsForms.Shared
{
    public class CreditUsageResponse
    {
        [JsonPropertyName("total_granted")]
        public double TotalGranted { get; set; }

        [JsonPropertyName("total_used")]
        public double TotalUsed { get; set; }

        [JsonIgnore]
        public double TotalAvailable => TotalGranted - TotalUsed;
    }
}
