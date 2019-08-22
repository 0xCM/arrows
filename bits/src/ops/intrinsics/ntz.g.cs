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
    using static AsIn;

    partial class gbits
    {
        [MethodImpl(Inline)]
        public static ulong ntz<T>(in T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.ntz(int8(in asRef(in src)));
            else if(typeof(T) == typeof(byte))
                 return Bits.ntz(uint8(in asRef(in src)));
            else if(typeof(T) == typeof(short))
                 return Bits.ntz(int16(in asRef(in src)));
            else if(typeof(T) == typeof(ushort))
                 return Bits.ntz(uint16(in asRef(in src)));
            else if(typeof(T) == typeof(int))
                 return Bits.ntz(int32(in asRef(in src)));
            else if(typeof(T) == typeof(uint))
                 return Bits.ntz(uint32(in asRef(in src)));
            else if(typeof(T) == typeof(long))
                 return Bits.ntz(int64(in asRef(in src)));
            else if(typeof(T) == typeof(ulong))
                 return Bits.ntz(uint64(in asRef(in src)));
            else 
                throw unsupported<T>();
        }

    }

}