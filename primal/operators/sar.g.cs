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
    
    partial class gmath
    {

        /// <summary>
        /// Computes an arithmetic rightwards shift
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T sar<T>(T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.sar(ref int8(ref src), offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.sar(ref uint8(ref src), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.sar(ref int16(ref src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sar(ref uint16(ref src), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.sar(ref int32(ref src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sar(ref uint32(ref src), offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.sar(ref int64(ref src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.sar(ref uint64(ref src), offset));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T sar<T>(ref T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.sar(ref int8(ref src), offset);
            else if(typeof(T) == typeof(byte))
                math.sar(ref uint8(ref src), offset);
            else if(typeof(T) == typeof(short))
                math.sar(ref int16(ref src), offset);
            else if(typeof(T) == typeof(ushort))
                math.sar(ref uint16(ref src), offset);
            else if(typeof(T) == typeof(int))
                math.sar(ref int32(ref src), offset);
            else if(typeof(T) == typeof(uint))
                math.sar(ref uint32(ref src), offset);
            else if(typeof(T) == typeof(long))
                math.sar(ref int64(ref src), offset);
            else if(typeof(T) == typeof(ulong))
                math.sar(ref uint64(ref src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }           
    }
}