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
    using static zcore;
    
    using structure = C.uint64;
    using primitive = System.UInt64;

    partial class C : C.RealCalc<structure>, C.Lifting<structure,primitive>
    {
        [MethodImpl(Inline)]            
        public static structure num(primitive x)
            => x;

        public static IEnumerable<structure> numbers(params primitive[] src)
            => src.Select(num);

        [MethodImpl(Inline)]
        public structure min(structure x, structure y)        
             => y ^ ((x ^ y) & ~(x < y));
            
        [MethodImpl(Inline)]
        public structure max(structure x, structure y)
            => x ^ ((x ^ y) & ~(x < y));

        public IEnumerable<structure> lift(IEnumerable<primitive> src)
            => src.Select(num);

        public IEnumerable<primitive> drop(IEnumerable<structure> src)
            => src.Select(x => x.unwrap());

   }
}