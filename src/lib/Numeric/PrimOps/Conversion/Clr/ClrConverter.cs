//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using static zcore;
    
    using static Operative;

    /// <summary>
    /// Defines stream conversion operations
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public readonly struct ClrConverter<S, T> : Operative.ClrConverter<S, T>
    {
        public static readonly ClrConverter<S, T> Inhabitant = default;
        
        static readonly Conversion<S,T> Convert = ClrConvert.raw<S,T>();


        [MethodImpl(Inline)]
        public IReadOnlyList<T> convert(IReadOnlyList<S> src)
        {
            var dst = array<T>(src.Count);
            iter(src.Count, i => dst[i] = Convert.convert(src[i]));
            return dst;
        }

        [MethodImpl(Inline)]
        public T convert(S src)
            => Convert.convert(src);

        [MethodImpl(Inline)]
        public T convert(S src, out T dst)
            => Convert.convert(src, out dst);
    }


}