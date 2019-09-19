//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    partial class SpanExtensions
    {
        /// <summary>
        /// Lifts the content of a span into a LINQ enumerable
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> ToEnumerable<T>(this ReadOnlySpan<T> src)
            => src.ToArray();
            
        /// <summary>
        /// Lifts the content of a span into a LINQ enumerable
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> ToEnumerable<T>(this Span<T> src)
            => src.ReadOnly().ToEnumerable();            

        /// <summary>
        /// Constructs a span from an array
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this T[] src)
            => src;

        /// <summary>
        /// Constructs a span from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this ReadOnlySpan<T> src)
        {
            Span<T> dst = new T[src.Length];
            src.CopyTo(dst);
            return dst;
        }

        /// <summary>
        /// Constructs a span from an aray
        /// </summary>
        /// <param name="src">The source aray</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this T[] src)
            => src;

        /// <summary>
        /// Constructs a span from a (presumeably finite) sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="offset">The number of elements to skip from the head of the sequence</param>
        /// <param name="length">The number of elements to take from the sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> TakeSpan<T>(this IEnumerable<T> src, int? offset = null, int? length = null)
        {
            var elements = length == null ? src.Skip(offset ?? 0) : src.Skip(offset ?? 0).Take(length.Value);
            return elements.ToArray();
        }

        /// <summary>
        /// Constructs a span from an array selection
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="start">The array index where the span is to begin</param>
        /// <param name="length">The number of elements to cover from the aray</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> TakeSpan<T>(this T[] src, int offset, int length)
            => new Span<T>(src, offset, length);

        /// <summary>
        /// Creates a set from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ISet<T> ToSet<T>(this Span<T> src)        
            => new HashSet<T>(src.ToEnumerable());

        /// <summary>
        /// Creates a dictionary from a span using the element indices as keys
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IDictionary<int,T> ToDictionary<T>(this Span<T> src)        
            => src.ReadOnly().ToDictionary();

        /// <summary>
        /// Creates a set from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ISet<T> ToSet<T>(this ReadOnlySpan<T> src)        
            => new HashSet<T>(src.ToEnumerable());

        /// <summary>
        /// Constructs a 256-bit blocked span from an array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this T[] src)
            where T : struct
            => Z0.Span256.Load<T>(src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this Span<T> src)
             where T : struct
                => Z0.Span128.Load(src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this Span<T> src)
             where T : struct
                => Z0.Span256.Load(src);

        /// <summary>
        /// Presents a readonly span of one value-type as a span of another value-type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source span element type</typeparam>
        /// <typeparam name="T">The target span element type</typeparam>
        [MethodImpl(Inline)]        
        public static ReadOnlySpan<T> As<S,T>(this ReadOnlySpan<S> src)
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);                                    

        /// <summary>
        /// Presents a span of one value-type as a span of another value-type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source span element type</typeparam>
        /// <typeparam name="T">The target span element type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<T> As<S,T>(this Span<S> src)
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);                                    
        
        /// <summary>
        /// Reimagines a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of uint16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ushort> AsUInt16<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ushort>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of uint32
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<uint> AsUInt32<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,uint>(src);
 
        /// <summary>
        /// Reimagines a span of generic values as a span of uint64
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ulong> AsUInt64<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ulong>(src);

        /// <summary>
        /// Reimagines a readonly span of generic values as a span of readonly bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source span element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(this ReadOnlySpan<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Reads a partial value if there aren't a sufficient number of bytes to comprise a target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T TakeScalar<T>(this Span<byte> src)
            where T : unmanaged
        {
            if(src.Length >= Unsafe.SizeOf<T>())
                return MemoryMarshal.Read<T>(src);
            else if(src.Length == 0)
                return default;
            else
            {
                Span<byte> tmp = stackalloc byte[Unsafe.SizeOf<T>()];
                src.CopyTo(tmp);
                return MemoryMarshal.Read<T>(tmp);
            }
        }

        /// <summary>
        /// Copies at most n bytes from the source span to the target span where n is the length of the target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static Span<byte> TakeBytes(this ReadOnlySpan<byte> src, Span<byte> dst)
        {
            if(src.Length > dst.Length)
                src.Slice(0,dst.Length).CopyTo(dst);
            else
                src.CopyTo(dst);
            return dst;
        }

        /// <summary>
        /// If the source is nonempty, converts the leading element to an 8-bit signed integer;
        /// otherwise, returns 0
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static sbyte TakeInt8<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
            => src.Length > 0 ? (sbyte)src.AsBytes()[0] : (sbyte)0;            

        /// <summary>
        /// If the source is nonempty, converts the leading element to an 8-bit signed integer;
        /// otherwise, returns 0
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static sbyte TakeInt8<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeInt8();

        /// <summary>
        /// If the source is nonempty, converts the leading element to an 8-bit unsigned integer;
        /// otherwise, returns 0
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
            => src.Length > 0 ? src.AsBytes()[0] : (byte)0;

        /// <summary>
        /// If the source is nonempty, converts the leading element to an 8-bit unsigned integer;
        /// otherwise, returns 0
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeUInt8();
 
        /// <summary>
        /// Converts the leading elements of a primal source span to a 16-bit signed integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static short TakeInt16<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
        {
            Span<byte> dst = stackalloc byte[2];       
            return BitConverter.ToInt16(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 16-bit signed integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static short TakeInt16<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeInt16();

        /// <summary>
        /// Converts the leading elements of a primal source span to a 16-bit unsigned integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ushort TakeUInt16<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[2];       
            return BitConverter.ToUInt16(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 16-bit unsigned integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ushort TakeUInt16<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeUInt16();

        /// <summary>
        /// Converts the leading elements of a primal source span to a 32-bit signed integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static int TakeInt32<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[4];       
            return BitConverter.ToInt32(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 32-bit signed integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static int TakeInt32<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeInt32();

        /// <summary>
        /// Converts the leading elements of a primal source span to a 32-bit usigned integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[4];       
            return BitConverter.ToUInt32(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 32-bit usigned integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeUInt32();

        /// <summary>
        /// Converts the leading elements of a primal source span to a 64-bit signed integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static long TakeInt64<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[8];       
            return BitConverter.ToInt64(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 64-bit signed integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static long TakeInt64<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeInt64();

        /// <summary>
        /// Converts the leading elements of a primal source span to a 64-bit unsigned integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            Span<byte> dst = stackalloc byte[8];       
            return BitConverter.ToUInt64(src.AsBytes().TakeBytes(dst));
        }

        /// <summary>
        /// Converts the leading elements of a primal source span to a 64-bit unsigned integer,
        /// 0-filling the high bits if the source is too short
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeUInt64();         
    }

}