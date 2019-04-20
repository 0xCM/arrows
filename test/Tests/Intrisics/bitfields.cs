//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;


    public abstract class BitFieldTest<S,T> : InXTest<S,T>
        where T : struct, IEquatable<T>
        where S : BitTestTest<S,T>
    {
        
        protected BitFieldTest(Interval<T>? domain = null, int? streamlen = null)
            : base(P.bittest, domain, streamlen)        
        {

        }
    }

}
