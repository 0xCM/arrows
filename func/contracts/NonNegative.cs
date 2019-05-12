//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes operations over nonnegative operands
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface INonNegativeOps<T>
    {
        
    }

    /// <summary>
    /// Characterizes a structure whose values are nonnegative
    /// </summary>
    /// <typeparam name="S">The reifying structure</typeparam>
    public interface INonNegative<S>            
        where S : INonNegative<S>, new()
    {

    }


}