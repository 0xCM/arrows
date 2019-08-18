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

   public abstract class StoreOps<K, V> : IFunctions<K, V, Input<V>, Output<V>, StoreContext>
        where K : struct
        where V : struct
    {

        [MethodImpl(Inline)]
        public void SingleReader(ref K key, ref Input<V> input, ref V value, ref Output<V> dst)
            => dst.Value = value;

        public void SingleWriter(ref K key, ref V src, ref V dst)
            => dst = src;

        [MethodImpl(Inline)]
        public void ConcurrentReader(ref K key, ref Input<V> input, ref V value, ref Output<V> dst)
            => dst.Value = value;

        [MethodImpl(Inline)]
        public void ConcurrentWriter(ref K key, ref V src, ref V dst)
            => dst = src;

        [MethodImpl(Inline)]
        public void InitialUpdater(ref K key, ref Input<V> input, ref V value)        
            => value = input.Value;
        

        public virtual void CopyUpdater(ref K key, ref Input<V> input, ref V oldValue, ref V newValue)
        {
            
        }

        public virtual void InPlaceUpdater(ref K key, ref Input<V> input, ref V value)
        {
            
        }

        public void UpsertCompletionCallback(ref K key, ref V value, StoreContext ctx) {}

        public void ReadCompletionCallback(ref K key, ref Input<V> input, ref Output<V> output, StoreContext ctx, Status status) {}

        public void RMWCompletionCallback(ref K key, ref Input<V> input, StoreContext ctx, Status status) {}

        public void DeleteCompletionCallback(ref K key, StoreContext ctx) {}

        public void CheckpointCompletionCallback(Guid sessionId, long serialNum) {}

    }


}