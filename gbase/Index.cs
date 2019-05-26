//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static zfunc;    

    /// <summary>
    /// Defines an integrally-indexed associative array
    /// </summary>
    public readonly struct Index<T> : IReadOnlyList<T>
    {
        static readonly T[] EmptyArray = new T[]{};
        
        static readonly ArraySegment<T> EmptySegment = new ArraySegment<T>(EmptyArray);

        public static readonly Index<T> Empty = new Index<T>(EmptyArray);

        readonly T[] data;

        readonly ArraySegment<T> segment;

        readonly int DataLength;

        readonly bool IsArrayAssigned;


        [MethodImpl(Inline)]
        public static implicit operator Index<T>(in T[] src)
            => new Index<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Index<T>(in ArraySegment<T> src)
            => new Index<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Index<T>(in List<T> src)
            => new Index<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T[](in Index<T> src)
            => src.ToArray();

        [MethodImpl(Inline)]
        public Index(IEnumerable<T> src)
        {
            this.data = src.ToArray();
            this.IsArrayAssigned = true;
            this.DataLength = data.Length;
            this.segment = EmptySegment;
        }

        [MethodImpl(Inline)]
        public Index(in T[] src)
        {
            this.data = src;
            this.IsArrayAssigned = true;
            this.DataLength = src.Length;
            this.segment = EmptySegment;
        }
            
        [MethodImpl(Inline)]
        public Index(in ArraySegment<T> src)
        {
            this.data = EmptyArray;
            this.segment = src;
            this.DataLength = src.Count;
            this.IsArrayAssigned = false;

        }

        [MethodImpl(Inline)]
        public Index(in List<T> src)
        {
            this.data = src.ToArray();
            this.segment = EmptySegment;
            this.DataLength = src.Count;
            this.IsArrayAssigned = true;
        }

        [MethodImpl(Inline)]
        public T item(int key) 
            => IsArrayAssigned ? data[key] : segment[key];

        IEnumerator<T> enumerator
            => (IsArrayAssigned 
                            ? (data as IReadOnlyList<T>) 
                            : (segment  as IReadOnlyList<T>)).GetEnumerator();
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => enumerator;

        IEnumerator IEnumerable.GetEnumerator()
            => enumerator;

        public bool Equals(Index<T> rhs)
        {        
            if(rhs.Length != this.Length)
                return false;
            
            if(rhs.IsEmpty)
                return true;

            for(var i= 0; i< Length; i++)
                if(!item(i).Equals(rhs.item(i))) 
                    return false;
            return true;
        }

        public T this[int key] 
        {
            [MethodImpl(Inline)]
            get => item(key);
        }
            
        public int Length
            => DataLength;

        public int Count 
            => DataLength;


        [MethodImpl(Inline)]
        public T[] ToArray()
            => IsArrayAssigned ? data : segment.ToArray();

        public bool IsEmpty
            => DataLength == 0;            

        public bool IsNonEmpty
            => DataLength != 0;            

        public Index<T> Where(Func<T,bool> predicate)
            => new Index<T>(data.Where(predicate));
    
        
    }


}