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

    

    public interface IContext
    {
        IReadOnlyList<AppMsg> Emit(params AppMsg[] addenda);
    }
    
    public abstract class Context : IContext
    {
        protected IRandomizer Randomizer {get;}

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

        protected Context(IRandomizer Randomizer)
        {
            this.Randomizer = Randomizer;
        }

        protected void HiLite(string msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define(msg, SeverityLevel.HiliteCL, GetType().DisplayName() + caller));            

        protected void NotifyError(Exception e)
        {
            var msg = AppMsg.Define($"{e}", SeverityLevel.Error);
            Emit(msg);
        }

        protected void Trace(string msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define(msg, SeverityLevel.Info, GetType().DisplayName() + caller));

        IReadOnlyList<AppMsg> IContext.Emit(params AppMsg[] addenda)
        {
            var messages = Flush(addenda);
            Emit(messages.ToArray());
            return messages;
        }
    }

    public abstract class Context<T> : Context
    {                
        protected Context(ulong[] seed)
            : base(Z0.Randomizer.define(seed))            
        {

        }

        protected Context(IRandomizer randomizer)
            : base(randomizer)            
        {

        }

        public override void Emit(params AppMsg[] addenda)        
        {
            var messages = Flush(addenda);
            zfunc.print(messages);
            //log(messages, LogTarget.TestLog);            
        }
    }   
}