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

    partial class xcore
    {
        /// <summary>
        /// Constructs a vector whose length descends from the type natural under extension
        /// </summary>
        /// <param name="n">The natural number representative</param>
        /// <param name="components">The source components</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> NatVec<N,T>(this Z0.TypeNat<N> n, IEnumerable<T> components)
            where N : ITypeNat, new()
            where T :struct, IEquatable<T>
                => new Vector<N, T>(components);

        /// <summary>
        /// Counts the number of components that are false
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static int CountFalse<N>(this Vector<N,bool> src)
            where N : ITypeNat, new()    
                => src.cells(x => x == false).Count();

        /// <summary>
        /// Counts the number of components that are true
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The vector length</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static int CountTrue<N>(this Vector<N,bool> src)
            where N : ITypeNat, new()    
                => src.cells(x => x == true).Count();

    }

}
