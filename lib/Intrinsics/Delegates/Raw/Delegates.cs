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
    
    using static zcore;
    using static inxfunc;

    public delegate Vector128<T> Vector128BinOp<T>(Vector128<T> lhs, Vector128<T> rhs)
        where T : struct, IEquatable<T>;

    public unsafe delegate Vector128<T> Vector128LoadOp<T>(void* src)
        where T : struct, IEquatable<T>;

    public unsafe delegate void Vector128StoreOp<T>(Vector128<T> src, void* dst)
        where T : struct, IEquatable<T>;

    public static partial class InXDelegates
    {


        //! Load
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        static unsafe Vector128<byte> LoadVector128U8(void* src)
            => Avx.LoadVector128((byte*)src);

        [MethodImpl(Inline)]
        static unsafe Vector128<sbyte> LoadVector128I8(void* src)
            => Avx.LoadVector128((sbyte*)src);

        [MethodImpl(Inline)]
        static unsafe Vector128<short> LoadVector128I16(void* src)
            => Avx.LoadVector128((short*)src);

        [MethodImpl(Inline)]
        static unsafe Vector128<ushort> LoadVector128U16(void* src)
            => Avx.LoadVector128((ushort*)src);

        [MethodImpl(Inline)]
        static unsafe Vector128<int> LoadVector128I32(void* src)
            => Avx.LoadVector128((int*)src);

        [MethodImpl(Inline)]
        static unsafe Vector128<uint> LoadVector128U32(void* src)
            => Avx.LoadVector128((uint*)src);

        [MethodImpl(Inline)]
        static unsafe Vector128<long> LoadVector128I64(void* src)
            => Avx.LoadVector128((long*)src);

        [MethodImpl(Inline)]
        static unsafe Vector128<ulong> LoadVector128U64(void* src)
            => Avx.LoadVector128((ulong*)src);

        [MethodImpl(Inline)]
        static unsafe Vector128<float> LoadVector128F32(void* src)
            => Avx.LoadVector128((float*)src);

        [MethodImpl(Inline)]
        static unsafe Vector128<double> LoadVector128F64(void* src)
            => Avx.LoadVector128((double*)src);

        public static unsafe readonly Vector128LoadOp<sbyte> LoadI8 = LoadVector128I8;

        public static unsafe readonly Vector128LoadOp<byte> LoadU8 = LoadVector128U8;

        public static unsafe readonly Vector128LoadOp<short> LoadI16 = LoadVector128I16;
        
        public static unsafe readonly Vector128LoadOp<ushort> LoadU16 = LoadVector128U16;

        public static unsafe readonly Vector128LoadOp<int> LoadI32 = LoadVector128I32;
        
        public static unsafe readonly Vector128LoadOp<uint> LoadU32 = LoadVector128U32;

        public static unsafe readonly Vector128LoadOp<long> LoadI64 = LoadVector128I64;

        public static unsafe readonly Vector128LoadOp<ulong> LoadU64 = LoadVector128U64;

        public static unsafe readonly Vector128LoadOp<float> LoadF32 = LoadVector128F32;

        public static unsafe readonly Vector128LoadOp<double> LoadF64 = LoadVector128F64;

        static readonly PrimalIndex LoadDelegates  = PrimKinds.index
            (@sbyte : LoadI8, 
             @byte : LoadU8, 
             @short : LoadI16, 
             @ushort : LoadU16, 
             @int : LoadI32, 
             @uint : LoadU32, 
             @long : LoadI64, 
             @ulong : LoadU64, 
             @float : LoadF32, 
             @double : LoadF64
             );

        //! Store
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        static unsafe void StoreVector128(Vector128<byte> src, void* dst)
            => Avx.Store((byte*)dst, src);

        [MethodImpl(Inline)]
        static unsafe void StoreVector128(Vector128<sbyte> src, void* dst)
            => Avx.Store((sbyte*)dst, src);

        [MethodImpl(Inline)]
        static unsafe void StoreVector128(Vector128<short> src, void* dst)
            => Avx.Store((short*)dst, src);

        [MethodImpl(Inline)]
        static unsafe void StoreVector128(Vector128<ushort> src,void* dst)
            => Avx.Store((ushort*)dst, src);

        [MethodImpl(Inline)]
        static unsafe void StoreVector128(Vector128<int> src, void* dst)
            => Avx.Store((int*)dst, src);

        [MethodImpl(Inline)]
        static unsafe void StoreVector128(Vector128<uint> src, void* dst)
            => Avx.Store((uint*)dst, src);

        [MethodImpl(Inline)]
        static unsafe void StoreVector128(Vector128<long> src, void* dst)
            => Avx.Store((long*)dst, src);

        [MethodImpl(Inline)]
        static unsafe void StoreVector128(Vector128<ulong> src, void* dst)
            => Avx.Store((ulong*)dst, src);

        [MethodImpl(Inline)]
        static unsafe void StoreVector128(Vector128<float> src, void* dst)
            => Avx.Store((float*)dst, src);

        [MethodImpl(Inline)]
        static unsafe void StoreVector128(Vector128<double> src, void* dst)
            => Avx.Store((double*)dst, src);

        public static unsafe readonly Vector128StoreOp<sbyte> StoreI8 = StoreVector128;

        public static unsafe readonly Vector128StoreOp<byte> StoreU8 = StoreVector128;

        public static unsafe readonly Vector128StoreOp<short> StoreI16 = StoreVector128;
        
        public static unsafe readonly Vector128StoreOp<ushort> StoreU16 = StoreVector128;

        public static unsafe readonly Vector128StoreOp<int> StoreI32 = StoreVector128;
        
        public static unsafe readonly Vector128StoreOp<uint> StoreU32 = StoreVector128;

        public static unsafe readonly Vector128StoreOp<long> StoreI64 = StoreVector128;

        public static unsafe readonly Vector128StoreOp<ulong> StoreU64 = StoreVector128;

        public static unsafe readonly Vector128StoreOp<float> StoreF32 = StoreVector128;

        public static unsafe readonly Vector128StoreOp<double> StoreF64 = StoreVector128;


         static readonly PrimalIndex StoreDelegates  = PrimKinds.index
            (@sbyte : StoreI8, 
             @byte : StoreU8, 
             @short : StoreI16, 
             @ushort : StoreU16, 
             @int : StoreI32, 
             @uint : StoreU32, 
             @long : StoreI64, 
             @ulong : StoreU64, 
             @float : StoreF32, 
             @double : StoreF64
             );

    }
}