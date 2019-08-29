//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using static zfunc;    
    using static As;


    /// <summary>
    /// Represents the result obtained by comparing two 256-bit cpu vectors
    /// </summary>
    public readonly struct Vec256Cmp<T>
        where T : struct
    {    
        readonly Bit[] Results;

        public static bool operator true(in Vec256Cmp<T> src)
            => src.Reduce();

        public static bool operator false(in Vec256Cmp<T> src)
            => !src.Reduce();

        public static implicit operator bool(in Vec256Cmp<T> src)
            => src.Reduce();

        [MethodImpl(Inline)]
        public Vec256Cmp(Bit[] Results)
            => this.Results = Results;

        public Bit this[int component]
        {
            [MethodImpl(Inline)]
            get => Results[component];            
        }

        /// <summary>
        /// Condenses comparison content to a single bit that is enabled if and
        /// only if all enclosed bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public Bit Reduce()
        {
            for(var i = 0; i<Results.Length; i++)
                if(!Results[i])
                    return Bit.Off;
            return Bit.On;
        }

        [MethodImpl(Inline)]
        public Vec256Cmp<S> As<S>()
            where S : struct
                => new Vec256Cmp<S>(Results);

    }

}