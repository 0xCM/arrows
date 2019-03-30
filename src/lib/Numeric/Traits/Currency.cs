namespace Z0
{
    using System;
    using System.Numerics;

    using Currency = Traits.Currency<decimal>;
    partial class Traits
    {

        /// <summary>
        /// Characterizes a bounded fractional operation provider
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public interface Currency<T> : BoundReal<T>, Fractional<T> 
        {

        }


        /// <summary>
        /// Characterizes operational reifications of Currency 
        /// </summary>
        /// <typeparam name="R">The reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Currency<R,T> : Currency<T>, Operational<R,T>
            where R : Currency<R,T>, new()
        {
            
        }

    }

}