//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using static zfunc;

    public class AsciDigits : SymbolSet<AsciDigits, AsciAlphabet>
    {
        static AsciDigits()
        {
            _Symbols = new Symbol<AsciAlphabet>[]{A0,A1,A2,A3,A4,A5,A6,A7,A8,A9};            
        }
        
        public const char A0 = '0';
        
        public const char A1 = '1';
        
        public const char A2 = '2';
        
        public const char A3 = '3';
        
        public const char A4 = '4';
        
        public const char A5 = '5';
        
        public const char A6 = '6';
        
        public const char A7 = '7';
        
        public const char A8 = '8';
        
        public const char A9 = '9';
        
    }
}