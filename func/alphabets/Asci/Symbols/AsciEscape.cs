//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using static zfunc;

    public class AsciEscape : SymbolSet<AsciEscape, AsciAlphabet>
    {
        static AsciEscape()
            => _Symbols = new Symbol<AsciAlphabet>[]{Tab, NewLine, LineFeed};
        
        public const char Tab = '\t';

        public const char NewLine = '\n';

        public const char LineFeed = '\r';
    }

}