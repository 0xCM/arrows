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
    
    using static zcore;
    using static inxfunc;

     partial class InX
     {
          [MethodImpl(Inline)]          
          public static Vec128<byte> avg(Vec128<byte> lhs, Vec128<byte> rhs)
               => Avx2.Average(lhs,rhs);

          [MethodImpl(Inline)]          
          public static Vec128<ushort> avg(Vec128<ushort> lhs, Vec128<ushort> rhs)
               => Avx2.Average(lhs,rhs);

          [MethodImpl(Inline)]          
          public static Vec256<byte> avg(Vec256<byte> lhs, Vec256<byte> rhs)
               => Avx2.Average(lhs,rhs);

          [MethodImpl(Inline)]          
          public static Vec256<ushort> avg(Vec256<ushort> lhs, Vec256<ushort> rhs)
               => Avx2.Average(lhs,rhs);

     }

}
