//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Evaluates the expression and writes the result to standard output
    /// </summary>
    /// <param name="fx">The expression to evaluate</param>
    /// <typeparam name="T">The evaluation value type</typeparam>
    public static void show<T>(Expression<Func<T>> fx)
    {
        var nv = fx.Evaluate();
        print(AppMsg.Define($"{nv}", SeverityLevel.HiliteCL));
    }

    /// <summary>
    /// Writes a named value to standard output
    /// </summary>
    /// <param name="nv">The named vaue to emit</param>
    /// <typeparam name="T">The value type</typeparam>
    public static void show<T>(NamedValue<T> nv)
    {
        print(AppMsg.Define($"{nv}", SeverityLevel.HiliteCL));
    }

    public static void show<T>(string name, T value)
        => show(NamedValue.Define(name,value));


}