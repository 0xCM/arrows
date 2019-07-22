//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public sealed class FixedStringTest : UnitTest<FixedStringTest>
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

        public void VerifyConcat()
        {
            var x1 = Char2.FromChars('a','b');
            Char2 x2 = "ab";
            
            Claim.eq(x2.ToString(), "ab");
            Claim.eq(x1, x2);

            Char2 x3 = "cd";

            var x4 = Char4.FromChars(x2,x3);
            Claim.eq(x4.ToString(), "abcd");

            var x5 = x2 + x3;
            Claim.eq(x5, x4);

            var x6 = x5 + "efgh";
            var x7 = Char8.FromChars(Char4.FromChars(Char2.FromChars('a','b'), Char2.FromChars('c', 'd')), 
                Char4.FromChars(Char2.FromChars('e','f'), Char2.FromChars('g', 'h')));
            Claim.eq(x6,x7);

            var s1 = string.Empty;
            for(var i=0; i<8; i++)
                s1 += x7[i];
            Claim.eq(s1, "abcdefgh");



        }
        


    }

}