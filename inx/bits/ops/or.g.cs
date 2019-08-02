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
    using static AsInX;

    partial class gbits
    {

        /// <summary>
        /// Computes the bitwise or of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.or(int8(lhs),int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.or(uint8(lhs),uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.or(int16(lhs),int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.or(uint16(lhs),uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.or(int32(lhs),int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.or(uint32(lhs),uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.or(int64(lhs),int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.or(uint64(lhs),uint64(rhs)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Computes the bitwise or of two primal operands and stores the
        /// result in the left operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T or<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.or(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.or(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.or(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.or(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.or(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.or(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.or(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.or(ref uint64(ref lhs), uint64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> or<T>(in ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs, in Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.or(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.or(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.or(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.or(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.or(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.or(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.or(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.or(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static Span<T> or<T>(in ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
                => or(lhs, rhs, span<T>(length(lhs,rhs)));

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> or<T>(in Span<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.or(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.or(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.or(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.or(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.or(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.or(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.or(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.or(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref readonly Span<T> or<T>(in Span<T> lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.or(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.or(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.or(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.or(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.or(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.or(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.or(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.or(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static Vec128<T> or<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.or(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.or(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.or(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.or(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.or(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.or(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.or(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.or(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.or(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.or(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> or<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.or(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.or(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.or(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.or(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.or(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.or(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.or(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.or(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.or(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.or(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void or<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                Bits.or(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                Bits.or(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                Bits.or(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                Bits.or(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.or(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.or(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.or(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.or(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                Bits.or(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.or(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }
        
        [MethodImpl(Inline)]
        public static void or<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                Bits.or(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                Bits.or(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                Bits.or(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                Bits.or(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.or(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.or(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.or(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.or(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                Bits.or(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                Bits.or(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }         
    }
}