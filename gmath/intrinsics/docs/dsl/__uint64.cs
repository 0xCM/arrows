//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BitSpecs
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static mfunc;


    public ref struct __uint64
    {
        BitVectorU64 bits;

        [MethodImpl(Inline)]
        public static implicit operator __uint64(ulong src)
            => new __uint64(src);
    
        [MethodImpl(Inline)]
        public __uint64(ulong src)
            => bits = src;

        public Bit this[int pos]  
        {
            [MethodImpl(Inline)]
            get => (int)bits[pos];
            
            [MethodImpl(Inline)]
            set => bits[pos] = value;
        }              
    }

}