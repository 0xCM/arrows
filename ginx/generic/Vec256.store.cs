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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;
    using static AsInX;

    partial class Vec256
    {
         [MethodImpl(Inline)]
        public unsafe static void store<T>(in Vec256<T> src, ref T dst)
            where T : struct
        {            
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                dinx.store(in int8(src), ref int8(ref dst));
            else if(kind == PrimalKind.uint8)                
                dinx.store(in uint8(src), ref uint8(ref dst));
            else if(kind == PrimalKind.int16)                
                dinx.store(in int16(src), ref int16(ref dst));
            else if(kind == PrimalKind.uint16)                
                dinx.store(in uint16(src), ref uint16(ref dst));
            else if(kind == PrimalKind.int32)                
                dinx.store(in int32(src), ref int32(ref dst));
            else if(kind == PrimalKind.uint32)                
                dinx.store(in uint32(src), ref uint32(ref dst));
            else if(kind == PrimalKind.int64)                
                dinx.store(in int64(src), ref int64(ref dst));
            else if(kind == PrimalKind.uint64)                
                dinx.store(in uint64(src), ref uint64(ref dst));
            else if(kind == PrimalKind.float32)                
                dinx.store(in float32(src), ref float32(ref dst));
            else if(kind == PrimalKind.float64)                
                dinx.store(in float64(src), ref float64(ref dst));
            else
                throw unsupported(kind);
        }        

 
    }

}