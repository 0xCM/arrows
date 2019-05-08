//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    using static BitPatterns;
    
    using P = Paths;


    [DisplayName(Path)]
    public class BitType : UnitTest<BitType>
    {
        public const string Path = P.primops + P.bits + "bit/";

        static readonly Bit off = Z0.Bit.Off;
        static readonly Bit on = Z0.Bit.On;

        public void BitConvert()
        {
            Claim.eq<bool>(false, off);
            Claim.eq<bool>(true, on);

            Claim.eq<byte>(0, (byte)off);
            Claim.eq<byte>(1, (byte)on);

            Claim.eq<ushort>(0, (ushort)off);
            Claim.eq<ushort>(1, (ushort)on);

            Claim.eq<uint>(0, (uint)off);
            Claim.eq<uint>(1, (uint)on);

            Claim.eq<ulong>(0, (ulong)off);
            Claim.eq<ulong>(1, (ulong)on);

            Claim.enumeq<BinaryDigit>(BinaryDigit.B0, off);
            Claim.enumeq<BinaryDigit>(BinaryDigit.B1, on);

        }


        public void BitOps()
        {

            //parse
            Claim.eq(off, Z0.Bit.Parse('0'));
            Claim.eq(on, Z0.Bit.Parse('1'));

            //flip
            Claim.eq(on, ~ off);
            Claim.eq(off, ~ on);

            //and
            Claim.eq(on, on & on);
            Claim.eq(off, on & off);
            Claim.eq(off, off & on);
            Claim.eq(off, off & off);

            //or
            Claim.eq(on, off | on);
            Claim.eq(on, on | off);
            Claim.eq(off, off | off);
            Claim.eq(on, on | on);
            
            
            //xor
            Claim.eq(on, off ^ on);
            Claim.eq(on, on ^ off);
            Claim.eq(off, off ^ off);
            Claim.eq(off, on ^ on);
        }
    }

}
