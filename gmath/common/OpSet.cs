//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Classifies sets of operations
    /// </summary>
    public enum OpSet
    {
        
        /// <summary>
        /// Indicates all available operations
        /// </summary>
        All, 
        
        /// <summary>
        /// Indicates fused and atomic primal operations
        /// </summary>        
        Primal, 
        
        /// <summary>
        /// Indicates fused and atomic intrinsic operations
        /// </summary>        
        Intrisic,
        
        /// <summary>
        /// Indicates intrinsic and primal fused  operations
        /// </summary>        
        Fused,

        /// <summary>
        /// Indicates intrinsic and primal atomic operations
        /// </summary>        
        Atomic 
        
    }

 

}