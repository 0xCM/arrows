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
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    [StructLayout(LayoutKind.Explicit, Size = ByteCount)]
    public unsafe struct YMM : IMMReg, ICpuReg256
    {
        public static readonly BitSize BitWidth = 256;  

        public const int ByteCount = 32;      

        const int HiPart = 16;

        /// <summary>
        /// Gets the vector bitmap for a specified primal type
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitMap256<T> BitMap<T>()
            where T : unmanaged
                => ref Z0.BitMap.Map256<T>();

        /// <summary>
        /// Computes the type-polymorphic cell count
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int CellCount<T>()
            where T : unmanaged 
                => BitMap<T>().CellCount;

        [MethodImpl(Inline)]
        public static Vector256<T> AsVec<T>(in YMM src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Vector256.As<sbyte,T>(src.ymm8i);
            else if(typeof(T) == typeof(byte))
                return Vector256.As<byte,T>(src.ymm8u);
            else if(typeof(T) == typeof(short))
                return Vector256.As<short,T>(src.ymm16i);
            else if(typeof(T) == typeof(ushort))
                return Vector256.As<ushort,T>(src.ymm16u);
            else if(typeof(T) == typeof(int))
                return Vector256.As<int,T>(src.ymm32i);
            else if(typeof(T) == typeof(uint))
                return Vector256.As<uint,T>(src.ymm32u);
            else if(typeof(T) == typeof(long))
                return Vector256.As<long,T>(src.ymm64i);
            else if(typeof(T) == typeof(ulong))
                return Vector256.As<ulong,T>(src.ymm64u);
            else if(typeof(T) == typeof(float))
                return Vector256.As<float,T>(src.ymm32f);
            else if(typeof(T) == typeof(double))
                return Vector256.As<double,T>(src.ymm64f);
            else
                throw unsupported<T>();
        } 

        /// <summary>
        /// Presents a generic cpu vector as a register
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static YMM FromVec<T>(Vector256<T> src)
            where T : unmanaged
        {
            YMM dst = default;
            if(typeof(T) == typeof(sbyte))
                dst.ymm8i = Vector256.As<T,sbyte>(src);
            else if(typeof(T) == typeof(byte))
                dst.ymm8u = Vector256.As<T,byte>(src);
            else if(typeof(T) == typeof(short))
                dst.ymm16i = Vector256.As<T,short>(src);
            else if(typeof(T) == typeof(ushort))
                dst.ymm16u = Vector256.As<T,ushort>(src);
            else if(typeof(T) == typeof(int))
                dst.ymm32i = Vector256.As<T,int>(src);
            else if(typeof(T) == typeof(uint))
                dst.ymm32u = Vector256.As<T,uint>(src);
            else if(typeof(T) == typeof(long))
                dst.ymm64i = Vector256.As<T,long>(src);
            else if(typeof(T) == typeof(ulong))
                dst.ymm64u = Vector256.As<T,ulong>(src);
            else if(typeof(T) == typeof(float))
                dst.ymm32f = Vector256.As<T,float>(src);
            else if(typeof(T) == typeof(double))
                dst.ymm64f = Vector256.As<T,double>(src);
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<sbyte> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<byte> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<short> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<ushort> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<int> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<uint> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<long> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<ulong> src)
            => FromVec(src);


        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<float> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<double> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static bool operator ==(YMM lhs, YMM rhs)
            =>lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(YMM lhs, YMM rhs)
            =>!lhs.Equals(rhs);

        [MethodImpl]
        public void Assign<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                ymm8i= Vector256.As<T,sbyte>(src);
            else if(typeof(T) == typeof(byte))
                ymm8u = Vector256.As<T,byte>(src);
            else if(typeof(T) == typeof(short))
                ymm16i = Vector256.As<T,short>(src);
            else if(typeof(T) == typeof(ushort))
                ymm16u = Vector256.As<T,ushort>(src);
            else if(typeof(T) == typeof(int))
                ymm32i = Vector256.As<T,int>(src);
            else if(typeof(T) == typeof(uint))
                ymm32u = Vector256.As<T,uint>(src);
            else if(typeof(T) == typeof(long))
                ymm64i = Vector256.As<T,long>(src);
            else if(typeof(T) == typeof(ulong))
                ymm64u = Vector256.As<T,ulong>(src);
            else if(typeof(T) == typeof(float))
                ymm32f = Vector256.As<T,float>(src);
            else if(typeof(T) == typeof(double))
                ymm64f = Vector256.As<T,double>(src);
            else
                throw unsupported<T>();

        }


        /// <summary>
        /// Returns a reference to the first cell
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T First<T>()
            where T : unmanaged
            => ref As.generic<T>(ref Bytes[0]);

        /// <summary>
        /// Gets the value of an index-identified cell
        /// </summary>
        /// <param name="index">The zero-based cell index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T Cell<T>(int index)
            where T : unmanaged
                => ref Unsafe.Add(ref First<T>(), index);

        /// <summary>
        /// Gets the value of an index-identified cell
        /// </summary>
        /// <param name="index">The zero-based cell index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T Cell<T>(uint index)
            where T : unmanaged
                => ref Unsafe.Add(ref First<T>(), (int)index);

        /// <summary>
        /// Manipulates a position-identified bit
        /// </summary>
        public Bit this[BitPos bitpos]
        {
            [MethodImpl(Inline)]
            get => GetBit(bitpos);   
            [MethodImpl(Inline)]
            set => SetBit(bitpos, value);
        }        

        /// <summary>
        /// Gets the value of position-identified bit where 0 <= pos < 128
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl]
        public Bit GetBit(BitPos pos)
        {
            ref readonly var index = ref BitMap<ulong>()[pos];
            ref var cell  = ref Cell<ulong>(index.CellIndex);
            return BitMask.test(in cell, index.CellOffset);
        }

        /// <summary>
        /// Sets a position-identified bit where 0 <= pos < 128
        /// </summary>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The bit value</param>
        [MethodImpl]
        public void SetBit(BitPos pos, Bit value)
        {
            ref readonly var index = ref BitMap<ulong>()[pos];
            ref var cell  = ref Cell<ulong>(index.CellIndex);
            BitMask.set(ref cell, index.CellOffset, value);
        }

        [MethodImpl]
        public bool Equals(YMM rhs)
            => x0 == rhs.x0 && x1 == rhs.x1 
            && x2 == rhs.x2 && x3 == rhs.x3;

        public override bool Equals(object obj)
            => obj is XMM x ? Equals(x) : false;
        
        public override int GetHashCode()
            => x0.GetHashCode() + x1.GetHashCode();

        [FieldOffset(0)]        
        fixed byte Bytes[ByteCount];

        #region I8
    
        [FieldOffset(0)]        
        sbyte x0000s;
        
        [FieldOffset(1)]
        sbyte x0001s;
        
        [FieldOffset(2)]
        sbyte x0002s;
        
        [FieldOffset(3)]
        sbyte x0003s;

        [FieldOffset(4)]
        sbyte x0004s;
        
        [FieldOffset(5)]
        sbyte x0005s;
        
        [FieldOffset(6)]
        sbyte x0006s;
        
        [FieldOffset(7)]
        sbyte x0007s;

        [FieldOffset(8)]        
        sbyte x0008s;
        
        [FieldOffset(9)]
        sbyte x0009s;
        
        [FieldOffset(10)]
        sbyte x000As;
        
        [FieldOffset(11)]
        sbyte x000Bs;

        [FieldOffset(12)]
        sbyte x000Cs;
        
        [FieldOffset(13)]
        sbyte x000Ds;
        
        [FieldOffset(14)]
        sbyte x000Es;
        
        [FieldOffset(15)]
        sbyte x000Fs;

        [FieldOffset(16)]
        sbyte x0010s;

        [FieldOffset(17)]
        sbyte x0011s;

        [FieldOffset(18)]
        sbyte x0012s;

        [FieldOffset(19)]
        sbyte x0013s;

        [FieldOffset(20)]
        sbyte x0014s;

        [FieldOffset(21)]
        sbyte x0015s;

        [FieldOffset(22)]
        sbyte x0016s;

        [FieldOffset(23)]
        sbyte x0017s;

        [FieldOffset(24)]
        sbyte x0018s;

        [FieldOffset(25)]
        sbyte x0019s;

        [FieldOffset(26)]
        sbyte x001As;

        [FieldOffset(27)]
        sbyte x001Bs;

        [FieldOffset(28)]
        sbyte x001Cs;

        [FieldOffset(29)]
        sbyte x001Ds;

        [FieldOffset(30)]
        sbyte x001Es;

        [FieldOffset(31)]
        sbyte x001Fs;

        
        #endregion

        #region U8
        
        [FieldOffset(0)]        
        byte x0000;
        
        [FieldOffset(1)]
        byte x0001;
        
        [FieldOffset(2)]
        byte x0002;
        
        [FieldOffset(3)]
        byte x0003;

        [FieldOffset(4)]
        byte x0004;
        
        [FieldOffset(5)]
        byte x0005;
        
        [FieldOffset(6)]
        byte x0006;
        
        [FieldOffset(7)]
        byte x0007;

        [FieldOffset(8)]        
        byte x0008;
        
        [FieldOffset(9)]
        byte x0009;
        
        [FieldOffset(10)]
        byte x000A;
        
        [FieldOffset(11)]
        byte x000B;

        [FieldOffset(12)]
        byte x000C;
        
        [FieldOffset(13)]
        byte x000D;
        
        [FieldOffset(14)]
        byte x000E;
        
        [FieldOffset(15)]
        byte x000F;

        [FieldOffset(16)]
        byte x0010;

        [FieldOffset(17)]
        byte x0011;

        [FieldOffset(18)]
        byte x0012;

        [FieldOffset(19)]
        byte x0013;

        [FieldOffset(20)]
        byte x0014;

        [FieldOffset(21)]
        byte x0015;

        [FieldOffset(22)]
        byte x0016;

        [FieldOffset(23)]
        byte x0017;

        [FieldOffset(24)]
        byte x0018;

        [FieldOffset(25)]
        byte x0019;

        [FieldOffset(26)]
        byte x001A;

        [FieldOffset(27)]
        byte x001B;

        [FieldOffset(28)]
        byte x001C;

        [FieldOffset(29)]
        byte x001D;

        [FieldOffset(30)]
        byte x001E;

        [FieldOffset(31)]
        byte x001F;

        
        #endregion

        #region U16

        [FieldOffset(0)]        
        ushort x000;
        
        [FieldOffset(2)]
        ushort x001;
        
        [FieldOffset(4)]
        ushort x002;
        
        [FieldOffset(6)]
        ushort x003;

        [FieldOffset(8)]
        ushort x004;
        
        [FieldOffset(10)]
        ushort x005;
        
        [FieldOffset(12)]
        ushort x006;
        
        [FieldOffset(14)]
        ushort x007;

        [FieldOffset(16)]        
        ushort x008;
        
        [FieldOffset(18)]
        ushort x009;
        
        [FieldOffset(20)]
        ushort x00A;
        
        [FieldOffset(22)]
        ushort x00B;

        [FieldOffset(24)]
        ushort x00C;
        
        [FieldOffset(26)]
        ushort x00D;
        
        [FieldOffset(28)]
        ushort x00E;
        
        [FieldOffset(30)]
        ushort x00F;


        #endregion

        #region I16

        [FieldOffset(0)]        
        short x000s;
        
        [FieldOffset(2)]
        short x001s;
        
        [FieldOffset(4)]
        short x002s;
        
        [FieldOffset(6)]
        short x003s;

        [FieldOffset(8)]
        short x004s;
        
        [FieldOffset(10)]
        short x005s;
        
        [FieldOffset(12)]
        short x006s;
        
        [FieldOffset(14)]
        short x007s;

        [FieldOffset(16)]        
        short x008s;
        
        [FieldOffset(18)]
        short x009s;
        
        [FieldOffset(20)]
        short x00As;
        
        [FieldOffset(22)]
        short x00Bs;

        [FieldOffset(24)]
        short x00Cs;
        
        [FieldOffset(26)]
        short x00Ds;
        
        [FieldOffset(28)]
        short x00Es;
        
        [FieldOffset(30)]
        short x00Fs;


        #endregion

        #region I32

        [FieldOffset(0)]
        int x00s;

        [FieldOffset(4)]
        int x01s;

        [FieldOffset(8)]
        int x02s;

        [FieldOffset(12)]
        int x03s;

        [FieldOffset(16)]
        int x04s;

        [FieldOffset(20)]
        int x05s;

        [FieldOffset(24)]
        int x06s;

        [FieldOffset(28)]
        int x07s;

        
        #endregion

        #region U32

        [FieldOffset(0)]
        uint x00;

        [FieldOffset(4)]
        uint x01;

        [FieldOffset(8)]
        uint x02;

        [FieldOffset(12)]
        uint x03;

        [FieldOffset(16)]
        uint x04;

        [FieldOffset(20)]
        uint x05;

        [FieldOffset(24)]
        uint x06;

        [FieldOffset(28)]
        uint x07;

        #endregion

        #region I64

        [FieldOffset(0)]
        long x0s;

        [FieldOffset(8)]
        long x1s;

        [FieldOffset(16)]
        long x2s;

        [FieldOffset(24)]
        long x3s;

        
        #endregion 

        #region U64

        [FieldOffset(0)]
        ulong x0;

        [FieldOffset(8)]
        ulong x1;

        [FieldOffset(16)]
        ulong x2;

        [FieldOffset(24)]
        ulong x3;

        #endregion 

        #region MM
        
        [FieldOffset(0)]
        Vector256<sbyte> ymm8i;

        [FieldOffset(0)]
        Vector256<byte> ymm8u;

        [FieldOffset(0)]
        Vector256<short> ymm16i;

        [FieldOffset(0)]
        Vector256<ushort> ymm16u;

        [FieldOffset(0)]
        Vector256<int> ymm32i;

        [FieldOffset(0)]
        Vector256<uint> ymm32u;

        [FieldOffset(0)]
        Vector256<long> ymm64i;

        [FieldOffset(0)]
        Vector256<ulong> ymm64u;

        [FieldOffset(0)]
        Vector256<float> ymm32f;

        [FieldOffset(0)]
        Vector256<double> ymm64f;

        [FieldOffset(0)]
        Vector128<sbyte> xmm8iL;

        [FieldOffset(HiPart)]
        Vector128<sbyte> xmm8iH;

        [FieldOffset(0)]
        Vector128<byte> xmm8uL;

        [FieldOffset(HiPart)]
        Vector128<byte> xmm8uH;
        
        [FieldOffset(0)]
        Vector128<short> xmm16iL;

        [FieldOffset(HiPart)]
        Vector128<short> xmm16iH;

        [FieldOffset(0)]
        Vector128<ushort> xmm16uL;

        [FieldOffset(HiPart)]
        Vector128<ushort> xmm16uH;

        [FieldOffset(0)]
        Vector128<int> xmm32iL;

        [FieldOffset(HiPart)]
        Vector128<int> xmm32iH;

        [FieldOffset(0)]
        Vector128<uint> xmm32uL;

        [FieldOffset(HiPart)]
        Vector128<uint> xmm32uH;

        [FieldOffset(0)]
        Vector128<long> xmm64iL;

        [FieldOffset(HiPart)]
        Vector128<long> xmm64iH;

        [FieldOffset(0)]
        Vector128<ulong> xmm64uL;

        [FieldOffset(HiPart)]
        Vector128<ulong> xmm64uH;

        [FieldOffset(0)]
        Vector128<float> xmm32fL;

        [FieldOffset(HiPart)]
        Vector128<float> xmm32fH;

        [FieldOffset(0)]
        Vector128<double> xmm64fL;

        [FieldOffset(HiPart)]
        Vector128<double> xmm64fH;            

        #endregion

    }
}    
