//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class Registers
    {
        /// <summary>
        /// Returns a reference to an index-identified source bank slot
        /// </summary>
        /// <param name="slot">The zero-based index of the register</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref YMM ymm(ref YmmBank src, int slot)
            => ref src.Slot<YMM>(slot);

        [MethodImpl(Inline)]
        public static ref Vec256<T> AsVector<T>(ref YMM src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return ref generic<T>(ref src.ymm8i);
            else if(typeof(T) == typeof(byte))
                return ref generic<T>(ref src.ymm8u);
            else if(typeof(T) == typeof(short))
                return ref generic<T>(ref src.ymm16i);
            else if(typeof(T) == typeof(ushort))
                return ref generic<T>(ref src.ymm16u);
            else if(typeof(T) == typeof(int))
                return ref generic<T>(ref src.ymm32i);
            else if(typeof(T) == typeof(uint))
                return ref generic<T>(ref src.ymm32u);
            else if(typeof(T) == typeof(long))
                return ref generic<T>(ref src.ymm64i);
            else if(typeof(T) == typeof(ulong))
                return ref generic<T>(ref src.ymm64u);
            else if(typeof(T) == typeof(float))
                return ref generic<T>(ref src.ymm32f);
            else if(typeof(T) == typeof(double))
                return ref generic<T>(ref src.ymm64f);
            else
                throw unsupported<T>();
        }

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
            /// Returns a reference to the first cell
            /// </summary>
            /// <typeparam name="T">The cell type</typeparam>
            [MethodImpl(Inline)]
            public ref T First<T>()
                where T : unmanaged
                => ref As.generic<T>(ref Bytes[0]);

            /// <summary>
            /// Computes the type-polymorphic cell count
            /// </summary>
            /// <typeparam name="T">The cell type</typeparam>
            [MethodImpl(Inline)]
            public int CellCount<T>()
                where T : unmanaged 
                    => BitMap<T>().CellCount;

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

            [MethodImpl(Inline)]
            unsafe ref T head<T>()
                where T : struct
            {
                fixed(void* pSrc = &this)
                    return ref Unsafe.AsRef<T>(pSrc);
            }
            
            ref T IMMReg.Cell<T>(int index)
                => ref Cell<T>(index);


            [FieldOffset(0)]        
            fixed byte Bytes[ByteCount];

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

            [FieldOffset(16)]
            public sbyte x0010s;

            [FieldOffset(17)]
            public sbyte x0011s;

            [FieldOffset(18)]
            public sbyte x0012s;

            [FieldOffset(19)]
            public sbyte x0013s;

            [FieldOffset(20)]
            public sbyte x0014s;

            [FieldOffset(21)]
            public sbyte x0015s;

            [FieldOffset(22)]
            public sbyte x0016s;

            [FieldOffset(23)]
            public sbyte x0017s;

            [FieldOffset(24)]
            public sbyte x0018s;

            [FieldOffset(25)]
            public sbyte x0019s;

            [FieldOffset(26)]
            public sbyte x001As;

            [FieldOffset(27)]
            public sbyte x001Bs;

            [FieldOffset(28)]
            public sbyte x001Cs;

            [FieldOffset(29)]
            public sbyte x001Ds;

            [FieldOffset(30)]
            public sbyte x001Es;

            [FieldOffset(31)]
            public sbyte x001Fs;

            
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

            [FieldOffset(16)]
            public byte x0010;

            [FieldOffset(17)]
            public byte x0011;

            [FieldOffset(18)]
            public byte x0012;

            [FieldOffset(19)]
            public byte x0013;

            [FieldOffset(20)]
            public byte x0014;

            [FieldOffset(21)]
            public byte x0015;

            [FieldOffset(22)]
            public byte x0016;

            [FieldOffset(23)]
            public byte x0017;

            [FieldOffset(24)]
            public byte x0018;

            [FieldOffset(25)]
            public byte x0019;

            [FieldOffset(26)]
            public byte x001A;

            [FieldOffset(27)]
            public byte x001B;

            [FieldOffset(28)]
            public byte x001C;

            [FieldOffset(29)]
            public byte x001D;

            [FieldOffset(30)]
            public byte x001E;

            [FieldOffset(31)]
            public byte x001F;

            
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

            [FieldOffset(16)]        
            public ushort x008;
            
            [FieldOffset(18)]
            public ushort x009;
            
            [FieldOffset(20)]
            public ushort x00A;
            
            [FieldOffset(22)]
            public ushort x00B;

            [FieldOffset(24)]
            public ushort x00C;
            
            [FieldOffset(26)]
            public ushort x00D;
            
            [FieldOffset(28)]
            public ushort x00E;
            
            [FieldOffset(30)]
            public ushort x00F;


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

            [FieldOffset(16)]        
            public short x008s;
            
            [FieldOffset(18)]
            public short x009s;
            
            [FieldOffset(20)]
            public short x00As;
            
            [FieldOffset(22)]
            public short x00Bs;

            [FieldOffset(24)]
            public short x00Cs;
            
            [FieldOffset(26)]
            public short x00Ds;
            
            [FieldOffset(28)]
            public short x00Es;
            
            [FieldOffset(30)]
            public short x00Fs;


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

            [FieldOffset(16)]
            public int x04s;

            [FieldOffset(20)]
            public int x05s;

            [FieldOffset(24)]
            public int x06s;

            [FieldOffset(28)]
            public int x07s;

            
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

            [FieldOffset(16)]
            public uint x04;

            [FieldOffset(20)]
            public uint x05;

            [FieldOffset(24)]
            public uint x06;

            [FieldOffset(28)]
            public uint x07;

            #endregion

            #region I64

            [FieldOffset(0)]
            public long x0s;

            [FieldOffset(8)]
            public long x1s;

            [FieldOffset(16)]
            public long x2s;

            [FieldOffset(24)]
            public long x3s;

            
            #endregion 

            #region U64

            [FieldOffset(0)]
            public ulong x0;

            [FieldOffset(8)]
            public ulong x1;

            [FieldOffset(16)]
            public ulong x2;

            [FieldOffset(24)]
            public ulong x3;

            #endregion 

            #region MM
            
            [FieldOffset(0)]
            public XMM xmm0;

            [FieldOffset(16)]
            public XMM xmm1;


            [FieldOffset(0)]
            public Vec256<sbyte> ymm8i;

            [FieldOffset(0)]
            public Vec256<byte> ymm8u;

            [FieldOffset(0)]
            public Vec256<short> ymm16i;

            [FieldOffset(0)]
            public Vec256<ushort> ymm16u;

            [FieldOffset(0)]
            public Vec256<int> ymm32i;

            [FieldOffset(0)]
            public Vec256<uint> ymm32u;

            [FieldOffset(0)]
            public Vec256<long> ymm64i;

            [FieldOffset(0)]
            public Vec256<ulong> ymm64u;

            [FieldOffset(0)]
            public Vec256<float> ymm32f;

            [FieldOffset(0)]
            public Vec256<double> ymm64f;

            [FieldOffset(0)]
            public Vec128<sbyte> xmm8iL;

            [FieldOffset(0)]
            public Vec128<byte> xmm8uL;

            [FieldOffset(0)]
            public Vec128<short> xmm16iL;

            [FieldOffset(0)]
            public Vec128<ushort> xmm16uL;

            [FieldOffset(0)]
            public Vec128<int> xmm32iL;

            [FieldOffset(0)]
            public Vec128<uint> xmm32uL;

            [FieldOffset(0)]
            public Vec128<long> xmm64iL;

            [FieldOffset(0)]
            public Vec128<ulong> xmm64uL;

            [FieldOffset(0)]
            public Vec128<float> xmm32fL;

            [FieldOffset(0)]
            public Vec128<double> xmm64fL;

            [FieldOffset(HiPart)]
            public Vec128<sbyte> xmm8iH;

            [FieldOffset(HiPart)]
            public Vec128<byte> xmm8uH;

            [FieldOffset(HiPart)]
            public Vec128<short> xmm16iH;

            [FieldOffset(HiPart)]
            public Vec128<ushort> xmm16uH;

            [FieldOffset(HiPart)]
            public Vec128<int> xmm32iH;

            [FieldOffset(HiPart)]
            public Vec128<uint> xmm32uH;

            [FieldOffset(HiPart)]
            public Vec128<long> xmm64iH;

            [FieldOffset(HiPart)]
            public Vec128<ulong> xmm64uH;

            [FieldOffset(HiPart)]
            public Vec128<float> xmm32fH;

            [FieldOffset(HiPart)]
            public Vec128<double> xmm64fH;

            #endregion
        }
    }    
}