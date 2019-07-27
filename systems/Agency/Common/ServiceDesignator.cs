//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    /// <summary>
    /// Identifies a service implementation
    /// </summary>
    public readonly struct ServiceDesignator
    {
        public static bool operator ==(ServiceDesignator lhs, ServiceDesignator rhs)
            => lhs.Identifier == rhs.Identifier;

        public static bool operator !=(ServiceDesignator lhs, ServiceDesignator rhs)
            => lhs.Identifier == rhs.Identifier;

        public ServiceDesignator(Type ContractType, string ContractLabel)
        {
            this.Identifier = $"{ContractType.FullName}[{ContractLabel}";
        }
        
        /// <summary>
        /// Composite key constructed from the name of the contract and the implementation
        /// label intended to uniquely identify a service reification
        /// </summary>
        readonly string Identifier;

        public override string ToString()
            => Identifier;
        
        public override int GetHashCode()
            => Identifier.GetHashCode();
        
        public bool Equals(ServiceDesignator src)
            => src.Identifier == Identifier;
         
         public override bool Equals(object obj)
            => obj is ServiceDesignator k ? Equals(k) : false;

    }        


}