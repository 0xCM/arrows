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
    public class MathSymK
    {
        public const string infinity = "∞";
        
        public const string otimes = "⊗";
        
        public const string oplus = "⊕";
        
        public const string wedge = "∧";
        
        public const string vee = "∨";
        
        public const string partial = "∂";
        
        public const string emptyset = "∅";
        
        public const string longrightarrow = "⟶";
        
        public const string times = "×";

        public const string lteq = "⩽";

        public const string gteq = "⩾";

        public const string coproduct = "⨿";

        public const string iff = "⟺";

        public const string member = "⋴";

        public const string forsome ="∃";

        public const string forall = "∀";

        public const string fornone = "∄";

        public const string equivalence = "∼";

        public const string almost = "≈";        
    }
    public class MathSym
    {
        public static readonly Atom infinity = MathSymK.infinity;
        
        public static readonly Atom otimes = MathSymK.otimes;
        
        public static readonly Atom oplus = MathSymK.oplus;
        
        public static readonly Atom wedge = MathSymK.wedge;
        
        public static readonly Atom vee = MathSymK.vee;        
        
        public static readonly Atom partial = MathSymK.partial;
        
        public static readonly Atom emptyset = MathSymK.emptyset;
        
        public static readonly Atom longrightarrow = MathSymK.longrightarrow;
        
        public static readonly Atom times = MathSymK.times;


        public static readonly Atom lteq = MathSymK.lteq;

        public static readonly Atom gteq = MathSymK.gteq;


    }

}