//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right primal operands
        /// </summary>
        /// <param name="lhs">The left scalar</param>
        /// <param name="rhs">The right scalar</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T andn<T>(in T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.andn(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.andn(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.andn(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.andn(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.andn(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.andn(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.andn(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.andn(in int64(in lhs), in int64(in rhs)));
            else 
                throw unsupported<T>();
        }


    }
}