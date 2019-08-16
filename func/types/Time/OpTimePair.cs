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
            this.LeftLabel = Left.OpName;
            this.Right = Right;
            this.RightLabel = Right.OpName;
        }
        
        public readonly OpTime Left;

        public readonly string LeftLabel;
         
        public readonly OpTime Right;

        public readonly string RightLabel;
        public long OpCount
            => Left.OpCount;

        public override string ToString()
            => Format();

        public string Format(int? labelPad = null)
            => concat(Left.Format(labelPad), eol(), Right.Format(labelPad));
            
    }


}