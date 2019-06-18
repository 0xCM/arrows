//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct m128i
    {
        [MethodImpl(Inline)]
        public Vec128<T> ToVec128<T>()
            where T : struct
                => Unsafe.As<m128i,Vec128<T>>(ref this);

        [MethodImpl(Inline)]
        public static m128i FromVec128<T>(in Vec128<T> src)
            where T : struct
                => Unsafe.As<Vec128<T>, m128i>(ref As.asRef(in src));

        [MethodImpl(Inline)]
        public Vector128<T> ToVector128<T>()
            where T : struct
                => Unsafe.As<m128i,Vector128<T>>(ref this);

        [MethodImpl(Inline)]
        public static m128i FromVector128<T>(in Vector128<T> src)
            where T : struct
                => Unsafe.As<Vector128<T>, m128i>(ref As.asRef(in src));

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vec128<sbyte> src)
            => FromVec128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vec128<byte> src)
            => FromVec128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vec128<short> src)
            => FromVec128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vec128<ushort> src)
            => FromVec128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vec128<int> src)
            => FromVec128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vec128<uint> src)
            => FromVec128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vec128<long> src)
            => FromVec128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vec128<ulong> src)
            => FromVec128(in src);


        [MethodImpl(Inline)]
        public static explicit operator Vec128<sbyte>(in m128i src)
            => src.ToVec128<sbyte>();

        [MethodImpl(Inline)]
        public static explicit operator Vec128<byte>(in m128i src)
            => src.ToVec128<byte>();

        [MethodImpl(Inline)]
        public static explicit operator Vec128<short>(in m128i src)
            => src.ToVec128<short>();

        [MethodImpl(Inline)]
        public static explicit operator Vec128<ushort>(in m128i src)
            => src.ToVec128<ushort>();

        [MethodImpl(Inline)]
        public static explicit operator Vec128<int>(in m128i src)
            => src.ToVec128<int>();

        [MethodImpl(Inline)]
        public static explicit operator Vec128<uint>(in m128i src)
            => src.ToVec128<uint>();

        [MethodImpl(Inline)]
        public static implicit operator Vec128<long>(in m128i src)
            => src.ToVec128<long>();

        [MethodImpl(Inline)]
        public static explicit operator Vec128<ulong>(in m128i src)
            => src.ToVec128<ulong>();

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vector128<sbyte> src)
            => FromVector128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vector128<byte> src)
            => FromVector128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vector128<short> src)
            => FromVector128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vector128<ushort> src)
            => FromVector128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vector128<int> src)
            => FromVector128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vector128<uint> src)
            => FromVector128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vector128<long> src)
            => FromVector128(in src);

        [MethodImpl(Inline)]
        public static implicit operator m128i(in Vector128<ulong> src)
            => FromVector128(in src);


        [MethodImpl(Inline)]
        public static explicit operator Vector128<sbyte>(in m128i src)
            => src.ToVector128<sbyte>();

        [MethodImpl(Inline)]
        public static explicit operator Vector128<byte>(in m128i src)
            => src.ToVector128<byte>();

        [MethodImpl(Inline)]
        public static explicit operator Vector128<short>(in m128i src)
            => src.ToVector128<short>();

        [MethodImpl(Inline)]
        public static explicit operator Vector128<ushort>(in m128i src)
            => src.ToVector128<ushort>();

        [MethodImpl(Inline)]
        public static explicit operator Vector128<int>(in m128i src)
            => src.ToVector128<int>();

        [MethodImpl(Inline)]
        public static explicit operator Vector128<uint>(in m128i src)
            => src.ToVector128<uint>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<long>(in m128i src)
            => src.ToVector128<long>();

        [MethodImpl(Inline)]
        public static explicit operator Vector128<ulong>(in m128i src)
            => src.ToVector128<ulong>();

        
        
        #region I8
        
        [FieldOffset(0)]        
        public sbyte x0000s;
        
        [FieldOffset(1)]
        public sbyte x0001s;
        
        [FieldOffset(2)]
        public sbyte x0002s;
        
        [FieldOffset(3)]
        public sbyte x0003s;

        [FieldOffset(4)]
        public sbyte x0004s;
        
        [FieldOffset(5)]
        public sbyte x0005s;
        
        [FieldOffset(6)]
        public sbyte x0006s;
        
        [FieldOffset(7)]
        public sbyte x0007s;

        [FieldOffset(8)]        
        public sbyte x0008s;
        
        [FieldOffset(9)]
        public sbyte x0009s;
        
        [FieldOffset(10)]
        public sbyte x000As;
        
        [FieldOffset(11)]
        public sbyte x000Bs;

        [FieldOffset(12)]
        public sbyte x000Cs;
        
        [FieldOffset(13)]
        public sbyte x000Ds;
        
        [FieldOffset(14)]
        public sbyte x000Es;
        
        [FieldOffset(15)]
        public sbyte x000Fs;


        
        #endregion

        #region U8
        
        [FieldOffset(0)]        
        public byte x0000;
        
        [FieldOffset(1)]
        public byte x0001;
        
        [FieldOffset(2)]
        public byte x0002;
        
        [FieldOffset(3)]
        public byte x0003;

        [FieldOffset(4)]
        public byte x0004;
        
        [FieldOffset(5)]
        public byte x0005;
        
        [FieldOffset(6)]
        public byte x0006;
        
        [FieldOffset(7)]
        public byte x0007;

        [FieldOffset(8)]        
        public byte x0008;
        
        [FieldOffset(9)]
        public byte x0009;
        
        [FieldOffset(10)]
        public byte x000A;
        
        [FieldOffset(11)]
        public byte x000B;

        [FieldOffset(12)]
        public byte x000C;
        
        [FieldOffset(13)]
        public byte x000D;
        
        [FieldOffset(14)]
        public byte x000E;
        
        [FieldOffset(15)]
        public byte x000F;


        
        #endregion

        #region U16

        [FieldOffset(0)]        
        public ushort x000;
        
        [FieldOffset(2)]
        public ushort x001;
        
        [FieldOffset(4)]
        public ushort x002;
        
        [FieldOffset(6)]
        public ushort x003;

        [FieldOffset(8)]
        public ushort x004;
        
        [FieldOffset(10)]
        public ushort x005;
        
        [FieldOffset(12)]
        public ushort x006;
        
        [FieldOffset(14)]
        public ushort x007;


        #endregion

        #region I16

        [FieldOffset(0)]        
        public short x000s;
        
        [FieldOffset(2)]
        public short x001s;
        
        [FieldOffset(4)]
        public short x002s;
        
        [FieldOffset(6)]
        public short x003s;

        [FieldOffset(8)]
        public short x004s;
        
        [FieldOffset(10)]
        public short x005s;
        
        [FieldOffset(12)]
        public short x006s;
        
        [FieldOffset(14)]
        public short x007s;


        #endregion

        #region I32

        [FieldOffset(0)]
        public int x00s;

        [FieldOffset(4)]
        public int x01s;

        [FieldOffset(8)]
        public int x02s;

        [FieldOffset(12)]
        public int x03s;


        
        #endregion

        #region U32

        [FieldOffset(0)]
        public uint x00;

        [FieldOffset(4)]
        public uint x01;

        [FieldOffset(8)]
        public uint x02;

        [FieldOffset(12)]
        public uint x03;

        #endregion

        #region I64

        [FieldOffset(0)]
        public long x0s;

        [FieldOffset(8)]
        public long x1s;

        
        #endregion 

        #region U64

        [FieldOffset(0)]
        public ulong x0;

        [FieldOffset(8)]
        public ulong x1;


        #endregion 


    }
}