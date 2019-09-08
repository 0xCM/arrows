//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Characterizes an injective linear mapping from a monotonic sequence of bit positions to 
    /// the cells in which they are stored. If the total bit count is equal to the product
    /// of the cell count and cell width, then the mapping is surjetive and hence bijective
    /// </summary>
    public interface IBitMap
    {
        /// <summary>
        /// The total number of bits in the map domain
        /// </summary>
        BitSize BitCount {get;}

        /// <summary>
        /// The number of cells in the map codomain
        /// </summary>
        int CellCount {get;}

        /// <summary>
        /// The (maximum) number of bits in a cell
        /// </summary>
        BitSize CellWidth {get;}

        /// <summary>
        /// Gets the 0-based index of the cell containing an identified bit
        /// </summary>
        /// <param name="pos">The 0-based linear index of the bit</param>
        ref readonly uint Cell(BitPos pos);

        /// <summary>
        /// Gets the cell-relative offset of the cell containing an identified bit
        /// </summary>
        /// <param name="pos">The 0-based linear index of the bit</param>
        ref readonly byte Offset(BitPos pos);

        /// <summary>
        /// Get the index for a bit at a specified position
        /// </summary>
        /// <param name="pos">The 0-based linear index of the bit</param>
        ref readonly BitIndex this[BitPos pos] {get;}

        /// <summary>
        /// Gets the index for a bit at a specified position
        /// </summary>
        /// <param name="pos">The 0-based linear index of the bit</param>
        ref readonly BitIndex Index(BitPos pos);

    }

    /// <summary>
    /// Characterizes an injective linear mapping from a monotonic sequence of bit positions to 
    /// the cells in which they are stored. If the total bit count is equal to the product
    /// of the cell count and cell width, then the mapping is surjetive and hence bijective
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    public interface IBitMap<T> : IBitMap
        where T : unmanaged
    {

        
    }

}