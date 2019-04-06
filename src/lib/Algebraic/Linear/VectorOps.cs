//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    public static class Vector
    {

        /// <summary>
        /// Defines a vector of natural length from a parameter array
        /// </summary>
        /// <param name="dim">The vector dimension</param>
        /// <param name="src">The component source</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(N len, params T[] src) 
            where N : TypeNat, new() 
                => new Vector<N,T>(src);

        /// <summary>
        /// Defines a vector of natural length from a sequence
        /// </summary>
        /// <param name="dim">The vector dimension</param>
        /// <param name="src">The component source</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(N len, IEnumerable<T> src) 
            where N : TypeNat, new() 
                => new Vector<N,T>(src);


        /// <summary>
        /// Defines a vector of natural length from a llist
        /// </summary>
        /// <param name="dim">The vector dimension</param>
        /// <param name="src">The component source</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(N len, IReadOnlyList<T> src) 
            where N : TypeNat, new() 
                => new Vector<N,T>(src);

        /// <summary>
        /// Defines a vector of natural length from a parameter array
        /// </summary>
        /// <param name="src">The component source</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(params T[] src) 
            where N : TypeNat, new() 
                => new Vector<N,T>(src);

        /// <summary>
        /// Constructs a vector from the componentwise-sum of two others
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="lhs">The second vector</param>
        /// <typeparam name="N">The common vector length</typeparam>
        /// <typeparam name="T">The common component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> add<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
            where N : TypeNat, new() 
            where T : Structures.Semiring<T>, new()
                => new Vector<N,T>(fuse(lhs,rhs, (x,y) => x.add(y)));

        /// <summary>
        /// Constructs a vector from the componentwise-product of two others
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="lhs">The second vector</param>
        /// <typeparam name="N">The common vector length</typeparam>
        /// <typeparam name="T">The common component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> mul<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
            where N : TypeNat, new() 
            where T : Structures.Semiring<T>, new()
                =>  new Vector<N,T>(fuse(lhs,rhs, (x,y) => x.add(y)));

        /// <summary>
        /// Sums the components of a vector to yield a scalar
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static T sum<N,T>(Vector<N,T> src) 
            where N : TypeNat, new() 
            where T : Structures.Semiring<T>, new()
                => Slice.sum(src.cells);

    }

}