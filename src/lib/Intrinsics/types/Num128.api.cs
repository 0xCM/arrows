//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static zcore;
    using static x86;

    public static class Num128
    {
       [MethodImpl(Inline)]
        public static unsafe Num128<T> define<T>(T value)
            where T : struct, IEquatable<T>
        {
            void* scalar = typecode<T>() switch 
            {
                TypeCode.SByte => i8num(value, 16),
                TypeCode.Byte => u8num(value, 16),
                TypeCode.Int16 => i16num(value, 8),
                TypeCode.UInt16 => u16num(value, 8),
                TypeCode.Int32 => i32num(value, 4),
                TypeCode.UInt32 => u32num(value, 4),
                TypeCode.Int64 => i64num(value, 2),
                TypeCode.UInt64 => u64num(value, 2),
                TypeCode.Single => f32num(value, 4),
                TypeCode.Double => f64num(value, 2),
                _ => throw new NotSupportedException()
            };        

            return castref<Vector128<T>>(scalar);                    
         }

    }

}