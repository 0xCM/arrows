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
        public static ref Covector<N,T> add<N,T>(ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.add(lhs.Unsized, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> sub<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.sub(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Covector<N,T> add<N,T>(Covector<N,T> lhs, Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct  
        {  
                
            var t = lhs.Transpose();
            return Linear.add(ref t, rhs.Transpose()).Transpose();            
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> add<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.add(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> mul<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.mul(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> div<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                gfp.div(lhs.Unsized, rhs.Unsized);
            else
                gmath.idiv(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> mod<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.mod(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> and<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.and(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> and<N,T>(ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {            
            gmath.and(lhs.Unsized, in rhs);
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref Covector<N,T> or<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gbits.or(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> or<N,T>(ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gbits.or(lhs.Unsized, in rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> xor<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gbits.xor(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> xor<N,T>(ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gbits.xor(lhs.Unsized, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Covector<N,T> shiftl<N,T>(ref Covector<N,T> lhs, in int rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            BitRef.ShiftL(lhs.Unsized, rhs);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Covector<N,T> shiftr<N,T>(ref Covector<N,T> lhs, in int rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            BitRef.ShiftR(lhs.Unsized, rhs);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> pow<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.pow(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> pow<N,T>(ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.pow(lhs.Unsized, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> flip<N,T>(ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            gbits.flip(src.Unsized);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref Covector<N,T> negate<N,T>(ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.negate(src.Unsized);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> inc<N,T>(ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.inc(src.Unsized);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> dec<N,T>(ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.dec(src.Unsized);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static Covector<N,bool> eq<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct            
                => gmath.eq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            

        [MethodImpl(Inline)]
        public static Covector<N,bool> neq<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct            
                => gmath.neq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();                    

        [MethodImpl(Inline)]
        public static Covector<N,bool> gt<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct            
                => gmath.gt<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();                    

        [MethodImpl(Inline)]
        public static Covector<N,bool> gteq<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
                => gmath.gteq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            

        [MethodImpl(Inline)]
        public static Covector<N,bool> lt<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
                => gmath.lt<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            

        [MethodImpl(Inline)]
        public static Covector<N,bool> lteq<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct            
                => gmath.lteq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();                    

        [MethodImpl(Inline)]
        public static T dot<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
                => gmath.dot<T>(lhs.Unsized,rhs.Unsized);
    
        public static bool all<N,T>(in Covector<N,T> src, in T match)
            where N : ITypeNat, new()
            where T : struct    
        {
            for(var i=0; i< Covector<N,T>.Length; i++)            
                if(gmath.neq(in src[i],in match))
                    return false;
            return true;
        }
    }
}