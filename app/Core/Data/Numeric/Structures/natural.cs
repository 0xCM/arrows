//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Data
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;

    using IX = System.Runtime.Intrinsics;
    using IX86 = System.Runtime.Intrinsics.X86;
    using SSE2 = System.Runtime.Intrinsics.X86.Sse2;
    using SSE42 = System.Runtime.Intrinsics.X86.Sse42;
    using AES = System.Runtime.Intrinsics.X86.Aes;

    using C = Contracts;    


    /// <summary>
    /// Represents an unsigned integral type subject to the constraits
    /// imposed by the underlying primitive
    /// </summary>
    public readonly struct natural<T>
    {

    }


    /// <summary>
    /// Represents a theoreteically unbounded natural number
    /// </summary>
    public readonly struct natural 
    {
        public static void blah()
        {
            
        }

        public static natural operator ++(natural src)
            => src._value + 1;
        
        public static implicit operator natural(int src)        
            => new natural(src);

        public static implicit operator natural(BigInteger src)        
            => new natural(src);

        readonly BigInteger _value;

        public natural (BigInteger n) 
            => _value = n;

    }

}