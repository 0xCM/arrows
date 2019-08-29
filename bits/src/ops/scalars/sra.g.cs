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
        /// Computes an arithmetic rightwards shift
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static T sra<T>(T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.sra(ref int8(ref src), offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.srl(ref uint8(ref src), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.sra(ref int16(ref src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.srl(ref uint16(ref src), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.sra(ref int32(ref src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.srl(ref uint32(ref src), offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.sra(ref int64(ref src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.srl(ref uint64(ref src), offset));
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
        public static ref T sra<T>(ref T src, in T offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.sra(ref int8(ref src), (int)int8(in offset));
            else if(typeof(T) == typeof(byte))
                Bits.srl(ref uint8(ref src), (int)uint8(in offset));
            else if(typeof(T) == typeof(short))
                Bits.sra(ref int16(ref src), (int)int16(in offset));
            else if(typeof(T) == typeof(ushort))
                Bits.srl(ref uint16(ref src), (int)uint16(in offset));
            else if(typeof(T) == typeof(int))
                Bits.sra(ref int32(ref src), (int)int32(in offset));
            else if(typeof(T) == typeof(uint))
                Bits.srl(ref uint32(ref src), (int)uint32(in offset));
            else if(typeof(T) == typeof(long))
                Bits.sra(ref int64(ref src), (int)int64(in offset));
            else if(typeof(T) == typeof(ulong))
                Bits.srl(ref uint64(ref src), (int)uint64(in offset));
            else            
                throw unsupported<T>();
            return ref src;
        }           

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T sra<T>(ref T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.sra(ref int8(ref src), offset);
            else if(typeof(T) == typeof(byte))
                Bits.srl(ref uint8(ref src), offset);
            else if(typeof(T) == typeof(short))
                Bits.sra(ref int16(ref src), offset);
            else if(typeof(T) == typeof(ushort))
                Bits.srl(ref uint16(ref src), offset);
            else if(typeof(T) == typeof(int))
                Bits.sra(ref int32(ref src), offset);
            else if(typeof(T) == typeof(uint))
                Bits.srl(ref uint32(ref src), offset);
            else if(typeof(T) == typeof(long))
                Bits.sra(ref int64(ref src), offset);
            else if(typeof(T) == typeof(ulong))
                Bits.srl(ref uint64(ref src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }           


    }

}