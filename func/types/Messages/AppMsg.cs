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

    using static zfunc;

    public enum SeverityLevel
    {   
        /// <summary>
        /// Boring
        /// </summary>
        Unspecified = ConsoleColor.White,
        
        /// <summary>
        /// Identifies chatty content
        /// </summary>
        Babble = ConsoleColor.DarkGray,

        /// <summary>
        /// Identifies iformational content
        /// </summary>
        Info = ConsoleColor.Green,
        
        /// <summary>
        /// Identifies warning content
        /// </summary>
        Warning = ConsoleColor.Yellow,

        /// <summary>
        /// Identifies error content
        /// </summary>
        Error = ConsoleColor.Red,
        
        /// <summary>
        /// Identifies benchmark/timing result
        /// </summary>
        Perform = ConsoleColor.Magenta,

        /// <summary>
        /// Dark blue foreground 
        /// </summary>
        HiliteBD = ConsoleColor.DarkBlue,

        /// <summary>
        /// Light blue foreground 
        /// </summary>
        HiliteBL = ConsoleColor.Blue,

        /// <summary>
        /// Dark cyan foreground 
        /// </summary>
        HiliteCD = ConsoleColor.DarkCyan,

        /// <summary>
        /// Cyan foreground 
        /// </summary>
        HiliteCL = ConsoleColor.Cyan,

        /// <summary>
        /// Dark magenta foreground
        /// </summary>
        HiliteMD = ConsoleColor.DarkMagenta,

        /// <summary>
        /// Magenta foreground
        /// </summary>
        HiliteML = ConsoleColor.Magenta,


    }


    public class AppMsg
    {
        public static AppMsg Define(string Content, SeverityLevel Level)
            => new AppMsg(Content, Level, string.Empty, string.Empty,null);

        public static AppMsg Define(string Content, SeverityLevel? Level = null,  [CallerMemberName] string Caller = null, 
            [CallerFilePath] string FilePath = null, [CallerLineNumber] int? LineNumber = null)
                    => new AppMsg(Content, Level ?? SeverityLevel.Info, Caller, FilePath, LineNumber);

        public static readonly AppMsg Empty
            = new AppMsg(string.Empty, SeverityLevel.Info, string.Empty, string.Empty, null);

        AppMsg(string Content, SeverityLevel Level, string Caller, string FilePath, int? FileLine)
        {
            this.Content = Content ?? string.Empty;
            this.Level = Level;
            this.Caller = Caller ?? string.Empty;
            this.FilePath = FilePath ?? string.Empty;
            this.FileLine = FileLine;

        }

        public string Content {get;}

        public SeverityLevel Level {get;}

        public string Caller {get;}

        public string FilePath {get;}

        public int? FileLine {get;}

        public bool IsEmpty
            => String.IsNullOrWhiteSpace(Content);

        public AppMsg WithLevel(SeverityLevel Level)
            => new AppMsg(Content, Level, Caller, FilePath, FileLine);

        public override string ToString()
        {
            var source = string.Empty;
            
            if(isNotBlank(Caller))
                source += $"{Caller}";

            if(FileLine != null)
                source += $" Line {FileLine}";

            if(isNotBlank(FilePath))
                source += $" {FilePath} ";

            return isNotBlank(source) ? $"{source.Trim()}: {Content}" : Content;
        }

        public AppMsg WithPrependedContent(string Content)    
            => new AppMsg($"{Content}{this.Content}", Level, Caller, FilePath, FileLine);


        public AppMsg WithAppendedContent(string Content)    
            => new AppMsg($"{this.Content}{Content}", Level, Caller, FilePath, FileLine);

    }



}