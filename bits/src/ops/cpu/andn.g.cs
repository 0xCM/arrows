//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    using static AsIn;
    
    partial class gbits
    {

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
         [MethodImpl(Inline)]
        public static Vec128<T> andn<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.andn(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.andn(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.andn(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.andn(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.andn(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.andn(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.andn(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.andn(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.andn(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.andn(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> andn<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.andn(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.andn(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.andn(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.andn(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.andn(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.andn(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.andn(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.andn(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.andn(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.andn(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }
    
        public static Span128<T> andn<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(andn(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst.Block(i));                             
            return dst;        
        }

        public static Span256<T> andn<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(andn(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst.Block(i));                             
            return dst;        
        } 

    }

}