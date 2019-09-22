//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines polarity - an optional choice between exactly one of two values
    /// From this perspective, an orientation can be viewed as a required choice
    /// of sign. Or, a sign can be viwed as a subsumption of orientation sans duality
    /// </summary>
    /// <remaks>
    /// Note also that this fills in the need for a true mathematical "sign": A number
    /// is either Negative, Positive or Neutral=0.
    /// </remaks>
    public enum Sign : int
    {
        
        /// <summary>
        /// Specifies negative polarity and can be interpreted as mathematical sign
        /// </summary>
        Neg = -1,
        
        /// <summary>
        /// Specifies neutral polarity and from a mathemtatical perspectives gives 
        /// a sign classification to the number 0.
        /// </summary>
        None = 0,
        
        
        /// <summary>
        /// Specifies positive polarity and can be interpreted as mathematical sign
        /// </summary>
        Pos = 1
    }

    /// <summary>
    /// Characterizes a sign adjudication operation
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface ISignableOps<T>
    {
        /// <summary>
        /// Determines the sign of the supplied value
        /// </summary>
        Sign Sign(T x);
    }

    /// <summary>
    /// Characterizes a structure for which a sign can be adjudicated
    /// </summary>
    /// <typeparam name="S">The signed structure</typeparam>
    public interface ISignable<S>
        where S : ISignable<S>, new()
    {
        /// <summary>
        /// Determines the sign of the structure
        /// </summary>
        Sign Sign();

    }

}