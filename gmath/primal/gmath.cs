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
    using static zfunc;

    using static As;

    partial class gmath
    {

        #region constants

        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : struct
                => convert(0, out T x);

        [MethodImpl(Inline)]
        public static T one<T>()
            where T : struct
                => convert(1, out T x);

        [MethodImpl(Inline)]
        public static T value<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return src;

            if(kind == PrimalKind.uint32)
                return src;

            if(kind == PrimalKind.int64)
                return src;

            if(kind == PrimalKind.uint64)
                return src;

            if(kind == PrimalKind.int16)
                return src;

            if(kind == PrimalKind.uint16)
                return src;

            if(kind == PrimalKind.int8)
                return src;

            if(kind == PrimalKind.uint8)
                return src;
            
            if(kind == PrimalKind.float32)
                return src;

            if(kind == PrimalKind.float64)
                return src;

            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return generic<T>(int.MinValue);

            if(kind == PrimalKind.uint32)
                return generic<T>(uint.MinValue);

            if(kind == PrimalKind.int64)
                return generic<T>(long.MinValue);

            if(kind == PrimalKind.uint64)
                return generic<T>(ulong.MinValue);

            if(kind == PrimalKind.int16)
                return generic<T>(short.MinValue);

            if(kind == PrimalKind.uint16)
                return generic<T>(ushort.MinValue);

            if(kind == PrimalKind.int8)
                return generic<T>(sbyte.MinValue);

            if(kind == PrimalKind.uint8)
                return generic<T>(byte.MinValue);
            
            if(kind == PrimalKind.float32)
                return generic<T>(float.MinValue);

            if(kind == PrimalKind.float64)
                return generic<T>(double.MinValue);

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return generic<T>(int.MaxValue);

            if(kind == PrimalKind.uint32)
                return generic<T>(uint.MaxValue);

            if(kind == PrimalKind.int64)
                return generic<T>(long.MaxValue);

            if(kind == PrimalKind.uint64)
                return generic<T>(ulong.MaxValue);

            if(kind == PrimalKind.int16)
                return generic<T>(short.MaxValue);

            if(kind == PrimalKind.uint16)
                return generic<T>(ushort.MaxValue);

            if(kind == PrimalKind.int8)
                return generic<T>(sbyte.MaxValue);

            if(kind == PrimalKind.uint8)
                return generic<T>(byte.MaxValue);
            
            if(kind == PrimalKind.float32)
                return generic<T>(float.MaxValue);

            if(kind == PrimalKind.float64)
                return generic<T>(double.MaxValue);

            throw unsupported(kind);
        }


        #endregion

        #region add

        [MethodImpl(Inline)]
        public static ref T add<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref addI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref addU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref addI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref addU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref addI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref addU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref addI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref addU64(ref lhs, rhs);
            
            if(kind == PrimalKind.float32)
                return ref addF32(ref lhs, rhs);
            
            if(kind == PrimalKind.float64)
                return ref addF64(ref lhs, rhs);
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : struct
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
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
                => fused.add(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, T[] dst)
            where T : struct
                => fused.add(lhs,rhs,dst);

        #endregion

        #region sub

        [MethodImpl(Inline)]
        public static ref T sub<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref subI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref subU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref subI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref subU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref subI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref subU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref subI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref subU64(ref lhs, rhs);
            
            if(kind == PrimalKind.float32)
                return ref subF32(ref lhs, rhs);
            
            if(kind == PrimalKind.float64)
                return ref subF64(ref lhs, rhs);
                                    
            throw unsupported(kind);
        }



        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return subI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return subU8(lhs,rhs);

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

            if(kind == PrimalKind.float32)
                return subF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return subF64(lhs,rhs);

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
                => fused.sub(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, T[] dst)
            where T : struct
                => fused.sub(lhs,rhs,dst);

        #endregion sub

        #region mul

        [MethodImpl(Inline)]
        public static ref T mul<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref mulI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref mulU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref mulI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref mulU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref mulI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref mulU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref mulI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref mulU64(ref lhs, rhs);
            
            if(kind == PrimalKind.float32)
                return ref mulF32(ref lhs, rhs);
            
            if(kind == PrimalKind.float64)
                return ref mulF64(ref lhs, rhs);
                                    
            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static T mul<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
                => fused.mul(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, T[] dst)
            where T : struct
                => fused.mul(lhs,rhs,dst);


        #endregion

        #region div

        [MethodImpl(Inline)]
        public static ref T div<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref divI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref divU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref divI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref divU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref divI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref divU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref divI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref divU64(ref lhs, rhs);
            
            if(kind == PrimalKind.float32)
                return ref divF32(ref lhs, rhs);
            
            if(kind == PrimalKind.float64)
                return ref divF64(ref lhs, rhs);
                                    
            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<T> div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
                => fused.div(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<T> div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, T[] dst)
            where T : struct
                => fused.div(lhs,rhs,dst);

        #endregion

        #region mod

        [MethodImpl(Inline)]
        public static ref T mod<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref modI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref modU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref modI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref modU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref modI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref modU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref modI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref modU64(ref lhs, rhs);
            
            if(kind == PrimalKind.float32)
                return ref modF32(ref lhs, rhs);
            
            if(kind == PrimalKind.float64)
                return ref modF64(ref lhs, rhs);
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
                => fused.mod(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, T[] dst)
            where T : struct
                => fused.mod(lhs,rhs,dst);
        
        #endregion

        #region and

        [MethodImpl(Inline)]
        public static ref T and<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref andI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref andU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref andI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref andU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref andI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref andU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref andI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref andU64(ref lhs, rhs);
            
                                    
            throw unsupported(kind);
        }


        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
                => fused.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, T[] dst)
            where T : struct
                => fused.and(lhs,rhs,dst);


        #endregion

        #region or

        [MethodImpl(Inline)]
        public static ref T or<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref orI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref orU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref orI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref orU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref orI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref orU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref orI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref orU64(ref lhs, rhs);
            
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
                => fused.or(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, T[] dst)
            where T : struct
                => fused.or(lhs,rhs,dst);

        #endregion

        #region xor

        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if (kind == PrimalKind.int8)
                return ref xorI8(ref lhs, rhs);
            
            if(kind == PrimalKind.uint8)
                return ref xorU8(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref xorI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref xorU16(ref lhs, rhs);

            if(kind == PrimalKind.int32)
                return ref xorI32(ref lhs, rhs);
            
            if(kind == PrimalKind.uint32)
                return ref xorU32(ref lhs, rhs);
            
            if(kind == PrimalKind.int64)
                return ref xorI64(ref lhs, rhs);
            
            if(kind == PrimalKind.uint64)
                return ref xorU64(ref lhs, rhs);
            
                                    
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T xor<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
                => fused.xor(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, T[] dst)
            where T : struct
                => fused.xor(lhs,rhs,dst);
        
        #endregion

        #region lshift / rshift

        [MethodImpl(Inline)]
        public static ref T lshift<T>(ref T lhs, int rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref lshiftI32(ref lhs, rhs);

            if(kind == PrimalKind.uint32)
                return ref lshiftU32(ref lhs, rhs);

            if(kind == PrimalKind.int64)
                return ref lshiftI64(ref lhs, rhs);

            if(kind == PrimalKind.uint64)
                return ref lshiftU64(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref lshiftI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref lshiftU16(ref lhs, rhs);

            if(kind == PrimalKind.int8)
                return ref lshiftI8(ref lhs, rhs);

            if(kind == PrimalKind.uint8)
                return ref lshiftU8(ref lhs, rhs);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T lshift<T>(T lhs, int rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return lshiftI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return lshiftU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return lshiftI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return lshiftU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return lshiftI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return lshiftU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return lshiftI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return lshiftU8(lhs,rhs);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref Span<T> lshift<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs, ref Span<T> dst)
            where T : struct
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = lshift(lhs[i],rhs[i]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref T rshift<T>(ref T lhs, int rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref rshiftI32(ref lhs, rhs);

            if(kind == PrimalKind.uint32)
                return ref rshiftU32(ref lhs, rhs);

            if(kind == PrimalKind.int64)
                return ref rshiftI64(ref lhs, rhs);

            if(kind == PrimalKind.uint64)
                return ref rshiftU64(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref rshiftI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref rshiftU16(ref lhs, rhs);

            if(kind == PrimalKind.int8)
                return ref rshiftI8(ref lhs, rhs);

            if(kind == PrimalKind.uint8)
                return ref rshiftU8(ref lhs, rhs);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T rshift<T>(T lhs, int rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return rshiftI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return rshiftU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return rshiftI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return rshiftU64(lhs,rhs);

            if(kind == PrimalKind.int16)
                return rshiftI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return rshiftU16(lhs,rhs);

            if(kind == PrimalKind.int8)
                return rshiftI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return rshiftU8(lhs,rhs);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static ref Span<T> rshift<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs, ref Span<T> dst)
            where T : struct
        {
            var len  = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = rshift(lhs[i],rhs[i]);
            return ref dst;
        }

        #endregion

        #region flip

        [MethodImpl(Inline)]
        public static ref T flip<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref flipI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref flipU32(ref src);

            if(kind == PrimalKind.int64)
                return ref flipI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref flipU64(ref src);

            if(kind == PrimalKind.int16)
                return ref flipI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref flipU16(ref src);

            if(kind == PrimalKind.int8)
                return ref flipI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref flipU8(ref src);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T flip<T>(T src)
            where T : struct
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

            throw unsupported(kind);
        }           


        [MethodImpl(Inline)]
        public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
                => fused.flip(src,dst);


        [MethodImpl(Inline)]
        public static Span<T> flip<T>(ReadOnlySpan<T> src, T[] dst)
            where T : struct
                => fused.flip(src,dst);

        #endregion

        #region abs

        [MethodImpl(Inline)]
        public static ref T abs<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref absI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref src;

            if(kind == PrimalKind.int64)
                return ref absI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref src;

            if(kind == PrimalKind.int16)
                return ref absI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref src;

            if(kind == PrimalKind.int8)
                return ref absI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref src;

            if(kind == PrimalKind.float32)
                return ref absF32(ref src);

            if(kind == PrimalKind.float64)
                return ref absF64(ref src);

            throw unsupported(kind);
        }           


        [MethodImpl(Inline)]
        public static T abs<T>(T src)
            where T : struct
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


            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
                => fused.abs(src,dst);

        [MethodImpl(Inline)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, T[] dst)
            where T : struct
                => fused.abs(src,dst);

        #endregion

        #region eq

        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return eqI8(lhs,rhs);

            if(kind == PrimalKind.uint8)
                return eqU8(lhs,rhs);

            if(kind == PrimalKind.int16)
                return eqI16(lhs,rhs);

            if(kind == PrimalKind.uint16)
                return eqU16(lhs,rhs);

            if(kind == PrimalKind.int32)
                return eqI32(lhs,rhs);

            if(kind == PrimalKind.uint32)
                return eqU32(lhs,rhs);

            if(kind == PrimalKind.int64)
                return eqI64(lhs,rhs);

            if(kind == PrimalKind.uint64)
                return eqU64(lhs,rhs);

            if(kind == PrimalKind.float32)
                return eqF32(lhs,rhs);

            if(kind == PrimalKind.float64)
                return eqF64(lhs,rhs);

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct, IEquatable<T>
        {
            var dst = span<bool>(length(lhs,rhs));
            return fused.eq(lhs,rhs,dst);
        }

        #endregion

        #region neq

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
                => fused.neq(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, bool[] dst)
            where T : struct, IEquatable<T>
                => fused.neq(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct, IEquatable<T>
        {
            var dst = span<bool>(length(lhs,rhs));
            return fused.neq(lhs,rhs,dst);
        }

        #endregion

        #region lt

        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
                => fused.lt(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, bool[] dst)
            where T : struct
                => fused.lt(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return fused.lt(lhs,rhs,dst);
        }

        #endregion

        #region lteq        

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
                => fused.lteq(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, bool[] dst)
            where T : struct
                => fused.lteq(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return fused.lteq(lhs,rhs,dst);
        }

        #endregion

        #region gt

        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
                => fused.gt(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, bool[] dst)
            where T : struct
                => fused.gt(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return fused.gt(lhs,rhs,dst);
        }

        #endregion

        #region gteq

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
                => fused.gteq(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, bool[] dst)
            where T : struct
                => fused.gteq(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return fused.gteq(lhs,rhs,dst);
        }

        #endregion

        #region pow

        [MethodImpl(Inline)]
        public static T pow<T>(T src, uint exp)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T pow<T>(T src, T exp)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return powF32(src,exp);

            if(kind == PrimalKind.float64)
                return powF64(src,exp);

            throw unsupported(kind);
        }

        #endregion

        #region negate

        [MethodImpl(Inline)]
        public static ref T negate<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return ref negateI8(ref src);

            if(kind == PrimalKind.int16)
                return ref negateI16(ref src);

            if(kind == PrimalKind.int32)
                return ref negateI32(ref src);

            if(kind == PrimalKind.int64)
                return ref negateI64(ref src);

            if(kind == PrimalKind.float32)
                return ref negateF32(ref src);

            if(kind == PrimalKind.float64)
                return ref negateF64(ref src);

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T negate<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return negateI8(ref src);

            if(kind == PrimalKind.int16)
                return negateI16(ref src);

            if(kind == PrimalKind.int32)
                return negateI32(ref src);

            if(kind == PrimalKind.int64)
                return negateI64(ref src);

            if(kind == PrimalKind.float32)
                return negateF32(ref src);

            if(kind == PrimalKind.float64)
                return negateF64(ref src);

            throw unsupported(kind);
        }           


        [MethodImpl(NotInline)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
                => fused.negate(src,dst);

        [MethodImpl(NotInline)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, T[] dst)
            where T : struct
                => fused.negate(src,dst);


        #endregion

        #region inc

        [MethodImpl(Inline)]
        public static ref T inc<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            
            if(kind == PrimalKind.int8)            
                return ref incI8(ref src);
            
            if(kind == PrimalKind.uint8)            
                return ref incU8(ref src);
            
            if(kind == PrimalKind.int16)            
                return ref incI16(ref src);
            
            if(kind == PrimalKind.uint16)
                return ref incU16(ref src);
            
            if(kind == PrimalKind.int32)
                return ref incI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref incU32(ref src);
            
            if(kind == PrimalKind.int64)
                return ref incI64(ref src);
            
            if(kind == PrimalKind.uint64)
                return ref incU64(ref src);
            
            if(kind == PrimalKind.float32)
                return ref incF32(ref src);
            
            if(kind == PrimalKind.float64)
                return ref incF64(ref src);
            
            throw unsupported(kind);

        }           


        [MethodImpl(Inline)]
        public static T inc<T>(T src)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(NotInline)]
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
                => fused.inc(src,dst);

        [MethodImpl(NotInline)]
        public static Span<T> inc<T>(ReadOnlySpan<T> src, T[] dst)
            where T : struct
                => fused.inc(src,dst);

        #endregion

        #region dec

        [MethodImpl(Inline)]
        public static ref T dec<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return ref decI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref decU8(ref src);

            if(kind == PrimalKind.int16)
                return ref decI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref decU16(ref src);

            if(kind == PrimalKind.int32)
                return ref decI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref decU32(ref src);

            if(kind == PrimalKind.int64)
                return ref decI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref decU64(ref src);

            if(kind == PrimalKind.float32)
                return ref decF32(ref src);

            if(kind == PrimalKind.float64)
                return ref decF64(ref src);

            throw unsupported(kind);
        }           



        [MethodImpl(Inline)]
        public static T dec<T>(T src)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(NotInline)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
                => fused.dec(src,dst);

        [MethodImpl(NotInline)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, T[] dst)
            where T : struct
                => fused.dec(src,dst);
        #endregion
        
        #region min/max

        [MethodImpl(Inline)]
        public static T min<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T min<T>(params T[] src)
            where T : struct
                => fused.min<T>(src);

        [MethodImpl(Inline)]
        public static T min<T>(ReadOnlySpan<T> src)
            where T : struct
                => fused.min(src);

        [MethodImpl(Inline)]
        public static T max<T>(T lhs, T rhs)
            where T : struct
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

            throw unsupported(kind);
        }           

        [MethodImpl(Inline)]
        public static T max<T>(params T[] src)
            where T : struct
                => fused.max<T>(src);

        [MethodImpl(Inline)]
        public static T max<T>(ReadOnlySpan<T> src)
            where T : struct
                => fused.max(src);

        #endregion
 
        #region parse

        [MethodImpl(Inline)]
        public static T parse<T>(string src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return atoms.parseI8<T>(src);

            if(kind == PrimalKind.uint8)
                return atoms.parseU8<T>(src);

            if(kind == PrimalKind.int16)
                return atoms.parseI16<T>(src);

            if(kind == PrimalKind.uint16)
                return atoms.parseU16<T>(src);
            
            if(kind == PrimalKind.int32)
                return atoms.parseI32<T>(src);

            if(kind == PrimalKind.uint32)
                return atoms.parseU32<T>(src);

            if(kind == PrimalKind.int64)
                return atoms.parseI64<T>(src);

            if(kind == PrimalKind.uint64)
                return atoms.parseU64<T>(src);

            if(kind == PrimalKind.float32)
                return atoms.parseF32<T>(src);

            if(kind == PrimalKind.float64)
                return atoms.parseF64<T>(src);

            throw unsupported(kind);
        }
        
        #endregion        

        #region sqrt

        [MethodImpl(Inline)]
        public static ref T sqrt<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref sqrtI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref src;

            if(kind == PrimalKind.int64)
                return ref sqrtI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref src;

            if(kind == PrimalKind.int16)
                return ref sqrtI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref src;

            if(kind == PrimalKind.int8)
                return ref sqrtI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref src;

            if(kind == PrimalKind.float32)
                return ref sqrtF32(ref src);

            if(kind == PrimalKind.float64)
                return ref sqrtF64(ref src);

            throw unsupported(kind);
        }           


        [MethodImpl(Inline)]
        public static T sqrt<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return sqrtI8(src);

            if(kind == PrimalKind.uint8)
                return src;

            if(kind == PrimalKind.int16)
                return sqrtI16(src);

            if(kind == PrimalKind.uint16)
                return src;

            if(kind == PrimalKind.int32)
                return sqrtI32(src);

            if(kind == PrimalKind.uint32)
                return src;

            if(kind == PrimalKind.int64)
                return sqrtI64(src);

            if(kind == PrimalKind.uint64)
                return src;

            if(kind == PrimalKind.float32)
                return sqrtF32(src);

            if(kind == PrimalKind.float64)
                return sqrtF64(src);

            throw unsupported(kind);
        }           


        #endregion

        #region square

        [MethodImpl(Inline)]
        public static ref T square<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref squareI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref src;

            if(kind == PrimalKind.int64)
                return ref squareI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref src;

            if(kind == PrimalKind.int16)
                return ref squareI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref src;

            if(kind == PrimalKind.int8)
                return ref squareI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref src;

            if(kind == PrimalKind.float32)
                return ref squareF32(ref src);

            if(kind == PrimalKind.float64)
                return ref squareF64(ref src);

            throw unsupported(kind);
        }           


        [MethodImpl(Inline)]
        public static T square<T>(T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return squareI8(src);

            if(kind == PrimalKind.uint8)
                return src;

            if(kind == PrimalKind.int16)
                return squareI16(src);

            if(kind == PrimalKind.uint16)
                return src;

            if(kind == PrimalKind.int32)
                return squareI32(src);

            if(kind == PrimalKind.uint32)
                return src;

            if(kind == PrimalKind.int64)
                return squareI64(src);

            if(kind == PrimalKind.uint64)
                return src;

            if(kind == PrimalKind.float32)
                return squareF32(src);

            if(kind == PrimalKind.float64)
                return squareF64(src);

            throw unsupported(kind);
        }           


        #endregion

    }
}