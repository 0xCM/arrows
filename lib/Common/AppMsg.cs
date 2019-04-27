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
        Unspecified = ConsoleColor.White,
        
        Verbose = ConsoleColor.DarkGray,

        Info = ConsoleColor.Green,
        
        Warning = ConsoleColor.Yellow,

        Error = ConsoleColor.Red,

        HiliteBD = ConsoleColor.DarkBlue,

        HiliteBL = ConsoleColor.Blue,

        HiliteCD = ConsoleColor.DarkCyan,

        HiliteCL = ConsoleColor.Cyan,

        HiliteMD = ConsoleColor.DarkMagenta,

        HiliteML = ConsoleColor.Magenta,

        Perform = ConsoleColor.Magenta

    }


    public class AppMsg
    {
        public static AppMsg Define(string Content, SeverityLevel Level)
            => new AppMsg(Content, Level , string.Empty);

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
            => String.IsNullOrWhiteSpace(Caller) ? Content : $"{Caller}: {Content}";
    }

}