//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public enum SeverityLevel
    {   
        Info = 0,
        
        Hilite = 1,

        Verbose = 2,

        Warning = 3,

        Error = -2,
    }

    public class AppMsg
    {

        public static AppMsg Define(string Content, SeverityLevel? Level = null, [CallerMemberName] string Caller = null)
            => new AppMsg(Content, Level ?? SeverityLevel.Info, Caller ?? string.Empty);

        public static readonly AppMsg Empty
            = new AppMsg(string.Empty, SeverityLevel.Info, string.Empty);

        AppMsg(string Content, SeverityLevel Level, string Caller)
        {
            this.Content = Content;
            this.Level = Level;
            this.Caller = Caller;
        }

        public string Content {get;}

        public SeverityLevel Level {get;}

        public string Caller {get;}

        public bool IsEmpty
            => String.IsNullOrWhiteSpace(Content);

        public override string ToString()
            => $"{Caller}: {Content}";
    }

}