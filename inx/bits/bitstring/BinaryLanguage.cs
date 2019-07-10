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
        
        static BinaryAlphabet Alphabet {get;} 
            = BinaryAlphabet.Get();
        
        static Symbol<BinaryAlphabet> One {get;} 
            = Alphabet.One;

        static Symbol<BinaryAlphabet> Zero {get;} 
            = Alphabet.Zero;

        static Word<BinaryAlphabet> Word(params Symbol<BinaryAlphabet>[] symbols)
            => new Word<BinaryAlphabet>(symbols);

        static Word<BinaryAlphabet> Word(params int[] symbolIds)
        {
            var symbols = new Symbol<BinaryAlphabet>[symbolIds.Length];
            for(var i=0; i<symbols.Length; i++)
                symbols[i] = symbolIds[i] == 0 ? Zero : One;
            return Word(symbols);
        }
            
        static IEnumerable<int> CountToExclusive(int value)
        {
            for(var i=0; i<value; i++)
                yield return i;
        }
        
        /// <summary>
        /// Generates all words over the binary alphabet for a specified word length
        /// </summary>
        /// <param name="length">The length of the words to generate</param>
        public override IEnumerable<BitString> Words(int length)
        {
            var count = Pow2.pow(length) - 1;
            for(var i=0ul; i <= count; i++)
                yield return BitString.From(BitString.From(i).Format(true).PadLeft(length, '0'));
        }                
    }
}