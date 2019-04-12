//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Latex
{
    using Z0;
    using static zcore;
    using static LatexCmd;



    public static class BB
    {
        public static readonly Syntax Zero = syntax(BBSym.Zero,"Bbbzero");
        
        public static readonly Syntax One = syntax(BBSym.One,"Bbbone");
        
        public static readonly Syntax Two = syntax(BBSym.Two,"Bbbtwo");
        
        public static readonly Syntax Three = syntax(BBSym.Three,"Bbbthree");
        
        public static readonly Syntax A = syntax(BBSym.A,"BbbA");
        
        public static readonly Syntax T = syntax(BBSym.T, "BbbT");
        
        public static readonly Syntax Q = syntax(BBSym.Q,"BbbQ");
        
        public static readonly Syntax R = syntax(BBSym.R,"BbbR");            
    }

}