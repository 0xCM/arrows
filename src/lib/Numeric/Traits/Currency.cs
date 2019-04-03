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

    partial class Structures
    {
        /// <summary>
        /// Characterizes structural reifications of Currency 
        /// </summary>
        /// <typeparam name="S">The structural reification type</typeparam>
        public interface Currency<S> : BoundReal<S>, Fractional<S>
            where S : Currency<S>, new()
        {

        }

    }

}