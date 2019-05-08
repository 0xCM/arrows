//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    
    using static atoms;
    using static mfunc;

    public static partial class gmath
    {

        #region constants

        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : struct, IEquatable<T>
            => default(T);

        [MethodImpl(Inline)]
        public static T one<T>()
            where T : struct, IEquatable<T>
        {
                var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return As.generic<T>(1);

            if(kind == PrimalKind.uint32)
                return As.generic<T>(1u);

            if(kind == PrimalKind.int64)
                return As.generic<T>(1L);

            if(kind == PrimalKind.uint64)
                return As.generic<T>(1UL);

            if(kind == PrimalKind.int16)
                return As.generic<T>((short)1);

            if(kind == PrimalKind.uint16)
                return As.generic<T>((ushort)1);

            if(kind == PrimalKind.int8)
                return As.generic<T>((sbyte)1);

            if(kind == PrimalKind.uint8)
                return As.generic<T>((byte)1);
            
                if(kind == PrimalKind.float32)
                return As.generic<T>(1f);

            if(kind == PrimalKind.float64)
                return As.generic<T>(1d);

            throw errors.unsupported(kind);
        }

        #endregion

        #region add

        [MethodImpl(Inline)]
        public static T addSwitch<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return addI8(lhs,rhs);
                case PrimalKind.uint8:
                    return addU8(lhs,rhs);
                case PrimalKind.int16:
                    return addI16(lhs,rhs);
                case PrimalKind.uint16:
                    return addU16(lhs,rhs);
                case PrimalKind.int32:
                    return addI32(lhs,rhs);
                case PrimalKind.uint32:
                    return addU32(lhs,rhs);
                case PrimalKind.int64:
                    return addI64(lhs,rhs);
                case PrimalKind.uint64:
                    return addU64(lhs,rhs);
                case PrimalKind.float32:
                    return addF32(lhs,rhs);
                case PrimalKind.float64:
                    return addF64(lhs,rhs);                
                default:
                    throw errors.unsupported(kind);
            }

        }

        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            
            if (kind == PrimalKind.int8)
                return addI8(lhs,rhs);
            
            if(kind == PrimalKind.uint8)
                return addU8(lhs,rhs);

            if(kind == PrimalKind.int16)
                return addI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return addU16(lhs,rhs);

            if(kind == PrimalKind.int32)
                return addI32(lhs,rhs);
            
            if(kind == PrimalKind.uint32)
                return addU32(lhs,rhs);
            
            if(kind == PrimalKind.int64)
                return addI64(lhs,rhs);
            
            if(kind == PrimalKind.uint64)
                return addU64(lhs,rhs);
            
            if(kind == PrimalKind.float32)
                return addF32(lhs,rhs);
            
            if(kind == PrimalKind.float64)
                return addF64(lhs,rhs);
                                    
            throw errors.unsupported(kind);

        }


        [MethodImpl(Inline)]
        public static ref T[] add<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = add(lhs[i],rhs[i]);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static void add<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
                => add(lhs,rhs, ref dst);

        #endregion

        #region sub

        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return subI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return subU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return subI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return subU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return subI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return subU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return subI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return subU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return subF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return subF64(lhs,rhs);

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref T[] sub<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = sub(lhs[i],rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void sub<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
            => sub(lhs,rhs, ref dst);

        #endregion sub

        #region mul

        [MethodImpl(Inline)]
        public static T mul<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return mulI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return mulU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return mulI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return mulU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return mulI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return mulU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return mulI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return mulU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return mulF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return mulF64(lhs,rhs);

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref T[] mul<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mul(lhs[i],rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void mul<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
            => mul(lhs,rhs, ref dst);

        #endregion

        #region div

        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();


            if(kind == PrimalKind.int32)
                return divI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return divU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return divI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return divU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return divI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return divU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return divI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return divU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return divF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return divF64(lhs,rhs);

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref T[] div<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = div(lhs[i],rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void div<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>        
            => div(lhs,rhs, ref dst);

        #endregion

        #region mod

        [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return modI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return modU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return modI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return modU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return modI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return modU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return modI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return modU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return modF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return modF64(lhs,rhs);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref T[] mod<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = mod(lhs[i],rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void mod<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
                => mod(lhs,rhs, ref dst);

        
        #endregion

        #region and

        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return andI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return andU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return andI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return andU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return andI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return andU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return andI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return andU8(lhs,rhs);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref T[] and<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = and(lhs[i],rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void and<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
            => and(lhs,rhs, ref dst);


        #endregion

        #region or

        [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return orI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return orU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return orI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return orU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return orI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return orU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return orI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return orU8(lhs,rhs);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref T[] or<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = or(lhs[i],rhs[i]);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static void or<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
            => or(lhs,rhs, ref dst);

        #endregion

        #region xor

        [MethodImpl(Inline)]
        public static T xor<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return xorI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return xorU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return xorI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return xorU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return xorI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return xorU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return xorI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return xorU8(lhs,rhs);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref T[] xor<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = xor(lhs[i],rhs[i]);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static void xor<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct, IEquatable<T>
            => xor(lhs,rhs, ref dst);

        #endregion

        #region flip

        [MethodImpl(Inline)]
        public static T flip<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return flipI32(src);

            if(kind == PrimalKind.uint32)
                return flipU32(src);

            if(kind == PrimalKind.int64)
                return flipI64(src);

            if(kind == PrimalKind.uint64)
                return flipU64(src);

            if(kind == PrimalKind.int16)
                return flipI16(src);

            if(kind == PrimalKind.uint16)
                return flipU16(src);

            if(kind == PrimalKind.int8)
                return flipI8(src);

            if(kind == PrimalKind.uint8)
                return flipU8(src);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref T[] flip<T>(T[] src, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = flip(src[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> flip<T>(ReadOnlySpan<T> src, ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = flip(src[i]);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static void flip<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
                => flip(src, ref dst);

        #endregion

        #region abs

        [MethodImpl(Inline)]
        public static T abs<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return absI32(src);

            if(kind == PrimalKind.uint32)
                return src;

            if(kind == PrimalKind.int64)
                return absI64(src);

            if(kind == PrimalKind.uint64)
                return src;

            if(kind == PrimalKind.int16)
                return absI16(src);

            if(kind == PrimalKind.uint16)
                return src;

            if(kind == PrimalKind.int8)
                return absI8(src);

            if(kind == PrimalKind.uint8)
                return src;

            if(kind == PrimalKind.float32)
                return absF32(src);

            if(kind == PrimalKind.float64)
                return absF64(src);


            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref T[] abs<T>(T[] src, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = abs(src[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> abs<T>(ReadOnlySpan<T> src, ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = abs(src[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void abs<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
            => abs(src, ref dst);

        #endregion

        #region eq

        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return eqI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return eqU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return eqI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return eqU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return eqI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return eqU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return eqI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return eqU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return eqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return eqF64(lhs,rhs);

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref bool[] eq<T>(T[] lhs, T[] rhs, ref bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i],rhs[i]);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static void eq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
            => eq(lhs,rhs, ref dst);

        #endregion

        #region neq

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return neqI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return neqU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return neqI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return neqU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return neqI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return neqU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return neqI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return neqU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return neqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return neqF64(lhs,rhs);

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref bool[] neq<T>(T[] lhs, T[] rhs, ref bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i],rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void neq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
            => neq(lhs,rhs, ref dst);

        #endregion

        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ltI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return ltU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return ltI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return ltU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return ltI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return ltU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return ltI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return ltU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return ltF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return ltF64(lhs,rhs);

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref bool[] lt<T>(T[] lhs, T[] rhs, ref bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i],rhs[i]);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static void lt<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
            => lt(lhs,rhs, ref dst);

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return lteqI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return lteqU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return lteqI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return lteqU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return lteqI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return lteqU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return lteqI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return lteqU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return lteqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return lteqF64(lhs,rhs);

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref bool[] lteq<T>(T[] lhs, T[] rhs, ref bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i],rhs[i]);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static void lteq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
            => lteq(lhs,rhs, ref dst);

        #region gt

        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return gtI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return gtU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return gtI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return gtU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return gtI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return gtU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return gtI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return gtU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return gtF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return gtF64(lhs,rhs);

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref bool[] gt<T>(T[] lhs, T[] rhs, ref bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i],rhs[i]);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static void gt<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
            => gt(lhs,rhs, ref dst);

        #endregion
        
        #region gteq

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return gteqI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return gteqU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return gteqI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return gteqU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return gteqI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return gteqU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return gteqI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return gteqU8(lhs,rhs);

            if(kind == PrimalKind.float32)
                return gteqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return gteqF64(lhs,rhs);

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref bool[] gteq<T>(T[] lhs, T[] rhs, ref bool[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs,  ref Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i],rhs[i]);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static void gteq<T>(T[] lhs, T[] rhs, bool[] dst)
            where T : struct, IEquatable<T>
            => gteq(lhs,rhs, ref dst);

        #endregion

        [MethodImpl(Inline)]
        public static T pow<T>(T src, uint exp)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

           if(kind == PrimalKind.int32)
                return powI32(src,exp);

            if(kind == PrimalKind.uint32)
                return powU32(src,exp);

            if(kind == PrimalKind.int64)
                return powI64(src,exp);

            if(kind == PrimalKind.uint64)
                return powU64(src,exp);

            if(kind == PrimalKind.int16)
                return powI16(src,exp);

            if(kind == PrimalKind.uint16)
                return powU16(src,exp);

            if(kind == PrimalKind.int8)
                return powI8(src,exp);

            if(kind == PrimalKind.uint8)
                return powU8(src,exp);

            if(kind == PrimalKind.float32)
                return powF32(src,exp);

            if(kind == PrimalKind.float64)
                return powF64(src,exp);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T pow<T>(T src, T exp)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return powF32(src,exp);

            if(kind == PrimalKind.float64)
                return powF64(src,exp);

            throw errors.unsupported(kind);
        }

        #region negate

        [MethodImpl(Inline)]
        public static T negate<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return negateI8(src);

            if(kind == PrimalKind.int16)
                return negateI16(src);

            if(kind == PrimalKind.int32)
                return negateI32(src);

            if(kind == PrimalKind.int64)
                return negateI64(src);

            if(kind == PrimalKind.float32)
                return negateF32(src);

            if(kind == PrimalKind.float64)
                return negateF64(src);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref T[] negate<T>(T[] src, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = negate(src[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> negate<T>(ReadOnlySpan<T> src, ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = negate(src[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void negate<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
            => negate(src, ref dst);


        #endregion


        #region inc

        [MethodImpl(Inline)]
        public static T inc<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return incI32(src);

            if(kind == PrimalKind.uint32)
                return incU32(src);

            if(kind == PrimalKind.int64)
                return incI64(src);

            if(kind == PrimalKind.uint64)
                return incU64(src);

            if(kind == PrimalKind.int16)
                return incI16(src);

            if(kind == PrimalKind.uint16)
                return incU16(src);

            if(kind == PrimalKind.int8)
                return incI8(src);

            if(kind == PrimalKind.uint8)
                return incU8(src);

            if(kind == PrimalKind.float32)
                return incF32(src);

            if(kind == PrimalKind.float64)
                return incF64(src);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref T[] inc<T>(T[] src, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = inc(src[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> inc<T>(ReadOnlySpan<T> src, ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = inc(src[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void inc<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
            => inc(src, ref dst);

        #endregion

        #region dec

        [MethodImpl(Inline)]
        public static T dec<T>(T src)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return decI32(src);

            if(kind == PrimalKind.uint32)
                return decU32(src);

            if(kind == PrimalKind.int64)
                return decI64(src);

            if(kind == PrimalKind.uint64)
                return decU64(src);

            if(kind == PrimalKind.int16)
                return decI16(src);

            if(kind == PrimalKind.uint16)
                return decU16(src);

            if(kind == PrimalKind.int8)
                return decI8(src);

            if(kind == PrimalKind.uint8)
                return decU8(src);

            if(kind == PrimalKind.float32)
                return decF32(src);

            if(kind == PrimalKind.float64)
                return decF64(src);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref T[] dec<T>(T[] src, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = dec(src[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> dec<T>(ReadOnlySpan<T> src, ref Span<T> dst)
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = dec(src[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void dec<T>(T[] src, T[] dst)
            where T : struct, IEquatable<T>
            => dec(src, ref dst);

        #endregion
        
        [MethodImpl(Inline)]
        public static T min<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return minI32(lhs, rhs);

            if(kind == PrimalKind.uint32)
                return minU32(lhs, rhs);

            if(kind == PrimalKind.int64)
                return minI64(lhs, rhs);

            if(kind == PrimalKind.uint64)
                return minU64(lhs, rhs);

            if(kind == PrimalKind.int16)
                return minI16(lhs, rhs);

            if(kind == PrimalKind.uint16)
                return minU16(lhs, rhs);

            if(kind == PrimalKind.int8)
                return minI8(lhs, rhs);

            if(kind == PrimalKind.uint8)
                return minU8(lhs, rhs);

            if(kind == PrimalKind.float32)
                return minF32(lhs, rhs);

            if(kind == PrimalKind.float64)
                return minF64(lhs, rhs);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T min<T>(params T[] src)
            where T : struct, IEquatable<T>
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }
            return result;
        }

        [MethodImpl(Inline)]
        public static T max<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return maxI32(lhs, rhs);

            if(kind == PrimalKind.uint32)
                return maxU32(lhs, rhs);

            if(kind == PrimalKind.int64)
                return maxI64(lhs, rhs);

            if(kind == PrimalKind.uint64)
                return maxU64(lhs, rhs);

            if(kind == PrimalKind.int16)
                return maxI16(lhs, rhs);

            if(kind == PrimalKind.uint16)
                return maxU16(lhs, rhs);

            if(kind == PrimalKind.int8)
                return maxI8(lhs, rhs);

            if(kind == PrimalKind.uint8)
                return maxU8(lhs, rhs);

            if(kind == PrimalKind.float32)
                return maxF32(lhs, rhs);

            if(kind == PrimalKind.float64)
                return maxF64(lhs, rhs);

            throw errors.unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T max<T>(params T[] src)
            where T : struct, IEquatable<T>
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }
            return result;
        }

        [MethodImpl(Inline)]
        public static T max<T>(ReadOnlySpan<T> src)
            where T : struct, IEquatable<T>
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }
            return result;
        }

    }
}