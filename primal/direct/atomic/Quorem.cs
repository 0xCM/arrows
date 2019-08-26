namespace Z0
{

    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Numerics;
    
    using static zfunc;    
    

    partial class math
    {
        [MethodImpl(Inline)]
        public static ref Quorem<int> quorem(in int lhs, in int rhs, out Quorem<int> dst)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            var quo = x / y;
            var rem = x - quo*y;
            dst = Quorem.define(in quo, in rem);                   
            return ref dst;
        }

    }
}