//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;


    partial class Traits
    {   
        public interface Interval<T>
            where T : Ordered<T>
        {
            

            T left {get;}

            bool leftclosed {get;}
            
            T right {get;}

            bool rightclosed {get;}

        }

        public interface LeftOpenInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }

        public interface RightOpenInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }


        public interface LeftClosedInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }

        public interface RightClosedInterval<T> : Interval<T>
            where T : Ordered<T>
        {

        }

        public interface OpenInterval<T> : LeftOpenInterval<T>, RightOpenInterval<T>
            where T : Ordered<T>

        {

        }

        public interface ClosedInterval<T> : LeftClosedInterval<T>, RightClosedInterval<T>
            where T : Ordered<T>
        {

        }

    }



}