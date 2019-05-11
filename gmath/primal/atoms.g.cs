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

    public static partial class atoms
    {

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

        #region lshift

        [MethodImpl(Inline)]
        public static T lshiftI8<T>(T lhs, int rhs)
            => generic<T>((sbyte)(int8(lhs) << rhs));

        [MethodImpl(Inline)]
        public static T lshiftU8<T>(T lhs, int rhs)
            => generic<T>((byte)(uint8(lhs) << rhs));

        [MethodImpl(Inline)]
        public static T lshiftI16<T>(T lhs, int rhs)
            => generic<T>((short)(int16(lhs) << rhs));

        [MethodImpl(Inline)]
        public static T lshiftU16<T>(T lhs, int rhs)
            => generic<T>((ushort)(uint16(lhs) << rhs));

        [MethodImpl(Inline)]
        public static T lshiftI32<T>(T lhs, int rhs)
            => generic<T>(int32(lhs) << rhs);
        
        [MethodImpl(Inline)]
        public static T lshiftU32<T>(T lhs, int rhs)
            => generic<T>(uint32(lhs) << rhs);

        [MethodImpl(Inline)]
        public static T lshiftI64<T>(T lhs, int rhs)
            => generic<T>(int64(lhs)  << rhs);

        [MethodImpl(Inline)]
        public static T lshiftU64<T>(T lhs, int rhs)
            => generic<T>(uint64(lhs)  << rhs);


        #endregion

        #region lshift

        [MethodImpl(Inline)]
        public static T rshiftI8<T>(T lhs, int rhs)
            => generic<T>((sbyte)(int8(lhs) >> rhs));

        [MethodImpl(Inline)]
        public static T rshiftU8<T>(T lhs, int rhs)
            => generic<T>((byte)(uint8(lhs) >> rhs));

        [MethodImpl(Inline)]
        public static T rshiftI16<T>(T lhs, int rhs)
            => generic<T>((short)(int16(lhs) >> rhs));

        [MethodImpl(Inline)]
        public static T rshiftU16<T>(T lhs, int rhs)
            => generic<T>((ushort)(uint16(lhs) >> rhs));

        [MethodImpl(Inline)]
        public static T rshiftI32<T>(T lhs, int rhs)
            => generic<T>(int32(lhs) >> rhs);
        
        [MethodImpl(Inline)]
        public static T rshiftU32<T>(T lhs, int rhs)
            => generic<T>(uint32(lhs) >> rhs);

        [MethodImpl(Inline)]
        public static T rshiftI64<T>(T lhs, int rhs)
            => generic<T>(int64(lhs)  >> rhs);

        [MethodImpl(Inline)]
        public static T rshiftU64<T>(T lhs, int rhs)
            => generic<T>(uint64(lhs)  >> rhs);

        #endregion

        #region flip

        [MethodImpl(Inline)]
        public static ref T flipI8<T>(ref T src)
        {
            math.flip(ref int8(ref src));            
            return ref src;
        }            

        [MethodImpl(Inline)]
        public static ref T flipU8<T>(ref T src)
        {
            math.flip(ref uint8(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T flipI16<T>(ref T src)
        {
            math.flip(ref int16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T flipU16<T>(ref T src)
        {
            math.flip(ref uint16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T flipI32<T>(ref T src)
        {
            math.flip(ref int32(ref src));            
            return ref src;
        }
        
        [MethodImpl(Inline)]
        public static ref T flipU32<T>(ref T src)
        {
            math.flip(ref uint32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T flipI64<T>(ref T src)
        {
            math.flip(ref int64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T flipU64<T>(ref T src)
        {
            math.flip(ref uint64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static T flipI8<T>(T src)
            => flipI8(ref src);

        [MethodImpl(Inline)]
        public static T flipU8<T>(T src)
            => flipU8(ref src);

        [MethodImpl(Inline)]
        public static T flipI16<T>(T src)
            => flipI16(ref src);

        [MethodImpl(Inline)]
        public static T flipU16<T>(T src)
            => flipU16(ref src);

        [MethodImpl(Inline)]
        public static T flipI32<T>(T src)
            => flipI32(ref src);
        
        [MethodImpl(Inline)]
        public static T flipU32<T>(T src)
            => flipU32(ref src);

        [MethodImpl(Inline)]
        public static T flipI64<T>(T src)
            => flipI64(ref src);

        [MethodImpl(Inline)]
        public static T flipU64<T>(T src)
            => flipU64(ref src);

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
        public static ref T incI8<T>(ref T io)
        {
            ref var result = ref math.inc(ref int8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incU8<T>(ref T io)
        {
            ref var result = ref math.inc(ref uint8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incI16<T>(ref T io)
        {
            ref var result = ref math.inc(ref int16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incU16<T>(ref T io)
        {
            ref var result = ref math.inc(ref uint16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incI32<T>(ref T io)
        {
            ref var result = ref math.inc(ref int32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incU32<T>(ref T io)
        {
            ref var result = ref math.inc(ref uint32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incI64<T>(ref T io)
        {
            ref var result = ref math.inc(ref int64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incU64<T>(ref T io)
        {
            ref var result = ref math.inc(ref uint64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incF32<T>(ref T io)
        {
            ref var result = ref math.inc(ref float32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incF64<T>(ref T io)
        {
            ref var result = ref math.inc(ref float64(ref io));
            return ref io;
        }



        [MethodImpl(Inline)]
        public static T incI8<T>(T src)
            => incI8(ref src);

        [MethodImpl(Inline)]
        public static T incU8<T>(T src)
            => incU8(ref src);

        [MethodImpl(Inline)]
        public static T incI16<T>(T src)
            => incI16(ref src);

        [MethodImpl(Inline)]
        public static T incU16<T>(T src)
            => incU16(ref src);

        [MethodImpl(Inline)]
        public static T incI32<T>(T src)
            => incI32(ref src);
        
        [MethodImpl(Inline)]
        public static T incU32<T>(T src)
            => incU32(ref src);

        [MethodImpl(Inline)]
        public static T incI64<T>(T src)
            => incI64(ref src);

        [MethodImpl(Inline)]
        public static T incU64<T>(T src)
            => incU64(ref src);

        [MethodImpl(Inline)]
        public static T incF32<T>(T src)
            => incF32(ref src);

        [MethodImpl(Inline)]
        public static T incF64<T>(T src)
            => incF64(ref src);


        #endregion

        #region dec

        [MethodImpl(Inline)]
        public static ref T decI8<T>(ref T io)
        {
            ref var result = ref math.dec(ref int8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decU8<T>(ref T io)
        {
            ref var result = ref math.dec(ref uint8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decI16<T>(ref T io)
        {
            ref var result = ref math.dec(ref int16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decU16<T>(ref T io)
        {
            ref var result = ref math.dec(ref uint16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decI32<T>(ref T io)
        {
            ref var result = ref math.dec(ref int32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decU32<T>(ref T io)
        {
            ref var result = ref math.dec(ref uint32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decI64<T>(ref T io)
        {
            ref var result = ref math.dec(ref int64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decU64<T>(ref T io)
        {
            ref var result = ref math.dec(ref uint64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decF32<T>(ref T io)
        {
            ref var result = ref math.dec(ref float32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decF64<T>(ref T io)
        {
            ref var result = ref math.dec(ref float64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static T decI8<T>(T src)
            => decI8(ref src);

        [MethodImpl(Inline)]
        public static T decU8<T>(T src)
            => decU8(ref src);

        [MethodImpl(Inline)]
        public static T decI16<T>(T src)
            => decI16(ref src);

        [MethodImpl(Inline)]
        public static T decU16<T>(T src)
            => decU16(ref src);

        [MethodImpl(Inline)]
        public static T decI32<T>(T src)
            => decI32(ref src);
        
        [MethodImpl(Inline)]
        public static T decU32<T>(T src)
            => decU32(ref src);

        [MethodImpl(Inline)]
        public static T decI64<T>(T src)
            => decI64(ref src);

        [MethodImpl(Inline)]
        public static T decU64<T>(T src)
            => decU64(ref src);

        [MethodImpl(Inline)]
        public static T decF32<T>(T src)
            => decF32(ref src);

        [MethodImpl(Inline)]
        public static T decF64<T>(T src)
            => decF64(ref src);


        #endregion

        #region negate

        [MethodImpl(Inline)]
        public static ref T negateI8<T>(ref T io)
        {
            ref var result = ref math.negate(ref int8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T negateI16<T>(ref T io)
        {
            ref var result = ref math.negate(ref int16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T negateI32<T>(ref T io)
        {
            ref var result = ref math.negate(ref int32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T negateI64<T>(ref T io)
        {
            ref var result = ref math.negate(ref int64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T negateF32<T>(ref T io)
        {
            ref var result = ref math.negate(ref float32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T negateF64<T>(ref T io)
        {
            ref var result = ref math.negate(ref float64(ref io));
            return ref io;
        }

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