using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{

    /// <summary>
    /// Constructs an empty concurrent index 
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    [MethodImpl(Inline)]   
    public static ConcurrentIndex<K,V> cindex<K,V>()
        => new ConcurrentIndex<K,V>();
}