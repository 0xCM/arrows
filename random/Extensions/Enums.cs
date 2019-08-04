//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class RngX
    {

        public static IEnumerable<E> EnumStream<E>(this IRandomSource random)
            where E : struct, Enum
        {
            var names = Enum.GetNames(typeof(E)).Mapi((index, name) => (index, name)).ToDictionary();
            var domain = closed(0, names.Count);
            var stream = random.Stream(domain);

            while(true)
            {   
                var name = names[stream.First()];
                var value = Enum.Parse<E>(name);
                yield return value;
            }
            
        }

    }

}


/*
Random.Stream<byte>(closed((byte)E1, (byte)(E7 + 1))).Cast<Events>();
 */