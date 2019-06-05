//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

   public sealed class BitGContext : BitContext
    {
        public static BitGContext Define(MetricConfig config, IRandomizer random = null)
            => new BitGContext(config, random);

        public BitGContext(MetricConfig config, IRandomizer random = null)
            : base(config, random)
        {

        }

        public Metrics<T> Run<T>(MetricKind metric, bool generic, OpKind op)
            where T : struct
        {
            switch(op)
            {
                case OpKind.Toggle:
                    return this.Toggle<T>();                            
                case OpKind.Pop:
                    return this.Pop<T>();                            ;
                case OpKind.Enable:
                    return this.Enable<T>();
                case OpKind.Disable:
                    return this.Disable<T>();
                case OpKind.Test:
                    return this.Test<T>();
                default:
                    throw unsupported(op);

            }            
        }
    }
}