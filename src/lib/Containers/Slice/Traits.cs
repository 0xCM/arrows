//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    partial class Traits
    {

        public interface Slice<T> : Seq<T> 
        {
            IReadOnlyList<T> data {get;}        

            intg<uint> length {get;}

            T this[int i] {get;}
        }

        /// <summary>
        /// Characterizes a fixed-lenth sequence of elements
        /// </summary>
        /// <typeparam name="N">The natural number type that indicates the slice length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public interface Slice<N,T> : Slice<T>
            where N : TypeNat, new()
        {
            

        }

        /// <summary>
        /// Characterizes a fixed-lenth sequence of elements
        /// </summary>
        /// <typeparam name="N">The natural number type that indicates the slice length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public interface Slice<S,N,T> : Slice<N,T>
            where S : Slice<S,N,T>, new()
            where N : TypeNat,new()
        {
            

        }

    }


}