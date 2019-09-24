//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zfunc;

    partial class dinx    
    {

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> negate(Vector128<sbyte> src)
            =>  sub(Vector128<sbyte>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> negate(Vector128<byte> src)
            =>  add(BitUtil.flip(src), Vec128.Ones<byte>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> negate(Vector128<short> src)
            =>  sub(Vector128<short>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> negate(Vector128<ushort> src)
            =>  add(BitUtil.flip(src), Vec128.Ones<ushort>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> negate(Vector128<int> src)
            =>  sub(Vector128<int>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> negate(Vector128<uint> src)
            =>  add(BitUtil.flip(src), Vec128.Ones<uint>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> negate(Vector128<long> src)
            =>  sub(Vector128<long>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> negate(Vector128<ulong> src)
            =>  add(BitUtil.flip(src), Vec128.Ones<ulong>());

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> negate(Vector256<byte> src)
            =>  add(BitUtil.flip(src), Vec256.Ones<byte>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> negate(Vector256<short> src)
            =>  sub(Vector256<short>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> negate(Vector256<ushort> src)
            =>  add(BitUtil.flip(src), Vec256.Ones<ushort>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> negate(Vector256<int> src)
            =>  sub(Vector256<int>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> negate(Vector256<uint> src)
            =>  add(BitUtil.flip(src), Vec256.Ones<uint>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> negate(Vector256<long> src)
            =>  sub(Vector256<long>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> negate(Vector256<ulong> src)
            =>  add(BitUtil.flip(src), Vec256.Ones<ulong>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> negate(Vector256<sbyte> src)
            =>  sub(Vector256<sbyte>.Zero, src);

    }
}