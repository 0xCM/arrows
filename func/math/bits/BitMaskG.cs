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

    /// <summary>
    /// Defines generic bitmask functions that parameterize those defined in <see cref='BitMask'/>
    /// </summary>
    public static class BitMaskG
    {
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

        /// <summary>
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
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
        /// Disables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
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
        /// Sets an identified bit to a supplied value
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T set<T>(ref T src, byte pos, in Bit value)            
            where T : struct
        {
            if(value)
                enable(ref src, pos);
            else
                disable(ref src, pos);
            return ref src;
        }

        /// <summary>
        /// Enables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref T setif<T>(in T src, int srcpos, ref T dst, int dstpos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitMask.setif(in int8(in src), srcpos, ref int8(ref dst), dstpos);
            else if(typeof(T) == typeof(byte))
                BitMask.setif(in uint8(in src), srcpos, ref uint8(ref dst), dstpos);
            else if(typeof(T) == typeof(short))
                BitMask.setif(in int16(in src), srcpos, ref int16(ref dst), dstpos);
            else if(typeof(T) == typeof(ushort))
                BitMask.setif(in uint16(in src), srcpos, ref uint16(ref dst), dstpos);
            else if(typeof(T) == typeof(int))
                BitMask.setif(in int32(in src), srcpos, ref int32(ref dst), dstpos);
            else if(typeof(T) == typeof(uint))
                BitMask.setif(in uint32(in src), srcpos, ref uint32(ref dst), dstpos);
            else if(typeof(T) == typeof(long))
                BitMask.setif(in int64(in src), srcpos, ref int64(ref dst), dstpos);
            else if(typeof(T) == typeof(ulong))
                BitMask.setif(in uint64(in src), srcpos, ref uint64(ref dst), dstpos);
            else if(typeof(T) == typeof(float))
                BitMask.setif(in float32(in src), srcpos, ref float32(ref dst), dstpos);
            else if(typeof(T) == typeof(double))
                BitMask.setif(in float64(in src), srcpos, ref float64(ref dst), dstpos);
            else
                throw unsupported<T>();
                
            return ref dst;                            
        }

        /// <summary>
        /// Inverts a bit at a specified position in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref T toggle<T>(ref T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitMask.toggle(ref int8(ref src), pos);
            else if(typeof(T) == typeof(byte))
                BitMask.toggle(ref uint8(ref src), pos);
            else if(typeof(T) == typeof(short))
                BitMask.toggle(ref int16(ref src), pos);
            else if(typeof(T) == typeof(ushort))
                BitMask.toggle(ref uint16(ref src), pos);
            else if(typeof(T) == typeof(int))
                BitMask.toggle(ref int32(ref src), pos);
            else if(typeof(T) == typeof(uint))
                BitMask.toggle(ref uint32(ref src), pos);
            else if(typeof(T) == typeof(long))
                BitMask.toggle(ref int64(ref src), pos);
            else if(typeof(T) == typeof(ulong))
                BitMask.toggle(ref uint64(ref src), pos);
            else if(typeof(T) == typeof(float))
                BitMask.toggle(ref float32(ref src), pos);
            else if(typeof(T) == typeof(double))
                BitMask.toggle(ref float64(ref src), pos);
            else
                throw unsupported<T>();

            return ref src;                            
        }

        /// <summary>
        /// Inverts a bit at a specified position in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref T toggle<T>(ref T src, byte pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitMask.toggle(ref int8(ref src), pos);
            else if(typeof(T) == typeof(byte))
                BitMask.toggle(ref uint8(ref src), pos);
            else if(typeof(T) == typeof(short))
                BitMask.toggle(ref int16(ref src), pos);
            else if(typeof(T) == typeof(ushort))
                BitMask.toggle(ref uint16(ref src), pos);
            else if(typeof(T) == typeof(int))
                BitMask.toggle(ref int32(ref src), pos);
            else if(typeof(T) == typeof(uint))
                BitMask.toggle(ref uint32(ref src), pos);
            else if(typeof(T) == typeof(long))
                BitMask.toggle(ref int64(ref src), pos);
            else if(typeof(T) == typeof(ulong))
                BitMask.toggle(ref uint64(ref src), pos);
            else if(typeof(T) == typeof(float))
                BitMask.toggle(ref float32(ref src), pos);
            else if(typeof(T) == typeof(double))
                BitMask.toggle(ref float64(ref src), pos);
            else
                throw unsupported<T>();

            return ref src;                            
        }


        /// <summary>
        /// Inverts a bit at a specified position in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T toggle<T>(T src, int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(BitMask.toggle(int8(src), pos));
            else if(typeof(T) == typeof(byte))
                return generic<T>(BitMask.toggle(uint8(src), pos));
            else if(typeof(T) == typeof(short))
                return generic<T>(BitMask.toggle(int16(src), pos));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(BitMask.toggle(uint16(src), pos));
            else if(typeof(T) == typeof(int))
                return generic<T>(BitMask.toggle(int32(src), pos));
            else if(typeof(T) == typeof(uint))
                return generic<T>(BitMask.toggle(uint32(src), pos));
            else if(typeof(T) == typeof(long))
                return generic<T>(BitMask.toggle(int64(src), pos));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(BitMask.toggle(uint64(src), pos));
            else if(typeof(T) == typeof(float))
                return generic<T>(BitMask.toggle(float32(src), pos));
            else if(typeof(T) == typeof(double))
                return generic<T>(BitMask.toggle(float64(src), pos));
            else
                throw unsupported<T>();
        }
    }
}