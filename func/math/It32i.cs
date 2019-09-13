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
    /// Defines a type that implements the increment/decrement pattern over integers
    /// </summary>
    public ref struct It32i
    {            
        [MethodImpl(Inline)]
        public static It32i Define(int start, int finish, int step = 1)
            => new It32i(start, finish, step);

        [MethodImpl(Inline)]
        public static bool operator false(It32i src)
            => !src.Valid;
        
        [MethodImpl(Inline)]
        public static bool operator true(It32i src)
            => src.Valid;

        [MethodImpl(Inline)]
        public static It32i operator ++(It32i src)
        {
            src.Next();
            return src;
        }

        [MethodImpl(Inline)]
        public static It32i operator --(It32i src)
        {
            src.Prior();
            return src;
        }

        [MethodImpl(Inline)]
        public static implicit operator int(It32i src)
            => src.Current;

        [MethodImpl(Inline)]
        public static implicit operator uint(It32i src)
            => (uint)src.Current;

        [MethodImpl(Inline)]
        public static implicit operator long(It32i src)
            => src.Current;

        [MethodImpl(Inline)]
        public static implicit operator ulong(It32i src)
            => (ulong)src.Current;

        [MethodImpl(Inline)]
        public It32i(int start, int finish, int step)
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