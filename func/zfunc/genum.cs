//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Creates a generic adapter for an enum value
    /// </summary>
    /// <param name="src">The value for which a generic view will be presented</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static GEnum<E> genum<E>(E src)
        where E : Enum
        => GEnum.FromValue(src);

    /// <summary>
    /// Creates a generic adapter for an enum value that is specific to the underlying type
    /// </summary>
    /// <param name="src">The value for which a generic view will be presented</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static GEnum<E,T> genum<E,T>(E src, T rep = default)
        where E : Enum
        where T : struct
            => GEnum.FromValue(src,rep);

    /// <summary>
    /// Attemts to parse an enum from a label
    /// </summary>
    /// <param name="label">The label</param>
    /// <param name="rep">A representative value of the enum, used only for type inference</param>
    /// <typeparam name="E">The enum type</typeparam>
    [MethodImpl(Inline)]
    public static Option<GEnum<E>> genum<E>(string label, E rep = default)
        where E : Enum
            => GEnum.Parse(label, rep);

    /// <summary>
    /// Attemts to parse an enum from a label
    /// </summary>
    /// <param name="label">The label</param>
    /// <param name="eRep">A representative value of the enum, used only for type inference</param>
    /// <param name="sRep">A representative value of the underlying scalar, used only for type inference</param>
    /// <typeparam name="E">The enum type</typeparam>
    /// <typeparam name="T">The underlying scalar type</typeparam>
    [MethodImpl(Inline)]
    public static Option<GEnum<E,T>> genum<E,T>(string label, E eRep = default, T sRep = default)
        where E : Enum
        where T : struct
            => GEnum.Parse(label,eRep, sRep);


}