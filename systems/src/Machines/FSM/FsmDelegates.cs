//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Delegate for event that fires when an input event has been received
    /// </summary>
    /// <param name="input">The input event</param>
    /// <typeparam name="E">The input event type</typeparam>
    public delegate void InputReceipt<E>(E input);
    
    /// <summary>
    /// Delegate for event that fires when a state transition occurs
    /// </summary>
    /// <param name="source">The source/antecdent state</param>
    /// <param name="target">The target state</param>
    /// <typeparam name="S">The state type</typeparam>
    public delegate void Transitioned<S>(S source, S target);

    public delegate void Completed<S>(S endstate, bool asPlanned);

    public delegate void ErrorRaised(Exception error);

    /// <summary>
    /// Delegate that fires upon state entry
    /// </summary>
    /// <param name="entry"></param>
    /// <typeparam name="S">The state type</typeparam>
    /// <typeparam name="A">The action type</typeparam>
    public delegate void StateEntry<S,A>(S entry, A action);


}