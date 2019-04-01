//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System.Runtime.CompilerServices;

    using static zcore;
    public static class ztest
    {
        [MethodImpl(Inline)]
        public static void tell(object msg, [CallerMemberName] string member = null)
            => babble($"{msg}", member);


    }

}