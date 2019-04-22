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


    public abstract class InXBinOpBench<T> : BinOpBench<T>
        where T : struct, IEquatable<T>
    {
        protected static readonly int PrimSize = Vec128<T>.PrimSize;

        protected static readonly int VecLength = Vec128<T>.Length;

        protected InXBinOpBench(string OpName, BenchConfig config)
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

        protected virtual Index<Vec128<T>> Apply(Vec128BinOp<T> vecop)
        {
            var results = new Vec128<T>[VecCount];
            for(var i = 0; i<VecCount; i++)
                 results[i] = vecop(LeftVecSrc[i], RightVecSrc[i]);                    
            return results;
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
            PrintMsgQueue();
            var repeat = Settings.Reps<T>();
            var statsMsg = $"{VecCount} vector pairs | {repeat} reps";
            var sw = begin($"Applying {name} | {statsMsg}");
            iter(repeat, i => f());
            var duration = end($"Applied {name} operator | {statsMsg}", sw);                        
            PrintMsgQueue();
            return duration;
        }

        protected long Measure(Vec128BinOp<T> vecop)
        {
            PrintMsgQueue();
            var repeat = Settings.Reps<T>();
            var statsMsg = $"{VecCount} vector pairs | {repeat} reps";
            var sw = begin($"Applying binary operator | {statsMsg}");
            iter(repeat, i => Apply(vecop));
            var duration = end($"Applied binary operator | {statsMsg}", sw);                        
            PrintMsgQueue();
            return duration;
        }

        protected long Measure(Vec128BinOut<T> vecop, int? reps = null)
        {
            PrintMsgQueue();
            var repeat = reps ?? Settings.Reps<T>();
            var statsMsg = $"{VecCount} vector pairs | {repeat} reps";
            var sw = begin($"Applying binary out operator | {statsMsg}");
            iter(repeat, i => Apply(vecop));
            var duration = end($"Applied binary out operator | {statsMsg}", sw);                        
            PrintMsgQueue();
            return duration;
        }

        protected long Measure(Vec128BinAOut<T> vecop, int? reps = null)
        {
            PrintMsgQueue();
            var repeat = reps ?? Settings.Reps<T>();
            var statsMsg = $"{VecCount} vector pairs | {repeat} reps";
            var sw = begin($"Applying binary storage operator | {statsMsg}");
            iter(repeat, i => Apply(vecop));
            var duration = end($"Applied binary storage operator | {statsMsg}", sw);
            PrintMsgQueue();
            return duration;
        }

        protected unsafe long Measure(Vec128BinPOut<T> vecop, void* dst, int? reps = null)
        {
            PrintMsgQueue();
            var repeat = reps ?? Settings.Reps<T>();
            var statsMsg = $"{VecCount} vector pairs | {repeat} reps";
            var sw = begin($"Applying binary storage operator | {statsMsg}");
            iter(repeat, i => Apply(vecop,dst));
            var duration = end($"Applied binary storage operator | {statsMsg}", sw);                        
            PrintMsgQueue();
            return duration;
        }

    }

}