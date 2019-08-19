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
        bool Lt(T lhs, T rhs);
        
        bool LtEq(T lhs, T rhs);
        
        bool Gt(T lhs, T rhs);  
        
        bool GtEq(T lhs, T rhs);              
    }    


    /// <summary>
    /// Characterizes a totally ordered structure
    /// </summary>
    /// <typeparam name="S">The structure reification type</typeparam>
    public interface IOrderable<S>
        where S : IOrderable<S>, new()
    {   
        /// <summary>
        /// Determines whether this:S & rhs:S => this < rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool Lt(S rhs);
        
        /// <summary>
        /// Determines whether this:S & rhs:S => this <= rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool LtEq(S rhs);
        
        /// <summary>
        /// Determines whether this:S & rhs:S => this > rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool Gt(S rhs);                
        
        /// <summary>
        /// Determines whether this:S & rhs:S => this >= rhs
        /// </summary>
        /// <param name="rhs">The operand to compare</param>
        bool GtEq(S rhs);              
    }    

}