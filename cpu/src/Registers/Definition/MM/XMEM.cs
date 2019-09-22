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

        [MethodImpl(Inline)]
        public static XMEM From<T>(Vector128<T> src)
            where T : unmanaged
                => Unsafe.As<Vector128<T>,XMEM>(ref src);

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
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<byte> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<short> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<ushort> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<int> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<uint> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<long> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<ulong> src)
            => From(src);
        
        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<float> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 128-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMEM(Vector128<double> src)
            => From(src);

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
        /// Presents the source content as a 128-bit cpu vector
        /// </summary>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public Vector128<T> Vec<T>()
            where T : unmanaged
                => Vector128.As<byte,T>(vxmm);
    }
}

