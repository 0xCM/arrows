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
        /// <summary>
        /// Allocates a new vector from the result of adding a specified scalar value 
        /// to each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="scalar">The scalar value</param>
        /// <typeparam name="N">The vector dimension type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> add<N,T>(BlockVector<N,T> src, T scalar)
            where N : ITypeNat, new()            
            where T : unmanaged   
        { 
            var dst = src.Replicate(true);
            add(src, scalar, ref dst);
            return dst;            
        }

        /// <summary>
        /// Adds a specified scalar value to each source vector component and writes the result to
        /// a caller-supplied target vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="scalar">The scalar value</param>
        /// <param name="dst">The arget vector</param>
        /// <typeparam name="N">The vector dimension type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> add<N,T>(BlockVector<N,T> src, T scalar, ref BlockVector<N,T> dst)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
             src.Data.CopyTo(dst.Data);
             gmath.add(dst.Unsized, scalar);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> add<N,T>(BlockVector<N,T> x, BlockVector<N,T> y, ref BlockVector<N,T> dst)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            ginx.add(x.Data, y.Data, dst.Data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> add<N,T>(BlockVector<N,T> x, BlockVector<N,T> y)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = x.Replicate(true);
            return add(x, y, ref dst);
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<T> add<T>(ref BlockVector<T> lhs, in BlockVector<T> rhs)            
            where T : unmanaged
        {
            gmath.add(lhs.Unblocked, rhs.Unblocked);
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
        public static ref BlockVector<N,T> add<N,T>(ref BlockVector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
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
        public static ref BlockVector<N,T> add<N,T>(ref BlockVector<N,T> x, in BlockVector<N,T> y)
            where N : ITypeNat, new()
            where T : unmanaged    
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
        public static ref BlockVector<N,T> add<N,T>(in BlockVector<N,T> x, in BlockVector<N,T> y, ref BlockVector<N,T> z)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            gmath.add(x.Unsized, y.Unsized, z.Unsized);
            return ref z;
        }

    }

}