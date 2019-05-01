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

    using static zcore;



    public abstract class Context 
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
            print(messages);
        }

        protected Context(IRandomizer Randomizer)
        {
            this.Randomizer = Randomizer;
        }

        protected void hilite(string msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define(msg, SeverityLevel.HiliteCL, GetType().DisplayName() + caller));            

        protected void trace(string msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define(msg, SeverityLevel.Info, GetType().DisplayName() + caller));            
    }


}