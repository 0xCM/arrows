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

    /// <summary>
    /// Defines various methods that extract/interrogate span content
    /// </summary>
    public static class SpanQueries
    {
        /// <summary>
        /// Determines whether any elements of the source match the target
        /// </summary>
        /// <param name="src">The source values</param>
        /// <param name="target">The target value to match</param>
        /// <typeparam name="T">The value type</typeparam>
        public static bool Contains<T>(this ReadOnlySpan<T> src, T target)        
            where T : struct
        {
            var enumerator = src.GetEnumerator();
            while(enumerator.MoveNext())
                if(enumerator.Current.Equals(target))
                    return true;
            return false;
        }

        [MethodImpl(Inline)]
        public static bool Contains<T>(this Span<T> src, T match)        
            where T : struct
                => src.ReadOnly().Contains(match);

        /// <summary>
        /// Returns a reference to the first element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T First<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref src[0];
        }

        /// <summary>
        /// Returns a reference to the last element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Last<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref src[src.Length - 1];
        }

        /// <summary>
        /// Returns a readonly reference to the first element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T First<T>(this ReadOnlySpan<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref src[0];
        }

        /// <summary>
        /// Returns a readonly reference to the last element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T Last<T>(this ReadOnlySpan<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref src[src.Length - 1];
        }

        /// <summary>
        /// Determines whether any elements of a span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        public static bool Any<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
        {
            var it = src.GetEnumerator();
            while(it.MoveNext())
                if(f(it.Current))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether any elements of a span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static bool Any<T>(this Span<T> src, Func<T,bool> f)
             where T : struct
                => src.ReadOnly().Any(f);

        /// <summary>
        /// Counts the number of values in the source that satisfy the predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate to evaluate over each element</param>
        /// <typeparam name="T">The element type</typeparam>
        public static int Count<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
             where T : struct
        {
            int count = 0;
            for(var i=0; i< src.Length; i++)
                if(f(src[i]))
                    count++;
            return count;
        }

        /// <summary>
        /// Counts the number of values in the source that satisfy the predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate to evaluate over each element</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static int Count<T>(this Span<T> src, Func<T,bool> f)
             where T : struct
             => src.ReadOnly().Count(f);

        /// <summary>
        /// Determines whether all of the elements of a source span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        public static bool All<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
             where T : struct
        {
            var it = src.GetEnumerator();
            while(it.MoveNext())
                if(!f(it.Current))
                    return false;
            return true;
        }

        /// <summary>
        /// Determines whether all of the elements of a source span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static bool All<T>(this Span<T> src, Func<T,bool> f)
             where T : struct  
                => src.ReadOnly().All(f);

        /// <summary>
        /// Counts the number of bytes stored in a span following an offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The offset value</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize ByteCount<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => (src.Length - offset) * Unsafe.SizeOf<T>();


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
        /// Reimagines a 256-bit bloocked span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span256<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src.Unblocked);

        /// <summary>
        /// Reimagines a 256-bit bloocked span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span128<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src.Unblock());

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
 
        [MethodImpl(Inline)]
        public static Span<byte> ToBytes<T>(this T src)
            where T : struct
        {
            Span<T> s = new T[1]{src};
            return MemoryMarshal.AsBytes(s);
        }        

        [MethodImpl(Inline)]
        public static T FromBytes<T>(this Span<byte> src)
            where T : struct
        {
            if(MemoryMarshal.TryRead(src, out T value))
                return value;
            else
                throw unsupported<T>();
        }

       [MethodImpl(Inline)]
        public static T ReadValue<T>(this ReadOnlySpan<byte> src, int offset = 0)
            where T : struct
        {
            if(MemoryMarshal.TryRead(src.Slice(offset), out T value))                
                return value;
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T ReadValue<T>(this Span<byte> src, int offset = 0)
            where T : struct
                => src.ReadOnly().ReadValue<T>(offset);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this ReadOnlySpan<byte> src, int offset, int count)
            where T : struct
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, count * Unsafe.SizeOf<T>()));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this Span<byte> src, int offset, int count)
            where T : struct
                => src.ReadOnly().ReadValues<T>(offset,count);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this ReadOnlySpan<byte> src)
            where T : struct
                => src.ReadValues<T>(0, src.Length/Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this Span<byte> src)
            where T : struct        
                => src.ReadOnly().ReadValues<T>();

        /// <summary>
        /// Reads a readonly span of bytes from a span of value types
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of source elements to skip from the head</param>
        /// <param name="length">Tne number of source elements to read</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> ReadBytes<T>(this ReadOnlySpan<T> src, int? offset = null, int? length = null)
            where T : struct
        {
            if(offset == null && length == null)
                return MemoryMarshal.AsBytes(src);
            else if(offset != null && length == null)
                return MemoryMarshal.AsBytes(src.Slice(offset.Value));
            else
                return MemoryMarshal.AsBytes(src.Slice(offset.Value,length.Value));
        }
                
        /// <summary>
        /// Reads a span of bytes from a span of value types
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of source elements to skip from the head</param>
        /// <param name="length">Tne number of source elements to read</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBytes<T>(this Span<T> src, int? offset = null, int? length = null)
            where T : struct
        {
            if(offset == null && length == null)
                return MemoryMarshal.AsBytes(src);
            else if(offset != null && length == null)
                return MemoryMarshal.AsBytes(src.Slice(offset.Value));
            else
                return MemoryMarshal.AsBytes(src.Slice(offset.Value,length.Value));
        }


        public static T Reduce<T>(this ReadOnlySpan<T> src, Func<T,T,T> f)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            else if(src.Length == 1)
                return src[0];            
            
            var x = src[0];
            for(var i=1; i<src.Length; i++)
                x = f(x,src[i]);
            return x;            
        }

        public static T Reduce<M,N,T>(this Span<M,N,T> src, Func<T,T,T> f)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => Reduce(src.ReadOnly(), f);

        [MethodImpl(Inline)]
        public static T Reduce<T>(this Span<T> src, Func<T,T,T> f)
            => src.ReadOnly().Reduce(f);        


        static void ThrowEmptySpanError()
            => throw new Exception($"The span is empty");

       static Exception unsupported<T>()
            => new Exception($"The type {typeof(T).Name} is unsupported");

    }
}