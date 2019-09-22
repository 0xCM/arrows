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
    using static As;
    using static AsIn;

    using static zfunc;

    

    [StructLayout(LayoutKind.Sequential, Size = ByteCount)]
    public struct YMM : IMMReg, ICpuReg256, IEquatable<YMM>
    {
        readonly ulong x0;

        readonly ulong x1;

        readonly ulong x2;

        readonly ulong x3;

        public const int ByteCount = 32;      

        public static readonly BitSize BitWidth = 256;  

        /// <summary>
        /// Defines a 1-filled YMM register
        /// </summary>
        public static readonly YMM Ones = FromCells(ulong.MaxValue, ulong.MaxValue, ulong.MaxValue, ulong.MaxValue);    

        /// <summary>
        /// Defines a 0-filled YMM register
        /// </summary>
        public static readonly YMM Zero = FromCells(0ul, 0ul, 0ul, 0ul);

        /// <summary>
        /// Creates a register with content from a cell parameter array
        /// </summary>
        /// <param name="cells">The cell content</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static YMM FromCells<T>(params T[] cells)
            where T : unmanaged
        {
            YMM dst = default;
            var len = Math.Min(cells.Length, CellCount<T>());
            for(var i=0; i<len; i++)              
                dst.Cell<T>(i) = cells[i];
            return dst;
        }

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
        public static YMM From<T>(Span<T> src)
            where T : unmanaged
        {
            var target = default(YMM);
            var count = Math.Min(CellCount<T>(), src.Length);
            ref var head = ref target.First<T>();
            for(var i=0; i< count; i++)
                Unsafe.Add(ref head, i) = src[i];
            return target;
        }

        [MethodImpl(Inline)]
        public static YMM From<T>(Span256<T> src)
            where T : unmanaged
                => From(src.Unblocked);

        [MethodImpl(Inline)]
        public static ref T As<T>(ref YMM src)
            where T : unmanaged
                => ref Unsafe.As<YMM, T>(ref src);

        /// <summary>
        /// Presents a generic cpu vector as a register
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static YMM From<T>(Vector256<T> src)
            where T : unmanaged
                => Unsafe.As<Vector256<T>,YMM>(ref src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<sbyte> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<byte> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<short> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<ushort> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<int> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<uint> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<long> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<ulong> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<float> src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator YMM(Vector256<double> src)
            => From(src);

        [MethodImpl(Inline)]
        public static bool operator ==(in YMM lhs, in YMM rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in YMM lhs, in YMM rhs)
            =>!lhs.Equals(rhs);

        /// <summary>
        /// Replaces the content of the target register with source vector content
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public void Assign<T>(Vector256<T> src)
            where T : unmanaged
        {
            bytes(src).CopyTo(this.AsSpan<byte>());
        }
        
        [MethodImpl(Inline)]
        public Span<T> AsSpan<T>()
            where T : unmanaged
                => BitView.ViewBits(ref this).Bytes.As<T>();

        /// <summary>
        /// Returns a reference to the first cell
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T First<T>()
            where T : unmanaged
                => ref BitView.ViewBits(ref this).Bytes.As<T>()[0];
                            
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
        public bool Equals(YMM rhs)
            => x0 == rhs.x0 && x1 == rhs.x1 
            && x2 == rhs.x2 && x3 == rhs.x3;

        [MethodImpl(Inline)]
        public string Format<T>()
            where T : unmanaged
                =>  AsSpan<T>().FormatCellBlocks();

        public override string ToString()
            => Format<ulong>();

        public override bool Equals(object obj)
            => obj is YMM x && Equals(x);
        
        public override int GetHashCode()
            => x0.GetHashCode() + x1.GetHashCode();

    }
}    
