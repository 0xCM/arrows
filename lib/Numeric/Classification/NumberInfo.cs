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
    using System.Text;

    public interface NumInfoProvider<T>
    {
        NumberInfo<T> numinfo {get;}
    }

    public readonly struct NumberInfo<T>
    {
        public NumberInfo((T min, T max) range, bool signed, T zero, T one, uint bitsize, T epsilon = default,bool infinite = false)
        {
            this.MinVal = range.min;
            this.MaxVal = range.max;
            this.Signed = signed;
            this.One = one;
            this.Zero = zero;
            this.BitSize = bitsize;
            this.Infinite = infinite;
            this.Epsilon = epsilon != default ? Option.some(epsilon) : Option.none<T>();
        }

        public T MinVal {get;}
        
        public T MaxVal {get;}
        
        public bool Signed {get;}

        public T One {get;}

        public T Zero {get;}

        public Option<T> Epsilon {get;}

        public uint BitSize {get;}

        public bool Infinite {get;}
        
    }
}