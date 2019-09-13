namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;    

    public enum OpFacet : byte
    {
        
        /// <summary>
        /// Indicates an operator is public
        /// </summary>
        Public = Pow2.T01,
        
        /// <summary>
        /// Indicates an operator is static
        /// </summary>
        Static = Pow2.T02,

        /// <summary>
        /// Indicates an operator is generic
        /// </summary>
        Generic = Pow2.T03
    }




}