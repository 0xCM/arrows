//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;


    public static class mathops
    {

        //! add
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T addI8<T>(T lhs, T rhs)
            => As.generic<T>((sbyte)(As.int8(lhs) + As.int8(rhs)));

        [MethodImpl(Inline)]
        public static T addU8<T>(T lhs, T rhs)
            => As.generic<T>((byte)(As.uint8(lhs) + As.uint8(rhs)));

        [MethodImpl(Inline)]
        public static T addI16<T>(T lhs, T rhs)
            => As.generic<T>((short)(As.int16(lhs) + As.int16(rhs)));

        [MethodImpl(Inline)]
        public static T addU16<T>(T lhs, T rhs)
            => As.generic<T>((ushort)(As.uint16(lhs) + As.uint16(rhs)));

        [MethodImpl(Inline)]
        public static T addI32<T>(T lhs, T rhs)
            => As.generic<T>(As.int32(lhs) + As.int32(rhs));
        
        [MethodImpl(Inline)]
        public static T addU32<T>(T lhs, T rhs)
            => As.generic<T>(As.uint32(lhs) + As.uint32(rhs));

        [MethodImpl(Inline)]
        public static T addI64<T>(T lhs, T rhs)
            => As.generic<T>(As.int64(lhs) + As.int64(rhs));

        [MethodImpl(Inline)]
        public static T addU64<T>(T lhs, T rhs)
            => As.generic<T>(As.uint64(lhs) + As.uint64(rhs));

        [MethodImpl(Inline)]
        public static T addF32<T>(T lhs, T rhs)
            => As.generic<T>(As.float32(lhs) + As.float32(rhs));

        [MethodImpl(Inline)]
        public static T addF64<T>(T lhs, T rhs)
            => As.generic<T>(As.float64(lhs) + As.float64(rhs));

        //! sub
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T subI8<T>(T lhs, T rhs)
            => As.generic<T>((sbyte)(As.int8(lhs) - As.int8(rhs)));

        [MethodImpl(Inline)]
        public static T subU8<T>(T lhs, T rhs)
            => As.generic<T>((byte)(As.uint8(lhs) - As.uint8(rhs)));

        [MethodImpl(Inline)]
        public static T subI16<T>(T lhs, T rhs)
            => As.generic<T>((short)(As.int16(lhs) - As.int16(rhs)));

        [MethodImpl(Inline)]
        public static T subU16<T>(T lhs, T rhs)
            => As.generic<T>((ushort)(As.uint16(lhs) - As.uint16(rhs)));

        [MethodImpl(Inline)]
        public static T subI32<T>(T lhs, T rhs)
            => As.generic<T>(As.int32(lhs) - As.int32(rhs));
        
        [MethodImpl(Inline)]
        public static T subU32<T>(T lhs, T rhs)
            => As.generic<T>(As.uint32(lhs) - As.uint32(rhs));

        [MethodImpl(Inline)]
        public static T subI64<T>(T lhs, T rhs)
            => As.generic<T>(As.int64(lhs) - As.int64(rhs));

        [MethodImpl(Inline)]
        public static T subU64<T>(T lhs, T rhs)
            => As.generic<T>(As.uint64(lhs) - As.uint64(rhs));

        [MethodImpl(Inline)]
        public static T subF32<T>(T lhs, T rhs)
            => As.generic<T>(As.float32(lhs) - As.float32(rhs));

        [MethodImpl(Inline)]
        public static T subF64<T>(T lhs, T rhs)
            => As.generic<T>(As.float64(lhs) - As.float64(rhs));

        //! mul
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T mulI8<T>(T lhs, T rhs)
            => As.generic<T>((sbyte)(As.int8(lhs) * As.int8(rhs)));

        [MethodImpl(Inline)]
        public static T mulU8<T>(T lhs, T rhs)
            => As.generic<T>((byte)(As.uint8(lhs) * As.uint8(rhs)));

        [MethodImpl(Inline)]
        public static T mulI16<T>(T lhs, T rhs)
            => As.generic<T>((short)(As.int16(lhs) * As.int16(rhs)));

        [MethodImpl(Inline)]
        public static T mulU16<T>(T lhs, T rhs)
            => As.generic<T>((ushort)(As.uint16(lhs) * As.uint16(rhs)));

        [MethodImpl(Inline)]
        public static T mulI32<T>(T lhs, T rhs)
            => As.generic<T>(As.int32(lhs) * As.int32(rhs));
        
        [MethodImpl(Inline)]
        public static T mulU32<T>(T lhs, T rhs)
            => As.generic<T>(As.uint32(lhs) * As.uint32(rhs));

        [MethodImpl(Inline)]
        public static T mulI64<T>(T lhs, T rhs)
            => As.generic<T>(As.int64(lhs) * As.int64(rhs));

        [MethodImpl(Inline)]
        public static T mulU64<T>(T lhs, T rhs)
            => As.generic<T>(As.uint64(lhs) * As.uint64(rhs));

        [MethodImpl(Inline)]
        public static T mulF32<T>(T lhs, T rhs)
            => As.generic<T>(As.float32(lhs) * As.float32(rhs));

        [MethodImpl(Inline)]
        public static T mulF64<T>(T lhs, T rhs)
            => As.generic<T>(As.float64(lhs) * As.float64(rhs));

        //! div
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T divI8<T>(T lhs, T rhs)
            => As.generic<T>((sbyte)(As.int8(lhs) / As.int8(rhs)));

        [MethodImpl(Inline)]
        public static T divU8<T>(T lhs, T rhs)
            => As.generic<T>((byte)(As.uint8(lhs) / As.uint8(rhs)));

        [MethodImpl(Inline)]
        public static T divI16<T>(T lhs, T rhs)
            => As.generic<T>((short)(As.int16(lhs) / As.int16(rhs)));

        [MethodImpl(Inline)]
        public static T divU16<T>(T lhs, T rhs)
            => As.generic<T>((ushort)(As.uint16(lhs) / As.uint16(rhs)));

        [MethodImpl(Inline)]
        public static T divI32<T>(T lhs, T rhs)
            => As.generic<T>(As.int32(lhs) / As.int32(rhs));
        
        [MethodImpl(Inline)]
        public static T divU32<T>(T lhs, T rhs)
            => As.generic<T>(As.uint32(lhs) / As.uint32(rhs));

        [MethodImpl(Inline)]
        public static T divI64<T>(T lhs, T rhs)
            => As.generic<T>(As.int64(lhs) / As.int64(rhs));

        [MethodImpl(Inline)]
        public static T divU64<T>(T lhs, T rhs)
            => As.generic<T>(As.uint64(lhs) / As.uint64(rhs));

        [MethodImpl(Inline)]
        public static T divF32<T>(T lhs, T rhs)
            => As.generic<T>(As.float32(lhs) / As.float32(rhs));

        [MethodImpl(Inline)]
        public static T divF64<T>(T lhs, T rhs)
            => As.generic<T>(As.float64(lhs) / As.float64(rhs));

        //! mod
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T modI8<T>(T lhs, T rhs)
            => As.generic<T>((sbyte)(As.int8(lhs) % As.int8(rhs)));

        [MethodImpl(Inline)]
        public static T modU8<T>(T lhs, T rhs)
            => As.generic<T>((byte)(As.uint8(lhs) % As.uint8(rhs)));

        [MethodImpl(Inline)]
        public static T modI16<T>(T lhs, T rhs)
            => As.generic<T>((short)(As.int16(lhs) % As.int16(rhs)));

        [MethodImpl(Inline)]
        public static T modU16<T>(T lhs, T rhs)
            => As.generic<T>((ushort)(As.uint16(lhs) % As.uint16(rhs)));

        [MethodImpl(Inline)]
        public static T modI32<T>(T lhs, T rhs)
            => As.generic<T>(As.int32(lhs) % As.int32(rhs));
        
        [MethodImpl(Inline)]
        public static T modU32<T>(T lhs, T rhs)
            => As.generic<T>(As.uint32(lhs) % As.uint32(rhs));

        [MethodImpl(Inline)]
        public static T modI64<T>(T lhs, T rhs)
            => As.generic<T>(As.int64(lhs) % As.int64(rhs));

        [MethodImpl(Inline)]
        public static T modU64<T>(T lhs, T rhs)
            => As.generic<T>(As.uint64(lhs) % As.uint64(rhs));

        [MethodImpl(Inline)]
        public static T modF32<T>(T lhs, T rhs)
            => As.generic<T>(As.float32(lhs) % As.float32(rhs));

        [MethodImpl(Inline)]
        public static T modF64<T>(T lhs, T rhs)
            => As.generic<T>(As.float64(lhs) % As.float64(rhs));

        //! and
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T andI8<T>(T lhs, T rhs)
            => As.generic<T>((sbyte)(As.int8(lhs) & As.int8(rhs)));

        [MethodImpl(Inline)]
        public static T andU8<T>(T lhs, T rhs)
            => As.generic<T>((byte)(As.uint8(lhs) & As.uint8(rhs)));

        [MethodImpl(Inline)]
        public static T andI16<T>(T lhs, T rhs)
            => As.generic<T>((short)(As.int16(lhs) & As.int16(rhs)));

        [MethodImpl(Inline)]
        public static T andU16<T>(T lhs, T rhs)
            => As.generic<T>((ushort)(As.uint16(lhs) & As.uint16(rhs)));

        [MethodImpl(Inline)]
        public static T andI32<T>(T lhs, T rhs)
            => As.generic<T>(As.int32(lhs) & As.int32(rhs));
        
        [MethodImpl(Inline)]
        public static T andU32<T>(T lhs, T rhs)
            => As.generic<T>(As.uint32(lhs) & As.uint32(rhs));

        [MethodImpl(Inline)]
        public static T andI64<T>(T lhs, T rhs)
            => As.generic<T>(As.int64(lhs) & As.int64(rhs));

        [MethodImpl(Inline)]
        public static T andU64<T>(T lhs, T rhs)
            => As.generic<T>(As.uint64(lhs) & As.uint64(rhs));

        //! or
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T orI8<T>(T lhs, T rhs)
            => As.generic<T>((sbyte)(As.int8(lhs) | As.int8(rhs)));

        [MethodImpl(Inline)]
        public static T orU8<T>(T lhs, T rhs)
            => As.generic<T>((byte)(As.uint8(lhs) | As.uint8(rhs)));

        [MethodImpl(Inline)]
        public static T orI16<T>(T lhs, T rhs)
            => As.generic<T>((short)(As.int16(lhs) | As.int16(rhs)));

        [MethodImpl(Inline)]
        public static T orU16<T>(T lhs, T rhs)
            => As.generic<T>((ushort)(As.uint16(lhs) | As.uint16(rhs)));

        [MethodImpl(Inline)]
        public static T orI32<T>(T lhs, T rhs)
            => As.generic<T>(As.int32(lhs) | As.int32(rhs));
        
        [MethodImpl(Inline)]
        public static T orU32<T>(T lhs, T rhs)
            => As.generic<T>(As.uint32(lhs) | As.uint32(rhs));

        [MethodImpl(Inline)]
        public static T orI64<T>(T lhs, T rhs)
            => As.generic<T>(As.int64(lhs) | As.int64(rhs));

        [MethodImpl(Inline)]
        public static T orU64<T>(T lhs, T rhs)
            => As.generic<T>(As.uint64(lhs) | As.uint64(rhs));

        //! xor
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T xorI8<T>(T lhs, T rhs)
            => As.generic<T>((sbyte)(As.int8(lhs) ^ As.int8(rhs)));

        [MethodImpl(Inline)]
        public static T xorU8<T>(T lhs, T rhs)
            => As.generic<T>((byte)(As.uint8(lhs) ^ As.uint8(rhs)));

        [MethodImpl(Inline)]
        public static T xorI16<T>(T lhs, T rhs)
            => As.generic<T>((short)(As.int16(lhs) ^ As.int16(rhs)));

        [MethodImpl(Inline)]
        public static T xorU16<T>(T lhs, T rhs)
            => As.generic<T>((ushort)(As.uint16(lhs) ^ As.uint16(rhs)));

        [MethodImpl(Inline)]
        public static T xorI32<T>(T lhs, T rhs)
            => As.generic<T>(As.int32(lhs) ^ As.int32(rhs));
        
        [MethodImpl(Inline)]
        public static T xorU32<T>(T lhs, T rhs)
            => As.generic<T>(As.uint32(lhs) ^ As.uint32(rhs));

        [MethodImpl(Inline)]
        public static T xorI64<T>(T lhs, T rhs)
            => As.generic<T>(As.int64(lhs) ^ As.int64(rhs));

        [MethodImpl(Inline)]
        public static T xorU64<T>(T lhs, T rhs)
            => As.generic<T>(As.uint64(lhs) ^ As.uint64(rhs));

        //! flip
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T flipI8<T>(T src)
            => As.generic<T>((sbyte)(~ As.int8(src)));

        [MethodImpl(Inline)]
        public static T flipU8<T>(T src)
            => As.generic<T>((byte)(~ As.uint8(src)));

        [MethodImpl(Inline)]
        public static T flipI16<T>(T src)
            => As.generic<T>((short)(~ As.int16(src)));

        [MethodImpl(Inline)]
        public static T flipU16<T>(T src)
            => As.generic<T>((ushort)(~ As.uint16(src)));

        [MethodImpl(Inline)]
        public static T flipI32<T>(T src)
            => As.generic<T>(~ As.int32(src));
        
        [MethodImpl(Inline)]
        public static T flipU32<T>(T src)
            => As.generic<T>(~ As.uint32(src));

        [MethodImpl(Inline)]
        public static T flipI64<T>(T src)
            => As.generic<T>(~ As.int64(src));

        [MethodImpl(Inline)]
        public static T flipU64<T>(T src)
            => As.generic<T>(~ As.uint64(src));

        //! abs
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T absI8<T>(T src)
            => As.generic<T>(Math.Abs(As.int8(src)));

        [MethodImpl(Inline)]
        public static T absI16<T>(T src)
            => As.generic<T>(Math.Abs(As.int16(src)));

        [MethodImpl(Inline)]
        public static T absI32<T>(T src)
            => As.generic<T>(Math.Abs(As.int32(src)));
        
        [MethodImpl(Inline)]
        public static T absI64<T>(T src)
            => As.generic<T>(Math.Abs(As.int64(src)));

        [MethodImpl(Inline)]
        public static T absF32<T>(T src)
            => As.generic<T>(MathF.Abs(As.float32(src)));

        [MethodImpl(Inline)]
        public static T absF64<T>(T src)
            => As.generic<T>(Math.Abs(As.float64(src)));

    }

}