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

    public enum BinaryDigit : byte
    {
        B0 = 0,
        B1 = 1
    }

    
    public readonly struct BitString<N>
        where N : TypeNat, new()        
    {

        public Slice<N,BinaryDigit> bits {get;}

        public BitString(IEnumerable<BinaryDigit> src)
            => this.bits = src.ToSlice<N,BinaryDigit>();

        public BitString(string src)
        {
            natcheck<N>(src.Length);
            var digits = new BinaryDigit[src.Length];
            for(var i = 0; i< digits.Length; i++)
                digits[i] = src[i] == '0' ? BinaryDigit.B0 : BinaryDigit.B0;        
            bits = digits;            
        }
            

        public BitString(params BinaryDigit[] bits)
            => this.bits = natcheck<N,BinaryDigit>(bits);

        public override string ToString()
            => concat(map(bits.cells, b => (byte)b));
    }

    public enum DecimalDigit : byte
    {
        D0 = 0,
        D1 = 1,
        D2 = 2,
        D3 = 3,
        D4 = 4,
        D5 = 5,
        D6 = 6,
        D7 = 7,
        D8 = 8,
        D9 = 9,

    }

}