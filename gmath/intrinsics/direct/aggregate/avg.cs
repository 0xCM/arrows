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

     partial class dinx
     {
          [MethodImpl(Inline)]          
          public static Vec128<byte> avg(in Vec128<byte> lhs, in Vec128<byte> rhs)
               => Avx2.Average(lhs,rhs);


          [MethodImpl(Inline)]          
          public static Vec128<ushort> avg(in Vec128<ushort> lhs,in Vec128<ushort> rhs)
               => Avx2.Average(lhs,rhs);

          [MethodImpl(Inline)]          
          public static Vec256<byte> avg(in Vec256<byte> lhs,in Vec256<byte> rhs)
               => Avx2.Average(lhs,rhs);

          [MethodImpl(Inline)]          
          public static Vec256<ushort> avg(in Vec256<ushort> lhs,in Vec256<ushort> rhs)
               => Avx2.Average(lhs,rhs);

     }

}
