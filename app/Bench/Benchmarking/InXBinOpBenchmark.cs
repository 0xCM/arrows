//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zcore;
    
    public abstract class InXBinOpBenchmark<T> : BinOpBenchmark<T>
        where T : struct, IEquatable<T>
    {
        protected static readonly int PrimSize = Vec128<T>.PrimSize;

        protected static readonly int VecLength = Vec128<T>.Length;

        protected InXBinOpBenchmark(string OpName, BenchConfig config)
            : base(config)
        {
            this.OpName = OpName;
            this.VecCount = base.SampleSize / VecLength;
            this.LeftVecSrc = Vec128.stream<T>(LeftSrc).Freeze();
            this.RightVecSrc = Vec128.stream<T>(RightSrc).Freeze();                    

            Claim.eq(base.SampleSize, VecCount*VecLength);
        }

        protected int VecCount {get;}

        protected PrimKind PritiveKind {get;} 
            = PrimKinds.kind<T>();

        protected IEnumerable<Vec128<T>> Results(Vec128BinOp<T> vecop)
        {
            for(var i = 0; i< VecCount; i++)
                yield return vecop(LeftVecSrc[i], RightVecSrc[i]);            
        }

        protected IEnumerable<ArraySegment<T>> LeftSegments
            => Arr.partition<T>(LeftSrc, VecLength);

        protected IEnumerable<ArraySegment<T>> RightSegments
            => Arr.partition<T>(RightSrc, VecLength);

        protected virtual Vec128BinOp<T> VecOp {get;}

        protected virtual Vec128BinOut<T> VecOpOut {get;}

        protected virtual Vec128BinAOut<T> VecOpAOut {get;}

        protected virtual IndexBinOp<T> IndexOp {get;}

        protected string OpName {get;}


        protected Index<Vec128<T>> LeftVecSrc {get;}

        protected Index<Vec128<T>> RightVecSrc {get;}


        protected virtual long Apply(Vec128BinOp<T> vecop, Vec128<T>[] dst)
        {
            var results = new Vec128<T>[VecCount];
            var sw = stopwatch();
            for(var i = 0; i<VecCount; i++)
                 dst[i] = vecop(LeftVecSrc[i], RightVecSrc[i]);                    
            return elapsed(sw);
        }

        protected virtual Index<Vec128<T>> Apply(Vec128BinAOut<T> vecop)
        {
            var storage = new T[SampleSize];
            for(int i = 0, offset = 0; i<VecCount; i++, offset += VecLength)
                vecop(LeftVecSrc[i], RightVecSrc[i], storage, offset);                
            return storage.Stream128().ToIndex();            
        }

        protected unsafe virtual void Apply(Vec128BinPOut<T> vecop, void* dst)
        {
            var results = new Vec128<T>[VecCount];
            for(int i = 0, offset = 0; i<VecCount; i++, offset += VecLength)
                vecop(LeftVecSrc[i], RightVecSrc[i], dst);                
        }

        protected virtual Index<Vec128<T>> Apply(Vec128BinOut<T> vecop)
        {
            var results = new Vec128<T>[VecCount];
            for(int i = 0, offset = 0; i<VecCount; i++, offset += VecLength)
                vecop(LeftVecSrc[i], RightVecSrc[i], out results[i]);                
            return results;        
        }

        protected void trace(int count, [CallerMemberName] string caller = null)
            => base.trace($"Applied the {OpName} operator over {count} vectors", caller);

        protected long Measure(Action f, string name)
        {
            print(FlushMessages());
            var repeat = Settings.Reps<T>();
            var statsMsg = $"{VecCount} vector pairs | {repeat} reps";
            var sw = begin($"Applying {name} | {statsMsg}");
            iter(repeat, i => f());
            var duration = end($"Applied {name} operator | {statsMsg}", sw);                        
            print(FlushMessages());
            return duration;
        }

        
        protected long Measure(Vec128BinOp<T> binop)
        {
            var msTotal = 0L;
            var kind = PrimKinds.kind<T>();
            var opinfo = $"{OpName}/{kind}";    
            var dst = new Vec128<T>[VecCount];

            print(FlushMessages());
            hilite($"{opinfo} Executing {Config.Cycles} cycles");
            for(var i = 0; i< Config.Cycles; i++)
            {
                var statsMsg = $"Cycle = {i} | Samples = {Config.SampleSize} | Reps = {Config.Reps}";
                begin($"{opinfo} Start  {statsMsg}");
                var msCycle = 0L;
                for(var j = 0; j < Config.Reps; j++)
                    msCycle += Apply(binop,dst);
                msTotal += msCycle;
                end($"{opinfo} Finish {statsMsg}", msCycle);                        
                
                print(FlushMessages());
            }
            hilite($"{opinfo} Summary: Cycles = {Config.Cycles}, Reps = {Config.Reps} | Duration = {msTotal}ms");
            print(FlushMessages());
            return msTotal;
        }

        protected long Measure(Vec128BinOut<T> vecop, int? reps = null)
        {
            print(FlushMessages());
            var repeat = reps ?? Settings.Reps<T>();
            var statsMsg = $"{VecCount} vector pairs | {repeat} reps";
            var sw = begin($"Applying binary out operator | {statsMsg}");
            iter(repeat, i => Apply(vecop));
            var duration = end($"Applied binary out operator | {statsMsg}", sw);                        
            print(FlushMessages());
            return duration;
        }

        protected long Measure(Vec128BinAOut<T> vecop, int? reps = null)
        {
            print(FlushMessages());
            var repeat = reps ?? Settings.Reps<T>();
            var statsMsg = $"{VecCount} vector pairs | {repeat} reps";
            var sw = begin($"Applying binary storage operator | {statsMsg}");
            iter(repeat, i => Apply(vecop));
            var duration = end($"Applied binary storage operator | {statsMsg}", sw);
            print(FlushMessages());
            return duration;
        }

        protected unsafe long Measure(Vec128BinPOut<T> vecop, void* dst, int? reps = null)
        {
            print(FlushMessages());
            var repeat = reps ?? Settings.Reps<T>();
            var statsMsg = $"{VecCount} vector pairs | {repeat} reps";
            var sw = begin($"Applying binary storage operator | {statsMsg}");
            iter(repeat, i => Apply(vecop,dst));
            var duration = end($"Applied binary storage operator | {statsMsg}", sw);                        
            print(FlushMessages());
            return duration;
        }

        protected long Measure(Action f, string name, int? reps = null)
        {
            var repeat = reps ?? Settings.Reps<T>();
            var statsMsg = $"{VecCount} vector pairs | {reps} reps";
            var sw = begin($"Applying {name} | {statsMsg}");
            iter(repeat, i => f());
            return end($"Applied {name} operator | {statsMsg}", sw);                        
        }
    }
}