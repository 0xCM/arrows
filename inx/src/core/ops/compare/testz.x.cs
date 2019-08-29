//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using Avx = System.Runtime.Intrinsics.X86.Avx;   
    using static zfunc;
    using static As;
        

    partial class dinxx
    {
        public static bool TestZ<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return uint8(in lhs).TestZ(uint8(in rhs));
            else if(typeof(T) == typeof(sbyte))
                return int8(in lhs).TestZ(int8(in rhs));
            else if(typeof(T) == typeof(short))
                return int16(in lhs).TestZ(int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                return uint16(in lhs).TestZ(uint16(in rhs));
            else if(typeof(T) == typeof(int))
                return int32(in lhs).TestZ(int32(in rhs));
            else if(typeof(T) == typeof(uint)) 
                return uint32(in lhs).TestZ(uint32(in rhs));
            else if(typeof(T) == typeof(long))
                return int64(in lhs).TestZ(int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                return uint64(in lhs).TestZ(uint64(in rhs));
            else if(typeof(T) == typeof(float))
                return float32(in lhs).TestZ(float32(in rhs));
            else if(typeof(T) == typeof(double))
                return float64(in lhs).TestZ(float64(in rhs));
            else
                throw unsupported<T>();
        }

        public static bool TestZ<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return uint8(in lhs).TestZ(uint8(in rhs));
            else if(typeof(T) == typeof(sbyte))
                return int8(in lhs).TestZ(int8(in rhs));
            else if(typeof(T) == typeof(short))
                return int16(in lhs).TestZ(int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                return uint16(in lhs).TestZ(uint16(in rhs));
            else if(typeof(T) == typeof(int))
                return int32(in lhs).TestZ(int32(in rhs));
            else if(typeof(T) == typeof(uint)) 
                return uint32(in lhs).TestZ(uint32(in rhs));
            else if(typeof(T) == typeof(long))
                return int64(in lhs).TestZ(int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                return uint64(in lhs).TestZ(uint64(in rhs));
            else if(typeof(T) == typeof(float))
                return float32(in lhs).TestZ(float32(in rhs));
            else if(typeof(T) == typeof(double))
                return float64(in lhs).TestZ(float64(in rhs));
            else
                throw unsupported<T>();

        }

        [MethodImpl(Inline)]
        static bool TestZ(this Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec128<short> lhs, in Vec128<short> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec128<int> lhs, in Vec128<int> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec128<long> lhs, in Vec128<long> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec128<float> lhs, in Vec128<float> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec128<double> lhs, in Vec128<double> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec256<short> lhs, in Vec256<short> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec256<int> lhs, in Vec256<int> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec256<uint> lhs, in Vec256<uint> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec256<long> lhs, in Vec256<long> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec256<float> lhs, in Vec256<float> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        static bool TestZ(this Vec256<double> lhs, in Vec256<double> rhs)
            => Avx.TestZ(lhs,rhs);        

    }

}