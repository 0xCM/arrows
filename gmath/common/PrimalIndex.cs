//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static mfunc;
    

    public readonly struct PrimalIndex
    {
        [MethodImpl(Inline)]
        public static PrimalIndex define(
            object @sbyte = null, 
            object @byte = null, 
            object @short = null, 
            object @ushort = null, 
            object @int = null, 
            object @uint = null, 
            object @long = null, 
            object @ulong = null, 
            object @float = null, 
            object @double = null,
            object @decimal = null,
            object @bigint = null
            ) => new PrimalIndex(new object[]{null, 
                @sbyte, @byte, @short, @ushort, @int, 
                @uint, @long, @ulong, @float, @double,
                @decimal, @bigint
                });

        readonly object[] index;
        
        public PrimalIndex(object[] src)
            => index = src;
        
        public V lookup<K,V>()
            where K : struct, IEquatable<K>
        {
            var del = index[PrimalKinds.key<K>()];
            return Unsafe.As<object,V>(ref del);
        }            

        public V lookup<V>(PrimalKind kind)
            => (V)index[(int)kind];
    }
}