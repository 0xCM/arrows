//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Linq;
    
    using static zfunc;


    public abstract class Context : IContext
    {
        public IRandomSource Random {get;}

        protected List<AppMsg> Messages {get;} = new List<AppMsg>();


        public IReadOnlyList<AppMsg> DequeueMessages(params AppMsg[] addenda)
        {
            Messages.AddRange(addenda);
            var messages = Messages.ToArray();
            Messages.Clear();
            return messages;
        }

        protected Context(IRandomSource Randomizer)
        {
            this.Random = Randomizer;
        }

        protected virtual bool TraceEnabled {get;}
            = true;

        protected void NotifyError(Exception e)
        {
            var msg = AppMsg.Define($"{e}", SeverityLevel.Error);
            (this as IContext).EmitMessages(msg);
        }

        protected void HiLite(string msg, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => Messages.Add(AppMsg.Define(msg, SeverityLevel.HiliteCL, caller, file, line));

        protected void Trace(string msg, SeverityLevel? severity = null)
        {
            if(TraceEnabled)
                Messages.Add(AppMsg.Define($"{msg}", severity ?? SeverityLevel.Babble));
        }

        protected void Trace(AppMsg msg, SeverityLevel? severity = null)
        {
            if(TraceEnabled)
                Messages.Add(msg.WithLevel(severity ?? SeverityLevel.Babble));
        }

        /// <summary>
        /// Emits a performance-related trace message
        /// </summary>
        /// <param name="msg">The message to emit</param>
        protected void TracePerf(AppMsg msg)
        {
            if(TraceEnabled)
                Messages.Add(msg.WithLevel(SeverityLevel.Benchmark));
        }

        protected void TracePerf(OpTimePair timing)
        {
            if(TraceEnabled)
                TracePerf(timing.Format());
        }


        /// <summary>
        /// Emits a performance-related trace message
        /// </summary>
        /// <param name="msg">The message to emit</param>
        protected void TracePerf(string msg)
        {
            if(TraceEnabled)
                Messages.Add(AppMsg.Define($"{msg}", SeverityLevel.Benchmark));
        }

    }

    public abstract class Context<T> : Context
    {                

        protected Context(IRandomSource randomizer)
            : base(randomizer)            
        {

        }

    }   
}