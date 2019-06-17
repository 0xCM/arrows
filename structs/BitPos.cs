//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Specifies a 0-relative bit position where significance increases
    /// in the same direction as the position. The meaning of a negativev
    /// position will be determined by a given use case, if any.
    /// </summary>
    public ref struct BitPos
    {
        public int current;

        [MethodImpl(Inline)]
        public static bool operator ==(BitPos lhs, BitPos rhs)        
            => lhs.current == rhs.current;

        [MethodImpl(Inline)]
        public static bool operator !=(BitPos lhs, BitPos rhs)        
            => lhs.current != rhs.current;

        [MethodImpl(Inline)]
        public static BitPos operator +(BitPos lhs, BitPos rhs)        
            => lhs.current + rhs.current;

        [MethodImpl(Inline)]
        public static BitPos operator ++(BitPos src)        
            => ++src.current;

        [MethodImpl(Inline)]
        public static BitPos Define(int current)
            => new BitPos(current);

        [MethodImpl(Inline)]
        public static implicit operator BitPos(int src)
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator int(BitPos src)
            => src.current;        

        [MethodImpl(Inline)]
        public BitPos(int current)
            => this.current = current;


        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object obj)
            => throw new NotSupportedException();
    }

}