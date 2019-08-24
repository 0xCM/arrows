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
        public static Vector<N,T> Add<N,T>(this Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsized;
            var y = rhs.Unsized;
            gmath.add(ref x, y);
            return lhs;
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
            var x = lhs.Unsized;
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
        public static Vector<N,T> Sub<N,T>(this Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsized;
            var y = rhs.Unsized;
            gmath.sub(x, y);
            return lhs;
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
            var x = lhs.Unsized;
            var y = rhs.Unsized;
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
            var x = lhs.Unsized;
            var y = rhs.Unsized;
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
            var x = lhs.Unsized;
            var y = rhs.Unsized;
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
            var x = lhs.Unsized;
            var y = rhs.Unsized;
            BitRef.and(x, y);
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
            var x = lhs.Unsized;
            BitRef.and(x, in rhs);
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
            var x = lhs.Unsized;
            var y = rhs.Unsized;
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
            var x = lhs.Unsized;
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
            var x = lhs.Unsized;
            var y = rhs.Unsized;
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
            var x = lhs.Unsized;
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
            var x = lhs.Unsized;
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
            var x = src.Unsized;
            gbits.flip(in x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Negate<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = src.Unsized;
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
            var x = io.Unsized;
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
            var x = io.Unsized;
            gmath.dec(ref x);
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Sqrt<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsized;
            gmath.sqrt(ref x);
            return ref src;
        }

       [MethodImpl(Inline)]
        public static ref Vector<N,T> Abs<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsized;
            gmath.abs(in x);
            return ref src;
        }


       [MethodImpl(Inline)]
        public static Span<N,bool> Eq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsized;
            var y = rhs.Unsized;
            return gmath.eq<T>(x, y).ToNatural<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> NEq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsized;
            var y = rhs.Unsized;
            return gmath.neq<T>(x, y).ToNatural<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> Gt<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsized;
            var y = rhs.Unsized;
            return gmath.gt<T>(x, y).ToNatural<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> GtEq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsized;
            var y = rhs.Unsized;
            return gmath.gteq<T>(x, y).ToNatural<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> Lt<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsized;
            var y = rhs.Unsized;
            return gmath.lt<T>(x, y).ToNatural<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> LtEq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsized;
            var y = rhs.Unsized;
            return gmath.lteq<T>(x, y).ToNatural<N,bool>();            
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
                => gmath.dot<T>(lhs.Unsized,rhs.Unsized);

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
                => src.Unsized.FormatList();

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
            for(var i=0; i< Vector<N,T>.Length; i++)            
                if(gmath.neq(src[i],match))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public static Vector<N,T> ReDim<M,N,T>(this Vector<M,T> src, N newdim = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => Vector<N, T>.LoadAligned(src.Unsized);

        [MethodImpl(Inline)]        
        static Span<T> Slice<N,T>(this Span<T> src, N start = default)
            where N : ITypeNat, new()
                => src.Slice((int)start.value);

        [MethodImpl(Inline)]
        public static Vector<P,T> Concat<M,N,P,T>(this Vector<M,T> head, Vector<N,T> tail, P sum = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : INatSum<M,N>, new()
            where T : struct
        {
            var dst = span<T>(new NatSum<M,N>());
            head.Unsized.CopyTo(dst);
            tail.Unsized.CopyTo(dst.Slice(new M()));
            return Vector<P,T>.LoadAligned(dst);
        }


    }
}