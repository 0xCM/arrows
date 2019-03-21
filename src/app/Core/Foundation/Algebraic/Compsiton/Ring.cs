//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    public enum Ordering
    {
        LT = -1,
        EQ = 0,
        GT = 1
    }

    partial class Traits
    {

        /// <summary>
        /// Characterizes a (unital) ring
        /// </summary>
        public interface Ring<T> : GroupA<T>, MonoidM<T>, Distributive<T> 
        {
            
        }

        public interface Ring<H,T> : TypeClass<H>, Ring<T>
            where H : Ring<H,T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a commutative, unital ring
        /// </summary>
        public interface CommutativeRing<T> : Ring<T>
        {
            
        }


        public interface DivisionRing<T> : Ring<T>, Divisive<T>, Reciprocative<T>
        {


        }

        public interface DivisionRing<H,T> : TypeClass<H>, DivisionRing<T>
            where H : DivisionRing<H,T>, new()
        {


        }

    }
}
