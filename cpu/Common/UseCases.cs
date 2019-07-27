//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class UseCases
    {
        [MethodImpl(Inline)]
        public static int FOR(int min,  int max)
        {
            int j = 0;
            for(var i= min; i<max; i++)
                j--;
            return j;
        }   

        public static int DoFor(int min, int max)
            => FOR(min,max);
    }
}