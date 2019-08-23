//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {                        

        /// <summary>
        /// Calculates the number of bits set up to and including the current bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public static T rank<T>(in T src, BitPos pos)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.rank(int8(src), pos));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rank(uint8(src), pos));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.rank(int16(src), pos));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rank(uint16(src), pos));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.rank(int32(src), pos));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rank(uint32(src), pos));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.rank(int64(src), pos));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rank(uint64(src), pos));
            else            
                throw unsupported<T>();
        }


    }

}