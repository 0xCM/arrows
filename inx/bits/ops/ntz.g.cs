//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static As;


    partial class gbits
    {
        [MethodImpl(Inline)]
        public static ulong ntz<T>(in T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.ntz(AsIn.int8(in asRef(in src)));
            else if(typeof(T) == typeof(byte))
                 return Bits.ntz(AsIn.uint8(in asRef(in src)));
            else if(typeof(T) == typeof(short))
                 return Bits.ntz(AsIn.int16(in asRef(in src)));
            else if(typeof(T) == typeof(ushort))
                 return Bits.ntz(AsIn.uint16(in asRef(in src)));
            else if(typeof(T) == typeof(int))
                 return Bits.ntz(AsIn.int32(in asRef(in src)));
            else if(typeof(T) == typeof(uint))
                 return Bits.ntz(AsIn.uint32(in asRef(in src)));
            else if(typeof(T) == typeof(long))
                 return Bits.ntz(AsIn.int64(in asRef(in src)));
            else if(typeof(T) == typeof(ulong))
                 return Bits.ntz(AsIn.uint64(in asRef(in src)));
            else 
                throw unsupported<T>();
        }

    }

}