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


    [StructLayout(LayoutKind.Sequential, Size = ByteCount)]
    public unsafe struct XMM : IMMReg, ICpuReg128, IEquatable<XMM>
    {

        ulong x0;

        ulong x1;

        public const int ByteCount = 16;

        public static readonly BitSize BitWidth = 128;    

        /// <summary>
        /// Defines a 1-filled XMM register
        /// </summary>
        public static readonly XMM Ones = FromCells(ulong.MaxValue, ulong.MaxValue);    

        /// <summary>
        /// Defines a 0-filled XMM register
        /// </summary>
        public static readonly XMM Zero = FromCells(0ul, 0ul);

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
        public static XMM From<T>(Span<T> src)
            where T : unmanaged
        {
            var target = default(XMM);
            var count = Math.Min(CellCount<T>(), src.Length);
            ref var head = ref target.First<T>();
            for(var i=0; i< count; i++)
                Unsafe.Add(ref head, i) = src[i];
            return target;
        }

        /// <summary>
        /// Replaces the content of the target register with source vector content
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public void Assign<T>(Vector128<T> src)
            where T : unmanaged
        {
            bytes(src).CopyTo(this.AsSpan<byte>());
        }
        

        /// <summary>
        /// Presents a generic cpu vector as a register
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static XMM From<T>(Vector128<T> src)
            where T : unmanaged
                => Unsafe.As<Vector128<T>,XMM>(ref src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<sbyte> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<byte> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<short> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<ushort> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<int> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<uint> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<long> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<ulong> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<float> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator XMM(Vector128<double> src)
            => From(src);

        [MethodImpl(Inline)]
        public static bool operator ==(XMM lhs, XMM rhs)
            =>lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(XMM lhs, XMM rhs)
            =>!lhs.Equals(rhs);

        /// <summary>
        /// Presents the data in the register as a span
        /// </summary>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public Span<T> AsSpan<T>()
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(BitView.ViewBits(ref this).Bytes);

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
        /// Returns a reference to the first cell
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T First<T>()
            where T : unmanaged
                => ref BitView.ViewBits(ref this).Bytes.As<T>()[0];

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
    


        /// <summary>
        /// Evaluates registers for content equality
        /// </summary>
        /// <param name="rhs">The other registers</param>
        [MethodImpl(Inline)]
        public bool Equals(XMM rhs)
            => x0 == rhs.x0 && x1 == rhs.x1;

        public string Format<T>()
            where T : unmanaged
                =>  AsSpan<T>().FormatCellBlocks();

        public override string ToString()
            => Format<ulong>();


        public override bool Equals(object obj)
            => obj is XMM x ? Equals(x) : false;
        
        public override int GetHashCode()
            => x0.GetHashCode() + x1.GetHashCode();
        

    }
}    
