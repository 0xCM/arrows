//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {

        /// <summary>
        /// Determines whether identified bits in the operands agree.
        /// </summary>
        /// <param name="lhs">The first bit source</param>
        /// <param name="nx">The first bit position</param>
        /// <param name="rhs">The second bit source</param>
        /// <param name="ny">The second bit position</param>
        /// <typeparam name="S">The left operand type</typeparam>
        /// <typeparam name="T">The right operand type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All, PrimalKind.All)]
        public static bool match<S,T>(in S lhs, in int nx, T rhs, in int ny)
            where S : struct
            where T : struct
                => test(in lhs, in nx) == test(in rhs, in ny);     


    }

}