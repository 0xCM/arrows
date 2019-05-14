//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static As;

    public static class gbits
    {
        public static bool test<T>(T src, int pos)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                 return Bits.test(int8(ref src), pos);

            if(kind == PrimalKind.uint8)
                 return Bits.test(uint8(ref src), pos);

            if(kind == PrimalKind.int16)
                 return Bits.test(int16(ref src), pos);

            if(kind == PrimalKind.uint16)
                 return Bits.test(uint16(ref src), pos);

            if(kind == PrimalKind.int32)
                 return Bits.test(int32(ref src), pos);

            if(kind == PrimalKind.uint32)
                 return Bits.test(uint32(ref src), pos);

            if(kind == PrimalKind.int64)
                 return Bits.test(int64(ref src), pos);

            if(kind == PrimalKind.uint64)
                 return Bits.test(uint64(ref src), pos);

            if(kind == PrimalKind.float32)
                 return Bits.test(float32(ref src), pos);

            if(kind == PrimalKind.float64)
                 return Bits.test(float64(ref src), pos);

            throw unsupported(kind);


        }
    }


}