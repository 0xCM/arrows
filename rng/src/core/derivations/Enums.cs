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

        /// <summary>
        /// Produces a stream values sampled from an enum
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static IEnumerable<E> EnumStream<E>(this IPolyrand random, Func<E,bool> filter = null)
            where E : struct, Enum
        {
            IEnumerable<E> produce()
            {
                var names = Enum.GetNames(typeof(E)).Mapi((index, name) => (index, name)).ToDictionary();
                var domain = closed(0, names.Count);
                var stream = random.Stream(domain);

                while(true)
                {   
                    var name = names[stream.First()];
                    var value = Enum.Parse<E>(name);
                    if(filter != null)
                    {
                        if(filter(value))
                            yield return value;
                    }
                    else
                        yield return value;
                }            
            }

            return stream(produce(), random.RngKind);
        }
    }

}

