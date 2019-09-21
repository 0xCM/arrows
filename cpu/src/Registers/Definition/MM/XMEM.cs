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


    /// <summary>
    /// Encapsulates register or memory data and values of this type serve 
    /// as an operand for instructs that accept xmm/xem[128]
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = ByteCount)]
    public unsafe struct XMEM  
    {
        public const int ByteCount = 16;

        [FieldOffset(0)]
        fixed byte mem[ByteCount];

        [FieldOffset(0)]
        Vector128<byte> vxmm;

        [FieldOffset(0)]
        XMM xmm;

        [MethodImpl(Inline)]
        XMEM(Vector128<byte> vxmm)
            : this()
        {
            this.vxmm = vxmm;
        }

        [MethodImpl(Inline)]
        XMEM(XMM xmm)
            : this()
        {
            this.xmm = xmm;
        }

        /// <summary>
        /// Assigns the source vector to an exising instance of a target memory/register
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public static ref XMEM Assign<T>(Vector128<T> src, ref XMEM dst)
            where T : unmanaged
        {
            dst.vxmm = Vector128.As<T,byte>(src);
            return ref dst;
        }

        /// <summary>
        /// Allocates the target and populates it with a source vector
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public static ref XMEM Load<T>(Vector128<T> src, out XMEM dst)
            where T : unmanaged
        {
            dst = new XMEM(Vector128.As<T,byte>(src));
            return ref dst;
        }

        /// <summary>
        /// Implicitly converts ymem source value to a ymm register
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM(in XMEM src)
            => src.xmm;

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<sbyte> src)
        {
            Load(src, out XMEM dst);
            return dst;
        }

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<byte> src)
        {
            Load(src, out XMEM dst);
            return dst;
        }

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<short> src)
        {
            Load(src, out XMEM dst);
            return dst;
        }

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<ushort> src)
        {
            Load(src, out XMEM dst);
            return dst;
        }

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<int> src)
        {
            Load(src, out XMEM dst);
            return dst;
        }

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<uint> src)
        {
            Load(src, out XMEM dst);
            return dst;
        }

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<long> src)
        {
            Load(src, out XMEM dst);
            return dst;
        }

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<ulong> src)
        {
            Load(src, out XMEM dst);
            return dst;
        }
        
        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<float> src)
        {
            Load(src, out XMEM dst);
            return dst;
        }

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<double> src)
        {
            Load(src, out XMEM dst);
            return dst;
        }

        /// <summary>
        /// Implicly converts an xmem source value to a 128-bit vector of usigned 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector128<byte>(in XMEM src)
            => src.Vec<byte>();

        /// <summary>
        /// Implicly converts an xmem source value to a 128-bit vector of signed 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector128<sbyte>(in XMEM src)
            => src.Vec<sbyte>();

        /// <summary>
        /// Implicly converts an xmem source value to a 128-bit vector of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector128<short>(in XMEM src)
            => src.Vec<short>();

        /// <summary>
        /// Implicly converts an xmem source value to a 128-bit vector of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector128<ushort>(in XMEM src)
            => src.Vec<ushort>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<int>(in XMEM src)
            => src.Vec<int>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<uint>(in XMEM src)
            => src.Vec<uint>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<long>(in XMEM src)
            => src.Vec<long>();

        /// <summary>
        /// Implictly presents the encapsulated data as a 128-bit cpu vector of 64-bit uinsigned integers
        /// </summary>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(in XMEM src)
            => src.Vec<ulong>();

        /// <summary>
        /// Implicly converts an xmem source value to a 128-bit vector of usigned 32-bit floats
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector128<float>(in XMEM src)
            => src.Vec<float>();

        /// <summary>
        /// Implicly converts an xmem source value to a 128-bit vector of usigned 64-bit floats
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector128<double>(in XMEM src)
            => src.Vec<double>();

        /// <summary>
        /// Returns a reference to the first memory cell of the encapsulated data
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T First<T>()
            where T : unmanaged
                => ref As.generic<T>(ref mem[0]);

        /// <summary>
        /// Gets the value of an index-identified memory cell
        /// </summary>
        /// <param name="index">The zero-based cell index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T Cell<T>(int index)
            where T : unmanaged
                => ref Unsafe.Add(ref First<T>(), index);
            
        /// <summary>
        /// Presents the source content as a 128-bit cpu vector
        /// </summary>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public Vector128<T> Vec<T>()
            where T : unmanaged
                => Vector128.As<byte,T>(vxmm);
    }
}

