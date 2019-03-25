//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Traits
    {
        public interface Ordered<T> : Stepwise<T>, Equatable<T>
        {
            bool lt(T lhs, T rhs);
            
            bool lteq(T lhs, T rhs);
            
            bool gt(T lhs, T rhs);  
            
            bool gteq(T lhs, T rhs);              
        }    

        /// <summary>
        /// Characterizes a structural number that can be ordered
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underling primitive</typeparam>
        public interface Ordered<S,T> : Stepwise<S,T>, Equatable<S,T>, IComparable<S>
            where S : Ordered<S,T>, new()
        {   
            bool lt(S rhs);
            
            bool lteq(S rhs);
            
            bool gt(S rhs);                
            
            bool gteq(S rhs);              
        }    

        
    }

}