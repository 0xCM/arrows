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
    using static mfunc;

    public ref struct It
    {            
        [MethodImpl(Inline)]
        public static It Define(int start, int finish, int step = 1)
            => new It(start, finish, step);

        [MethodImpl(Inline)]
        public static bool operator false(It src)
            => !src.Valid;
        
        [MethodImpl(Inline)]
        public static bool operator true(It src)
            => src.Valid;

        [MethodImpl(Inline)]
        public static It operator ++(It src)
        {
            src.Next();
            return src;
        }

        [MethodImpl(Inline)]
        public static It operator --(It src)
        {
            src.Prior();
            return src;
        }

        public static implicit operator int(It src)
            => src.Current;

        public static implicit operator uint(It src)
            => (uint)src.Current;

        public static implicit operator long(It src)
            => src.Current;

        public static implicit operator ulong(It src)
            => (ulong)src.Current;

        [MethodImpl(Inline)]
        public It(int start, int finish, int step)
        {
            LowerLimit = Math.Min(start, finish);
            UpperLimit = Math.Max(start, finish);
            Step = step;
            Current = start - step;
        }

        int Current;
        
        public readonly int Step;

        public readonly int LowerLimit;
        
        public readonly int UpperLimit;
        
        public int Value 
        {
            [MethodImpl(Inline)]
            get => Current;
        }

        public bool Valid
        {
            [MethodImpl(Inline)]
            get => Current < UpperLimit && Current >= LowerLimit;

        }

        [MethodImpl(Inline)]
        public bool Next()
        {
            Current += Step;
            return Valid;
        }

        [MethodImpl(Inline)]
        public bool Prior()
        {
            Current -= Step;
            return Valid;
        }
    }
}