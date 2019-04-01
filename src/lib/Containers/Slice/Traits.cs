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



    }

    partial class Structure
    {
        public interface Slice<T> :  Formattable, Hashable, IEnumerable<T> 
        {
            intg<uint> length {get;}

            T this[int i] {get;}
        }



        /// <summary>
        /// Characterizes a structre S comprised of finite sequence of elements of type T
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="S">The type of the reifying structure</typeparam>
        public interface Slice<S,T> : Slice<T>, Reversible<S>, Equatable<S>
            where S : Slice<S,T>, new()
        {

        }


    }


}