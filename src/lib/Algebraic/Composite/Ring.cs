//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
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

        /// <summary>
        /// Characterizes a commutative, unital ring
        /// </summary>
        public interface CommutativeRing<T> : Ring<T>
        {
            
        }



        public interface DivisionRing<T> : Ring<T>, Divisive<T>, Reciprocative<T>
        {


        }


        public interface Field<T> : CommutativeRing<T>, DivisionRing<T>
        {

        }
    }

    partial class Structure
    {
        public interface Ring<S,T> : GroupA<S,T>, MonoidM<S,T>, Distributive<S,T>
            where S : Ring<S,T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a commutative, unital ring
        /// </summary>
        public interface CommutativeRing<S,T> : Ring<S,T>
            where S : CommutativeRing<S,T>, new()
        {
            
        }


        public interface DivisionRing<S,T> : Ring<S,T>, Divisive<S,T>, Reciprocative<S,T>
            where S : DivisionRing<S,T>, new()
        {


        }

    }
}
