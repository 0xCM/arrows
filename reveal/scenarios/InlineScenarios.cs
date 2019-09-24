//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using static zfunc;


    [DisplayName("scenarios-inline")]
    class InlineScenarios
    {
    
        [MethodImpl(Inline)]
        public static int For(int min,  int max)
        {
            int j = 0;
            for(var i= min; i<max; i++)
                j--;
            return j;
        }   

        public static int DoFor(int min, int max)
            => For(min,max);
    
    }

}