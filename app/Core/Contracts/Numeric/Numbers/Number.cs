//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    public interface Number<T> : Operational<T>,
        Equatable<T>,
        Additive<T>, 
        Nullary<T>, 
        Multiplicative<T>,
        Unital<T>,
        Subtractive<T>,
        Divisive<T>,
        Powered<T,int> 
    where T : new()
    {                    
        T muladd(T x, T y, T z);

        /// <summary>
        /// Calculates the number's absolute value
        /// </summary>
        /// <returns></returns>
        T abs(T x);

        /// <summary>
        /// Calculates the number's sign
        /// </summary>
        Sign sign(T x);

        /// <summary>
        /// Formats the source value a sequence of base-2 digits
        /// </summary>
        string bitstring(T x);

    }


    /// <summary>
    /// Characterizes a structral number
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The structure subect</typeparam>
    public interface Number<S,T> : Structural<S,T>, 
          Equatable<S,T>,
          Additive<S,T>,
          Nullary<S,T>,
          Multiplicative<S,T>,
          Unital<S,T>,
          Subtractive<S,T>,
          Divisive<S,T>
        where S : Number<S,T>, new()
        where T : new()
    {
        /// <summary>
        /// Calculates the number's magnitude
        /// </summary>
        /// <returns></returns>
        S abs();

        /// <summary>
        /// Calculates the number's sign
        /// </summary>
        Sign sign();

        string bitstring();
                       
    }
}