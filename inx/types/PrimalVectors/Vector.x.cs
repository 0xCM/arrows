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

    public static class VectorX
    {
        /// <summary>
        /// Performs componentwise addition that updates the left operand in-place:
        /// lhs[i] := lhs[i] + rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Add<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.add(ref x, y);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] + rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Add<N,T>(this ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            gmath.add(ref x, rhs);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] - rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Sub<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.sub(ref x, y);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] * rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Mul<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.mul(ref x, y);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] / rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Div<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.div(ref x, y);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] % rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Mod<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.mod(ref x, y);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] & rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> And<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gbits.and(in x, y);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] + rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> And<N,T>(this ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gbits.and(in x, in rhs);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] | rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Or<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gbits.or(in x, y);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] | rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Or<N,T>(this ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gbits.or(in x, in rhs);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] ^ rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> XOr<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gbits.xor(in x, y);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := lhs[i] ^ rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> XOr<N,T>(this ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gbits.xor(in x, rhs);
            return ref lhs;
        }

        /// <summary>
        /// Effects lhs[i] := pow(lhs[i],rhs)  for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Pow<N,T>(this ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gmath.pow(ref x, rhs);
            return ref lhs;
        }

        /// <summary>
        /// Peforms a bitwise complement on each component in-place: io[i] := ~io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The source/target operand will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Flip<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gbits.flip(in x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Negate<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = src.Unsize();
            gmath.negate(ref x);
            return ref src;
        }

        /// <summary>
        /// Increments each source vector component in-place: io[i] := ++io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="io">The source/target operand which will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Inc<N,T>(this ref Vector<N,T> io)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = io.Unsize();
            gmath.inc(ref x);
            return ref io;
        }

        /// <summary>
        /// Decrements each source vector component in-place: io[i] := --io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="io">The source/target operand which will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Dec<N,T>(this ref Vector<N,T> io)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = io.Unsize();
            gmath.dec(ref x);
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Sqrt<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.sqrt(ref x);
            return ref src;
        }

       [MethodImpl(Inline)]
        public static ref Vector<N,T> Abs<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.abs(in x);
            return ref src;
        }


       [MethodImpl(Inline)]
        public static Span<N,bool> Eq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.eq<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> NEq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.neq<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> Gt<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.gt<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> GtEq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.gteq<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> Lt<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.lt<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> LtEq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.lteq<T>(x, y).ToNatSpan<N,bool>();            
        }

        /// <summary>
        /// Commputes the canonical scalar product btween two vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static T Dot<N,T>(in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
                => gmath.dot<T>(lhs.Unsize(),rhs.Unsize());

        /// <summary>
        /// Renders the source vector as text
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static string Format<N,T>(in Vector<N,T> src)
            where T : struct    
            where N: ITypeNat, new()
                => src.Unsize().Format();

        /// <summary>
        /// Returns true of each component of the source vector equals a specified value; otherwise, returns false
        /// </summary>
        /// <param name="src">The source vector to interrogate</param>
        /// <param name="match">The target value to match</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        public static bool All<N,T>(this Vector<N,T> src, T match)
            where N : ITypeNat, new()
            where T : struct    
        {
            for(var i=0; i< Vector<N,T>.NatLength; i++)            
                if(gmath.neq(src[i],match))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public static Vector<N,T> ReDim<M,N,T>(this Vector<M,T> src, N newdim = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => Vector<N, T>.Define(src.Unsize());

        [MethodImpl(Inline)]
        public static Vector<P,T> Concat<M,N,P,T>(this Vector<M,T> head, Vector<N,T> tail, P sum = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : INatSum<M,N>, new()
            where T : struct
                => Vector.Concat(head, tail, sum);
    }
}