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
    
    
    using static mfunc;
    using static As;

    public static class atoms
    {

        #region add

        [MethodImpl(Inline)]
        public static T addI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) + int8(rhs)));

        [MethodImpl(Inline)]
        public static T addU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) + uint8(rhs)));

        [MethodImpl(Inline)]
        public static T addI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) + int16(rhs)));

        [MethodImpl(Inline)]
        public static T addU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) + uint16(rhs)));

        [MethodImpl(Inline)]
        public static T addI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) + int32(rhs));
        
        [MethodImpl(Inline)]
        public static T addU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) + uint32(rhs));

        [MethodImpl(Inline)]
        public static T addI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) + int64(rhs));

        [MethodImpl(Inline)]
        public static T addU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) + uint64(rhs));

        [MethodImpl(Inline)]
        public static T addF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) + float32(rhs));

        [MethodImpl(Inline)]
        public static T addF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) + float64(rhs));

        [MethodImpl(Inline)]
        public static T addF64<T>(ref T lhs, ref T rhs)
            => generic<T>(float64(lhs) + float64(rhs));


        #endregion

        #region sub


        [MethodImpl(Inline)]
        public static T subI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) - int8(rhs)));

        [MethodImpl(Inline)]
        public static T subU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) - uint8(rhs)));

        [MethodImpl(Inline)]
        public static T subI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) - int16(rhs)));

        [MethodImpl(Inline)]
        public static T subU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) - uint16(rhs)));

        [MethodImpl(Inline)]
        public static T subI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) - int32(rhs));
        
        [MethodImpl(Inline)]
        public static T subU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) - uint32(rhs));

        [MethodImpl(Inline)]
        public static T subI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) - int64(rhs));

        [MethodImpl(Inline)]
        public static T subU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) - uint64(rhs));

        [MethodImpl(Inline)]
        public static T subF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) - float32(rhs));

        [MethodImpl(Inline)]
        public static T subF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) - float64(rhs));

        #endregion

        #region mul
        

        [MethodImpl(Inline)]
        public static T mulI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) * int8(rhs)));

        [MethodImpl(Inline)]
        public static T mulU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) * uint8(rhs)));

        [MethodImpl(Inline)]
        public static T mulI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) * int16(rhs)));

        [MethodImpl(Inline)]
        public static T mulU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) * uint16(rhs)));

        [MethodImpl(Inline)]
        public static T mulI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) * int32(rhs));
        
        [MethodImpl(Inline)]
        public static T mulU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) * uint32(rhs));

        [MethodImpl(Inline)]
        public static T mulI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) * int64(rhs));

        [MethodImpl(Inline)]
        public static T mulU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) * uint64(rhs));

        [MethodImpl(Inline)]
        public static T mulF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) * float32(rhs));

        [MethodImpl(Inline)]
        public static T mulF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) * float64(rhs));

        #endregion

        #region div


        [MethodImpl(Inline)]
        public static T divI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) / int8(rhs)));

        [MethodImpl(Inline)]
        public static T divU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) / uint8(rhs)));

        [MethodImpl(Inline)]
        public static T divI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) / int16(rhs)));

        [MethodImpl(Inline)]
        public static T divU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) / uint16(rhs)));

        [MethodImpl(Inline)]
        public static T divI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) / int32(rhs));
        
        [MethodImpl(Inline)]
        public static T divU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) / uint32(rhs));

        [MethodImpl(Inline)]
        public static T divI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) / int64(rhs));

        [MethodImpl(Inline)]
        public static T divU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) / uint64(rhs));

        [MethodImpl(Inline)]
        public static T divF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) / float32(rhs));

        [MethodImpl(Inline)]
        public static T divF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) / float64(rhs));

        #endregion

        #region mod


        [MethodImpl(Inline)]
        public static T modI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) % int8(rhs)));

        [MethodImpl(Inline)]
        public static T modU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) % uint8(rhs)));

        [MethodImpl(Inline)]
        public static T modI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) % int16(rhs)));

        [MethodImpl(Inline)]
        public static T modU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) % uint16(rhs)));

        [MethodImpl(Inline)]
        public static T modI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) % int32(rhs));
        
        [MethodImpl(Inline)]
        public static T modU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) % uint32(rhs));

        [MethodImpl(Inline)]
        public static T modI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) % int64(rhs));

        [MethodImpl(Inline)]
        public static T modU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) % uint64(rhs));

        [MethodImpl(Inline)]
        public static T modF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) % float32(rhs));

        [MethodImpl(Inline)]
        public static T modF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) % float64(rhs));

        #endregion

        #region and


        [MethodImpl(Inline)]
        public static T andI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) & int8(rhs)));

        [MethodImpl(Inline)]
        public static T andU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) & uint8(rhs)));

        [MethodImpl(Inline)]
        public static T andI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) & int16(rhs)));

        [MethodImpl(Inline)]
        public static T andU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) & uint16(rhs)));

        [MethodImpl(Inline)]
        public static T andI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) & int32(rhs));
        
        [MethodImpl(Inline)]
        public static T andU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) & uint32(rhs));

        [MethodImpl(Inline)]
        public static T andI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) & int64(rhs));

        [MethodImpl(Inline)]
        public static T andU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) & uint64(rhs));

        #endregion

        #region or

        [MethodImpl(Inline)]
        public static T orI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) | int8(rhs)));

        [MethodImpl(Inline)]
        public static T orU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) | uint8(rhs)));

        [MethodImpl(Inline)]
        public static T orI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) | int16(rhs)));

        [MethodImpl(Inline)]
        public static T orU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) | uint16(rhs)));

        [MethodImpl(Inline)]
        public static T orI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) | int32(rhs));
        
        [MethodImpl(Inline)]
        public static T orU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) | uint32(rhs));

        [MethodImpl(Inline)]
        public static T orI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) | int64(rhs));

        [MethodImpl(Inline)]
        public static T orU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) | uint64(rhs));

        #endregion

        #region xor

        [MethodImpl(Inline)]
        public static T xorI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) ^ int8(rhs)));

        [MethodImpl(Inline)]
        public static T xorU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) ^ uint8(rhs)));

        [MethodImpl(Inline)]
        public static T xorI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) ^ int16(rhs)));

        [MethodImpl(Inline)]
        public static T xorU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) ^ uint16(rhs)));

        [MethodImpl(Inline)]
        public static T xorI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) ^ int32(rhs));
        
        [MethodImpl(Inline)]
        public static T xorU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) ^ uint32(rhs));

        [MethodImpl(Inline)]
        public static T xorI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) ^ int64(rhs));

        [MethodImpl(Inline)]
        public static T xorU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) ^ uint64(rhs));

        #endregion

        #region flip

        [MethodImpl(Inline)]
        public static T flipI8<T>(T src)
            => generic<T>((sbyte)(~ int8(src)));

        [MethodImpl(Inline)]
        public static T flipU8<T>(T src)
            => generic<T>((byte)(~ uint8(src)));

        [MethodImpl(Inline)]
        public static T flipI16<T>(T src)
            => generic<T>((short)(~ int16(src)));

        [MethodImpl(Inline)]
        public static T flipU16<T>(T src)
            => generic<T>((ushort)(~ uint16(src)));

        [MethodImpl(Inline)]
        public static T flipI32<T>(T src)
            => generic<T>(~ int32(src));
        
        [MethodImpl(Inline)]
        public static T flipU32<T>(T src)
            => generic<T>(~ uint32(src));

        [MethodImpl(Inline)]
        public static T flipI64<T>(T src)
            => generic<T>(~ int64(src));

        [MethodImpl(Inline)]
        public static T flipU64<T>(T src)
            => generic<T>(~ uint64(src));

        #endregion

        #region abs


        [MethodImpl(Inline)]
        public static T absI8<T>(T src)
            => generic<T>(Math.Abs(int8(src)));

        [MethodImpl(Inline)]
        public static T absI16<T>(T src)
            => generic<T>(Math.Abs(int16(src)));

        [MethodImpl(Inline)]
        public static T absI32<T>(T src)
            => generic<T>(Math.Abs(int32(src)));
        
        [MethodImpl(Inline)]
        public static T absI64<T>(T src)
            => generic<T>(Math.Abs(int64(src)));

        [MethodImpl(Inline)]
        public static T absF32<T>(T src)
            => generic<T>(MathF.Abs(float32(src)));

        [MethodImpl(Inline)]
        public static T absF64<T>(T src)
            => generic<T>(Math.Abs(float64(src)));

        #endregion

        #region eq

        [MethodImpl(Inline)]
        public static bool eqI8<T>(T lhs, T rhs)
            => int8(lhs) == int8(rhs);

        [MethodImpl(Inline)]
        public static bool eqU8<T>(T lhs, T rhs)
            => uint8(lhs) == uint8(rhs);

        [MethodImpl(Inline)]
        public static bool eqI16<T>(T lhs, T rhs)
            => int16(lhs) == int16(rhs);

        [MethodImpl(Inline)]
        public static bool eqU16<T>(T lhs, T rhs)
            => uint16(lhs) == uint16(rhs);

        [MethodImpl(Inline)]
        public static bool eqI32<T>(T lhs, T rhs)
            => int32(lhs) == int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool eqU32<T>(T lhs, T rhs)
            => uint32(lhs) == uint32(rhs);

        [MethodImpl(Inline)]
        public static bool eqI64<T>(T lhs, T rhs)
            => int64(lhs) == int64(rhs);

        [MethodImpl(Inline)]
        public static bool eqU64<T>(T lhs, T rhs)
            => uint64(lhs) == uint64(rhs);

        [MethodImpl(Inline)]
        public static bool eqF32<T>(T lhs, T rhs)
            => float32(lhs) == float32(rhs);

        [MethodImpl(Inline)]
        public static bool eqF64<T>(T lhs, T rhs)
            => float64(lhs) == float64(rhs);

        #endregion
   
        #region neq


        [MethodImpl(Inline)]
        public static bool neqI8<T>(T lhs, T rhs)
            => int8(lhs) != int8(rhs);

        [MethodImpl(Inline)]
        public static bool neqU8<T>(T lhs, T rhs)
            => uint8(lhs) != uint8(rhs);

        [MethodImpl(Inline)]
        public static bool neqI16<T>(T lhs, T rhs)
            => int16(lhs) != int16(rhs);

        [MethodImpl(Inline)]
        public static bool neqU16<T>(T lhs, T rhs)
            => uint16(lhs) != uint16(rhs);

        [MethodImpl(Inline)]
        public static bool neqI32<T>(T lhs, T rhs)
            => int32(lhs) != int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool neqU32<T>(T lhs, T rhs)
            => uint32(lhs) != uint32(rhs);

        [MethodImpl(Inline)]
        public static bool neqI64<T>(T lhs, T rhs)
            => int64(lhs) != int64(rhs);

        [MethodImpl(Inline)]
        public static bool neqU64<T>(T lhs, T rhs)
            => uint64(lhs) != uint64(rhs);

        [MethodImpl(Inline)]
        public static bool neqF32<T>(T lhs, T rhs)
            => float32(lhs) != float32(rhs);

        [MethodImpl(Inline)]
        public static bool neqF64<T>(T lhs, T rhs)
            => float64(lhs) != float64(rhs);

        #endregion
 
        #region gt

        [MethodImpl(Inline)]
        public static bool gtI8<T>(T lhs, T rhs)
            => int8(lhs) > int8(rhs);

        [MethodImpl(Inline)]
        public static bool gtU8<T>(T lhs, T rhs)
            => uint8(lhs) > uint8(rhs);

        [MethodImpl(Inline)]
        public static bool gtI16<T>(T lhs, T rhs)
            => int16(lhs) > int16(rhs);

        [MethodImpl(Inline)]
        public static bool gtU16<T>(T lhs, T rhs)
            => uint16(lhs) > uint16(rhs);

        [MethodImpl(Inline)]
        public static bool gtI32<T>(T lhs, T rhs)
            => int32(lhs) > int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool gtU32<T>(T lhs, T rhs)
            => uint32(lhs) > uint32(rhs);

        [MethodImpl(Inline)]
        public static bool gtI64<T>(T lhs, T rhs)
            => int64(lhs) > int64(rhs);

        [MethodImpl(Inline)]
        public static bool gtU64<T>(T lhs, T rhs)
            => uint64(lhs) > uint64(rhs);

        [MethodImpl(Inline)]
        public static bool gtF32<T>(T lhs, T rhs)
            => float32(lhs) > float32(rhs);

        [MethodImpl(Inline)]
        public static bool gtF64<T>(T lhs, T rhs)
            => float64(lhs) > float64(rhs);

        #endregion
 
        #region gteq


        [MethodImpl(Inline)]
        public static bool gteqI8<T>(T lhs, T rhs)
            => int8(lhs) >= int8(rhs);

        [MethodImpl(Inline)]
        public static bool gteqU8<T>(T lhs, T rhs)
            => uint8(lhs) >= uint8(rhs);

        [MethodImpl(Inline)]
        public static bool gteqI16<T>(T lhs, T rhs)
            => int16(lhs) >= int16(rhs);

        [MethodImpl(Inline)]
        public static bool gteqU16<T>(T lhs, T rhs)
            => uint16(lhs) >= uint16(rhs);

        [MethodImpl(Inline)]
        public static bool gteqI32<T>(T lhs, T rhs)
            => int32(lhs) >= int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool gteqU32<T>(T lhs, T rhs)
            => uint32(lhs) >= uint32(rhs);

        [MethodImpl(Inline)]
        public static bool gteqI64<T>(T lhs, T rhs)
            => int64(lhs) >= int64(rhs);

        [MethodImpl(Inline)]
        public static bool gteqU64<T>(T lhs, T rhs)
            => uint64(lhs) >= uint64(rhs);

        [MethodImpl(Inline)]
        public static bool gteqF32<T>(T lhs, T rhs)
            => float32(lhs) >= float32(rhs);

        [MethodImpl(Inline)]
        public static bool gteqF64<T>(T lhs, T rhs)
            => float64(lhs) >= float64(rhs);

        #endregion
 
        #region lt


        [MethodImpl(Inline)]
        public static bool ltI8<T>(T lhs, T rhs)
            => int8(lhs) < int8(rhs);

        [MethodImpl(Inline)]
        public static bool ltU8<T>(T lhs, T rhs)
            => uint8(lhs) < uint8(rhs);

        [MethodImpl(Inline)]
        public static bool ltI16<T>(T lhs, T rhs)
            => int16(lhs) < int16(rhs);

        [MethodImpl(Inline)]
        public static bool ltU16<T>(T lhs, T rhs)
            => uint16(lhs) < uint16(rhs);

        [MethodImpl(Inline)]
        public static bool ltI32<T>(T lhs, T rhs)
            => int32(lhs) < int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool ltU32<T>(T lhs, T rhs)
            => uint32(lhs) < uint32(rhs);

        [MethodImpl(Inline)]
        public static bool ltI64<T>(T lhs, T rhs)
            => int64(lhs) < int64(rhs);

        [MethodImpl(Inline)]
        public static bool ltU64<T>(T lhs, T rhs)
            => uint64(lhs) < uint64(rhs);

        [MethodImpl(Inline)]
        public static bool ltF32<T>(T lhs, T rhs)
            => float32(lhs) < float32(rhs);

        [MethodImpl(Inline)]
        public static bool ltF64<T>(T lhs, T rhs)
            => float64(lhs) < float64(rhs);

        #endregion
 
        #region lteq


        [MethodImpl(Inline)]
        public static bool lteqI8<T>(T lhs, T rhs)
            => int8(lhs) <= int8(rhs);

        [MethodImpl(Inline)]
        public static bool lteqU8<T>(T lhs, T rhs)
            => uint8(lhs) <= uint8(rhs);

        [MethodImpl(Inline)]
        public static bool lteqI16<T>(T lhs, T rhs)
            => int16(lhs) <= int16(rhs);

        [MethodImpl(Inline)]
        public static bool lteqU16<T>(T lhs, T rhs)
            => uint16(lhs) <= uint16(rhs);

        [MethodImpl(Inline)]
        public static bool lteqI32<T>(T lhs, T rhs)
            => int32(lhs) <= int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool lteqU32<T>(T lhs, T rhs)
            => uint32(lhs) <= uint32(rhs);

        [MethodImpl(Inline)]
        public static bool lteqI64<T>(T lhs, T rhs)
            => int64(lhs) <= int64(rhs);

        [MethodImpl(Inline)]
        public static bool lteqU64<T>(T lhs, T rhs)
            => uint64(lhs) <= uint64(rhs);

        [MethodImpl(Inline)]
        public static bool lteqF32<T>(T lhs, T rhs)
            => float32(lhs) <= float32(rhs);

        [MethodImpl(Inline)]
        public static bool lteqF64<T>(T lhs, T rhs)
            => float64(lhs) <= float64(rhs);

        #endregion

        #region pow


        [MethodImpl(Inline)]
        public static T powU8<T>(T src, uint exp)
            => generic<T>(math.pow(int8(src), exp));

        [MethodImpl(Inline)]
        public static T powI8<T>(T src, uint exp)
            => generic<T>(math.pow(uint8(src), exp));

        [MethodImpl(Inline)]
        public static T powI16<T>(T src, uint exp)
            => generic<T>(math.pow(int16(src), exp));

        [MethodImpl(Inline)]
        public static T powU16<T>(T src, uint exp)
            => generic<T>(math.pow(uint16(src), exp));

        [MethodImpl(Inline)]
        public static T powI32<T>(T src, uint exp)
            => generic<T>(math.pow(int32(src), exp));
        
        [MethodImpl(Inline)]
        public static T powU32<T>(T src, uint exp)
            => generic<T>(math.pow(uint32(src), exp));

        [MethodImpl(Inline)]
        public static T powI64<T>(T src, uint exp)
            => generic<T>(math.pow(int64(src), exp));

        [MethodImpl(Inline)]
        public static T powU64<T>(T src, uint exp)
            => generic<T>(math.pow(uint64(src), exp));

        [MethodImpl(Inline)]
        public static T powF32<T>(T src, uint exp)
            => generic<T>(math.pow(float32(src), exp));

        [MethodImpl(Inline)]
        public static T powF64<T>(T src, uint exp)
            => generic<T>(math.pow(float64(src), exp));

        [MethodImpl(Inline)]
        public static T powF32<T>(T src, T exp)
            => generic<T>(math.pow(float32(src), float32(exp)));

        [MethodImpl(Inline)]
        public static T powF64<T>(T src, T exp)
            => generic<T>(math.pow(float64(src), float64(exp)));

        #endregion
 
        #region inc


        [MethodImpl(Inline)]
        public static T incI8<T>(T src)
            => generic<T>((sbyte)(int8(src) + 1));

        [MethodImpl(Inline)]
        public static T incU8<T>(T src)
            => generic<T>((byte)(uint8(src) + 1));

        [MethodImpl(Inline)]
        public static T incI16<T>(T src)
            => generic<T>((short)(int16(src) + 1));

        [MethodImpl(Inline)]
        public static T incU16<T>(T src)
            => generic<T>((ushort)(uint16(src) + 1));

        [MethodImpl(Inline)]
        public static T incI32<T>(T src)
            => generic<T>(int32(src) + 1);
        
        [MethodImpl(Inline)]
        public static T incU32<T>(T src)
            => generic<T>(uint32(src) + 1);

        [MethodImpl(Inline)]
        public static T incI64<T>(T src)
            => generic<T>(int64(src) + 1);

        [MethodImpl(Inline)]
        public static T incU64<T>(T src)
            => generic<T>(uint64(src) + 1);

        [MethodImpl(Inline)]
        public static T incF32<T>(T src)
            => generic<T>(float32(src) + 1);

        [MethodImpl(Inline)]
        public static T incF64<T>(T src)
            => generic<T>(float64(src) + 1);

        #endregion

        #region dec


        [MethodImpl(Inline)]
        public static T decI8<T>(T src)
            => generic<T>((sbyte)(int8(src)- 1));

        [MethodImpl(Inline)]
        public static T decU8<T>(T src)
            => generic<T>((byte)(uint8(src) - 1));

        [MethodImpl(Inline)]
        public static T decI16<T>(T src)
            => generic<T>((short)(int16(src) - 1));

        [MethodImpl(Inline)]
        public static T decU16<T>(T src)
            => generic<T>((ushort)(uint16(src) - 1));

        [MethodImpl(Inline)]
        public static T decI32<T>(T src)
            => generic<T>(int32(src) - 1);
        
        [MethodImpl(Inline)]
        public static T decU32<T>(T src)
            => generic<T>(uint32(src) - 1);

        [MethodImpl(Inline)]
        public static T decI64<T>(T src)
            => generic<T>(int64(src) - 1);

        [MethodImpl(Inline)]
        public static T decU64<T>(T src)
            => generic<T>(uint64(src) - 1);

        [MethodImpl(Inline)]
        public static T decF32<T>(T src)
            => generic<T>(float32(src) - 1);

        [MethodImpl(Inline)]
        public static T decF64<T>(T src)
            => generic<T>(float64(src) - 1);

        #endregion

        #region negate


        [MethodImpl(Inline)]
        public static T negateI8<T>(T src)
            => generic<T>((sbyte)(- int8(src)));


        [MethodImpl(Inline)]
        public static T negateI16<T>(T src)
            => generic<T>((short)(- int16(src)));


        [MethodImpl(Inline)]
        public static T negateI32<T>(T src)
            => generic<T>(- int32(src));
        

        [MethodImpl(Inline)]
        public static T negateI64<T>(T src)
            => generic<T>(- int64(src));


        [MethodImpl(Inline)]
        public static T negateF32<T>(T src)
            => generic<T>(- float32(src));

        [MethodImpl(Inline)]
        public static T negateF64<T>(T src)
            => generic<T>(- float64(src));

        #endregion

        #region max
        
        [MethodImpl(Inline)]
        public static T maxI8<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int8(lhs), int8(rhs))));

        [MethodImpl(Inline)]
        public static T maxU8<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint8(lhs), uint8(rhs))));

        [MethodImpl(Inline)]
        public static T maxI16<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        public static T maxU16<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        public static T maxI32<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        public static T maxU32<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        public static T maxI64<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int64(lhs), int64(rhs))));

        [MethodImpl(Inline)]
        public static T maxU64<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint64(lhs), uint64(rhs))));

        [MethodImpl(Inline)]
        public static T maxF32<T>(T lhs, T rhs)
            => generic<T>((MathF.Max(float32(lhs), float32(rhs))));

        [MethodImpl(Inline)]
        public static T maxF64<T>(T lhs, T rhs)
            => generic<T>((Math.Max(float64(lhs), float64(rhs))));

        #endregion

        #region min
        
        [MethodImpl(Inline)]
        public static T minI8<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int8(lhs), int8(rhs))));

        [MethodImpl(Inline)]
        public static T minU8<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint8(lhs), uint8(rhs))));

        [MethodImpl(Inline)]
        public static T minI16<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        public static T minU16<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        public static T minI32<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        public static T minU32<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        public static T minI64<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int64(lhs), int64(rhs))));

        [MethodImpl(Inline)]
        public static T minU64<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint64(lhs), uint64(rhs))));

        [MethodImpl(Inline)]
        public static T minF32<T>(T lhs, T rhs)
            => generic<T>((MathF.Min(float32(lhs), float32(rhs))));

        [MethodImpl(Inline)]
        public static T minF64<T>(T lhs, T rhs)
            => generic<T>((Math.Min(float64(lhs), float64(rhs))));

        #endregion

        #region trig

        [MethodImpl(Inline)]
        public static T sinF32<T>(T src)
            => generic<T>(MathF.Sin(float32(src)));

        [MethodImpl(Inline)]
        public static T sinF64<T>(T src)
            => generic<T>(Math.Sin(float64(src)));

        [MethodImpl(Inline)]
        public static T cosF32<T>(T src)
            => generic<T>(MathF.Cos(float32(src)));

        [MethodImpl(Inline)]
        public static T cosF64<T>(T src)
            => generic<T>(Math.Cos(float64(src)));

        [MethodImpl(Inline)]
        public static T tanF32<T>(T src)
            => generic<T>(MathF.Tan(float32(src)));

        [MethodImpl(Inline)]
        public static T tanF64<T>(T src)
            => generic<T>(Math.Cos(float64(src)));

        #endregion

        #region special

        [MethodImpl(Inline)]
        public static T ceilingF32<T>(T src)
            => generic<T>(MathF.Ceiling(float32(src)));

        [MethodImpl(Inline)]
        public static T ceilingF64<T>(T src)
            => generic<T>(Math.Ceiling(float64(src)));

        #endregion

    }

}