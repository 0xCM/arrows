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

        #region add

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

        #endregion

        #region sub

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

        #endregion

        #region mul
        
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

        #endregion

        #region div

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

        #endregion

        #region mod

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

        #endregion

        #region and

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

        #endregion

        #region or

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

        #endregion

        #region xor

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

        #endregion

        #region flip

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

        #endregion

        #region abs

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

        #endregion

        #region eq

        //! eq
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static bool eqI8<T>(T lhs, T rhs)
            => As.int8(lhs) == As.int8(rhs);

        [MethodImpl(Inline)]
        public static bool eqU8<T>(T lhs, T rhs)
            => As.uint8(lhs) == As.uint8(rhs);

        [MethodImpl(Inline)]
        public static bool eqI16<T>(T lhs, T rhs)
            => As.int16(lhs) == As.int16(rhs);

        [MethodImpl(Inline)]
        public static bool eqU16<T>(T lhs, T rhs)
            => As.uint16(lhs) == As.uint16(rhs);

        [MethodImpl(Inline)]
        public static bool eqI32<T>(T lhs, T rhs)
            => As.int32(lhs) == As.int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool eqU32<T>(T lhs, T rhs)
            => As.uint32(lhs) == As.uint32(rhs);

        [MethodImpl(Inline)]
        public static bool eqI64<T>(T lhs, T rhs)
            => As.int64(lhs) == As.int64(rhs);

        [MethodImpl(Inline)]
        public static bool eqU64<T>(T lhs, T rhs)
            => As.uint64(lhs) == As.uint64(rhs);

        [MethodImpl(Inline)]
        public static bool eqF32<T>(T lhs, T rhs)
            => As.float32(lhs) == As.float32(rhs);

        [MethodImpl(Inline)]
        public static bool eqF64<T>(T lhs, T rhs)
            => As.float64(lhs) == As.float64(rhs);

        #endregion
   
        #region neq

        //! neq
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static bool neqI8<T>(T lhs, T rhs)
            => As.int8(lhs) != As.int8(rhs);

        [MethodImpl(Inline)]
        public static bool neqU8<T>(T lhs, T rhs)
            => As.uint8(lhs) != As.uint8(rhs);

        [MethodImpl(Inline)]
        public static bool neqI16<T>(T lhs, T rhs)
            => As.int16(lhs) != As.int16(rhs);

        [MethodImpl(Inline)]
        public static bool neqU16<T>(T lhs, T rhs)
            => As.uint16(lhs) != As.uint16(rhs);

        [MethodImpl(Inline)]
        public static bool neqI32<T>(T lhs, T rhs)
            => As.int32(lhs) != As.int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool neqU32<T>(T lhs, T rhs)
            => As.uint32(lhs) != As.uint32(rhs);

        [MethodImpl(Inline)]
        public static bool neqI64<T>(T lhs, T rhs)
            => As.int64(lhs) != As.int64(rhs);

        [MethodImpl(Inline)]
        public static bool neqU64<T>(T lhs, T rhs)
            => As.uint64(lhs) != As.uint64(rhs);

        [MethodImpl(Inline)]
        public static bool neqF32<T>(T lhs, T rhs)
            => As.float32(lhs) != As.float32(rhs);

        [MethodImpl(Inline)]
        public static bool neqF64<T>(T lhs, T rhs)
            => As.float64(lhs) != As.float64(rhs);

        #endregion
 
        #region gt

        //! gt
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static bool gtI8<T>(T lhs, T rhs)
            => As.int8(lhs) > As.int8(rhs);

        [MethodImpl(Inline)]
        public static bool gtU8<T>(T lhs, T rhs)
            => As.uint8(lhs) > As.uint8(rhs);

        [MethodImpl(Inline)]
        public static bool gtI16<T>(T lhs, T rhs)
            => As.int16(lhs) > As.int16(rhs);

        [MethodImpl(Inline)]
        public static bool gtU16<T>(T lhs, T rhs)
            => As.uint16(lhs) > As.uint16(rhs);

        [MethodImpl(Inline)]
        public static bool gtI32<T>(T lhs, T rhs)
            => As.int32(lhs) > As.int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool gtU32<T>(T lhs, T rhs)
            => As.uint32(lhs) > As.uint32(rhs);

        [MethodImpl(Inline)]
        public static bool gtI64<T>(T lhs, T rhs)
            => As.int64(lhs) > As.int64(rhs);

        [MethodImpl(Inline)]
        public static bool gtU64<T>(T lhs, T rhs)
            => As.uint64(lhs) > As.uint64(rhs);

        [MethodImpl(Inline)]
        public static bool gtF32<T>(T lhs, T rhs)
            => As.float32(lhs) > As.float32(rhs);

        [MethodImpl(Inline)]
        public static bool gtF64<T>(T lhs, T rhs)
            => As.float64(lhs) > As.float64(rhs);

        #endregion
 
        #region gteq

        //! gteq
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static bool gteqI8<T>(T lhs, T rhs)
            => As.int8(lhs) >= As.int8(rhs);

        [MethodImpl(Inline)]
        public static bool gteqU8<T>(T lhs, T rhs)
            => As.uint8(lhs) >= As.uint8(rhs);

        [MethodImpl(Inline)]
        public static bool gteqI16<T>(T lhs, T rhs)
            => As.int16(lhs) >= As.int16(rhs);

        [MethodImpl(Inline)]
        public static bool gteqU16<T>(T lhs, T rhs)
            => As.uint16(lhs) >= As.uint16(rhs);

        [MethodImpl(Inline)]
        public static bool gteqI32<T>(T lhs, T rhs)
            => As.int32(lhs) >= As.int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool gteqU32<T>(T lhs, T rhs)
            => As.uint32(lhs) >= As.uint32(rhs);

        [MethodImpl(Inline)]
        public static bool gteqI64<T>(T lhs, T rhs)
            => As.int64(lhs) >= As.int64(rhs);

        [MethodImpl(Inline)]
        public static bool gteqU64<T>(T lhs, T rhs)
            => As.uint64(lhs) >= As.uint64(rhs);

        [MethodImpl(Inline)]
        public static bool gteqF32<T>(T lhs, T rhs)
            => As.float32(lhs) >= As.float32(rhs);

        [MethodImpl(Inline)]
        public static bool gteqF64<T>(T lhs, T rhs)
            => As.float64(lhs) >= As.float64(rhs);

        #endregion
 
        #region lt

        //! lt
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static bool ltI8<T>(T lhs, T rhs)
            => As.int8(lhs) < As.int8(rhs);

        [MethodImpl(Inline)]
        public static bool ltU8<T>(T lhs, T rhs)
            => As.uint8(lhs) < As.uint8(rhs);

        [MethodImpl(Inline)]
        public static bool ltI16<T>(T lhs, T rhs)
            => As.int16(lhs) < As.int16(rhs);

        [MethodImpl(Inline)]
        public static bool ltU16<T>(T lhs, T rhs)
            => As.uint16(lhs) < As.uint16(rhs);

        [MethodImpl(Inline)]
        public static bool ltI32<T>(T lhs, T rhs)
            => As.int32(lhs) < As.int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool ltU32<T>(T lhs, T rhs)
            => As.uint32(lhs) < As.uint32(rhs);

        [MethodImpl(Inline)]
        public static bool ltI64<T>(T lhs, T rhs)
            => As.int64(lhs) < As.int64(rhs);

        [MethodImpl(Inline)]
        public static bool ltU64<T>(T lhs, T rhs)
            => As.uint64(lhs) < As.uint64(rhs);

        [MethodImpl(Inline)]
        public static bool ltF32<T>(T lhs, T rhs)
            => As.float32(lhs) < As.float32(rhs);

        [MethodImpl(Inline)]
        public static bool ltF64<T>(T lhs, T rhs)
            => As.float64(lhs) < As.float64(rhs);

        #endregion
 
        #region lteq

        //! lteq
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static bool lteqI8<T>(T lhs, T rhs)
            => As.int8(lhs) <= As.int8(rhs);

        [MethodImpl(Inline)]
        public static bool lteqU8<T>(T lhs, T rhs)
            => As.uint8(lhs) <= As.uint8(rhs);

        [MethodImpl(Inline)]
        public static bool lteqI16<T>(T lhs, T rhs)
            => As.int16(lhs) <= As.int16(rhs);

        [MethodImpl(Inline)]
        public static bool lteqU16<T>(T lhs, T rhs)
            => As.uint16(lhs) <= As.uint16(rhs);

        [MethodImpl(Inline)]
        public static bool lteqI32<T>(T lhs, T rhs)
            => As.int32(lhs) <= As.int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool lteqU32<T>(T lhs, T rhs)
            => As.uint32(lhs) <= As.uint32(rhs);

        [MethodImpl(Inline)]
        public static bool lteqI64<T>(T lhs, T rhs)
            => As.int64(lhs) <= As.int64(rhs);

        [MethodImpl(Inline)]
        public static bool lteqU64<T>(T lhs, T rhs)
            => As.uint64(lhs) <= As.uint64(rhs);

        [MethodImpl(Inline)]
        public static bool lteqF32<T>(T lhs, T rhs)
            => As.float32(lhs) <= As.float32(rhs);

        [MethodImpl(Inline)]
        public static bool lteqF64<T>(T lhs, T rhs)
            => As.float64(lhs) <= As.float64(rhs);

        #endregion

        #region pow

        //! pow
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T powU8<T>(T src, uint exp)
            => As.generic<T>(math.pow(As.int8(src), exp));

        [MethodImpl(Inline)]
        public static T powI8<T>(T src, uint exp)
            => As.generic<T>(math.pow(As.uint8(src), exp));

        [MethodImpl(Inline)]
        public static T powI16<T>(T src, uint exp)
            => As.generic<T>(math.pow(As.int16(src), exp));

        [MethodImpl(Inline)]
        public static T powU16<T>(T src, uint exp)
            => As.generic<T>(math.pow(As.uint16(src), exp));

        [MethodImpl(Inline)]
        public static T powI32<T>(T src, uint exp)
            => As.generic<T>(math.pow(As.int32(src), exp));
        
        [MethodImpl(Inline)]
        public static T powU32<T>(T src, uint exp)
            => As.generic<T>(math.pow(As.uint32(src), exp));

        [MethodImpl(Inline)]
        public static T powI64<T>(T src, uint exp)
            => As.generic<T>(math.pow(As.int64(src), exp));

        [MethodImpl(Inline)]
        public static T powU64<T>(T src, uint exp)
            => As.generic<T>(math.pow(As.uint64(src), exp));

        [MethodImpl(Inline)]
        public static T powF32<T>(T src, uint exp)
            => As.generic<T>(math.pow(As.float32(src), exp));

        [MethodImpl(Inline)]
        public static T powF64<T>(T src, uint exp)
            => As.generic<T>(math.pow(As.float64(src), exp));

        [MethodImpl(Inline)]
        public static T powF32<T>(T src, T exp)
            => As.generic<T>(math.pow(As.float32(src), As.float32(exp)));

        [MethodImpl(Inline)]
        public static T powF64<T>(T src, T exp)
            => As.generic<T>(math.pow(As.float64(src), As.float64(exp)));

        #endregion
 
        #region inc

        //! inc
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T incI8<T>(T src)
            => As.generic<T>((sbyte)(As.int8(src) + 1));

        [MethodImpl(Inline)]
        public static T incU8<T>(T src)
            => As.generic<T>((byte)(As.uint8(src) + 1));

        [MethodImpl(Inline)]
        public static T incI16<T>(T src)
            => As.generic<T>((short)(As.int16(src) + 1));

        [MethodImpl(Inline)]
        public static T incU16<T>(T src)
            => As.generic<T>((ushort)(As.uint16(src) + 1));

        [MethodImpl(Inline)]
        public static T incI32<T>(T src)
            => As.generic<T>(As.int32(src) + 1);
        
        [MethodImpl(Inline)]
        public static T incU32<T>(T src)
            => As.generic<T>(As.uint32(src) + 1);

        [MethodImpl(Inline)]
        public static T incI64<T>(T src)
            => As.generic<T>(As.int64(src) + 1);

        [MethodImpl(Inline)]
        public static T incU64<T>(T src)
            => As.generic<T>(As.uint64(src) + 1);

        [MethodImpl(Inline)]
        public static T incF32<T>(T src)
            => As.generic<T>(As.float32(src) + 1);

        [MethodImpl(Inline)]
        public static T incF64<T>(T src)
            => As.generic<T>(As.float64(src) + 1);

        #endregion

        #region dec

        //! dec
        //!--------------------------------------------------------------------


        [MethodImpl(Inline)]
        public static T decI8<T>(T src)
            => As.generic<T>((sbyte)(As.int8(src)- 1));

        [MethodImpl(Inline)]
        public static T decU8<T>(T src)
            => As.generic<T>((byte)(As.uint8(src) - 1));

        [MethodImpl(Inline)]
        public static T decI16<T>(T src)
            => As.generic<T>((short)(As.int16(src) - 1));

        [MethodImpl(Inline)]
        public static T decU16<T>(T src)
            => As.generic<T>((ushort)(As.uint16(src) - 1));

        [MethodImpl(Inline)]
        public static T decI32<T>(T src)
            => As.generic<T>(As.int32(src) - 1);
        
        [MethodImpl(Inline)]
        public static T decU32<T>(T src)
            => As.generic<T>(As.uint32(src) - 1);

        [MethodImpl(Inline)]
        public static T decI64<T>(T src)
            => As.generic<T>(As.int64(src) - 1);

        [MethodImpl(Inline)]
        public static T decU64<T>(T src)
            => As.generic<T>(As.uint64(src) - 1);

        [MethodImpl(Inline)]
        public static T decF32<T>(T src)
            => As.generic<T>(As.float32(src) - 1);

        [MethodImpl(Inline)]
        public static T decF64<T>(T src)
            => As.generic<T>(As.float64(src) - 1);

        #endregion

        #region negate

        //! negate
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T negateI8<T>(T src)
            => As.generic<T>((sbyte)(- As.int8(src)));


        [MethodImpl(Inline)]
        public static T negateI16<T>(T src)
            => As.generic<T>((short)(- As.int16(src)));


        [MethodImpl(Inline)]
        public static T negateI32<T>(T src)
            => As.generic<T>(- As.int32(src));
        

        [MethodImpl(Inline)]
        public static T negateI64<T>(T src)
            => As.generic<T>(- As.int64(src));


        [MethodImpl(Inline)]
        public static T negateF32<T>(T src)
            => As.generic<T>(- As.float32(src));

        [MethodImpl(Inline)]
        public static T negateF64<T>(T src)
            => As.generic<T>(- As.float64(src));

        #endregion

        #region max
        
        //! max
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T maxI8<T>(T lhs, T rhs)
            => As.generic<T>((Math.Max(As.int8(lhs), As.int8(rhs))));

        [MethodImpl(Inline)]
        public static T maxU8<T>(T lhs, T rhs)
            => As.generic<T>((Math.Max(As.uint8(lhs), As.uint8(rhs))));

        [MethodImpl(Inline)]
        public static T maxI16<T>(T lhs, T rhs)
            => As.generic<T>((Math.Max(As.int16(lhs), As.int16(rhs))));

        [MethodImpl(Inline)]
        public static T maxU16<T>(T lhs, T rhs)
            => As.generic<T>((Math.Max(As.uint16(lhs), As.int16(rhs))));

        [MethodImpl(Inline)]
        public static T maxI32<T>(T lhs, T rhs)
            => As.generic<T>((Math.Max(As.int32(lhs), As.int32(rhs))));

        [MethodImpl(Inline)]
        public static T maxU32<T>(T lhs, T rhs)
            => As.generic<T>((Math.Max(As.uint32(lhs), As.int32(rhs))));

        [MethodImpl(Inline)]
        public static T maxI64<T>(T lhs, T rhs)
            => As.generic<T>((Math.Max(As.int64(lhs), As.int64(rhs))));

        [MethodImpl(Inline)]
        public static T maxU64<T>(T lhs, T rhs)
            => As.generic<T>((Math.Max(As.uint64(lhs), As.uint64(rhs))));

        [MethodImpl(Inline)]
        public static T maxF32<T>(T lhs, T rhs)
            => As.generic<T>((MathF.Max(As.float32(lhs), As.float32(rhs))));

        [MethodImpl(Inline)]
        public static T maxF64<T>(T lhs, T rhs)
            => As.generic<T>((Math.Max(As.float64(lhs), As.float64(rhs))));

        #endregion

        #region min
        
        //! min
        //!--------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static T minI8<T>(T lhs, T rhs)
            => As.generic<T>((Math.Min(As.int8(lhs), As.int8(rhs))));

        [MethodImpl(Inline)]
        public static T minU8<T>(T lhs, T rhs)
            => As.generic<T>((Math.Min(As.uint8(lhs), As.uint8(rhs))));

        [MethodImpl(Inline)]
        public static T minI16<T>(T lhs, T rhs)
            => As.generic<T>((Math.Min(As.int16(lhs), As.int16(rhs))));

        [MethodImpl(Inline)]
        public static T minU16<T>(T lhs, T rhs)
            => As.generic<T>((Math.Min(As.uint16(lhs), As.int16(rhs))));

        [MethodImpl(Inline)]
        public static T minI32<T>(T lhs, T rhs)
            => As.generic<T>((Math.Min(As.int32(lhs), As.int32(rhs))));

        [MethodImpl(Inline)]
        public static T minU32<T>(T lhs, T rhs)
            => As.generic<T>((Math.Min(As.uint32(lhs), As.int32(rhs))));

        [MethodImpl(Inline)]
        public static T minI64<T>(T lhs, T rhs)
            => As.generic<T>((Math.Min(As.int64(lhs), As.int64(rhs))));

        [MethodImpl(Inline)]
        public static T minU64<T>(T lhs, T rhs)
            => As.generic<T>((Math.Min(As.uint64(lhs), As.uint64(rhs))));

        [MethodImpl(Inline)]
        public static T minF32<T>(T lhs, T rhs)
            => As.generic<T>((MathF.Min(As.float32(lhs), As.float32(rhs))));

        [MethodImpl(Inline)]
        public static T minF64<T>(T lhs, T rhs)
            => As.generic<T>((Math.Min(As.float64(lhs), As.float64(rhs))));

        #endregion


        #region trig

        [MethodImpl(Inline)]
        public static T sinF32<T>(T src)
            => As.generic<T>(MathF.Sin(As.float32(src)));

        [MethodImpl(Inline)]
        public static T sinF64<T>(T src)
            => As.generic<T>(Math.Sin(As.float64(src)));

        [MethodImpl(Inline)]
        public static T cosF32<T>(T src)
            => As.generic<T>(MathF.Cos(As.float32(src)));

        [MethodImpl(Inline)]
        public static T cosF64<T>(T src)
            => As.generic<T>(Math.Cos(As.float64(src)));

        [MethodImpl(Inline)]
        public static T tanF32<T>(T src)
            => As.generic<T>(MathF.Tan(As.float32(src)));

        [MethodImpl(Inline)]
        public static T tanF64<T>(T src)
            => As.generic<T>(Math.Cos(As.float64(src)));

        #endregion

        #region special

        [MethodImpl(Inline)]
        public static T ceilingF32<T>(T src)
            => As.generic<T>(MathF.Ceiling(As.float32(src)));

        [MethodImpl(Inline)]
        public static T ceilingF64<T>(T src)
            => As.generic<T>(Math.Ceiling(As.float64(src)));

        #endregion

    }

}