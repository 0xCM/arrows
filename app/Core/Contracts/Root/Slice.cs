//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;

    partial class Class
    {

        public interface Slice<T>
        {
            IReadOnlyList<T> cells {get;}        

            int length {get;}
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
        
    }

}