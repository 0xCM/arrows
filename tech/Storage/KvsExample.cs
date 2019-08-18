//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Storage
{
    using System;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

    using FASTER.core;
    using static zfunc;


    using Key2 = StoreKey<ulong>;


    public struct Value2
    {
        public long vfield1;
        public long vfield2;
    }

    public class KvsExample : KeyValueStore<Key2,Value2>
    {

        public static long CountRecords()
        {
            var log = OpenLog();
            var cpConfig = CpConfig();
            var logConfig = LogConfig(log);

            var kvs = new FasterKV<Key2, Value2, Input<Value2>, Output<Value2>, StoreContext, KvsExampleOps>
                    (Pow2.T20, new KvsExampleOps(),logConfig, cpConfig); 
            kvs.StartSession();
            kvs.Recover();

            var count = 0L;
            var iterator = kvs.Log.Scan(kvs.Log.BeginAddress, kvs.Log.TailAddress);
            while(iterator.GetNext(out RecordInfo info, out StoreKey<ulong> key, out Value2 value))
            {
                count++;
                

            }
            print($"Found {count} records");

            kvs.StopSession();
            CloseLog(log);
            return count;

        }
        
        public static void SaveRandom(long count)
        {
            var random = RNG.XOrShift1024(Seed1024.Entropic);
            var valuesA = random.Stream<long>().Take((uint)count).Freeze();
            var valuesB = random.Stream<long>().Take((uint)count).Freeze();
            var userContext = StoreContext.Default;

            var sw = stopwatch();
            var log = OpenLog();
            var logConfig = LogConfig(log);
            var cpConfig = CpConfig();

            var kvs = new FasterKV<Key2, Value2, Input<Value2>, Output<Value2>, StoreContext, KvsExampleOps>
                    (Pow2.T20, new KvsExampleOps(),logConfig, cpConfig); 
            kvs.StartSession();

            for(var i=0; i<count; i++)
            {            
                var k = Keys.Key((ulong)DateTime.Now.Ticks);
                var v = new Value2
                    {   vfield1 = valuesA[i], 
                        vfield2 = valuesB[i]
                    };
                
                kvs.Upsert(ref k, ref v, userContext, 0);
            }

            kvs.TakeFullCheckpoint(out Guid token);
            kvs.CompletePending(true);
            kvs.Log.Compact(kvs.Log.HeadAddress);

            inform($"Performed {count} insert/read operations in {snapshot(sw)}");
            inform($"Checkpoint token {token}");

            kvs.StopSession();
            CloseLog(log);
        }
    }

    public sealed class KvsExampleOps : StoreOps<Key2,Value2>
    {
        public override void CopyUpdater(ref Key2 key, ref Input<Value2> input, ref Value2 oldValue, ref Value2 newValue)
        {
            newValue.vfield1 = oldValue.vfield1 + input.Value.vfield1;
            newValue.vfield2 = oldValue.vfield2 + input.Value.vfield2;
        }
        public override void InPlaceUpdater(ref Key2 key, ref Input<Value2> input, ref Value2 value)
        {
            value.vfield1 += input.Value.vfield1;
            value.vfield2 += input.Value.vfield2;
        }

    }
}