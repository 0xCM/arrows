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

        public interface Slice<T> : Seq<T>, IEnumerable<T>,Traits.Formattable
        {
            IReadOnlyList<T> data {get;}        

            intg<uint> length {get;}

            T this[int i] {get;}
        }

        public interface Slice<S,T> : Slice<T>, IEquatable<S>, Equatable<S>, Traits.Reversible<S,T>
            where S : Slice<S,T>
        {

        }

        /// <summary>
        /// Characterizes a fixed-lenth sequence of elements
        /// </summary>
        /// <typeparam name="N">The natural number type that indicates the slice length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public interface NSlice<N,T> : Slice<T>
            where N : TypeNat, new()
        {
            

        }

        /// <summary>
        /// Characterizes a fixed-lenth sequence of elements
        /// </summary>
        /// <typeparam name="N">The natural number type that indicates the slice length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public interface NSlice<S,N,T> : NSlice<N,T>
            where S : NSlice<S,N,T>, new()
            where N : TypeNat,new()
        {
            

        }

    }


}