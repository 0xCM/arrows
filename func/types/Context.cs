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
    using System.Linq;
    
    using static zfunc;

    
    public interface IContext
    {
        IReadOnlyList<AppMsg> Emit(params AppMsg[] addenda);
        
        IReadOnlyList<AppMsg> Flush(params AppMsg[] addenda);
    }
    
    public abstract class Context : IContext
    {
        protected IRandomSource Randomizer {get;}

        List<AppMsg> Messages {get;} = new List<AppMsg>();

        public IReadOnlyList<AppMsg> Flush(params AppMsg[] addenda)
        {
            Messages.AddRange(addenda);
            var messages = Messages.ToArray();
            Messages.Clear();
            return messages;
        }

        public virtual void Emit(params AppMsg[] addenda)
        {
            var messages = Flush(addenda);
            zfunc.print(messages);
        }

        protected Context(IRandomSource Randomizer)
        {
            this.Randomizer = Randomizer;
        }

        protected virtual bool TraceEnabled {get;}
            = true;

        protected void NotifyError(Exception e)
        {
            var msg = AppMsg.Define($"{e}", SeverityLevel.Error);
            Emit(msg);
        }

        protected void HiLite(string msg, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => Messages.Add(AppMsg.Define(msg, SeverityLevel.HiliteCL, caller, file, line));

        protected void TypeCaseStart<T>([CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define($"{caller}<{typeof(T).Name}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<T>([CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define($"{caller}<{typeof(T).Name}> succeeded", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<T>(AppMsg msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define($"{caller}<{typeof(T).Name}> succeeded: {msg}", SeverityLevel.HiliteCL));

        protected void Trace(string msg)
        {
            if(TraceEnabled)
                Messages.Add(AppMsg.Define($"{msg}", SeverityLevel.Babble));
        }

        protected void Trace(AppMsg msg)
        {
            if(TraceEnabled)
                Messages.Add(msg.WithLevel(SeverityLevel.Babble));
        }

        IReadOnlyList<AppMsg> IContext.Emit(params AppMsg[] addenda)
        {
            var messages = Flush(addenda);
            Emit(messages.ToArray());
            return messages;
        }
    }

    public abstract class Context<T> : Context
    {                

        protected Context(IRandomSource randomizer)
            : base(randomizer)            
        {

        }

        public override void Emit(params AppMsg[] addenda)        
        {
            var messages = Flush(addenda);
            zfunc.print(messages);
            log(messages, LogArea.Test);            
        }
    }   
}