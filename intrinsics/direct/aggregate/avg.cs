//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    
    using static zfunc;

     partial class dinx
     {
          [MethodImpl(Inline)]          
          public static Vec128<byte> avg(in Vec128<byte> lhs, in Vec128<byte> rhs)
               => Average(lhs,rhs);

          [MethodImpl(Inline)]          
          public static Vec128<ushort> avg(in Vec128<ushort> lhs,in Vec128<ushort> rhs)
               => Average(lhs,rhs);

          [MethodImpl(Inline)]          
          public static Vec256<byte> avg(in Vec256<byte> lhs,in Vec256<byte> rhs)
               => Average(lhs,rhs);

          [MethodImpl(Inline)]          
          public static Vec256<ushort> avg(in Vec256<ushort> lhs,in Vec256<ushort> rhs)
               => Average(lhs,rhs);

     }

}
