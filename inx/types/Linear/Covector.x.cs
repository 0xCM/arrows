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

    public static class LinearX
    {
        [MethodImpl(Inline)]
        public static ref Covector<N,T> Add<N,T>(this ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.add(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> Add<N,T>(this ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            gmath.add(ref x, rhs);
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref Covector<N,T> Sub<N,T>(this ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.sub(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> Mul<N,T>(this ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.mul(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> Div<N,T>(this ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.div(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> Mod<N,T>(this ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.mod(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> And<N,T>(this ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gbits.and(in x, y);
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref Covector<N,T> And<N,T>(this ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gbits.and(in x, in rhs);
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref Covector<N,T> Or<N,T>(this ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gbits.or(in x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> Or<N,T>(this ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gbits.or(in x, in rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> XOr<N,T>(this ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gbits.xor(in x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> XOr<N,T>(this ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gbits.xor(in x, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Covector<N,T> ShiftL<N,T>(this ref Covector<N,T> lhs, in int rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            gbits.shiftl(ref x, rhs);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Covector<N,T> ShiftR<N,T>(this ref Covector<N,T> lhs, in int rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            gbits.shiftr(ref x, rhs);
            return lhs;
        }

       [MethodImpl(Inline)]
        public static ref Covector<N,T> Pow<N,T>(this ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.pow(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> Pow<N,T>(this ref Covector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gmath.pow(ref x, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> Flip<N,T>(this ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gbits.flip(in x);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref Covector<N,T> Negate<N,T>(this ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = src.Unsize();
            gmath.negate(ref x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> Inc<N,T>(this ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.inc(ref x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> Dec<N,T>(this ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.dec(ref x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> Sqrt<N,T>(this ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.sqrt(ref x);
            return ref src;
        }

       [MethodImpl(Inline)]
        public static ref Covector<N,T> Abs<N,T>(this ref Covector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.abs(in x);
            return ref src;
        }

       [MethodImpl(Inline)]
        public static Covector<N,bool> Eq<N,T>(this in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.eq<T>(x, y).ToNatSpan<N,bool>();            
        }

       [MethodImpl(Inline)]
        public static Covector<N,bool> NEq<N,T>(this in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.neq<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Covector<N,bool> Gt<N,T>(this in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.gt<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Covector<N,bool> GtEq<N,T>(this in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.gteq<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Covector<N,bool> Lt<N,T>(this in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.lt<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Covector<N,bool> LtEq<N,T>(this in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.lteq<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static T Dot<N,T>(in Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
                => gmath.dot<T>(lhs.Unsize(),rhs.Unsize());

        [MethodImpl(Inline)]
        public static string Format<N,T>(in Covector<N,T> src)
            where T : struct    
            where N: ITypeNat, new()
                => src.Unsize().Format();
    
        public static bool All<N,T>(this Covector<N,T> src, T match)
            where N : ITypeNat, new()
            where T : struct    
        {
            for(var i=0; i< Covector<N,T>.Length; i++)            
                if(gmath.neq(src[i],match))
                    return false;
            return true;
        }
 

    }



}