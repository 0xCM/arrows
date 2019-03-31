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

        public interface Slice<T> :  Traits.Formattable, IEnumerable<T> 
        {
            intg<uint> length {get;}

            T this[int i] {get;}
        }

        /// <summary>
        /// Characterizes a structure comprized of a fixed-lenth sequence of elements
        /// </summary>
        /// <typeparam name="N">The natural number type that indicates the slice length</typeparam>
        /// <typeparam name="S">The element type</typeparam>
        public interface NSlice<N,T> : Slice<T>
            where N : TypeNat, new()
        {
            

        }


    }

    partial class Structure
    {


        /// <summary>
        /// Characterizes a structre S comprised of finite sequence of elements of type T
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="S">The type of the reifying structure</typeparam>
        public interface Slice<S,T> : Traits.Slice<T>, Reversible<S>, Equatable<S>, IEquatable<S>
            where S : Slice<S,T>, new()
        {

        }

        /// <summary>
        /// Characterizes a structre S comprised of finite sequence of elements T of natural length N
        /// </summary>
        /// <typeparam name="N">The natural number type that indicates the slice length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="S">The type of the reifying structure</typeparam>
        public interface NSlice<N,S,T> : Slice<S,T>, Traits.NSlice<N,T>
            where S : NSlice<N,S,T>, new()
            where N : TypeNat,new()
        {
            

        }

    }


}