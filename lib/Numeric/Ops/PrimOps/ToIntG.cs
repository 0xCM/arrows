//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;


    using static zcore;

    partial class xcore
    {

        [MethodImpl(Inline)]   
        public static intg<byte> ToIntG(this byte src)
            => src;


        [MethodImpl(Inline)]   
        public static intg<sbyte> ToIntG(this sbyte src)
            => src;


        [MethodImpl(Inline)]   
        public static intg<short> ToIntG(this short src)
            => src;


        [MethodImpl(Inline)]   
        public static intg<ushort> ToIntG(this ushort src)
            => src;

        [MethodImpl(Inline)]   
        public static intg<int> ToIntG(this int src)
            => src;

        [MethodImpl(Inline)]   
        public static intg<uint> ToIntG(this uint src)
            => src;

        [MethodImpl(Inline)]   
        public static intg<long> ToIntG(this long src)
            => src;


        [MethodImpl(Inline)]   
        public static intg<ulong> ToIntG(this ulong src)
            => src;

        [MethodImpl(Inline)]   
        public static intg<BigInteger> ToIntG(this BigInteger src)
            => src;

        [MethodImpl(Inline)]   
        public static intg<long> ToIntG(this double src)
            => (long)src;
        
        [MethodImpl(Inline)]   
        public static intg<long> ToIntG(this decimal src)
            => (long)src;

        
        [MethodImpl(Inline)]   
        public static intg<int> ToIntG(this float src)
            => (int)src;

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<byte>> ToIntG(this IEnumerable<byte> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<sbyte>> ToIntG(this IEnumerable<sbyte> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<short>> ToIntG(this IEnumerable<short> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<ushort>> ToIntG(this IEnumerable<ushort> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<int>> ToIntG(this IEnumerable<int> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<uint>> ToIntG(this IEnumerable<uint> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<long>> ToIntG(this IEnumerable<long> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<ulong>> ToIntG(this IEnumerable<ulong> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<BigInteger>> ToIntG(this IEnumerable<BigInteger> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<int>> ToIntG(this IEnumerable<float> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<long>> ToIntG(this IEnumerable<double> src)
            => src.Select(x => x.ToIntG());

        [MethodImpl(Inline)]   
        public static IEnumerable<intg<long>> ToIntG(this IEnumerable<decimal> src)
            => src.Select(x => x.ToIntG());

        /// <summary>
        /// effects byte => intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this byte src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<byte,T>(src);

        /// <summary>
        /// x:sbyte => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this sbyte src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<sbyte,T>(src);

        /// <summary>
        /// x:short => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this short src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<short,T>(src);
        
        /// <summary>
        /// x:ushort => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]       
        public static intg<T> ToIntG<T>(this ushort src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<ushort,T>(src);

        /// <summary>
        /// x:int => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this int src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<int,T>(src);

        /// <summary>
        /// x:uint => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this uint src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<uint,T>(src);

        /// <summary>
        /// x:long=> x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this long src)    
            where T : struct, IEquatable<T>
            => ClrConverter.convert<long,T>(src);

        /// <summary>
        /// x:ulong => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this ulong src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<ulong,T>(src);

        /// <summary>
        /// x:float => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this float src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<float,T>(src);

        /// <summary>
        /// x:double => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this double src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<double,T>(src);

        /// <summary>
        /// x:decimal => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        public static intg<T> ToIntG<T>(this decimal src)
            where T : struct, IEquatable<T>
            => ClrConverter.convert<decimal,T>(src);

        /// <summary>
        /// x:intg[byte] => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this intg<byte> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<byte,T>(src);

        /// <summary>
        /// x:intg[sbyte] => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this intg<sbyte> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<sbyte,T>(src);


        /// <summary>
        /// x:intg[short] => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this intg<short> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<short,T>(src);
        
        /// <summary>
        /// x:intg[ushort] => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]       
        public static intg<T> ToIntG<T>(this intg<ushort> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<ushort,T>(src);

        /// <summary>
        /// x:intg[int] => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this intg<int> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<int,T>(src);

        /// <summary>
        /// x:intg[uint] => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this intg<uint> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<uint,T>(src);

        /// <summary>
        /// x:intg[long] => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this intg<long> src)    
            where T : struct, IEquatable<T>
                => ClrConverter.convert<long,T>(src);

        /// <summary>
        /// x:intg[ulong] => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this intg<ulong> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<ulong,T>(src);
        
        /// <summary>
        /// x:floatg[float] => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this floatg<float> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<float,T>(src);

        /// <summary>
        /// x:floatg[float] => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this floatg<double> src)
            where T : struct, IEquatable<T>
                => ClrConverter.convert<double,T>(src);

        /// <summary>
        /// x:Enum => x:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static intg<T> ToIntG<T>(this Enum src)    
            where T : struct, IEquatable<T>
                => enumg<T>(src);

        [MethodImpl(Inline)]   
        public static Index<intg<T>> ToIntG<T>(this Index<real<T>> src)
            where T : struct, IEquatable<T>
                => map(src, x =>  intg<T>(x.unwrap()));
    }
}
