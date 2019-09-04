//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System;
    using System.Timers;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Defines configuration parameters for the <see cref='PulseEmitter'/> service
    /// </summary>
    public sealed class PulseEmitterConfig
    {
        public PulseEmitterConfig(TimeSpan Frequency)
        {
            this.Frequency = Frequency;
        }

        /// <summary>
        /// Specifies the emission frequency
        /// </summary>
        public TimeSpan Frequency {get;}
    }


}