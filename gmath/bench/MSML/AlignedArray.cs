// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//This code in this file was extracted from the MSML project
namespace MS
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using nuint = System.UInt64;

    using static zcore;

    /// <summary>
    /// This implements a logical array of floats that is automatically aligned for SSE/AVX operations.
    /// To pin and force alignment, call the GetPin method, typically wrapped in a using (since it
    /// returns a Pin struct that is IDisposable). From the pin, you can get the IntPtr to pass to
    /// native code.
    ///
    /// The ctor takes an alignment value, which must be a power of two at least sizeof(float).
    /// </summary>
    public sealed class AlignedArray
    {
        /// <summary>
        /// Sets the matrix items to zero.
        /// </summary>
        /// <param name="destination">The destination values.</param>
        /// <param name="ccol">The stride column.</param>
        /// <param name="cfltRow">The row to use.</param>
        /// <param name="indices">The indicies.</param>
        public static void ZeroMatrixItems(AlignedArray destination, int ccol, int cfltRow, int[] indices)
        {
            Contracts.Assert(ccol > 0);
            Contracts.Assert(ccol <= cfltRow);

            if (ccol == cfltRow)
            {
                ZeroItemsU(destination, destination.Size, indices, indices.Length);
            }
            else
            {
                ZeroMatrixItemsCore(destination, destination.Size, ccol, cfltRow, indices, indices.Length);
            }
        }

        public static unsafe void ZeroItemsU(AlignedArray destination, int c, int[] indices, int cindices)
        {
            fixed (float* pdst = &destination.Items[0])
            fixed (int* pidx = &indices[0])
            {
                for (int i = 0; i < cindices; ++i)
                {
                    int index = pidx[i];
                    Contracts.Assert(index >= 0);
                    Contracts.Assert(index < c);
                    pdst[index] = 0;
                }
            }
        }

        public static unsafe void ZeroMatrixItemsCore(AlignedArray destination, int c, int ccol, int cfltRow, int[] indices, int cindices)
        {
            fixed (float* pdst = &destination.Items[0])
            fixed (int* pidx = &indices[0])
            {
                int ivLogMin = 0;
                int ivLogLim = ccol;
                int ivPhyMin = 0;

                for (int i = 0; i < cindices; ++i)
                {
                    int index = pidx[i];
                    Contracts.Assert(index >= 0);
                    Contracts.Assert(index < c);

                    int col = index - ivLogMin;
                    if ((uint)col >= (uint)ccol)
                    {
                        Contracts.Assert(ivLogMin > index || index >= ivLogLim);

                        int row = index / ccol;
                        ivLogMin = row * ccol;
                        ivLogLim = ivLogMin + ccol;
                        ivPhyMin = row * cfltRow;

                        Contracts.Assert(index >= ivLogMin);
                        Contracts.Assert(index < ivLogLim);
                        col = index - ivLogMin;
                    }

                    pdst[ivPhyMin + col] = 0;
                }
            }
        }



        // Items includes "head" items filled with NaN, followed by _size entries, followed by "tail"
        // items, also filled with NaN. Note that _size * sizeof(Float) is divisible by _cbAlign.
        // It is illegal to access any slot outsize [_base, _base + _size). This is internal so clients
        // can easily pin it.
        public float[] Items;

        private readonly int _size; // Must be divisible by (_cbAlign / sizeof(Float)).
        private readonly int _cbAlign; // The alignment in bytes, a power of two, divisible by sizeof(Float).
        private int _base; // Where the values start in Items (changes to ensure alignment).

        private object _lock; // Used to make sure only one thread can re-align the values.

        /// <summary>
        /// Allocate an aligned vector with the given alignment (in bytes).
        /// The alignment must be a power of two and at least sizeof(Float).
        /// </summary>
        public AlignedArray(int size, int cbAlign)
        {
            demand(0 < size);
            // cbAlign should be a power of two.
            demand(sizeof(float) <= cbAlign);
            demand((cbAlign & (cbAlign - 1)) == 0);
            // cbAlign / sizeof(Float) should divide size.
            demand((size * sizeof(float)) % cbAlign == 0);

            Items = new float[size + cbAlign / sizeof(float)];
            _size = size;
            _cbAlign = cbAlign;
            _lock = new object();
        }

        public unsafe int GetBase(long addr)
        {
#if DEBUG
            fixed (float* pv = Items)
                demand((float*)addr == pv);
#endif

            int cbLow = (int)(addr & (_cbAlign - 1));
            int ibMin = cbLow == 0 ? 0 : _cbAlign - cbLow;
            demand(ibMin % sizeof(float) == 0);

            int ifltMin = ibMin / sizeof(float);
            if (ifltMin == _base)
                return _base;

            MoveData(ifltMin);
#if DEBUG
            // Anything outsize [_base, _base + _size) should not be accessed, so
            // set them to NaN, for debug validation.
            for (int i = 0; i < _base; i++)
                Items[i] = float.NaN;
            for (int i = _base + _size; i < Items.Length; i++)
                Items[i] = float.NaN;
#endif
            return _base;
        }

        private void MoveData(int newBase)
        {
            lock (_lock)
            {
                // Since the array is already pinned, addr and ifltMin in GetBase() cannot change
                // so all we need is to make sure the array is moved only once.
                if (_base != newBase)
                {
                    Array.Copy(Items, _base, Items, newBase, _size);
                    _base = newBase;
                }
            }
        }

        public int Size { get { return _size; } }

        public int CbAlign { get { return _cbAlign; } }

        public float this[int index]
        {
            get
            {
                demand(0 <= index && index < _size);
                return Items[index + _base];
            }
            set
            {
                demand(0 <= index && index < _size);
                Items[index + _base] = value;
            }
        }

        public void CopyTo(Span<float> dst, int index, int count)
        {
            demand(0 <= count && count <= _size);
            demand(dst != null);
            demand(0 <= index && index <= dst.Length - count);
            Items.AsSpan(_base, count).CopyTo(dst.Slice(index));
        }

        public void CopyTo(int start, Span<float> dst, int index, int count)
        {
            demand(0 <= count);
            demand(0 <= start && start <= _size - count);
            demand(dst != null);
            demand(0 <= index && index <= dst.Length - count);
            Items.AsSpan(start + _base, count).CopyTo(dst.Slice(index));
        }

        public void CopyFrom(ReadOnlySpan<float> src)
        {
            demand(src.Length <= _size);
            src.CopyTo(Items.AsSpan(_base));
        }

        public void CopyFrom(int start, ReadOnlySpan<float> src)
        {
            demand(0 <= start && start <= _size - src.Length);
            src.CopyTo(Items.AsSpan(start + _base));
        }

        // Copies values from a sparse vector.
        // valuesSrc contains only the non-zero entries. Those are copied into their logical positions in the dense array.
        // rgposSrc contains the logical positions + offset of the non-zero entries in the dense array.
        // rgposSrc runs parallel to the valuesSrc array.
        public void CopyFrom(ReadOnlySpan<int> rgposSrc, ReadOnlySpan<float> valuesSrc, int posMin, int iposMin, int iposLim, bool zeroItems)
        {
            demand(rgposSrc != null);
            demand(valuesSrc != null);
            demand(rgposSrc.Length <= valuesSrc.Length);
            demand(0 <= iposMin && iposMin <= iposLim && iposLim <= rgposSrc.Length);

            // Zeroing-out and setting the values in one-pass does not seem to give any perf benefit.
            // So explicitly zeroing and then setting the values.
            if (zeroItems)
                ZeroItems();

            for (int ipos = iposMin; ipos < iposLim; ++ipos)
            {
                demand(posMin <= rgposSrc[ipos]);
                int iv = _base + rgposSrc[ipos] - posMin;
                demand(iv < _size + _base);
                Items[iv] = valuesSrc[ipos];
            }
        }

        public void CopyFrom(AlignedArray src)
        {
            demand(src != null);
            demand(src._size == _size);
            demand(src._cbAlign == _cbAlign);
            Array.Copy(src.Items, src._base, Items, _base, _size);
        }

        public void ZeroItems()
        {
            Array.Clear(Items, _base, _size);
        }

        public void ZeroItems(int[] rgposSrc, int posMin, int iposMin, int iposLim)
        {
            demand(rgposSrc != null);
            demand(0 <= iposMin && iposMin <= iposLim && iposLim <= rgposSrc.Length);
            demand(iposLim - iposMin <= _size);

            int ivCur = 0;
            for (int ipos = iposMin; ipos < iposLim; ++ipos)
            {
                int ivNextNonZero = rgposSrc[ipos] - posMin;
                demand(ivCur <= ivNextNonZero && ivNextNonZero < _size);
                while (ivCur < ivNextNonZero)
                    Items[_base + ivCur++] = 0;
                demand(ivCur == ivNextNonZero);
                // Skip the non-zero element at ivNextNonZero.
                ivCur++;
            }

            while (ivCur < _size)
                Items[_base + ivCur++] = 0;
        }

        // REVIEW: This is hackish and slightly dangerous. Perhaps we should wrap this in an
        // IDisposable that "locks" this, prohibiting GetBase from being called, while the buffer
        // is "checked out".
        public void GetRawBuffer(out float[] items, out int offset)
        {
            items = Items;
            offset = _base;
        }
    }
}