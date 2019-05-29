//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    using static As;
    using static AsInX;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vec128<T> add<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.add(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.add(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.add(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.add(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.add(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.add(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.add(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.add(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.add(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.add(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported(PrimalKinds.kind<T>());

        }

        [MethodImpl(Inline)]
        public static Vec256<T> add<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.add(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.add(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.add(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.add(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.add(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.add(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.add(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.add(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.add(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.add(in float64(in lhs), in float64(in rhs)));
            else throw unsupported(PrimalKinds.kind<T>());
        }

        
        [MethodImpl(Inline)]
        public static void add<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinx.add(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                dinx.add(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                dinx.add(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                dinx.add(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.add(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.add(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                dinx.add(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                dinx.add(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                dinx.add(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                dinx.add(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static ref T add<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinx.add(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                dinx.add(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                dinx.add(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                dinx.add(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.add(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.add(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                dinx.add(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                dinx.add(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                dinx.add(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                dinx.add(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported(PrimalKinds.kind<T>());
            return ref dst;
        }


        public static ref Span128<T> add<T>(in ReadOnlySpan128<T> lhs, in ReadOnlySpan128<T> rhs, ref Span128<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
            {
                var xDst = int8(dst);
                dinx.add(int8(lhs), int8(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(byte))
            {
                var xDst = uint8(dst);
                dinx.add(uint8(lhs), uint8(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(short))
            {
                var xDst = int16(dst);
                dinx.add(int16(lhs), int16(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(ushort))
            {
                var xDst = uint16(dst);
                dinx.add(uint16(lhs), uint16(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(int))
            {
                var xDst = int32(dst);
                dinx.add(int32(lhs), int32(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(uint))
            {
                var xDst = uint32(dst);
                dinx.add(uint32(lhs), uint32(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(long))
            {
                var xDst = int64(dst);
                dinx.add(int64(lhs), int64(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(ulong))
            {
                var xDst = uint64(dst);
                dinx.add(uint64(lhs), uint64(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(float))
            {
                var xDst = float32(dst);
                dinx.add(float32(lhs), float32(rhs), ref xDst);
            }
            else if(typeof(T) == typeof(double))
            {
                var xDst = float64(dst);
                dinx.add(float64(lhs), float64(rhs), ref xDst);
            }                

            else 
                throw unsupported(PrimalKinds.kind<T>());
            return ref dst;
        }

        public static ref Span256<T> add<T>(in ReadOnlySpan256<T> lhs, in ReadOnlySpan256<T> rhs, ref Span256<T> dst)
            where T : struct
        {            
            if(typeof(T) == typeof(float))
            {
                var xDst = float32(dst);
                dinx.add(float32(lhs), float32(rhs), ref xDst);
            }
            else if(typeof(T) == typeof(double))
            {
                var xDst = float64(dst);
                dinx.add(float64(lhs), float64(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(sbyte))
            {
                var xDst = int8(dst);
                dinx.add(int8(lhs), int8(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(byte))
            {
                var xDst = uint8(dst);
                dinx.add(uint8(lhs), uint8(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(short))
            {
                var xDst = int16(dst);
                dinx.add(int16(lhs), int16(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(ushort))
            {
                var xDst = uint16(dst);
                dinx.add(uint16(lhs), uint16(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(int))
            {
                var xDst = int32(dst);
                dinx.add(int32(lhs), int32(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(uint))
            {
                var xDst = uint32(dst);
                dinx.add(uint32(lhs), uint32(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(long))
            {
                var xDst = int64(dst);
                dinx.add(int64(lhs), int64(rhs), ref xDst);
            }                
            else if(typeof(T) == typeof(uint))
            {
                var xDst = uint64(dst);
                dinx.add(uint64(lhs), uint64(rhs), ref xDst);
            }                
            else 
                throw unsupported(PrimalKinds.kind<T>());
            return ref dst;
        }

    }
}
