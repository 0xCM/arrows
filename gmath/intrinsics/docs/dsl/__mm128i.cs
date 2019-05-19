//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BitSpecs
{
    using System;


    using static zfunc;
    using static mfunc;
    using static Nats;


    public ref struct __mm128i
    {
        BitVectorU128 bits;

        public __mm128i(U128 src)
            => bits = src;

        public Span<Bit> this[int lastIx, int startIx]
            => bits[startIx, lastIx];


        public BitVectorU64 this[N63 lastIx, N0 startIx]
            => Lo;

        public BitVectorU64 this[N127 lastIx, N64 startIx]
            => Hi;

        public void UpdateBit(int pos, Bit value)
            => bits[pos] = value;

        public Bit this[int pos]
        {
            get => bits[pos];
            set => bits[pos] = value;
        }

        BitVectorU64 Lo
            => bits.Lo;

        BitVectorU64 Hi
            => bits.Hi;
    }
}