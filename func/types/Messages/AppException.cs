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
    using System.Runtime.Serialization;
        
    using static zfunc;

    public class AppException : Exception
    {
        public static AppException Define(AppMsg msg)
            => new AppException(msg);

        public static AppException Define(string msg, string caller, string file, int? line)
            => new AppException(msg, caller, file, line);

        public AppException() { }
     
        public AppException(AppMsg msg) 
            : base(msg.ToString()) 
            { 
                this.Message = msg;
                this.Caller = Message.Caller;
                this.File = Message.CallerFile;
                this.Line = Message.FileLine;
            }

        public AppException(string msg, string caller, string file, int? line) 
            : base(msg.ToString()) 
            { 
                this.Message = AppMsg.Define($"{caller} line {line} {file}: {msg}", SeverityLevel.Error, caller, file, line);
                this.Caller = Message.Caller;
                this.File = Message.CallerFile;
                this.Line = Message.FileLine;
            }
     
        protected AppException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }    
        
        public string Caller {get;}

        public FilePath File {get;}

        public int? Line {get;}
        
        public new AppMsg Message {get;}

        public SeverityLevel Severity
            => Message.Level;

        public override string ToString()
            => Message.ToString();

    }

}