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
    using System.IO;
    
    using static zfunc;
    using static MetricKind;

    public enum MetricKind
    {
        None,
        
        /// <summary>
        /// Identifies primal + direct + atomic metrics
        /// </summary>        
        PrimalD,

        /// <summary>
        /// Identifies primal + generic + fused benchmarks
        /// </summary>        
        PrimalDFused,

        /// <summary>
        /// Identifies primal + generic + atomic benchmarks
        /// </summary>        
        PrimalG,

        /// <summary>
        /// Identifies primal + generic + fused benchmarks
        /// </summary>        
        PrimalGFused,


        /// <summary>
        /// Identifies number + generic + atomic metrics
        /// </summary>        
        NumG,

        /// <summary>
        /// Identifies numbers + generic + fused metrics
        /// </summary>        
        NumGFused,

        BitD,

        BitG,
        
        InX128D,

        InX128DFused,

        InX128G,
        
        InX128GFused,

        InX256D,
        InX256DFused,

        InX256G,
        
        InX256GFused        
    }

    public static class MetricKindX
    {
        static readonly HashSet<MetricKind> Atomic 
            = set(BitD, BitG, NumG, PrimalG, PrimalD);

        static readonly HashSet<MetricKind> BitOp
            = set(BitD, BitG);
        
        static readonly HashSet<MetricKind> Fused
            = set(NumGFused, PrimalGFused, PrimalDFused);

        static readonly HashSet<MetricKind> Generic 
            = set(BitD, InX128GFused, InX256GFused, NumG, NumGFused, PrimalG, PrimalGFused);

        static readonly HashSet<MetricKind> Direct 
            = set(BitD, InX128DFused, InX256DFused, PrimalD, PrimalDFused);

        static readonly HashSet<MetricKind> Intrinsic
            = set(InX128DFused, InX128GFused, InX256DFused, InX256GFused);

         public static bool IsAtomic(this MetricKind metric)
            => Atomic.Contains(metric);
      
        public static bool IsGeneric(this MetricKind metric)
            => Generic.Contains(metric);

        public static bool IsBit(this MetricKind metric)
            => BitOp.Contains(metric);

        public static bool IsDirect(this MetricKind metric)
            => Direct.Contains(metric);

        public static bool IsIntrinsic(this MetricKind metric)
            => Intrinsic.Contains(metric);

        public static bool IsFused(this MetricKind metric)
            => Fused.Contains(metric);

    }

}