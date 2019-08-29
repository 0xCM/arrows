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
    /// Encapsulates the result of a 128-bit cpu vector comparison operation
    /// </summary>
    public readonly struct Vec128Cmp<T>
        where T : struct
    {
        public static bool operator true(in Vec128Cmp<T> src)
            => src.Reduce();

        public static bool operator false(in Vec128Cmp<T> src)
            => !src.Reduce();

        public static implicit operator bool(in Vec128Cmp<T> src)
            => src.Reduce();

        [MethodImpl(Inline)]
        public Vec128Cmp(Bit[] Results)
            => this.Results = Results;

        readonly Bit[] Results;

        public Bit this[int component]
        {
            [MethodImpl(Inline)]
            get => Results[component];            
        }

        [MethodImpl(Inline)]
        public Vec128Cmp<S> As<S>()
            where S : struct
                => new Vec128Cmp<S>(Results);
    
        /// <summary>
        /// Condenses comparison content to a single bit that is enabled if and
        /// only if all enclosed bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public Bit Reduce()
        {
            Bit result = Bit.On;
            for(var i = 0; i<Results.Length; i++)
                result &= this[i];
            return result;
        }
    }
}