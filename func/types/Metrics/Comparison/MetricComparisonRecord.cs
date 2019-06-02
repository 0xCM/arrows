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

    public class MetricComparisonRecord : IRecord<MetricComparisonRecord>
    {
        public static IReadOnlyList<string> GetHeaders()
            => type<MetricComparisonRecord>().DeclaredProperties().Select(p => p.Name).ToReadOnlyList();

        public static string GetHeaderText(char delimiter = ',')
        {
            var i = 0;
            var headers = GetHeaders();
            var delimited = string.Join(string.Empty, 
                $"{headers[i++]}{delimiter}".PadRight(OpNameLen), 
                $"{headers[i++]}{delimiter}".PadRight(OpNameLen), 
                $"{headers[i++]}{delimiter}".PadRight(MetricLen), 
                $"{headers[i++]}{delimiter}".PadRight(MetricLen), 
                $"{headers[i++]}{delimiter}".PadRight(MetricLen), 
                    headers[i]);
            return delimited;
            
        }

        public MetricComparisonRecord(string LeftOpUri, string RightOpUri, long OpCount, 
            Duration LeftWorkTime, Duration RightWorkTime, double PerformanceRatio)
        {
            this.LeftOp = LeftOpUri;
            this.RightOp = RightOpUri;
            
            this.OpCount = OpCount;

            this.LeftTime = LeftWorkTime;
            this.RightTime = RightWorkTime;
            this.Ratio = PerformanceRatio;
        }

        public string LeftOp {get;}

        public string RightOp {get;}

        public long OpCount {get;}
        
        public Duration LeftTime {get;}

        public Duration RightTime {get;}

        public double Ratio {get;}

        const int OpNameLen = 50;
        
        const int MetricLen = 14;


        string FormatOpCount(char delimiter = ',', bool digitcommas = false)
            => $"{OpCount.ToString(digitcommas ? "#,#" : string.Empty)}{delimiter}".PadRight(MetricLen);
        
        public string Delimited(char delimiter = ',', bool digitcommas = false)
            => string.Join(string.Empty, 
                $"{LeftOp.Trim()}{delimiter}".PadRight(OpNameLen), 
                $"{RightOp.Trim()}{delimiter}".PadRight(OpNameLen), 
                FormatOpCount(delimiter, digitcommas),
                $"{LeftTime.Ms} ms{delimiter}".PadRight(MetricLen), 
                $"{RightTime.Ms} ms{delimiter}".PadRight(MetricLen), 
                    Ratio);

        public override string ToString()
            => Delimited();

        public IReadOnlyList<string> Headers()
            => GetHeaders();
 
        public (AppMsg Header, AppMsg Content) Describe()
            => (DescribeHeader(), DescribeContent());
            
        public AppMsg DescribeHeader()
            => AppMsg.Define(GetHeaderText(), SeverityLevel.HiliteCL);
        
        public AppMsg DescribeContent()
            => AppMsg.Define(Delimited(), SeverityLevel.Perform);

    }
}