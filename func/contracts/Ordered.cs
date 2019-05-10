//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;



    public interface IOrderedOps<T> 
    {
        bool lt(T lhs, T rhs);
        
        bool lteq(T lhs, T rhs);
        
        bool gt(T lhs, T rhs);  
        
        bool gteq(T lhs, T rhs);              
    }    


    /// <summary>
    /// Characterizes a totally ordered structure
    /// </summary>
    /// <typeparam name="S">The structure reification type</typeparam>
    public interface IOrderable<S> : IEquatable<S>
        where S : IOrderable<S>, new()
    {   
        /// <summary>
        /// Determines whether this:S & rhs:S => this < rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool lt(S rhs);
        
        /// <summary>
        /// Determines whether this:S & rhs:S => this <= rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool lteq(S rhs);
        
        /// <summary>
        /// Determines whether this:S & rhs:S => this > rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool gt(S rhs);                
        
        /// <summary>
        /// Determines whether this:S & rhs:S => this >= rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool gteq(S rhs);              
    }    

}