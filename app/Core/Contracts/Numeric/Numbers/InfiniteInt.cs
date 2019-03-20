//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;

    partial class Class
    {
        public interface InfiniteInt<T> : Integer<T>, Infinite<T>
        {

        }

        public interface InfiniteInt<H,T> : TypeClass<H>, Integer<T> 
            where H : InfiniteInt<H,T>, new()
        {

        }


    }

    partial class Struct
    {
        /// <summary>
        /// Characterizes a structure over a bound integral type
        /// </summary>
            public interface InfiniteInt<S,T> : Integer<S,T>, Infinite<S,T>
                where S : InfiniteInt<S,T>, new()
                where T : new()
            {

            }


    }







}