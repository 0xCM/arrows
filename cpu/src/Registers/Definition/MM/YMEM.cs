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
    /// as an operand for instructs that accept ymm/mem[256]
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = ByteCount)]
    public unsafe struct YMEM  
    {
        public const int ByteCount = 32;

        [FieldOffset(0)]
        fixed byte mem[ByteCount];

        [FieldOffset(0)]
        Vector256<byte> vymm;

        [FieldOffset(0)]
        YMM ymm;

        [MethodImpl(Inline)]
        YMEM(Vector256<byte> vymm)
            : this()
        {
            this.vymm = vymm;
        }

        [MethodImpl(Inline)]
        YMEM(Vec256<byte> vymm)
            : this()
        {
            this.vymm = vymm;
        }


        [MethodImpl(Inline)]
        public static YMEM From<T>(Vector256<T> src)
            where T : unmanaged
                => Unsafe.As<Vector256<T>,YMEM>(ref src);
                
        /// <summary>
        /// Implicitly converts ymem source value to a ymm register
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator YMM(in YMEM src)
            => src.ymm;

        /// <summary>
        /// Implicly converts an ymem source value to a 256-bit vector of signed 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector256<sbyte>(in YMEM src)
            => src.Vec<sbyte>();

        /// <summary>
        /// Implicly converts an ymem source value to a 256-bit vector of signed 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector256<short>(in YMEM src)
            => src.Vec<short>();

        /// <summary>
        /// Implicly converts an ymem source value to a 256-bit vector of unsigned 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(in YMEM src)
            => src.Vec<byte>();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ushort>(in YMEM src)
            => src.Vec<ushort>();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<int>(in YMEM src)
            => src.Vec<int>();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<uint>(in YMEM src)
            => src.Vec<uint>();

        /// <summary>
        /// Implicly converts a ymem source value to a 256-bit vector of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector256<long>(in YMEM src)
            => src.Vec<long>();

        /// <summary>
        /// Implicly converts an ymem source value to a 256-bit vector of 64-bit usigned integers
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector256<ulong>(in YMEM src)
            => src.Vec<ulong>();

        /// <summary>
        /// Implicly converts an ymem source value to a 256-bit vector of usigned 32-bit floats
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector256<float>(in YMEM src)
            => src.Vec<float>();

        /// <summary>
        /// Implicly converts an ymem source value to a 256-bit vector of usigned 64-bit floats
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector256<double>(in YMEM src)
            => src.Vec<double>();

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator YMEM(Vector256<sbyte> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator YMEM(Vector256<byte> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator YMEM(Vector256<short> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator YMEM(Vector256<ushort> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator YMEM(Vector256<int> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator YMEM(Vector256<uint> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator YMEM(Vector256<long> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator YMEM(Vector256<ulong> src)
            => From(src);
        
        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator YMEM(Vector256<float> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a source vector to a 256-bit memory block
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator YMEM(Vector256<double> src)
            => From(src);

        /// <summary>
        /// Returns a reference to the first element
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref T First<T>()
            where T : unmanaged
                => ref As.generic<T>(ref mem[0]);

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
        /// Presents the source content as a 256-bit cpu vector
        /// </summary>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public Vector256<T> Vec<T>()
            where T : unmanaged
                => Vector256.As<byte,T>(vymm);

    }

}

