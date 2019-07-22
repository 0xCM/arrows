//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public interface IFixedString
    {
        Span<char> AsSpan();
        
        ReadOnlySpan<char> AsReadOnlySpan();        

        ref char this[int i] {get;}

        void Fill(ReadOnlySpan<char> src);
        
    }
    public interface IFixedString<N> : IFixedString
        where N : ITypeNat,new()
    {

    }
}