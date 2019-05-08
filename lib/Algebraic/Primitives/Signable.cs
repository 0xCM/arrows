//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    /// <summary>
    /// Characterizes a sign adjudication operation
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface ISignableOps<T>
    {
        /// <summary>
        /// Determines the sign of the supplied value
        /// </summary>
        Sign sign(T x);

    }

    /// <summary>
    /// Characterizes a structure for which a sign can be adjudicated
    /// </summary>
    /// <typeparam name="S">The signed structure</typeparam>
    public interface ISignable<S>
        where S : ISignable<S>, new()
    {
        /// <summary>
        /// Specifies the sign of the structure
        /// </summary>
        Sign sign();

    }

}