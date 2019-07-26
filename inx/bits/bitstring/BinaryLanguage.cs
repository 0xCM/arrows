//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using static zfunc;

    public sealed class BinaryLanguage : Language<BinaryLanguage, BinaryAlphabet, BitString>
    {                        
        public static BinaryLanguage Get()
            => new BinaryLanguage();
        
        public static BinaryAlphabet Alphabet {get;} 
            = BinaryAlphabet.Get();
        
        public static Symbol<BinaryAlphabet> One {get;} 
            = Alphabet.One;

        public static Symbol<BinaryAlphabet> Zero {get;} 
            = Alphabet.Zero;

        public static Word<BinaryAlphabet> Word(params Symbol<BinaryAlphabet>[] symbols)
            => new Word<BinaryAlphabet>(symbols);
        
        /// <summary>
        /// Generates all words over the binary alphabet for a specified word length
        /// </summary>
        /// <param name="length">The length of the words to generate</param>
        public override IEnumerable<BitString> Words(int length)
        {
            var count = Pow2.pow(length) - 1;
            for(var i=0ul; i <= count; i++)
            {
                var bs = BitString.FromScalar(i);
                var bsfmt = bs.Format(true).PadLeft(length, '0');
                Claim.eq(bsfmt.Length, length);
                yield return BitString.Parse(bsfmt);
            }
                
        }                
    }
}