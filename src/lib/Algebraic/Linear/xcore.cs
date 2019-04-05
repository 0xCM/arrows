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
            where N : TypeNat, new()
            where T : Equatable<T>, new()                                
                => new Vector<N, T>(components);
 
    }

}
