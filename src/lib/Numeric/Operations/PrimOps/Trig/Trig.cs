//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;

    partial class PrimOps { partial class Reify {
        public readonly partial struct Trig                  
        {
            static readonly Trig Inhabitant = default;

            [MethodImpl(Inline)]
            public static Trigonmetric<T> Operator<T>() 
                => cast<Trigonmetric<T>>(Inhabitant);
    
      }

    }
}}