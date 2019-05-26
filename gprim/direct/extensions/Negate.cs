//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    

    partial class MathX
    {
        [MethodImpl(Inline)]
        public static ref sbyte Negate(this ref sbyte src)
        {
            src = (sbyte) -src;
            return ref src;

        }

        [MethodImpl(Inline)]
        public static ref short Negate(this ref short src)
        {
            src = (short) -src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int Negate(this ref int src)
        {
            src = (sbyte) -src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long Negate(this ref long src)
        {
            src = (short) -src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref float Negate(this ref float src)
        {
            src = (sbyte) -src;
            return ref src;

        }

        [MethodImpl(Inline)]
        public static ref double Negate(this ref double src)
        {
            src = (short) -src;
            return ref src;
        }

    }

}