//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;
using System.Diagnostics;

using Z0;
using static zfunc;

partial class mfunc
{
    /// <summary>
    /// Returns the vector component for a specified index
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="index">The index</param>
    /// <typeparam name="T">The vector primitive type</typeparam>
    [MethodImpl(Inline)]
    public static T component<T>(Vector128<T> src, int index)
        where T : struct
            => src.GetElement(index);

    /// <summary>
    /// Returns the vector component for a specified index
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="index">The index</param>
    /// <typeparam name="T">The vector primitive type</typeparam>
    [MethodImpl(Inline)]
    public static T component<T>(Vector256<T> src, int index)
        where T : struct
            => src.GetElement(index);

    /// <summary>
    /// Returns true if the value of an identified component the NaN representative
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="ix">The 0-based component index</param>
    [MethodImpl(Inline)]
    public static bool isNaN(Vector128<float> src, int ix)
        => float.IsNaN(src.GetElement(ix));

    /// <summary>
    /// Returns true if any component of the source vector is the NaN representative
    /// </summary>
    /// <param name="src">The source vector</param>
    [MethodImpl(Inline)]
    public static bool anyNaN(Vector128<float> src)
        => anyNaN(component(src,0), component(src, 1), component(src,2), component(src,3));

    /// <summary>
    /// Returns true if the value of a component the NaN representative
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static bool isNaN(Vector128<double> src, int index)
        => double.IsNaN(src.GetElement(index));

    /// <summary>
    /// Returns true if any component of the source vector is the NaN representative
    /// </summary>
    /// <param name="src">The source vector</param>
    [MethodImpl(Inline)]
    public static bool anyNaN(Vector128<double> src)
        => anyNan(component(src,0), component(src, 1));

    /// <summary>
    /// Replaces an identified NaN component with a specified value
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vector128<float> clearNaN(Vector128<float> src, int ix, float replacement = -1)
        => src.WithElement(ix,clearNaN(src.GetElement(ix), replacement));

    /// <summary>
    /// Replaces any NaN components with a specified value
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vector128<float> clearNaN(Vector128<float> src, float replacement = -1)
    {
        var lolo = clearNaN(src.GetElement(0), replacement);
        var lohi = clearNaN(src.GetElement(1), replacement);
        var hilo = clearNaN(src.GetElement(2), replacement);
        var hihi = clearNaN(src.GetElement(3), replacement);
        return Vector128.Create(lolo,lohi,hilo,hihi);
    }

    /// <summary>
    /// Replaces an identified NaN component with a specified value
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vector128<double> clearNaN(Vector128<double> src, int ix, double replacement = -1)
        => src.WithElement(ix,clearNaN(src.GetElement(ix), replacement));

    /// <summary>
    /// Replaces any NaN components with -1
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vec128<double> clearNaN(Vector128<double> src, double replacement = -1)
    {
        var lo = clearNaN(src.GetElement(0),replacement);
        var hi = clearNaN(src.GetElement(1),replacement);
        return Vector128.Create(lo,hi);
    }

    /// <summary>
    /// Replaces any NaN components with -1
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vec256<double> clearNaN(Vector256<double> src, double replacement = -1)
    {
        var x0 = clearNaN(src.GetElement(0),replacement);
        var x1 = clearNaN(src.GetElement(1),replacement);
        var x2 = clearNaN(src.GetElement(2),replacement);
        var x3 = clearNaN(src.GetElement(3),replacement);
        return Vector256.Create(x0,x1,x2,x3);
    }

    /// <summary>
    /// Replaces any NaN components with -1
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vec256<float> clearNaN(Vector256<float> src, float replacement = -1)
    {
        var x0 = clearNaN(src.GetElement(0),replacement);
        var x1 = clearNaN(src.GetElement(1),replacement);
        var x2 = clearNaN(src.GetElement(2),replacement);
        var x3 = clearNaN(src.GetElement(3),replacement);
        var x4 = clearNaN(src.GetElement(4),replacement);
        var x5 = clearNaN(src.GetElement(5),replacement);
        var x6 = clearNaN(src.GetElement(6),replacement);
        var x7 = clearNaN(src.GetElement(7),replacement);
        return Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);
    }

}