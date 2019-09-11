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
        
    using static As;
    using static AsIn;
    using static zfunc;

    partial class fmath
    {
        /// <summary>
        /// Computes the sign of the operand
        /// </summary>
        /// <param name="src">The operand</param>
        [MethodImpl(Inline)]
        public static Sign sign(float src)
            => (Sign)MathF.Sign(src);

        /// <summary>
        /// Computes the sign of the operand
        /// </summary>
        /// <param name="src">The operand</param>
        [MethodImpl(Inline)]
        public static Sign sign(double src)
            => (Sign)Math.Sign(src);
    }

}