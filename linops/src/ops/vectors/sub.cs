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
        /// Computes z[i] := x[i] - y[i] for i = 0...N-1
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> sub<N,T>(BlockVector<N,T> x, BlockVector<N,T> y, ref BlockVector<N,T> z)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            ginx.sub(x.Data,y.Data,z.Data);
            return ref z;
        }

        /// <summary>
        /// Computes the result x[i] - y[i] for i = 0...N
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> sub<N,T>(BlockVector<N,T> x, BlockVector<N,T> y)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = x.Replicate(true);
            sub(x,y, ref dst);
            return dst;
        }

        /// <summary>
        /// Computes z[i] := x[i] - y[i] for i = 0...n-1 where n is the (presumed) common length of the operands 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<T> sub<T>(BlockVector<T> x, BlockVector<T> y, ref BlockVector<T> z)
            where T : struct
        {
            gmath.sub(x.Unblocked, y.Unblocked, z.Unblocked);
            return ref z;
        }

        /// <summary>
        /// Computes the result x[i] - y[i] for i = 0...n-1 where n is the (presumed) common length of the operands 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<T> sub<T>(BlockVector<T> x, BlockVector<T> y)
            where T : struct
        {                
            var z = x.Replicate(true);
            return sub(x,y,ref z);
        }
    }
}