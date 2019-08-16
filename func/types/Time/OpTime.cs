//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using static zfunc;

    /// <summary>
    /// Defines a benchmark measure for an operator
    /// </summary>
    public readonly struct OpTime : IRecord<OpTime>
    {
        public static readonly OpTime Zero = new OpTime(0, Duration.Zero);
        
        [MethodImpl(Inline)]
        public static implicit operator (long OpCount, Duration WorkTime, string Label)(OpTime src)
            => (src.OpCount, src.WorkTime,src.OpName);

        [MethodImpl(Inline)]
        public static implicit operator OpTime((long OpCount, Duration WorkTime) src)
            => Define(src.OpCount, src.WorkTime);        

        [MethodImpl(Inline)]
        public static implicit operator OpTime((long OpCount, Duration WorkTime, string Label) src)
            => Define(src.OpCount, src.WorkTime, src.Label);        

        [MethodImpl(Inline)]
        public static implicit operator OpTime((long OpCount, Stopwatch sw, string Label) src)
            => Define(src.OpCount, snapshot(src.sw), src.Label);        

        [MethodImpl(Inline)]
        public static OpTime Define(long OpCount, Duration WorkTime, string label = null)
            => new OpTime(OpCount, WorkTime, label);

        [MethodImpl(Inline)]
        public static OpTime operator +(OpTime lhs, OpTime rhs)
            => new OpTime(lhs.OpCount + rhs.OpCount, lhs.WorkTime + rhs.WorkTime, $"{lhs.OpName}/{rhs.OpName}");

        [MethodImpl(Inline)]
        public OpTime(long OpCount, Duration WorkTime, string Label = null)
        {
            this.OpName = Label ?? "?";
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
        }            

        /// <summary>
        /// The name of the measured operation
        /// </summary>
        public readonly string OpName;

        /// <summary>
        /// Either the invocation count or the number of discrete operations performed
        /// </summary>
        public readonly long OpCount;

        /// <summary>
        /// The measured time
        /// </summary>
        public readonly Duration WorkTime;

        public string Format(int? labelPad = null)
            => $"{OpName}".PadRight(labelPad ?? 20) + $"| Ops = {OpCount} " + $"| Time = {WorkTime}";
        
        string IRecord.DelimitedText(char delimiter)
        {
            var sep = $" {delimiter} ";
            return $"{OpName}".PadRight(30) + sep + OpCount.ToString() + sep + WorkTime.Ms.ToString();
        }

        IReadOnlyList<string> IRecord.GetHeaders()
            => (this as IRecord<OpTime>).Headers;

        public override string ToString()
            => Format();

    }


}