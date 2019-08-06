//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Describes a dimension of any order
    /// </summary>
    public readonly struct DimInfo
    {
        public DimInfo(int Order, ulong[] Axes, ulong Volume)
        {
            this.Order = Order;
            this.Axes = Axes;
            this.Volume = Volume;
        }

        /// <summary>
        /// The number of dimension axes
        /// </summary>
        public readonly int Order;

        /// <summary>
        /// The axis index
        /// </summary>
        public readonly ulong[] Axes;

        /// <summary>
        /// Specifies the maximum number of cells that may inhabit the associated space
        /// </summary>
        public readonly ulong Volume;

    }

 
}