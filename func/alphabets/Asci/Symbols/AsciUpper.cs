//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using static zfunc;
    using System.Linq;
    using System.Collections.Generic;

    public sealed class AsciUpper : SymbolSet<AsciUpper, AsciAlphabet>
    {        
        public static Symbol<AsciAlphabet>[] All
            => _Symbols;


        static AsciUpper()
        {
            _Symbols = new Symbol<AsciAlphabet>[]{A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z};            
        }

        public const char A = 'A';
        
        public const char B = 'B';
        
        public const char C = 'C';
        
        public const char D = 'D';
        
        public const char E = 'E';
        
        public const char F = 'F';
        
        public const char G = 'G';
        
        public const char H = 'H';
        
        public const char I = 'I';
        
        public const char J = 'J';

        public const char K = 'K';

        public const char L = 'L';
        
        public const char M = 'M';
        
        public const char N = 'N';
        
        public const char O = 'O';
        
        public const char P = 'P';
        
        public const char Q = 'Q';
        
        public const char R = 'R';
        
        public const char S = 'S';
        
        public const char T = 'T';
        
        public const char U = 'U';
        
        public const char V = 'V';

        public const char W = 'W';

        public const char X = 'X';

        public const char Y = 'Y';

        public const char Z = 'Z';
   }
}