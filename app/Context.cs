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


    
    public abstract class Context<T> : Context
    {                
        protected Context(ulong[] seed)
            : base(Z0.Randomizer.define(seed))            
        {

        }

        public override void Emit(params AppMsg[] addenda)        
        {
            var messages = Flush(addenda);
            print(messages);
            log(messages, LogTarget.TestLog);            
        }
    }   
}