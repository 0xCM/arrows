//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    

    partial class gbits
    {
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(lhs) & int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) & uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) & int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) & uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs) & int32(rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs) & uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs) & int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs) & uint64(rhs));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.and(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.and(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref T and<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 math.and(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                 math.and(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                 math.and(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                 math.and(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                 math.and(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                 math.and(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                 math.and(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                 math.and(ref uint64(ref lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                 math.and(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 math.and(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        /// <summary>
        /// Computes the bitwise and between two input vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> and<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.and(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.and(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.and(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.and(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.and(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.and(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.and(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.and(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.and(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.and(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the bitwise and between two input vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> and<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.and(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.and(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.and(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.and(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.and(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.and(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.and(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.and(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.and(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.and(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the bitwise and between two input vectors and stores the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static void and<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                Bits.and(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                Bits.and(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                Bits.and(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                Bits.and(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.and(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.and(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.and(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.and(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                Bits.and(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.and(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }
        
        /// <summary>
        /// Computes the bitwise and btween two input vectors and stores the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static void and<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                Bits.and(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                Bits.and(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                Bits.and(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                Bits.and(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.and(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.and(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.and(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.and(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                Bits.and(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.and(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> and<T>(ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs, in Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitRef.and(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                BitRef.and(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                BitRef.and(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                BitRef.and(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                BitRef.and(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                BitRef.and(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                BitRef.and(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                BitRef.and(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                BitRef.and(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                BitRef.and(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return ref dst;
        }


        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> and<T>(in Span<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitRef.and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                BitRef.and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                BitRef.and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                BitRef.and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                BitRef.and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                BitRef.and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                BitRef.and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                BitRef.and(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                BitRef.and(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                BitRef.and(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Memory<T> and<T>(in Memory<T> lhs, in ReadOnlyMemory<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitRef.and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                BitRef.and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                BitRef.and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                BitRef.and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                BitRef.and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                BitRef.and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                BitRef.and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                BitRef.and(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                BitRef.and(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                BitRef.and(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }
            
        [MethodImpl(Inline)]
        public static Span128<T> and<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).And(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).And(uint8(rhs), uint8(dst));
            else if (typeof(T) == typeof(short))
                int16(lhs).And(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).And(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).And(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).And(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).And(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).And(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).And(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).And(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;        
        }

        [MethodImpl(Inline)]
        public static Span256<T> and<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).And(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).And(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).And(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).And(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).And(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).And(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).And(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).And(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).And(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).And(float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;        
        } 

   }

    
}