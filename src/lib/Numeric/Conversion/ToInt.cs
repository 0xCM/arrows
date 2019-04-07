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
        public static int ToInt(this byte src)
            => src;

        [MethodImpl(Inline)]   
        public static int ToInt(this sbyte src)
            => src;

        [MethodImpl(Inline)]   
        public static int ToInt(this short src)
            => src;

        [MethodImpl(Inline)]   
        public static int ToInt(this ushort src)
            => src;

        [MethodImpl(Inline)]   
        public static int ToInt(this int src)
            => src;

        [MethodImpl(Inline)]   
        public static int ToInt(this uint src)
            => (int)src;

        [MethodImpl(Inline)]   
        public static int ToInt(this long src)
            => (int)src;

        [MethodImpl(Inline)]   
        public static int ToInt(this ulong src)
            => (int)src;

        [MethodImpl(Inline)]   
        public static int ToInt(this float src)
            => (int)src;


        [MethodImpl(Inline)]   
        public static int ToInt(this double src)
            => (int)src;

        [MethodImpl(Inline)]   
        public static int ToInt(this decimal src)
            => (int)src;

        [MethodImpl(Inline)]   
        public static int ToInt(this byte? src)
            => (src ?? 0);

        [MethodImpl(Inline)]   
        public static int ToInt(this sbyte? src)
            => (src ?? 0);

        [MethodImpl(Inline)]   
        public static int ToInt(this short? src)
            => (src ?? 0);

        [MethodImpl(Inline)]   
        public static int ToInt(this ushort? src)
            => (src ?? 0);

        [MethodImpl(Inline)]   
        public static int ToInt(this int? src)
            => (src ?? 0);

        [MethodImpl(Inline)]   
        public static int ToInt(this uint? src)
            => (int)(src ?? 0);

        [MethodImpl(Inline)]   
        public static int ToInt(this long? src)
            => (int)(src ?? 0);

        [MethodImpl(Inline)]   
        public static int ToInt(this ulong? src)
            => (int)(src ?? 0);

        [MethodImpl(Inline)]   
        public static int ToInt(this float? src)
            => (int)(src ?? 0);

    [MethodImpl(Inline)]   
        public static int ToInt(this double? src)
            => (int)src;

    [MethodImpl(Inline)]   
        public static int ToInt(this decimal? src)
            => (int)src;

        /// <summary>
        /// x:intg[byte] => x:int
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static int ToInt(this intg<byte> src)
            => src;

        /// <summary>
        /// x:intg[sbyte] => x:int
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static int ToInt(this intg<sbyte> src)
            => src;

        /// <summary>
        /// x:intg[short] => x:int
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static int ToInt(this intg<short> src)
            => src;

        /// <summary>
        /// x:intg[ushort] => x:int
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static int ToInt(this intg<ushort> src)
            => src;

        /// <summary>
        /// x:intg[int] => x:int
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static int ToInt(this intg<int> src)
            => src;

        [MethodImpl(Inline)]   
        public static int ToInt(this intg<uint> src)
            => (int)src;

        [MethodImpl(Inline)]   
        public static int ToInt(this intg<long> src)
            => (int)src;

        [MethodImpl(Inline)]   
        public static int ToInt(this intg<ulong> src)
            => (int)src;


        [MethodImpl(Inline)]   
        public static int ToInt(this floatg<double> src)
            => (int)unwrap(src);


        [MethodImpl(Inline)]   
        public static int ToInt(this floatg<float> src)
            => (int)unwrap(src);

        [MethodImpl(Inline)]   
        public static int ToInt<T>(this floatg<T> src)
            => convert<int>(unwrap(src));

}
}