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

    partial class gbits
    {
        [MethodImpl(Inline)]
        public static bool subset<T,S>(T test, S set)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return subset(int8(test), set);
            else if(typeof(T) == typeof(byte))
                return subset(uint8(test), set);
            else if(typeof(T) == typeof(short))
                return subset(int16(test), set);
            else if(typeof(T) == typeof(ushort))
                return subset(uint16(test), set);
            else if(typeof(T) == typeof(int))
                return subset(int32(test), set);
            else if(typeof(T) == typeof(uint))
                return subset(uint32(test), set);
            else if(typeof(T) == typeof(long))
                return subset(int64(test), set);
            else if(typeof(T) == typeof(ulong))
                return subset(uint64(test), set);
            else            
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static bool subset<S>(byte test, S set)
            where S : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return Bits.subset(test, int8(set));
            else if(typeof(S) == typeof(byte))
                return Bits.subset(test, uint8(set));
            else if(typeof(S) == typeof(short))
                return Bits.subset(test, int16(set));
            else if(typeof(S) == typeof(ushort))
                return Bits.subset(test, uint16(set));
            else if(typeof(S) == typeof(int))
                return Bits.subset(test, int32(set));
            else if(typeof(S) == typeof(uint))
                return Bits.subset(test, uint32(set));
            else if(typeof(S) == typeof(long))
                return Bits.subset(test, int64(set));
            else if(typeof(S) == typeof(ulong))
                return Bits.subset(test, uint64(set));
            else if(typeof(S) == typeof(float))
                return Bits.subset(test, float32(set));
            else if(typeof(S) == typeof(double))
                return Bits.subset(test, float64(set));
            else            
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static bool subset<S>(sbyte test, S set)
            where S : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return Bits.subset(test, int8(set));
            else if(typeof(S) == typeof(byte))
                return Bits.subset(test, uint8(set));
            else if(typeof(S) == typeof(short))
                return Bits.subset(test, int16(set));
            else if(typeof(S) == typeof(ushort))
                return Bits.subset(test, uint16(set));
            else if(typeof(S) == typeof(int))
                return Bits.subset(test, int32(set));
            else if(typeof(S) == typeof(uint))
                return Bits.subset(test, uint32(set));
            else if(typeof(S) == typeof(long))
                return Bits.subset(test, int64(set));
            else if(typeof(S) == typeof(ulong))
                return Bits.subset(test, uint64(set));
            else if(typeof(S) == typeof(float))
                return Bits.subset(test, float32(set));
            else if(typeof(S) == typeof(double))
                return Bits.subset(test, float64(set));
            else            
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static bool subset<S>(short test, S set)
            where S : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return Bits.subset(test, int8(set));
            else if(typeof(S) == typeof(byte))
                return Bits.subset(test, uint8(set));
            else if(typeof(S) == typeof(short))
                return Bits.subset(test, int16(set));
            else if(typeof(S) == typeof(ushort))
                return Bits.subset(test, uint16(set));
            else if(typeof(S) == typeof(int))
                return Bits.subset(test, int32(set));
            else if(typeof(S) == typeof(uint))
                return Bits.subset(test, uint32(set));
            else if(typeof(S) == typeof(long))
                return Bits.subset(test, int64(set));
            else if(typeof(S) == typeof(ulong))
                return Bits.subset(test, uint64(set));
            else if(typeof(S) == typeof(float))
                return Bits.subset(test, float32(set));
            else if(typeof(S) == typeof(double))
                return Bits.subset(test, float64(set));
            else            
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static bool subset<S>(ushort test, S set)
            where S : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return Bits.subset(test, int8(set));
            else if(typeof(S) == typeof(byte))
                return Bits.subset(test, uint8(set));
            else if(typeof(S) == typeof(short))
                return Bits.subset(test, int16(set));
            else if(typeof(S) == typeof(ushort))
                return Bits.subset(test, uint16(set));
            else if(typeof(S) == typeof(int))
                return Bits.subset(test, int32(set));
            else if(typeof(S) == typeof(uint))
                return Bits.subset(test, uint32(set));
            else if(typeof(S) == typeof(long))
                return Bits.subset(test, int64(set));
            else if(typeof(S) == typeof(ulong))
                return Bits.subset(test, uint64(set));
            else if(typeof(S) == typeof(float))
                return Bits.subset(test, float32(set));
            else if(typeof(S) == typeof(double))
                return Bits.subset(test, float64(set));
            else            
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static bool subset<S>(int test, S set)
            where S : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return Bits.subset(test, int8(set));
            else if(typeof(S) == typeof(byte))
                return Bits.subset(test, uint8(set));
            else if(typeof(S) == typeof(short))
                return Bits.subset(test, int16(set));
            else if(typeof(S) == typeof(ushort))
                return Bits.subset(test, uint16(set));
            else if(typeof(S) == typeof(int))
                return Bits.subset(test, int32(set));
            else if(typeof(S) == typeof(uint))
                return Bits.subset(test, uint32(set));
            else if(typeof(S) == typeof(long))
                return Bits.subset(test, int64(set));
            else if(typeof(S) == typeof(ulong))
                return Bits.subset(test, uint64(set));
            else if(typeof(S) == typeof(float))
                return Bits.subset(test, float32(set));
            else if(typeof(S) == typeof(double))
                return Bits.subset(test, float64(set));
            else            
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static bool subset<S>(uint test, S set)
            where S : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return Bits.subset(test, int8(set));
            else if(typeof(S) == typeof(byte))
                return Bits.subset(test, uint8(set));
            else if(typeof(S) == typeof(short))
                return Bits.subset(test, int16(set));
            else if(typeof(S) == typeof(ushort))
                return Bits.subset(test, uint16(set));
            else if(typeof(S) == typeof(int))
                return Bits.subset(test, int32(set));
            else if(typeof(S) == typeof(uint))
                return Bits.subset(test, uint32(set));
            else if(typeof(S) == typeof(long))
                return Bits.subset(test, int64(set));
            else if(typeof(S) == typeof(ulong))
                return Bits.subset(test, uint64(set));
            else if(typeof(S) == typeof(float))
                return Bits.subset(test, float32(set));
            else if(typeof(S) == typeof(double))
                return Bits.subset(test, float64(set));
            else            
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static bool subset<S>(long test, S set)
            where S : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return Bits.subset(test, int8(set));
            else if(typeof(S) == typeof(byte))
                return Bits.subset(test, uint8(set));
            else if(typeof(S) == typeof(short))
                return Bits.subset(test, int16(set));
            else if(typeof(S) == typeof(ushort))
                return Bits.subset(test, uint16(set));
            else if(typeof(S) == typeof(int))
                return Bits.subset(test, int32(set));
            else if(typeof(S) == typeof(uint))
                return Bits.subset(test, uint32(set));
            else if(typeof(S) == typeof(long))
                return Bits.subset(test, int64(set));
            else if(typeof(S) == typeof(ulong))
                return Bits.subset(test, uint64(set));
            else if(typeof(S) == typeof(float))
                return Bits.subset(test, float32(set));
            else if(typeof(S) == typeof(double))
                return Bits.subset(test, float64(set));
            else            
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static bool subset<S>(ulong test, S set)
            where S : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return Bits.subset(test, int8(set));
            else if(typeof(S) == typeof(byte))
                return Bits.subset(test, uint8(set));
            else if(typeof(S) == typeof(short))
                return Bits.subset(test, int16(set));
            else if(typeof(S) == typeof(ushort))
                return Bits.subset(test, uint16(set));
            else if(typeof(S) == typeof(int))
                return Bits.subset(test, int32(set));
            else if(typeof(S) == typeof(uint))
                return Bits.subset(test, uint32(set));
            else if(typeof(S) == typeof(long))
                return Bits.subset(test, int64(set));
            else if(typeof(S) == typeof(ulong))
                return Bits.subset(test, uint64(set));
            else if(typeof(S) == typeof(float))
                return Bits.subset(test, float32(set));
            else if(typeof(S) == typeof(double))
                return Bits.subset(test, float64(set));
            else            
                throw unsupported<S>();
        }




    }

}