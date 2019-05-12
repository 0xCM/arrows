//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;    

using bigint = Z0.intg<System.Numerics.BigInteger>;

using Z0;

using static zcore;
using static zfunc;
using static mfunc;

partial class zcore
{


    /// <summary>
    /// Constructs a generic integer
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static intg<T> intg<T>(T src)
        where T : struct, IEquatable<T>
            => new intg<T>(src);

    [MethodImpl(Inline)]   
    public static intg<T> enumg<T>(Enum src)
        where T : struct, IEquatable<T>
            => (T)Convert.ChangeType(src, type<T>());    

}
    
    