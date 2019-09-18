//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines a unit interval for a primal type
    /// </summary>
    public readonly struct U01<T>
        where T : unmanaged
    {
        static readonly T LowerBound = gmath.zero<T>();

        static readonly T UpperBound = gmath.one<T>();        
        
        public static implicit operator Interval<T>(U01<T> src)
            => new Interval<T>(src.Left, src.LeftClosed, src.Right, src.RightClosed);
        
        public U01(bool LeftClosed, bool RightClosed)
        {
            this.LeftClosed = LeftClosed;
            this.RightClosed = RightClosed;
        }

        public T Left 
        {
            [MethodImpl(Inline)]
            get => LowerBound;
        }

        public T Right 
        {
            [MethodImpl(Inline)]
            get => UpperBound;
        }

        /// <summary>
        /// Specifies whether the interval is closed on the left
        /// </summary>
        public readonly bool LeftClosed;

        /// <summary>
        /// Specifies whether the interval is closed on the right
        /// </summary>
        public readonly bool RightClosed;

        /// <summary>
        /// Manufactures the interval [0,1]
        /// </summary>
        [MethodImpl(Inline)]
        public U01<T> Close()
            => new U01<T>(true,true);

        /// <summary>
        /// Manufactures the interval (0,1)
        /// </summary>
        [MethodImpl(Inline)]
        public U01<T> Open()
            => new U01<T>(false,false);

        [MethodImpl(Inline)]
        public U01<T> OpenLeft()
            => new U01<T>(false, RightClosed);

        [MethodImpl(Inline)]
        public U01<T> OpenRight()
            => new U01<T>(LeftClosed, false);

    }

}