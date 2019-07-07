//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes the memory layout of a BitMatrix
    /// </summary>
    public readonly struct BitGridSpec
    {
        public static BitGridSpec Define<M,N,T>(M m = default, N n = default, T x = default)
            where N : ITypeNat, new()
            where M : ITypeNat, new()
            where T : struct
                => new BitGridSpec(SizeOf<T>.BitSize, m.value, n.value);

        public static implicit operator BitGridSpec((BitSize PrimalSize, BitSize RowCount, BitSize ColCount) x)
            => new BitGridSpec(x.PrimalSize, x.RowCount, x.ColCount);
            
        public BitGridSpec(BitSize PrimalSize, BitSize RowCount, BitSize ColCount)
        {
            this.PrimalSize = PrimalSize;
            this.RowCount = RowCount;
            this.ColCount = ColCount;
        }
        
        /// <summary>
        /// The bit size of the underlying primal storage type, e.g. uint, byte, etc.
        /// </summary>
        public readonly BitSize PrimalSize;
        
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly BitSize RowCount;
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly BitSize ColCount;

        public string Format()
            => (PrimalSize, RowCount, ColCount).Format();
    }
}