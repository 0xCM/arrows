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

    public static class Vec128Cmp
    {
        [MethodImpl(Inline)]
        public static Vec128Cmp<T> Define<T>(Bit[] Results)
            where T : struct
                => new Vec128Cmp<T>(Results);

        public static Vec128Cmp<T> Define<T>(Vec128<T> Result)                
            where T : struct
        {
            var dst = new Bit[Vec128<T>.Length];
            for(var i = 0; i< dst.Length; i++)
                dst[i] = gmath.nonzero(Result[i]);
            return Define<T>(dst);
        }
    }

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
    
        [MethodImpl(Inline)]
        public Bit Reduce()
        {
            for(var i = 0; i<Results.Length; i++)
                if(!Results[i])
                    return Bit.Off;
            return Bit.On;
        }
    }

}