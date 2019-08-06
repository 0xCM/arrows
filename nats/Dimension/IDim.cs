//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a dimension of arbitrary order
    /// </summary>
    public interface IDim
    {
        /// <summary>
        /// Specifies the number of axes in the dimension
        /// </summary>
        int Order {get;}

        /// <summary>
        /// Specifies the maximum number of cells that may inhabit the associated space
        /// </summary>
        ulong Volume {get;}

        /// <summary>
        /// Gets the dimension axis determined by its 0-based index, an integer in the interval [0,Order-1]
        /// </summary>
        ulong this[int axis] {get;}

    }


}