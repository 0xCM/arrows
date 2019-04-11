//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    
using System.Text;

using Z0;

partial class zcore
{

    /// <summary>
    /// Defines a one-byte bit array 
    /// </summary>
    /// <param name="bits">The source bits</param>
    [MethodImpl(Inline)]
    public static bit[] bits(bit b7, bit b6, bit b5, bit b4, bit b3, bit b2, bit b1, bit b0)
        => array(b7, b6, b5, b4, b3, b2, b1, b0);



}