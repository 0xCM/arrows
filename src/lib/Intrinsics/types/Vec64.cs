//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zcore;
    using static inxfunc;

    using NumVec = System.Numerics.Vector;


    public readonly struct Vec64<T>
        where T : struct, IEquatable<T>
    {
        
        readonly Vector64<T> data;
    
        [MethodImpl(Inline)]
        public Vec64(Vector64<T> src)
        {
            this.data = src;
        }

        public T this[int idx]
        {
            [MethodImpl(Inline)]
            get => Vec64.element(data,idx);
        }


        public override string ToString()
            => data.ToString();
    }
    
    
}