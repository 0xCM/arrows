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

    partial class Operative
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


    }

    partial class Structures
    {
        
        public interface Ring<S> : GroupA<S>, MonoidM<S>, Distributive<S>
            where S : Ring<S>, new()
        {

        }
        
        public interface Ring<S,T> : Ring<S>, GroupA<S,T>, MonoidM<S,T>, Distributive<S,T>
            where S : Ring<S,T>, new()
        {
            
        }

        public interface CommutativeRing<S> : Ring<S>
            where S : CommutativeRing<S>, new()
        {

        }


        public interface DivisionRing<S> : Ring<S>, Divisive<S>, Reciprocative<S>
            where S : DivisionRing<S>, new()
        {

        }


    }
}
