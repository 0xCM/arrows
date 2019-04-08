//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    static class Pipeline
    {
        static async IAsyncEnumerable<T> produce<T>(Func<int,T> producer, int? reps, int? delay)
        {
            if(reps != null)
            {
                for (int i = 0; i < reps; i++)
                {
                    await Task.Delay(delay ?? 1);
                    yield return producer(i);
                }
            }
            else
            {   var i = 0;
                while(true)
                {
                    await Task.Delay(delay ?? 1);
                    yield return producer(i++);
                }
            }
        }

        public static async void execute<T>(Func<int,T> producer, Action<T> consumer, Func<bool> stop = null, int? reps = null, int? delay = null)
        {
            await foreach (var product in produce(producer,reps,delay))
            {
                consumer(product);
                if(stop())
                    break;
            }

        }

    }
}