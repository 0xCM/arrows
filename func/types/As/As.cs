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
    using System.Runtime.Intrinsics.X86;
    using System.Security;
    
    using static zfunc;

    public static partial class As
    {
        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static Span<T> cast<S,T>(in Span<S> src)                
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);

        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<T> cast<S,T>(in ReadOnlySpan<S> src)                
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);

        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static Span256<T> cast<S,T>(in Span256<S> src)                
            where S : struct
            where T : struct
                => Span256<T>.LoadAligned(MemoryMarshal.Cast<S,T>(src));

        /// <summary>
        /// Reimagines a readonly span of one element type as a readonly span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static ReadOnlySpan256<T> cast<S,T>(in ReadOnlySpan256<S> src)                
            where S : struct
            where T : struct
                => (ReadOnlySpan256<T>)MemoryMarshal.Cast<S,T>(src);
                
        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static Span128<T> cast<S,T>(in Span128<S> src)                
            where S : struct
            where T : struct
                =>  Span128.Load(MemoryMarshal.Cast<S,T>(src));

        /// <summary>
        /// Reimagines a readonly span of one element type as a readonly span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal  static ReadOnlySpan128<T> cast<S,T>(in ReadOnlySpan128<S> src)                
            where S : struct
            where T : struct
                => (ReadOnlySpan128<T>)MemoryMarshal.Cast<S,T>(src);


        [MethodImpl(Inline)]
        public static ref T asRef<T>(in T src)
            => ref Unsafe.AsRef(in src);
        
        [MethodImpl(Inline)]
        public static ref T refAdd<T>(ref T src, int offset)
            => ref Unsafe.Add(ref src, offset);

        [MethodImpl(Inline)]
        public static ref T refAdd<T>(ref T src, IntPtr offset)
            => ref Unsafe.Add(ref src, offset);

        [MethodImpl(Inline)]
        public static ref T inAdd<T>(in T src, IntPtr offset)
            => ref Unsafe.Add(ref asRef(in src), offset);
 
        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<sbyte> uint8<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>, ReadOnlyMemory<sbyte>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<byte> int8<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>, ReadOnlyMemory<byte>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<short> int16<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>, ReadOnlyMemory<short>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<ushort> uint16<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<ushort>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<int> int32<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>, ReadOnlyMemory<int>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<uint> uint32<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<uint>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<long> int64<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>, ReadOnlyMemory<long>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<ulong> uint64<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>, ReadOnlyMemory<ulong>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<float> float32<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>, ReadOnlyMemory<float>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<double> float64<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>, ReadOnlyMemory<double>>(ref src);
 
        [MethodImpl(Inline)]
        public static sbyte[] int8<T>(T[] src)
            => Unsafe.As<T[],sbyte[]>(ref src);

        [MethodImpl(Inline)]
        public static ref sbyte[] int8<T>(ref T[] src)
            => ref Unsafe.As<T[],sbyte[]>(ref src);

        [MethodImpl(Inline)]
        public static byte[] uint8<T>(T[] src)
            => Unsafe.As<T[],byte[]>(ref src);

        [MethodImpl(Inline)]
        public static ref byte[] uint8<T>(ref T[] src)
            => ref Unsafe.As<T[],byte[]>(ref src);

        [MethodImpl(Inline)]
        public static short[] int16<T>(T[] src)
            => Unsafe.As<T[],short[]>(ref src);

        [MethodImpl(Inline)]
        public static ref short[] int16<T>(ref T[] src)
            => ref Unsafe.As<T[],short[]>(ref src);

        [MethodImpl(Inline)]
        public static ushort[] uint16<T>(T[] src)
            => Unsafe.As<T[],ushort[]>(ref src);

        [MethodImpl(Inline)]
        public static ref ushort[] uint16<T>(ref T[] src)
            => ref Unsafe.As<T[],ushort[]>(ref src);

        [MethodImpl(Inline)]
        public static int[] int32<T>(T[] src)
            => Unsafe.As<T[],int[]>(ref src);

        [MethodImpl(Inline)]
        public static ref int[] int32<T>(ref T[] src)
            => ref Unsafe.As<T[],int[]>(ref src);

        [MethodImpl(Inline)]
        public static ref uint[] uint32<T>(ref T[] src)
            => ref Unsafe.As<T[],uint[]>(ref src);

        [MethodImpl(Inline)]
        public static uint[] uint32<T>(T[] src)
            => Unsafe.As<T[],uint[]>(ref src);

        [MethodImpl(Inline)]
        public static long[] int64<T>(T[] src)
            => Unsafe.As<T[],long[]>(ref src);

        [MethodImpl(Inline)]
        public static ref long[] int64<T>(ref T[] src)
            => ref Unsafe.As<T[],long[]>(ref src);

        [MethodImpl(Inline)]
        public static ref ulong[] uint64<T>(ref T[] src)
            => ref Unsafe.As<T[],ulong[]>(ref src);

        [MethodImpl(Inline)]
        public static ulong[] uint64<T>(T[] src)
            => Unsafe.As<T[],ulong[]>(ref src);


        [MethodImpl(Inline)]
        public static float[] float32<T>(T[] src)
            => Unsafe.As<T[],float[]>(ref src);

        [MethodImpl(Inline)]
        public static ref float[] float32<T>(ref T[] src)
            => ref Unsafe.As<T[],float[]>(ref src);

        [MethodImpl(Inline)]
        public static double[] float64<T>(T[] src)
            => Unsafe.As<T[],double[]>(ref src);

        [MethodImpl(Inline)]
        public static ref double[] float64<T>(ref T[] src)
            => ref Unsafe.As<T[],double[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(sbyte[] src)
            => Unsafe.As<sbyte[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref sbyte[] src)
            => ref Unsafe.As<sbyte[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(byte[] src)
            => Unsafe.As<byte[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref byte[] src)
            => ref Unsafe.As<byte[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(short[] src)
            => Unsafe.As<short[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref short[] src)
            => ref Unsafe.As<short[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(ushort[] src)
            => Unsafe.As<ushort[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref ushort[] src)
            => ref Unsafe.As<ushort[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(int[] src)
            => Unsafe.As<int[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref int[] src)
            => ref Unsafe.As<int[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(uint[] src)
            => Unsafe.As<uint[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref uint[] src)
            => ref Unsafe.As<uint[],T[]>(ref src);


        [MethodImpl(Inline)]
        public static T[] generic<T>(long[] src)
            => Unsafe.As<long[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref long[] src)
            => ref Unsafe.As<long[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(ulong[] src)
            => Unsafe.As<ulong[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref ulong[] src)
            => ref Unsafe.As<ulong[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(float[] src)
            => Unsafe.As<float[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref float[] src)
            => ref Unsafe.As<float[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(double[] src)
            => Unsafe.As<double[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref double[] src)
            => ref Unsafe.As<double[],T[]>(ref src);        
    }
}