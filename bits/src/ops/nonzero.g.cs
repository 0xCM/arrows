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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    
    using static As;
    using static AsInX;

    partial class gbits
    {
        [MethodImpl(Inline)]
        public static bool nonzero<T>(in Vec128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return nonzero(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return nonzero(in uint8(in src));
            else if(typeof(T) == typeof(short))
                return nonzero(in int16(in src));
            else if(typeof(T) == typeof(ushort))
                return nonzero(in uint16(in src));
            else if(typeof(T) == typeof(int))
                return nonzero(in int32(in src));
            else if(typeof(T) == typeof(uint))
                return nonzero(in uint32(in src));
            else if(typeof(T) == typeof(long))
                return nonzero(in int64(in src));
            else if(typeof(T) == typeof(ulong))
                return nonzero(in uint64(in src));
            else if(typeof(T) == typeof(float))
                return nonzero(in float32(in src));
            else if(typeof(T) == typeof(double))
                return nonzero(in float64(in src));
            else 
                throw unsupported<T>();
        }

       [MethodImpl(Inline)]
        static bool nonzero(in Vec128<byte> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec128<sbyte> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec128<short> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec128<ushort> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec128<int> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec128<uint> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec128<long> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec128<ulong> src) 
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec128<float> src) 
            => ! TestZ(src,src);        


        [MethodImpl(Inline)]
        static bool nonzero(in Vec128<double> src) 
            => ! TestZ(src,src);        


        [MethodImpl(Inline)]
        public static bool nonzero<T>(in Vec256<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return nonzero(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return nonzero(in uint8(in src));
            else if(typeof(T) == typeof(short))
                return nonzero(in int16(in src));
            else if(typeof(T) == typeof(ushort))
                return nonzero(in uint16(in src));
            else if(typeof(T) == typeof(int))
                return nonzero(in int32(in src));
            else if(typeof(T) == typeof(uint))
                return nonzero(in uint32(in src));
            else if(typeof(T) == typeof(long))
                return nonzero(in int64(in src));
            else if(typeof(T) == typeof(ulong))
                return nonzero(in uint64(in src));
            else if(typeof(T) == typeof(float))
                return nonzero(in float32(in src));
            else if(typeof(T) == typeof(double))
                return nonzero(in float64(in src));
            else 
                throw unsupported<T>();
        }         
 
 
        [MethodImpl(Inline)]
        static bool nonzero(in Vec256<byte> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec256<sbyte> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec256<short> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec256<ushort> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec256<int> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec256<uint> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec256<long> src)
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec256<ulong> src) 
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec256<float> src) 
            => ! TestZ(src,src);        

        [MethodImpl(Inline)]
        static bool nonzero(in Vec256<double> src) 
            => ! TestZ(src,src);        
 
    }

}