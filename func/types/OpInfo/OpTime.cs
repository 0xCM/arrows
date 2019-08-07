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

    public readonly struct OpTime
    {
        public static readonly OpTime Zero = new OpTime(0, Duration.Zero);
        
        public static implicit operator (long OpCount, Duration WorkTime, string Label)(OpTime src)
            => (src.OpCount, src.WorkTime,src.Label);

        public static implicit operator OpTime((long OpCount, Duration WorkTime) src)
            => Define(src.OpCount, src.WorkTime);        

        public static implicit operator OpTime((long OpCount, Duration WorkTime, string Label) src)
            => Define(src.OpCount, src.WorkTime, src.Label);        

        public static OpTime Define(long OpCount, Duration WorkTime, string label = null)
            => new OpTime(OpCount, WorkTime, label);

        public static OpTime operator +(OpTime lhs, OpTime rhs)
            => new OpTime(lhs.OpCount + rhs.OpCount, lhs.WorkTime + rhs.WorkTime, $"{lhs.Label}/{rhs.Label}");

        public OpTime(long OpCount, Duration WorkTime, string Label = null)
        {
            this.Label = Label ?? "?";
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
        }            

        public readonly long OpCount {get;}

        public readonly Duration WorkTime {get;}

        public readonly string Label {get;}

        public string Format(int? labelPad = null)
            => $"{Label}".PadRight(labelPad ?? 20) + $"| Ops = {OpCount} " + $"| Time = {WorkTime}";
        
        public override string ToString()
            => Format();
    }

    public readonly struct OpTimePair
    {
        public static readonly OpTimePair Zero = Define(OpTime.Zero, OpTime.Zero);
        
        public static implicit operator OpTimePair((OpTime left, OpTime right) src)
            => Define(src.left, src.right);

        public static OpTimePair Define(OpTime Left, OpTime Right)
            => new OpTimePair(Left,Right);

        public OpTimePair(OpTime Left, OpTime Right)
        {
            if(Left.OpCount != Right.OpCount)
                throw new ArgumentException($"Operation counts not equal");
            this.Left = Left;
            this.LeftLabel = Left.Label;
            this.Right = Right;
            this.RightLabel = Right.Label;
        }
        
        public readonly OpTime Left;

        public readonly string LeftLabel;
         
        public readonly OpTime Right;

        public readonly string RightLabel;
        public long OpCount
            => Left.OpCount;

        public override string ToString()
            => Format();

        public string Format()
            => concat(Left.Format(), eol(), Right.Format());
            
    }

}