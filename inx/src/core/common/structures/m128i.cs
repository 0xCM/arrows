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

    using static zfunc;
    using static As;

    public static class m128i
    {

        /// <summary>
        /// Loads a 128-bit integer from a primal span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static m128i<T> From<T>(Span<T> src)
            where T : unmanaged
                => new m128i<T>(src.AsUInt64<T>());

        /// <summary>
        /// Loads a 128-bit integer from an intrinsic vector
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static m128i<T> From<T>(Vector128<T> src)
            where T : unmanaged
                => m128i<T>.From(src);
    }

    /// <summary>
    /// Allocates a 128-bit data block for use with intrinsics. This structure
    /// is essentially a discriminated union where the discriminator
    /// is carried by the type system as a generic parameter
    /// </summary>
     public struct m128i<T>
        where T : unmanaged
     {        
        Block128i data;

        /// <summary>
        /// The number of cells contained by the structure when viewed as a sequence of 8-bit integers
        /// </summary>
        public const int ByteCount = 16;

        /// <summary>
        /// The number of cells contained by the structure when viewed as a sequence of 16-bit integers
        /// </summary>
        public const int ShortCount = 8;

        /// <summary>
        /// The number of cells contained by the structure when viewed as a sequence of 32-bit integers
        /// </summary>
        public const int IntCount = 4;

        /// <summary>
        /// The number of cells contained by the structure when viewed as a sequence of 64-bit integers
        /// </summary>
        public const int LongCount = 2;
                
        /// <summary>
        /// Loads a 128-bit integer from a primal span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static m128i<T> From<S>(Span<S> src)
            where S : unmanaged
                => new m128i<T>(src.AsUInt64<S>());

        /// <summary>
        /// Loads a 128-bit integer from an intrinsic vector
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static m128i<T> From<S>(Vector128<S> src)
            where S : unmanaged
        {
            if (typeof(S) == typeof(sbyte))
                return new m128i<T>(int8(src));
            else if(typeof(S) == typeof(byte))
                return new m128i<T>(uint8(src));
            else if(typeof(S) == typeof(short))
                return new m128i<T>(int16(src));
            else if(typeof(T) == typeof(ushort))
                return new m128i<T>(uint16(src));
            else if(typeof(T) == typeof(int))
                return new m128i<T>(int32(src));
            else if(typeof(T) == typeof(uint))
                return new m128i<T>(uint32(src));
            else if(typeof(T) == typeof(long))
                return new m128i<T>(int64(src));
            else if(typeof(T) == typeof(ulong))
                return new m128i<T>(uint64(src));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vector128<sbyte> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vector128<byte> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vector128<short> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vector128<ushort> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vector128<int> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vector128<uint> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vector128<long> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vector128<ulong> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vec128<sbyte> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vec128<byte> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vec128<short> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vec128<ushort> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vec128<int> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vec128<uint> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vec128<long> src)
            => new m128i<T>(src);

        /// <summary>
        /// Implicitly converts an intrinsic vector to a structure value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator m128i<T>(Vec128<ulong> src)
            => new m128i<T>(src);

        /// <summary>
        /// Initializes the structure with four unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(ulong x0, ulong x1)
            : this()
        {
            data.x0u = x0;
            data.x1u = x1;
        }

        /// <summary>
        /// Initializes the structure with four signed 64-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(long x0, long x1)
            : this()
        {
            data.x0i = x0;
            data.x1i = x1;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vector128<sbyte> src)
            : this()
        {
            data.v128x8i = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vector128<byte> src)
            : this()
        {
            data.v128x8u = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vector128<short> src)
            : this()
        {
            data.v128x16i = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vector128<ushort> src)
            : this()
        {
            data.v128x16u = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vector128<int> src)
            : this()
        {
            data.v128x32i = src;
        }

        [MethodImpl(Inline)]
        public m128i(Vector128<uint> src)
            : this()
        {
            data.v128x32u = src;
        }

        [MethodImpl(Inline)]
        public m128i(Vector128<long> src)
            : this()
        {
            data.v128x64i = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vector128<ulong> src)
            : this()
        {
            data.v128x64u = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vec128<sbyte> src)
            : this()
        {
            data.v128x8i = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vec128<byte> src)
            : this()
        {
            data.v128x8u = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vec128<short> src)
            : this()
        {
            data.v128x16i = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vec128<ushort> src)
            : this()
        {
            data.v128x16u = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vec128<int> src)
            : this()
        {
            data.v128x32i = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vec128<uint> src)
            : this()
        {
            data.v128x32u = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vec128<long> src)
            : this()
        {
            data.v128x64i = src;
        }

        /// <summary>
        /// Initializes the structure with an intrinsi vector
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Vec128<ulong> src)
            : this()
        {
            data.v128x64u = src;
        }

        /// <summary>
        /// Initializes the structure with a span of unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public m128i(Span<ulong> src)
            : this()
        {
            data.x0u = src[0];                    
            data.x1u = src[1];                    
        }

        /// <summary>
        /// Presents the contained data as intrinsic vector with signed 8-bit integer comonents
        /// </summary>
        public Vector128<sbyte> v8i
        {
            [MethodImpl(Inline)]
            get => data.v128x8i;
        }

        /// <summary>
        /// Presents the contained data as intrinsic vector with unsigned 8-bit integer comonents
        /// </summary>
        public Vector128<byte> v8u
        {
            [MethodImpl(Inline)]
            get => data.v128x8u;
        }

        /// <summary>
        /// Presents the contained data as intrinsic vector with signed 16-bit integer comonents
        /// </summary>
        public Vector128<short> v16i
        {
            [MethodImpl(Inline)]
            get => data.v128x16i;
        }

        /// <summary>
        /// Presents the contained data as intrinsic vector with unsigned 16-bit integer comonents
        /// </summary>
        public Vector128<ushort> v16u
        {
            [MethodImpl(Inline)]
            get => data.v128x16u;
        }

        /// <summary>
        /// Presents the contained data as intrinsic vector with signed 32-bit integer comonents
        /// </summary>
        public Vector128<int> v32i
        {
            [MethodImpl(Inline)]
            get => data.v128x32i;
        }

        /// <summary>
        /// Presents the contained data as intrinsic vector with unsigned 32-bit integer comonents
        /// </summary>
        public Vector128<uint> v32u
        {
            [MethodImpl(Inline)]
            get => data.v128x32u;
        }

        /// <summary>
        /// Presents the contained data as intrinsic vector with signed 64-bit integer comonents
        /// </summary>
        public Vector128<long> v64i
        {
            [MethodImpl(Inline)]
            get => data.v128x64i;
        }

        /// <summary>
        /// Presents the contained data as intrinsic vector with unsigned 64-bit integer comonents
        /// </summary>
        public Vector128<ulong> v64u
        {
            [MethodImpl(Inline)]
            get => data.v128x64u;
        }

        /// <summary>
        /// Copies the contained data to a caller-supplied span of primal type
        /// </summary>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public void CopyTo<S>(Span<S> dst)
            where S : unmanaged
        {
            var target = dst.AsUInt64();
            require(target.Length >= LongCount);
            target[0] = data.x0u;
            target[1] = data.x1u;
        }

        /// <summary>
        /// Allocacates a primal span and fills it with the contained data
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public Span<S> ToSpan<S>()
            where S : unmanaged
        {
            Span<byte> dst = new byte[ByteCount];
            CopyTo(dst);
            return dst.As<byte,S>();
        }
 
        [MethodImpl(Inline)]
        public m128i<T> Replicate()
            => new m128i<T>(data.v128x64u);

     }
}