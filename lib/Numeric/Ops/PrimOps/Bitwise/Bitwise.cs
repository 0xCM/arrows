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
        public readonly partial struct Bitwise                  
        {
            static readonly Bitwise Inhabitant = default;

            [MethodImpl(Inline)]
            public static IBitwiseOps<T> Operator<T>() 
                where T : struct, IEquatable<T>
                    => cast<IBitwiseOps<T>>(Inhabitant);
    
      }

    }
}}