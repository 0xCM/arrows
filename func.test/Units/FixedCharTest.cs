//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public sealed class FixedCharTest : UnitTest<FixedCharTest>
    {
       public void VerifyChar8()
        {
            var x1 = "Hello, W";
            Char8 x2 = x1;
            string x3 = x1;
            Claim.eq(x1,x3);

            Span<char> x4 = x2;
            Claim.eq(Char8.CharCount, x4.Length);

            ReadOnlySpan<char> x5 = x1;
            Claim.eq(Char8.CharCount, x5.Length);

        }

        public void VerifyChar64()
        {
            string x1 = "Hello, World!";
            Char64 x2 = x1;

            Span<char> x4 = x2;
            Claim.eq(x4.Length, Char64.CharCount);

            string x3 = x1;
            Claim.eq(x1,x3);


            x4[1] = '1';
            Char64 x5 = x4;
            string x6 = x5;
            string x7 = x1.Replace('e', '1');

            Claim.eq(x7.Length, x6.Length);
                
            
        }

        public void VerifyChar32()
        {
            var x1 = "Hello, World!";
            Char32 x2 = x1;
            string x3 = x1;
            Claim.eq(x1,x3);
        }

        public void VerifyChar16()
        {
            var x1 = "Hello, World!";
            Char16 x2 = x1;
            string x3 = x1;
            Claim.eq(x1,x3);
        }

 
    }
}