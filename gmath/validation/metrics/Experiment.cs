//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static zfunc;    
    using static mfunc;
    
    using static math;

    public static class AddOps
    {

       readonly struct Add<T,S>
            where T : struct
            where S : struct
       {
            public static Add<T,S> TheOnly = Unsafe.As<AddI32<S>, Add<T,S>>(ref AddI32<S>.TheOnly);
            

            S apply(S lhs, S rhs)
                => default(S);

            public T apply(T lhs, T rhs)
                => default(T);

       }

       readonly struct AddI32<T>
            where T : struct
       {
            public static AddI32<T> TheOnly = default;

            [MethodImpl(Inline)]
            public T apply(T lhs, T rhs)
                => As.generic<T>(As.int32(lhs) + As.int32(rhs));
       }

       readonly struct AddU32<T>
            where T : struct
       {
           public static readonly AddU32<T> TheOnly = default;

            [MethodImpl(Inline)]
            public T apply(T lhs, T rhs)
                => As.generic<T>(As.uint32(lhs) + As.uint32(rhs));
       }

        public static T apply<T>(T lhs, T rhs)
            where T : struct
                => Add<T,T>.TheOnly.apply(lhs,rhs);

    }


}