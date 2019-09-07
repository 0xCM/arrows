//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;


    [StructLayout(LayoutKind.Explicit, Size = ByteCount)]
    public unsafe struct XMM : IMMReg, ICpuReg128
    {
        public static readonly BitSize BitWidth = 128;        

        public const int ByteCount = 16;

        [MethodImpl(Inline)]
        public static ref readonly BitMap128<T> BitMap<T>()
            where T : unmanaged
                => ref Z0.BitMap.Map128<T>();

        /// <summary>
        /// Creates a register with content from a cell parameter array
        /// </summary>
        /// <param name="cells">The cell content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static XMM FromCells<T>(params T[] cells)
            where T : unmanaged
        {
            XMM dst = default;
            var len = Math.Min(cells.Length, CellCount<T>());
            for(var i=0; i<len; i++)              
                dst.Cell<T>(i) = cells[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static Vector128<T> AsVec<T>(in XMM src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Vector128.As<sbyte,T>(src.xmm8i);
            else if(typeof(T) == typeof(byte))
                return Vector128.As<byte,T>(src.xmm8u);
            else if(typeof(T) == typeof(short))
                return Vector128.As<short,T>(src.xmm16i);
            else if(typeof(T) == typeof(ushort))
                return Vector128.As<ushort,T>(src.xmm16u);
            else if(typeof(T) == typeof(int))
                return Vector128.As<int,T>(src.xmm32i);
            else if(typeof(T) == typeof(uint))
                return Vector128.As<uint,T>(src.xmm32u);
            else if(typeof(T) == typeof(long))
                return Vector128.As<long,T>(src.xmm64i);
            else if(typeof(T) == typeof(ulong))
                return Vector128.As<ulong,T>(src.xmm64u);
            else if(typeof(T) == typeof(float))
                return Vector128.As<float,T>(src.xmm32f);
            else if(typeof(T) == typeof(double))
                return Vector128.As<double,T>(src.xmm64f);
            else
                throw unsupported<T>();
        } 

        /// <summary>
        /// Presents a generic cpu vector as a register
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static XMM FromVec<T>(Vector128<T> src)
            where T : unmanaged
        {
            XMM dst = default;
            if(typeof(T) == typeof(sbyte))
                dst.xmm8i = Vector128.As<T,sbyte>(src);
            else if(typeof(T) == typeof(byte))
                dst.xmm8u = Vector128.As<T,byte>(src);
            else if(typeof(T) == typeof(short))
                dst.xmm16i = Vector128.As<T,short>(src);
            else if(typeof(T) == typeof(ushort))
                dst.xmm16u = Vector128.As<T,ushort>(src);
            else if(typeof(T) == typeof(int))
                dst.xmm32i = Vector128.As<T,int>(src);
            else if(typeof(T) == typeof(uint))
                dst.xmm32u = Vector128.As<T,uint>(src);
            else if(typeof(T) == typeof(long))
                dst.xmm64i = Vector128.As<T,long>(src);
            else if(typeof(T) == typeof(ulong))
                dst.xmm64u = Vector128.As<T,ulong>(src);
            else if(typeof(T) == typeof(float))
                dst.xmm32f = Vector128.As<T,float>(src);
            else if(typeof(T) == typeof(double))
                dst.xmm64f = Vector128.As<T,double>(src);
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<sbyte> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<byte> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<short> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<ushort> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<int> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<uint> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<long> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<ulong> src)
            => FromVec(src);


        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<float> src)
            => FromVec(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<double> src)
            => FromVec(src);


        [MethodImpl(Inline)]
        public static bool operator ==(XMM lhs, XMM rhs)
            =>lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(XMM lhs, XMM rhs)
            =>!lhs.Equals(rhs);

        [MethodImpl]
        public void Assign<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                xmm8i= Vector128.As<T,sbyte>(src);
            else if(typeof(T) == typeof(byte))
                xmm8u = Vector128.As<T,byte>(src);
            else if(typeof(T) == typeof(short))
                xmm16i = Vector128.As<T,short>(src);
            else if(typeof(T) == typeof(ushort))
                xmm16u = Vector128.As<T,ushort>(src);
            else if(typeof(T) == typeof(int))
                xmm32i = Vector128.As<T,int>(src);
            else if(typeof(T) == typeof(uint))
                xmm32u = Vector128.As<T,uint>(src);
            else if(typeof(T) == typeof(long))
                xmm64i = Vector128.As<T,long>(src);
            else if(typeof(T) == typeof(ulong))
                xmm64u = Vector128.As<T,ulong>(src);
            else if(typeof(T) == typeof(float))
                xmm32f = Vector128.As<T,float>(src);
            else if(typeof(T) == typeof(double))
                xmm64f = Vector128.As<T,double>(src);
            else
                throw unsupported<T>();

        }

        /// <summary>
        /// Computes type-polymorphic cell count
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int CellCount<T>()
            where T : unmanaged 
                => BitMap<T>().CellCount;

        /// <summary>
        /// Computes type-specific cell bitsize
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSize CellWidth<T>()
            where T : unmanaged 
                => BitMap<T>().CellWidth;

        /// <summary>
        /// Returns a reference to the first element
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T First<T>()
            where T : unmanaged
                => ref As.generic<T>(ref u8[0]);

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
        public bool Equals(XMM rhs)
            => x0 == rhs.x0 && x1 == rhs.x1;

        public override bool Equals(object obj)
            => obj is XMM x ? Equals(x) : false;
        
        public override int GetHashCode()
            => x0.GetHashCode() + x1.GetHashCode();

        [FieldOffset(0)]        
        fixed byte u8[ByteCount];

        [FieldOffset(0)]        
        fixed sbyte i8[ByteCount];

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

        #endregion

        #region I64

        [FieldOffset(0)]
        long x0s;

        [FieldOffset(8)]
        long x1s;
        
        #endregion 

        #region U64

        [FieldOffset(0)]
        ulong x0;

        [FieldOffset(8)]
        ulong x1;

        #endregion


        #region Vectors

        [FieldOffset(0)]
        Vector128<sbyte> xmm8i;

        [FieldOffset(0)]
        Vector128<byte> xmm8u;

        [FieldOffset(0)]
        Vector128<short> xmm16i;

        [FieldOffset(0)]
        Vector128<ushort> xmm16u;

        [FieldOffset(0)]
        Vector128<int> xmm32i;

        [FieldOffset(0)]
        Vector128<uint> xmm32u;

        [FieldOffset(0)]
        Vector128<long> xmm64i;

        [FieldOffset(0)]
        Vector128<ulong> xmm64u;

        [FieldOffset(0)]
        Vector128<float> xmm32f;

        [FieldOffset(0)]
        Vector128<double> xmm64f;

        #endregion
    }
}    
