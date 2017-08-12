﻿namespace SharePointPnP.PowerShell.Commands.Diagnostic
{
    public sealed class ResponseTimeStatistics
    {
        public double Average { get; set; }
        public long Max { get; set; }
        public long Min { get; set; }
        public double StandardDeviation { get; set; }
        public double TruncatedAverage { get; set; }
        public long Count { get; set; }
    }
}
