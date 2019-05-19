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



    public ref struct __uint32
    {
        BitVectorU64 bits;

        [MethodImpl(Inline)]
        public static implicit operator __uint32(uint src)
            => new __uint32(src);

        public __uint32(uint src)
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