//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.IO;

    using static zfunc;

    public enum LogArea
    {
        Test,

        Bench,

        App,

    }

    public static class LogTarget
    {
        public static LogTarget<T> Define<T>(LogArea Area, T Kind)
            where T : Enum
                => new LogTarget<T>(Area, Kind);

        public static LogTarget<LogArea> AreaRoot(LogArea Area)
            => new LogTarget<LogArea>(Area,Area);

    }

    public interface ILogTarget
    {
        LogArea Area {get;}

        string KindName {get;}

        bool AreaRoot {get;}
    }

    public readonly struct LogTarget<T> : ILogTarget
        where T : Enum
    {
        public LogTarget(LogArea Area, T LogKind)
        {
            this.Area = Area;
            this.Kind = LogKind;
        }

        public readonly LogArea Area {get;}
        
        public readonly T Kind {get;}

        public bool AreaRoot 
            => typeof(T) == typeof(LogArea);

        public string KindName 
            => Kind.ToString();

        public override string ToString()
            => $"{Area}/{Kind}";
    }


}