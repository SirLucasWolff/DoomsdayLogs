namespace DoomsdayLogs.WindowsForms.Shared
{
    public class FilterDateTime
    {
        public static FilterDateTimeEnum filterDateTime { get; set; }

        public enum FilterDateTimeEnum
        {
            LastDateTime = 1,
            OldDateTime
        }
    }
}
