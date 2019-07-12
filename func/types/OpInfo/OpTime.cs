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

    public readonly struct OpTime
    {
        public static readonly OpTime Zero = new OpTime(0, Duration.Zero);
        
        public static implicit operator (string Label, long OpCount, Duration WorkTime)(OpTime src)
            => (src.Label, src.OpCount, src.WorkTime);

        public static implicit operator OpTime((long OpCount, Duration WorkTime) src)
            => Define(src.OpCount, src.WorkTime);        

        public static implicit operator OpTime((string Label, long OpCount, Duration WorkTime) src)
            => Define(src.Label, src.OpCount, src.WorkTime);        

        public static OpTime Define(long OpCount, Duration WorkTime)
            => new OpTime(OpCount, WorkTime);

        public static OpTime Define(string Label, long OpCount, Duration WorkTime)
            => new OpTime(Label, OpCount, WorkTime);

        public static OpTime operator +(OpTime lhs, OpTime rhs)
            => new OpTime($"{lhs.Label}/{rhs.Label}", lhs.OpCount + rhs.OpCount, lhs.WorkTime + rhs.WorkTime);

        public OpTime(string Label, long OpCount, Duration WorkTime)
        {
            this.Label = Label;
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
        }

        public OpTime(long OpCount, Duration WorkTime)
        {
            this.Label = string.Empty;
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
        }
            
        public readonly string Label {get;}

        public readonly long OpCount {get;}

        public readonly Duration WorkTime {get;}


        public override string ToString()
            => $"{Label} | {OpCount} ops".PadRight(30) + $"| {WorkTime}";
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
        {
            var fmt = $"{LeftLabel} = {Left.WorkTime}".PadRight(25) 
                   + $"| {RightLabel} = {Right.WorkTime}".PadRight(25) 
                   + $"| OpCount = {OpCount}";
            return fmt;

        }
            
    }

}