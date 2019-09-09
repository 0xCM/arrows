//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static AsIn;

    partial class gmath
    {
        /// <summary>
        /// Computes the XOR of the source value and the result of left-shifting 
        /// the source by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static T xorsl<T>(T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.xorsl(int8(src), offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.xorsl(uint8(src), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.xorsl(int16(src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.xorsl(uint16(src), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.xorsl(int32(src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.xorsl(uint32(src), offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.xorsl(int64(src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.xorsl(uint64(src), offset));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Computes in-place the XOR of the source value and the result of left-shifting 
        /// the source by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static ref T xorsl<T>(ref T lhs, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xorsl(ref int8(ref lhs), offset);
            else if(typeof(T) == typeof(byte))
                math.xorsl(ref uint8(ref lhs), offset);
            else if(typeof(T) == typeof(short))
                math.xorsl(ref int16(ref lhs), offset);
            else if(typeof(T) == typeof(ushort))
                math.xorsl(ref uint16(ref lhs), offset);
            else if(typeof(T) == typeof(int))
                math.xorsl(ref int32(ref lhs), offset);
            else if(typeof(T) == typeof(uint))
                math.xorsl(ref uint32(ref lhs), offset);
            else if(typeof(T) == typeof(long))
                math.xorsl(ref int64(ref lhs), offset);
            else if(typeof(T) == typeof(ulong))
                math.xorsl(ref uint64(ref lhs), offset);
            else            
                throw unsupported<T>();
            return ref lhs;
        }
    }
}