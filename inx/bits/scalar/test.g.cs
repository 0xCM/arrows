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
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Determines whether a position-identified bit in value is enabled
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static bool test<T>(in T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.test(in AsIn.int8(asRef(in src)), pos);
            else if(typeof(T) == typeof(byte))
                 return Bits.test(in AsIn.uint8(asRef(in src)), pos);
            else if(typeof(T) == typeof(short))
                 return Bits.test(in AsIn.int16(asRef(in src)), pos);
            else if(typeof(T) == typeof(ushort))
                 return Bits.test(in AsIn.uint16(asRef(in src)), pos);
            else if(typeof(T) == typeof(int))
                 return Bits.test(in AsIn.int32(asRef(in src)), pos);
            else if(typeof(T) == typeof(uint))
                 return Bits.test(in AsIn.uint32(asRef(in src)), pos);
            else if(typeof(T) == typeof(long))
                 return Bits.test(in AsIn.int64(asRef(in src)), pos);
            else if(typeof(T) == typeof(ulong))
                 return Bits.test(in AsIn.uint64(asRef(in src)), pos);
            else if(typeof(T) == typeof(float))
                 return Bits.test(in AsIn.float32(asRef(in src)), pos);
            else if(typeof(T) == typeof(double))
                 return Bits.test(in AsIn.float64(asRef(in src)), pos);
            else
                throw unsupported<T>();
        }

        public static bool test<T>(in T src, byte pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return Bits.test(in AsIn.int8(asRef(in src)), pos);
            else if(typeof(T) == typeof(byte))
                 return Bits.test(in AsIn.uint8(asRef(in src)), pos);
            else if(typeof(T) == typeof(short))
                 return Bits.test(in AsIn.int16(asRef(in src)), pos);
            else if(typeof(T) == typeof(ushort))
                 return Bits.test(in AsIn.uint16(asRef(in src)), pos);
            else if(typeof(T) == typeof(int))
                 return Bits.test(in AsIn.int32(asRef(in src)), pos);
            else if(typeof(T) == typeof(uint))
                 return Bits.test(in AsIn.uint32(asRef(in src)), pos);
            else if(typeof(T) == typeof(long))
                 return Bits.test(in AsIn.int64(asRef(in src)), pos);
            else if(typeof(T) == typeof(ulong))
                 return Bits.test(in AsIn.uint64(asRef(in src)), pos);
            else if(typeof(T) == typeof(float))
                 return Bits.test(in AsIn.float32(asRef(in src)), pos);
            else if(typeof(T) == typeof(double))
                 return Bits.test(in AsIn.float64(asRef(in src)), pos);
            else
                throw unsupported<T>();
        }

    }
}