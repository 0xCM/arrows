//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;

    
    using static zfunc;


    partial class xfunc
    {
        public static IEnumerable<T> Convert<T>(this IEnumerable<sbyte> src)
            where T : struct
                => from item in src select convert<T>(item);

        public static IEnumerable<T> Convert<T>(this IEnumerable<byte> src)
            where T : struct
                => from item in src select convert<T>(item);

        public static IEnumerable<T> Convert<T>(this IEnumerable<short> src)
            where T : struct
                => from item in src select convert<T>(item);

        public static IEnumerable<T> Convert<T>(this IEnumerable<ushort> src)
            where T : struct
                => from item in src select convert<T>(item);

        public static IEnumerable<T> Convert<T>(this IEnumerable<int> src)
            where T : struct
                => from item in src select convert<T>(item);

        public static IEnumerable<T> Convert<T>(this IEnumerable<uint> src)
            where T : struct
                => from item in src select convert<T>(item);


        public static IEnumerable<T> Convert<T>(this IEnumerable<long> src)
            where T : struct
                => from item in src select convert<T>(item);

        public static IEnumerable<T> Convert<T>(this IEnumerable<ulong> src)
            where T : struct            
                => from item in src select convert<T>(item);

        public static IEnumerable<T> Convert<T>(this IEnumerable<float> src)
            where T : struct            
                => from item in src select convert<T>(item);

        public static IEnumerable<T> Convert<T>(this IEnumerable<double> src)
            where T : struct            
                => from item in src select convert<T>(item);


    }

}