namespace Z0
{
    using System;
    using System.Numerics;

    using Currency = Operative.Currency<decimal>;
    partial class Operative
    {

        /// <summary>
        /// Characterizes a bounded fractional operation provider
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public interface Currency<T> : BoundReal<T>, Fractional<T> 
        {

        }



    }

    partial class Structure
    {
        public interface Currency<S> : BoundReal<S>, Fractional<S>
        {

        }
        
        /// <summary>
        /// Characterizes operational reifications of Currency 
        /// </summary>
        /// <typeparam name="S">The structural reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Currency<S,T> : BoundReal<S,T>, Fractional<S,T>
            where S : Currency<S,T>, new()
        {
            
        }

    }

}