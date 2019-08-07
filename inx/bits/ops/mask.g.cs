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
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static ref T enable<T>(ref T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitMask.enable(ref int8(ref src), in pos);
            else if(typeof(T) == typeof(byte))
                BitMask.enable(ref uint8(ref src), in pos);
            else if(typeof(T) == typeof(short))
                BitMask.enable(ref int16(ref src), in pos);
            else if(typeof(T) == typeof(ushort))
                BitMask.enable(ref uint16(ref src), in pos);
            else if(typeof(T) == typeof(int))
                BitMask.enable(ref int32(ref src), in pos);
            else if(typeof(T) == typeof(uint))
                BitMask.enable(ref uint32(ref src), in pos);
            else if(typeof(T) == typeof(long))
                BitMask.enable(ref int64(ref src), in pos);
            else if(typeof(T) == typeof(ulong))
                BitMask.enable(ref uint64(ref src), in pos);
            else
                throw unsupported<T>();

            return ref src;                            
        }

        /// <summary>
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static T enable<T>(T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(BitMask.enable(int8(src), pos));
            else if(typeof(T) == typeof(byte))
                return generic<T>(BitMask.enable(uint8(src), pos));
            else if(typeof(T) == typeof(short))
                return generic<T>(BitMask.enable(int16(src), pos));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(BitMask.enable(uint16(src), pos));
            else if(typeof(T) == typeof(int))
                return generic<T>(BitMask.enable(int32(src), pos));
            else if(typeof(T) == typeof(uint))
                return generic<T>(BitMask.enable(uint32(src), pos));
            else if(typeof(T) == typeof(long))
                return generic<T>(BitMask.enable(int64(src), pos));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(BitMask.enable(uint64(src), pos));
            else
                throw unsupported<T>();            
        }

        /// <summary>
        /// Disables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static ref T disable<T>(ref T src, byte pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitMask.disable(ref int8(ref src), pos);
            else if(typeof(T) == typeof(byte))
                BitMask.disable(ref uint8(ref src), pos);
            else if(typeof(T) == typeof(short))
                BitMask.disable(ref int16(ref src), pos);
            else if(typeof(T) == typeof(ushort))
                BitMask.disable(ref uint16(ref src), pos);
            else if(typeof(T) == typeof(int))
                BitMask.disable(ref int32(ref src), pos);
            else if(typeof(T) == typeof(uint))
                BitMask.disable(ref uint32(ref src), pos);
            else if(typeof(T) == typeof(long))
                BitMask.disable(ref int64(ref src), pos);
            else if(typeof(T) == typeof(ulong))
                BitMask.disable(ref uint64(ref src), pos);
            else if(typeof(T) == typeof(float))
                BitMask.disable(ref float32(ref src), pos);
            else if(typeof(T) == typeof(double))
                BitMask.disable(ref float64(ref src), pos);
            else
                throw unsupported<T>();
                
            return ref src;                            
        }

        /// <summary>
        /// Determines whether a position-identified bit in value is enabled
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static bool test<T>(in T src,in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return BitMask.test(in int8(in src), pos);
            else if(typeof(T) == typeof(byte))
                 return BitMask.test(in uint8(in src), pos);
            else if(typeof(T) == typeof(short))
                 return BitMask.test(in int16(in src), pos);
            else if(typeof(T) == typeof(ushort))
                 return BitMask.test(in uint16(in src), pos);
            else if(typeof(T) == typeof(int))
                 return BitMask.test(in int32(in src), pos);
            else if(typeof(T) == typeof(uint))
                 return BitMask.test(in uint32(in src), pos);
            else if(typeof(T) == typeof(long))
                 return BitMask.test(in int64(in src), pos);
            else if(typeof(T) == typeof(ulong))
                 return BitMask.test(in uint64(in src), pos);
            else if(typeof(T) == typeof(float))
                 return BitMask.test(in float32(in src), pos);
            else if(typeof(T) == typeof(double))
                 return BitMask.test(in float64(in src), pos);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        public static bool test<T>(in T src, byte pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return BitMask.test(in int8(in src), pos);
            else if(typeof(T) == typeof(byte))
                 return BitMask.test(in uint8(in src), pos);
            else if(typeof(T) == typeof(short))
                 return BitMask.test(in int16(in src), pos);
            else if(typeof(T) == typeof(ushort))
                 return BitMask.test(in uint16(in src), pos);
            else if(typeof(T) == typeof(int))
                 return BitMask.test(in int32(in src), pos);
            else if(typeof(T) == typeof(uint))
                 return BitMask.test(in uint32(in src), pos);
            else if(typeof(T) == typeof(long))
                 return BitMask.test(in int64(in src), pos);
            else if(typeof(T) == typeof(ulong))
                 return BitMask.test(in uint64(in src), pos);
            else if(typeof(T) == typeof(float))
                 return BitMask.test(in float32(in src), pos);
            else if(typeof(T) == typeof(double))
                 return BitMask.test(in float64(in src), pos);
            else
                throw unsupported<T>();
        }

    }
}