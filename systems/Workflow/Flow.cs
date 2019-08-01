//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flow
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    
    using System.Linq;

    public delegate ulong EventHandler(ulong eventid, ulong data);

    public class EventHandlerIndex
    {
        readonly Dictionary<ulong, EventHandler> data;

        public EventHandler this[ulong id]
        {
            get => data[id];
            set => data[id] = value;
        }

    }

    public abstract class Node<T>
        where T : struct
    {

    }

    public class Branch<T> : Node<T>
        where T : struct
    {

    }


    public class Decision<T> : Node<T>
        where T : struct
    {

    }

    public class Process<T> : Node<T>
        where T : struct
    {

    }



}
