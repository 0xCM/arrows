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

    public static partial class Linear
    {



        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<T> add<T>(ref Vector<T> lhs, in Vector<T> rhs)            
            where T : struct
        {
            gmath.add(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> add<N,T>(ref Vector<N,T> lhs, Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.add(lhs.Unsized, rhs.Unsized);
            return lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> add<N,T>(ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.add(lhs.Unsized, rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> add<N,T>(ref Vector<N,T> x, in Vector<N,T> y)
            where N : ITypeNat, new()
            where T : struct    
        {
            ginx.add<T>(x,y,x);
            return ref x;
        }

        /// <summary>
        /// Add the first vector to the second and populates the third with the result
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The vector length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> add<N,T>(in Vector<N,T> x, in Vector<N,T> y, ref Vector<N,T> z)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.add(x.Unsized, y.Unsized, z.Unsized);
            return ref z;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] - rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<T> sub<T>(ref Vector<T> lhs, in Vector<T> rhs)
            where T : struct
        {
            gmath.sub(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] - rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> sub<N,T>(ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.sub(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] * rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<T> mul<T>(ref Vector<T> lhs, in Vector<T> rhs)
            where T : struct
        {
            gmath.mul(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] * rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> mul<N,T>(ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.mul(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] / rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<T> div<T>(ref Vector<T> lhs, in Vector<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                gfp.div(lhs.Unblocked, rhs.Unblocked);
            else
                gmath.idiv(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] / rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> div<N,T>(ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                gfp.div(lhs.Unsized, rhs.Unsized);
            else
                gmath.idiv(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] % rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<T> mod<T>(ref Vector<T> lhs, in Vector<T> rhs)
            where T : struct
        {
            gmath.mod(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] % rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> mod<N,T>(ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsized;
            var y = rhs.Unsized;
            gmath.mod(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] & rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> and<N,T>(ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.and(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> and<N,T>(ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.and(lhs.Unsized, in rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] | rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> or<N,T>(ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gbits.or(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] | rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> or<N,T>(ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gbits.or(lhs.Unsized, in rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] ^ rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> xor<N,T>(ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gbits.xor(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] ^ rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> xor<N,T>(ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gbits.xor(lhs.Unsized, rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := pow(lhs[i],rhs)  for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> pow<N,T>(ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.pow(lhs.Unsized, rhs);
            return ref lhs;
        }

        /// <summary>
        /// Peforms a bitwise complement on each component in-place: io[i] := ~io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The source/target operand will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> flip<N,T>(ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            gbits.flip(src.Unsized);
            return ref src;
        }

        /// <summary>
        /// Negates the value of each source vector component in-place
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<T> negate<T>(ref Vector<T> src)
            where T : struct
        {
            gmath.negate(src.Unblocked);
            return ref src;
        }

        /// <summary>
        /// Negates the value of each source vector component in-place
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> negate<N,T>(ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = src.Unsized;
            gmath.negate(src.Unsized);
            return ref src;
        }

        /// <summary>
        /// Increments each source vector component in-place: io[i] := ++io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="src">The source/target operand which will be updated in-place</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<T> inc<T>(ref Vector<T> src)
            where T : struct
        {
            gmath.inc(src.Unblocked);
            return ref src;
        }


        /// <summary>
        /// Increments each source vector component in-place: io[i] := ++io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="src">The source/target operand which will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> inc<N,T>(ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.inc(src.Unsized);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> dec<T>(ref Vector<T> src)
            where T : struct
        {
            gmath.dec(src.Unblocked);
            return ref src;
        }

        /// <summary>
        /// Decrements each source vector component in-place: io[i] := --io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="src">The source/target operand which will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> dec<N,T>(ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            gmath.dec(src.Unsized);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(Vector<T> lhs, in Vector<T> rhs)
            where T : struct
                => gmath.eq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(in Vector<T> lhs, in Vector<T> rhs)
            where T : struct
            => gmath.gt<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(in Vector<T> lhs, in Vector<T> rhs)
            where T : struct
            => gmath.gteq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> lt<T>(in Vector<T> lhs, in Vector<T> rhs)
            where T : struct
                => gmath.lt<T>(lhs.Unblocked, rhs.Unblocked);            

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(in Vector<T> lhs, in Vector<T> rhs)
            where T : struct
                => gmath.lteq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<N,bool> eq<N,T>(in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            return gmath.eq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> neq<N,T>(in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct           
                => gmath.neq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();                   

        [MethodImpl(Inline)]
        public static Span<N,bool> gt<N,T>(in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct            
                => gmath.gt<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            
        

        [MethodImpl(Inline)]
        public static Span<N,bool> gteq<N,T>(in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            return gmath.gteq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> Lt<N,T>(in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            return gmath.lt<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Span<N,bool> lteq<N,T>(in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            return gmath.lteq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            
        }

        /// <summary>
        /// Commputes the canonical scalar product btween two vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static T dot<N,T>(in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
                => gmath.dot<T>(lhs.Unsized,rhs.Unsized);

        /// <summary>
        /// Returns true of each component of the source vector equals a specified value; otherwise, returns false
        /// </summary>
        /// <param name="src">The source vector to interrogate</param>
        /// <param name="match">The target value to match</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        public static bool all<N,T>(in Vector<N,T> src, T match)
            where N : ITypeNat, new()
            where T : struct    
        {
            for(var i=0; i< Vector<N,T>.Length; i++)            
                if(gmath.neq(src[i],match))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public static Vector<N,T> redim<M,N,T>(in Vector<M,T> src, N newdim = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => Vector<N, T>.LoadAligned(src.Unsized);

        [MethodImpl(Inline)]        
        static Span<T> Slice<N,T>(this Span<T> src, N start = default)
            where N : ITypeNat, new()
                => src.Slice((int)start.value);

        [MethodImpl(Inline)]
        public static Vector<P,T> concat<M,N,P,T>(in Vector<M,T> head, Vector<N,T> tail, P sum = default)
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




        [MethodImpl(Inline)]
        public static T dot<T>(in Vector<T> lhs, in Vector<T> rhs)
            where T : struct
             => gmath.dot<T>(lhs.Unblocked, rhs.Unblocked);

    }
}