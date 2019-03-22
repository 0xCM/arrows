//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;

    partial class Traits
    {

        public interface Slice<T>
        {
            IReadOnlyList<T> cells {get;}        

            uint length {get;}

            T this[int i] {get;}
        }

        /// <summary>
        /// Characterizes a fixed-lenth sequence of elements
        /// </summary>
        /// <typeparam name="N">The natural number type that indicates the slice length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public interface Slice<N,T> : Slice<T>
            where N : TypeNat
        {
            

        }

        /// <summary>
        /// Characterizes a fixed-lenth sequence of elements
        /// </summary>
        /// <typeparam name="N">The natural number type that indicates the slice length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public interface Slice<H,N,T> : Slice<N,T>
            where N : TypeNat
            where H : Slice<H,N,T>, new()
        {
            

        }

    }


}