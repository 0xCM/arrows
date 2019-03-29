//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zcore;

    public readonly struct BitString<N>
        where N : TypeNat, new()        
    {

        public BitString(IEnumerable<bit> src)
            => this.bits = slice<N,bit>(src);

        public BitString(string src)
        {
            Prove.claim<N>(src.Length);
            var digits = new bit[src.Length];
            for(var i = 0; i< digits.Length; i++)
                digits[i] = src[i] == '0' ? BinaryDigit.B0 : BinaryDigit.B0;        
            bits = digits;            
        }
            
        public Slice<N,bit> bits {get;}

        public BitString(params bit[] bits)
            => this.bits = Prove.length<N,bit>(bits);

        public override string ToString()
            => concat(map(bits.data, b => b.ToString()));
    }
}