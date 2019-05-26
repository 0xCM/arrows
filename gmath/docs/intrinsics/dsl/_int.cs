//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BitSpecs
{
    using System;

    public ref struct _int
    {
        BitVectorI32 bits;

        public _int(int src)
            => bits = src;

        public Bit this[int pos]  
        {
            get => (int)bits[pos];
            set => bits[pos] = value;
        }              
    }

}