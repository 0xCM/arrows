//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    partial class Linear
    {
        [MethodImpl(Inline)]
        public static BlockVector<N,T> add<N,T>(BlockVector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
             return BlockVector.Load<N,T>(gmath.add(lhs.Unsized, rhs));
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> sub<N,T>(BlockVector<N,T> lhs, BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = lhs.Replicate(true);
            ginx.sub(lhs.Data,rhs.Data,dst.Data);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> add<N,T>(BlockVector<N,T> lhs, BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = lhs.Replicate(true);
            ginx.add(lhs.Data,rhs.Data,dst.Data);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> and<N,T>(BlockVector<N,T> lhs, BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = lhs.Replicate(true);
            gbits.and(lhs.Data,rhs.Data,dst.Data);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> or<N,T>(BlockVector<N,T> lhs, BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = lhs.Replicate(true);
            gbits.or(lhs.Data,rhs.Data,dst.Data);
            return dst;
        }


        [MethodImpl(Inline)]
        public static BlockVector<N,T> xor<N,T>(BlockVector<N,T> lhs, BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = lhs.Replicate(true);
            gbits.xor(lhs.Data,rhs.Data,dst.Data);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> sll<N,T>(BlockVector<N,T> src, byte offset)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = src.Replicate(true);
            gbits.sll(src.Data,offset,dst.Data);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> srl<N,T>(BlockVector<N,T> src, byte offset)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = src.Replicate(true);
            gbits.srl(src.Data,offset,dst.Data);
            return dst;
        }


        [MethodImpl(Inline)]
        public static ref Covector<N,T> mul<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            gmath.mul(lhs.Span, rhs.Span);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> div<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    

        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                gfp.div(lhs.Span, rhs.Span);
            else
                gmath.idiv(lhs.Span, rhs.Span);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> mod<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    

        {
            gmath.mod(lhs.Span, rhs.Span);
            return ref lhs;
        }



        [MethodImpl(Inline)]
        public static ref Covector<N,T> pow<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    

        {
            gmath.pow(lhs.Span, rhs.Span);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> pow<N,T>(ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : unmanaged    

        {
            gmath.pow(lhs.Span, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> flip<N,T>(ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : unmanaged    

        {
            gbits.flip(src.Span);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref Covector<N,T> negate<N,T>(ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            gmath.negate(src.Span);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> inc<N,T>(ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            gmath.inc(src.Span);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> dec<N,T>(ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : unmanaged    

        {
            gmath.dec(src.Span);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> eq<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged            
                => gmath.eq<T>(lhs.Span, rhs.Span).ToNatural<N,bool>();            

        [MethodImpl(Inline)]
        public static Span<N,bool> neq<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged            
                => gmath.neq<T>(lhs.Span, rhs.Span).ToNatural<N,bool>();                    

        [MethodImpl(Inline)]
        public static Span<N,bool> gt<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged            
                => gmath.gt<T>(lhs.Span, rhs.Span).ToNatural<N,bool>();                    

        [MethodImpl(Inline)]
        public static Span<N,bool> gteq<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
                => gmath.gteq<T>(lhs.Span, rhs.Span).ToNatural<N,bool>();            

        [MethodImpl(Inline)]
        public static Span<N,bool> lt<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
                => gmath.lt<T>(lhs.Span, rhs.Span).ToNatural<N,bool>();            

        [MethodImpl(Inline)]
        public static Span<N,bool> lteq<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged            
                => gmath.lteq<T>(lhs.Span, rhs.Span).ToNatural<N,bool>();                    

        [MethodImpl(Inline)]
        public static T dot<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
                => gmath.dot<T>(lhs.Span,rhs.Span);
    
        public static bool all<N,T>(in Covector<N,T> src, in T match)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            for(var i=0; i< Covector<N,T>.Length; i++)            
                if(gmath.neq(in src[i],in match))
                    return false;
            return true;
        }
    }
}