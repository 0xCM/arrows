//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class MetricSummaryRecord : Record<MetricSummaryRecord>
    {
        
        const int OpNameLen = 50;
        
        const int MetricLen = 14;

        public MetricSummaryRecord()
        {

        }

        public MetricSummaryRecord(OpId op, long opcount, Duration time)
        {
            this.OpName = OpId.BuildOpUri(op);
            this.OpCount = opcount;
            this.WorkTime = time;
        }   
    
        public string OpName {get;}
            = string.Empty;

        public long OpCount {get;}
            = 0;

        public Duration WorkTime {get;}
            = Duration.Zero;

        protected static string FormatScalar(long value, bool withCommas = false)
            => withCommas ? value.CommaSeparated() : value.ToString();

        protected string DelimitScalar(long value, char delimiter = ',', bool digitcommas = false)
            => $"{FormatScalar(value, digitcommas)}{delimiter}".PadRight(MetricLen);

        public override string DelimitedText(char delimiter)
            => concat( 
                $"{OpName}{delimiter}".PadRight(OpNameLen), 
                DelimitScalar(OpCount, delimiter, false),
                $"{WorkTime}{delimiter}");
    }
}
