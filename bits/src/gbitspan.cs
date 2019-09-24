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

    public static class gbitspan
    {
        public static Span<T> and<T>(Span<T> lhs, in T rhs)
            where T : struct
        {
            for(var i=0; i<lhs.Length; i++)
                gbits.and(in lhs[i],in rhs, ref lhs[i]);
            return lhs;
        }

        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                gbits.and(in lhs[i], in rhs[i], ref dst[i]);
            return dst;
        }

        public static Span<T> and<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                gbits.and(in lhs[i], in rhs[i], ref lhs[i]);
            return lhs;
        }

        public static Span128<T> and<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(gbits.vand(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst.Block(i));                             
            return dst;        
        }

        public static Span256<T> and<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(gbits.vand<T>(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst.Block(i));                             
            return dst;        
        } 
        public static Span128<T> andn<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(gbits.andn(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst.Block(i));                             
            return dst;        
        }

        public static Span256<T> andn<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(gbits.andn(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i<lhs.Length; i++)
                gbits.or(in lhs[i], in rhs[i], ref dst[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> or<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            for(var i=0; i<lhs.Length; i++)
                gbits.or(in lhs[i], in rhs[i], ref lhs[i]);
            return lhs;
        }

        public static Span<T> or<T>(Span<T> lhs, in T rhs)
            where T : struct
        {
            for(var i=0; i<lhs.Length; i++)
                gbits.or(in lhs[i], in rhs, ref lhs[i]);
            return lhs;
        }

        public static Span<T> or<T>(ReadOnlySpan<T> lhs, in T rhs, Span<T> dst)
            where T : struct
        {
            lhs.CopyTo(dst);
            return or(dst,rhs);
        }

        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< length(lhs,rhs); i++)
                dst[i] = gmath.xor(lhs[i], rhs[i]);
           return dst;        }

        public static Span128<T> or<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(gbits.or(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst.Block(i));                             
            return dst;        
        }

        public static Span256<T> or<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(gbits.or(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span256<T> sll<T>(ReadOnlySpan256<T> lhs, byte offset, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< lhs.BlockCount; i++)
                vstore(gbits.sll(lhs.LoadVec256(i), offset), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span256<T> srl<T>(ReadOnlySpan256<T> lhs, byte offset, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< lhs.BlockCount; i++)
                vstore(gbits.srl(lhs.LoadVec256(i), offset), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span128<T> xor<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(gbits.vxor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst.Block(i));                             
            return dst;        
        }

        public static Span256<T> xor<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(gbits.vxor<T>(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span<T> xor<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            for(var i=0; i< length(lhs,rhs); i++)
                gmath.xor(ref lhs[i], rhs[i]);
           return lhs;
        }

        public static Span<T> xor<T>(Span<T> lhs, T rhs)
            where T : struct
        {
            for(var i=0; i< lhs.Length; i++)
                gmath.xor(ref lhs[i],rhs);
            return lhs;
        }

        public static Span<T> flip<T>(Span<T> src)
            where T : unmanaged
        {
            for(var i=0; i< src.Length; i++)
                gmath.flip(ref src[i]);
            return src;
        }

        public static Span<T> flip<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => flip(src.Replicate());

        public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< src.Length; i++)
                gmath.flip(in src[i], ref dst[i]);
            return dst;
            
        }

        public static Span<T> rotr<T>(ReadOnlySpan<T> src, T offset)        
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(bitspan.rotr(uint8(src), uint8(in offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(bitspan.rotr(uint16(src), uint16(in offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(bitspan.rotr(uint32(src), uint32(in offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(bitspan.rotr(uint64(src), uint64(in offset)));
            else            
                throw unsupported<T>();

        }

        public static Span<T> rotr<T>(ReadOnlySpan<T> src, T offset, Span<T> dst)        
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                bitspan.rotr(uint8(src), uint8(in offset), uint8(dst));
            else if(typeof(T) == typeof(ushort))
                bitspan.rotr(uint16(src), uint16(in offset), uint16(dst));
            else if(typeof(T) == typeof(uint))
                bitspan.rotr(uint32(src), uint32(in offset), uint32(dst));
            else if(typeof(T) == typeof(ulong))
                bitspan.rotr(uint64(src), uint64(in offset), uint64(dst));
            else            
                throw unsupported<T>();
            return dst;

        }

        public static Span<T> rotl<T>(ReadOnlySpan<T> src, T offset, Span<T> dst)        
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                bitspan.rotl(uint8(src), uint8(in offset), uint8(dst));
            else if(typeof(T) == typeof(ushort))
                bitspan.rotl(uint16(src), uint16(in offset), uint16(dst));
            else if(typeof(T) == typeof(uint))
                bitspan.rotl(uint32(src), uint32(in offset), uint32(dst));
            else if(typeof(T) == typeof(ulong))
                bitspan.rotl(uint64(src), uint64(in offset), uint64(dst));
            else            
                throw unsupported<T>();
            return dst;

        }

        public static Span<T> rotl<T>(ReadOnlySpan<T> src, T offset)        
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(bitspan.rotl(uint8(src), uint8(in offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(bitspan.rotl(uint16(src), uint16(in offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(bitspan.rotl(uint32(src), uint32(in offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(bitspan.rotl(uint64(src), uint64(in offset)));
            else            
                throw unsupported<T>();

        }


    }
}