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

        [MethodImpl(Inline)]
        public static Span<byte> AsByteSpan<T>(this T[] src)
            where T : struct
                => MemoryMarshal.AsBytes(src.AsSpan());


        /// <summary>
        /// Reimagines a span of generic values as a span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<sbyte> AsSBytes<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,sbyte>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of int16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<short> AsInt16<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,short>(src);

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
        /// Reimagines a span of generic values as a span of int32
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<int> AsInt32<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,int>(src);

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
        /// Reimagines a span of generic values as a span of int64
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<long> AsInt64<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,long>(src);

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
        /// Reimagines a span of generic values as a span of sbytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> AsSBytes<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,sbyte>(src);

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
        /// Reimagines a span of generic values as a span of int16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> AsInt16<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,short>(src);

        /// <summary>
        /// Reimagines a readonly span of generic values as a readonly span of uint16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> AsUInt16<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ushort>(src);

        /// <summary>
        /// Reimagines a readonly span of generic values as a readonly span of int32
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> AsInt32<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,int>(src);

        /// <summary>
        /// Reimagines a readonly span of generic values as a readonly span of uint32
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> AsUInt32<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> AsInt64<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,long>(src);
        
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> AsUInt64<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ulong>(src);

        /// <summary>
        /// Reads a partial value if there aren't a sufficient number of bytes to comprise a target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T TakePartial<T>(this Span<byte> src)
            where T : struct
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

        [MethodImpl(Inline)]
        public static sbyte TakeInt8<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.Slice(offset).AsSBytes()[0];

        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.Slice(offset).AsBytes()[0];

        [MethodImpl(Inline)]
        public static short TakeInt16<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.ByteCount(offset) >= sizeof(ushort) ? src.Slice(offset).AsInt16()[0] : (short)0;

        [MethodImpl(Inline)]
        public static ushort TakeUInt16<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.ByteCount(offset) >= sizeof(ushort) ? src.Slice(offset).AsUInt16()[0] : (ushort)0;

        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.ByteCount(offset) >= sizeof(uint) ? src.Slice(offset).AsUInt32()[0] : 0;

        [MethodImpl(Inline)]
        public static int TakeInt32<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.ByteCount(offset) >= sizeof(int) ? src.Slice(offset).AsInt32()[0] : 0;

        [MethodImpl(Inline)]
        public static long TakeInt64<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.ByteCount(offset) >= sizeof(long) ? src.Slice(offset).AsInt64()[0] : 0;

        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct
                => src.ByteCount(offset) >= sizeof(ulong) ? src.Slice(offset).AsUInt64()[0] : 0;                
        
        [MethodImpl(Inline)]
        public static sbyte TakeInt8<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeInt8(offset);

        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeUInt8(offset);
        
        [MethodImpl(Inline)]
        public static short TakeInt16<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeInt16(offset);

        [MethodImpl(Inline)]
        public static ushort TakeUInt16<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeUInt16(offset);

        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeUInt32(offset);

        [MethodImpl(Inline)]
        public static int TakeInt32<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeInt32(offset);

        [MethodImpl(Inline)]
        public static long TakeInt64<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeInt64(offset);

        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeUInt64(offset); 
        
        static Exception unsupported<T>()
            => new Exception($"The type {typeof(T).Name} is unsupported");
    }

}