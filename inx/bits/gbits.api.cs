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



        [MethodImpl(Inline)]
        public static ref T loff<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 Bits.loff(ref int8(ref src));
            if(typeof(T) == typeof(byte))
                 Bits.loff(ref uint8(ref src));
            if(typeof(T) == typeof(short))
                 Bits.loff(ref int16(ref src));
            if(typeof(T) == typeof(ushort))
                 Bits.loff(ref uint16(ref src));
            if(typeof(T) == typeof(int))
                 Bits.loff(ref int32(ref src));
            if(typeof(T) == typeof(uint))
                 Bits.loff(ref uint32(ref src));
            if(typeof(T) == typeof(long))
                 Bits.loff(ref int64(ref src));
            if(typeof(T) == typeof(ulong))
                 Bits.loff(ref uint64(ref src));
            else
                throw unsupported<T>();

            return ref src;
        }       
 
 


        public static ref T parse<T>(in ReadOnlySpan<char> src, in int offset, out T dst)
            where T : struct
        {            
            var last = Math.Min(Unsafe.SizeOf<T>()*8, src.Length) - 1;                                    
            dst = gmath.zero<T>();
            for(int i=offset, pos = 0; i<= last; i++, pos++)
                if(src[i] == Bit.One)
                    gbits.enable(ref dst, pos);                        
            return ref dst;
        }

        /// <summary>
        /// Determines whether identified bits in the operands agree.
        /// </summary>
        /// <param name="lhs">The first bit source</param>
        /// <param name="nx">The first bit position</param>
        /// <param name="rhs">The second bit source</param>
        /// <param name="ny">The second bit position</param>
        /// <typeparam name="S">The left operand type</typeparam>
        /// <typeparam name="T">The right operand type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All, PrimalKind.All)]
        public static bool match<S,T>(in S lhs, in int nx, T rhs, in int ny)
            where S : struct
            where T : struct
                => test(in lhs, in nx) == test(in rhs, in ny);     
    }
}