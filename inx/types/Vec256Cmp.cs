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

    public static class Vec256Cmp
    {
        [MethodImpl(Inline)]
        public static Vec256Cmp<T> Define<T>(Bit[] Results)
            where T : struct
                => new Vec256Cmp<T>(Results);

        public static Vec256Cmp<T> Define<T>(Vec256<T> Result)                
            where T : struct
        {
            var dst = new Bit[Vec256<T>.Length];
            for(var i = 0; i< dst.Length; i++)
                dst[i] = gmath.nonzero(Result[i]);
            return Define<T>(dst);
        }
    }

    public readonly struct Vec256Cmp<T>
        where T : struct
    {
    
        public static bool operator true(in Vec256Cmp<T> src)
            => src.Reduce();

        public static bool operator false(in Vec256Cmp<T> src)
            => !src.Reduce();

        public static implicit operator bool(in Vec256Cmp<T> src)
            => src.Reduce();


        [MethodImpl(Inline)]
        public Vec256Cmp(Bit[] Results)
            => this.Results = Results;

        readonly Bit[] Results;

        public Bit this[int component]
        {
            [MethodImpl(Inline)]
            get => Results[component];            
        }

        [MethodImpl(Inline)]
        public Vec256Cmp<S> As<S>()
            where S : struct
                => new Vec256Cmp<S>(Results);

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