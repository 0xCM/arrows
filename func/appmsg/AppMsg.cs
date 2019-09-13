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
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static zfunc;

    /// <summary>
    /// Defines a message that encapsulates application diagnstic/status/error message content
    /// </summary>
    public class AppMsg
    {
        public static AppMsg Define(string content, SeverityLevel level)
            => new AppMsg(content, level, string.Empty, string.Empty,null);

        public static AppMsg Define(string content, SeverityLevel? level = null,  [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, level ?? SeverityLevel.Info, caller, file, line);
        
        public static AppMsg Error(string content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, SeverityLevel.Error, caller, file, line);

        public static readonly AppMsg Empty
            = new AppMsg(string.Empty, SeverityLevel.Info, string.Empty, string.Empty, null);

        AppMsg(string Content, SeverityLevel Level, string Caller, string Path, int? FileLine)
        {
            this.Content = Content ?? string.Empty;
            this.Level = Level;
            this.Caller = Caller ?? string.Empty;
            this.CallerFile =  nonempty(Path) ? FilePath.Define(Path) : Z0.FilePath.Empty;
            this.FileLine = FileLine;    
        }

        AppMsg(string content, SeverityLevel Level, string caller, FilePath file, int? line)
        {
            this.Content = content ?? string.Empty;
            this.Level = Level;
            this.Caller = caller ?? string.Empty;
            this.CallerFile = file;
            this.FileLine = line;    
        }

        /// <summary>
        /// The message body
        /// </summary>
        public string Content {get;}

        /// <summary>
        /// The message severit
        /// </summary>
        public SeverityLevel Level {get;}

        /// <summary>
        /// The name of the member that originated the message
        /// </summary>
        public string Caller {get;}

        /// <summary>
        /// The path to the source file in which the message originated
        /// </summary>
        public FilePath CallerFile {get;}

        /// <summary>
        /// The source file line number on which the message originated
        /// </summary>
        public int? FileLine {get;}

        public bool SupressFullPath
            => Level != SeverityLevel.Error;

        public bool IsEmpty
            => String.IsNullOrWhiteSpace(Content);

        /// <summary>
        /// Edits the message severity level
        /// </summary>
        /// <param name="Level">The new severity level</param>
        public AppMsg WithLevel(SeverityLevel Level)
            => new AppMsg(Content, Level, Caller, CallerFile, FileLine);

        /// <summary>
        /// Prepends the message body with specified content
        /// </summary>
        /// <param name="prefix">The prefix conent</param>
        public AppMsg WithPrependedContent(string prefix)    
            => new AppMsg($"{prefix}{this.Content}", Level, Caller, CallerFile, FileLine);

        /// <summary>
        /// Appends specified content to the message body
        /// </summary>
        /// <param name="suffix">The suffix content</param>
        public AppMsg WithAppendedContent(string suffix)    
            => new AppMsg($"{this.Content}{suffix}", Level, Caller, CallerFile, FileLine);

        public string Format()
        {
            var source = string.Empty;
            
            if(nonempty(Caller))
                source += $"{Caller}(";

            if(CallerFile.Nonempty)
                source += SupressFullPath ? $"File: {CallerFile.FileName.Name}" : $"File: {CallerFile.Name}";                        

            if(FileLine != null)
                source += $", Line: {FileLine}";

            if(nonempty(Caller))
                source += ")";

            return nonempty(source) 
                ? $"{source.Trim()} | {Content}" 
                : Content;

        }
        public override string ToString()
            => Format();

    }
}