//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;


    partial class Registers
    {
        /// <summary>
        /// Returns a reference to an index-identified source bank slot
        /// </summary>
        /// <param name="src">The source register</param>
        /// <param name="slot">The zero-based index of the register</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref XMM xmm(ref XmmBank src, int slot)
            => ref src.Slot<XMM>(slot);

        /// <summary>
        /// Presents a source register as a cpu vector
        /// </summary>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vec128<T> AsVector<T>(ref XMM src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return ref generic<T>(ref src.xmm8i);
            else if(typeof(T) == typeof(byte))
                return ref generic<T>(ref src.xmm8u);
            else if(typeof(T) == typeof(short))
                return ref generic<T>(ref src.xmm16i);
            else if(typeof(T) == typeof(ushort))
                return ref generic<T>(ref src.xmm16u);
            else if(typeof(T) == typeof(int))
                return ref generic<T>(ref src.xmm32i);
            else if(typeof(T) == typeof(uint))
                return ref generic<T>(ref src.xmm32u);
            else if(typeof(T) == typeof(long))
                return ref generic<T>(ref src.xmm64i);
            else if(typeof(T) == typeof(ulong))
                return ref generic<T>(ref src.xmm64u);
            else if(typeof(T) == typeof(float))
                return ref generic<T>(ref src.xmm32f);
            else if(typeof(T) == typeof(double))
                return ref generic<T>(ref src.xmm64f);
            else
                throw unsupported<T>();
        }

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

            /// <summary>
            /// Returns a reference to the first element
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


            #region Vectors

            [FieldOffset(0)]
            public Vec128<sbyte> xmm8i;

            [FieldOffset(0)]
            public Vec128<byte> xmm8u;

            [FieldOffset(0)]
            public Vec128<short> xmm16i;

            [FieldOffset(0)]
            public Vec128<ushort> xmm16u;

            [FieldOffset(0)]
            public Vec128<int> xmm32i;

            [FieldOffset(0)]
            public Vec128<uint> xmm32u;

            [FieldOffset(0)]
            public Vec128<long> xmm64i;

            [FieldOffset(0)]
            public Vec128<ulong> xmm64u;

            [FieldOffset(0)]
            public Vec128<float> xmm32f;

            [FieldOffset(0)]
            public Vec128<double> xmm64f;

            #endregion
        }
    }    
}