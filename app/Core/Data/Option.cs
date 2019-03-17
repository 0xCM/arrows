//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static corefunc;

    /// <summary>
    /// Represents a potential value
    /// </summary>
    public readonly struct Option<T> 
    {
        public static readonly Option<T> None = default(Option<T>);

        public static implicit operator Option<T>(T potential)
            => potential != null ? some(potential) : none<T>();
            
        readonly T _potential;
        
        readonly bool _exists;

        public Option(T value)
        {
            _potential = value;
            _exists = true;
        }

        public bool exists => _exists;

        public T value 
            => _exists ? _potential : throw new ArgumentNullException();
        
    }


}