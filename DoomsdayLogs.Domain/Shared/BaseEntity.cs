﻿namespace DoomsdayLogs.Domain.Shared
{
    public abstract class BaseEntity <Tkey>
    {
        public int Id { get; set; }
    }
}
