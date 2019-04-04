//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    
    public static partial class Traits
    {

    }

    /// <summary>
    /// Provides canonical trait implementations
    /// </summary>
    public static partial class Reify
    {

    }

    /// <summary>
    /// Constituents responsible for defining constraints
    /// that, when proof is given, allows access to a
    /// a particular context, operation set, etc.
    /// </summary>
    public static partial class Demands
    {


    }

    public static partial class Structures
    {
        
    }

    public static partial class Operative
    {
        
    }

    /// <summary>
    /// Constituents responsible for reifying proofs that
    /// demands have been satisfied
    /// </summary>
    public static partial class Prove
    {


    }


    public static partial class xcore
    {

    }


    /// <summary>
    /// Defines operations that make it easier to translate C => C#
    /// </summary>
    /// <remarks>
    /// The following references were used:
    /// http://graphics.stanford.edu/~seander/bithacks.html
    /// </remarks>
    public partial class C
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public static readonly C Inhabitant = new C();
        
        static readonly object ops = Inhabitant;

        public static Number<T> number<T>()
            => (Number<T>)ops;

        public static SignableNumber<T> signable<T>()
            => (SignableNumber<T>)ops;        
        private C()
        {

        }

        
    }

}

public static partial class zcore
{
    
}