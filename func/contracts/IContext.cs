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
        /// <summary>
        /// Takes messages from the context queue, and appends an optional number of messages to the result
        /// </summary>
        /// <param name="addenda">The messages to append, if any</param>
        /// <returns>Returns the dequeued messages concatenated with any addenda</returns>
        IReadOnlyList<AppMsg> DequeueMessages(params AppMsg[] addenda);

        /// <summary>
        /// Takes messages from the context queue, appends an optional number of messages to the result, 
        /// and finally, pushes the joined messages through the context output channel(s) as a a transactional
        /// block
        /// </summary>
        /// <param name="addenda"></param>
        void EmitMessages(params AppMsg[] addenda)
        {
            var messages = DequeueMessages(addenda);
            Terminal.Get().WriteMessages(messages);
            log(messages, LogArea.Test);            
        }


        /// <summary>
        /// Specifies the context-specific randomizer 
        /// </summary>
        IRandomSource Random {get;}
    }


}