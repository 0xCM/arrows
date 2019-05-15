//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zfunc;

    
    /// <summary>
    /// Random selection of math-related unicode symbols
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Mathematical_operators_and_symbols_in_Unicode for a comprehensive list
    /// </remarks>
    public partial class MathSym
    {
        public const string Dots = "⋯";
        
        public const string Infinity = "∞";
        
        public const string OTimes = "⊗";
        
        public const string Oplus = "⊕";
        
        public const string Wedge = "∧";
        
        public const string Vee = "∨";
        
        public const string Partial = "∂";
        
        public const string EmptySet = "∅";
        
        public const string LongRightArrow = "⟶";
        
        public const string Times = "×";

        public const string NEQ = "≠";

        public const string LTEQ = "⩽";

        public const string LT2 = "≪";

        public const string GTEQ = "⩾";

        public const string GT2 = "≫";

        public const string NLT = "≮";

        public const string NGT = "≯";

        public const string NGTEQ = "≱";

        public const string NLTEQ = "≰";

        public const string Between = "≬";

        public const string Sum = "∑";

        public const string Product = "∏";
        
        public const string Coproduct = "∐";

        public const string Intersect = "∩";

        public const string Union = "∪";
        
        public const string IFF = "⟺";

        public const string Member = "⋴";

        public const string Some ="∃";

        public const string All = "∀";

        public const string None = "∄";

        public const string Equivalence = "∼";

        public const string Almost = "≈";        

        public const string Define = "≔"; 

        public const string CDot = "·";

        public const string Abs = AsciSym.Pipe + CDot + AsciSym.Pipe;
    }

}