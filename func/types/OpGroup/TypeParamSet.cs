namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;    

    public class TypeParamSet
    {        
        /// <summary>
        /// The name of the paramter, usually 'T' or some such
        /// </summary>
        public string ParamName {get;}

        /// <summary>
        /// A descriptive label such as "Integers" or "Floats"
        /// </summary>
        public string ParamLabel {get;}

        /// <summary>
        /// A bitfield where the set bits identify types over which the parameter
        /// set will close
        /// </summary>
        public ulong Members {get;}

        /// <summary>
        /// Specifies that the potential types are restricted to those
        /// enumerated in <see cref='PrimalKind'/>
        /// </summary>
        public bool Primal {get;}

        public bool IsMember(ulong id)
            => ((Members >> 8) & (id >> 8)) == id;

    }


}