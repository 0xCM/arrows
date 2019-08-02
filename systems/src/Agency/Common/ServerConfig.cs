//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines a server configuration record
    /// </summary>
    public class ServerConfig 
    {
        public ServerConfig(uint ServerId, string ServerName, uint CoreNumber)
        {
            this.ServerId = ServerId;
            this.ServerName = ServerName;
            this.CoreNumber = CoreNumber;

        }

        /// <summary>
        /// Identifes the server to which the configuration applies
        /// </summary>        
        public uint ServerId {get;}

        /// <summary>
        /// A descriptive name
        /// </summary>
        public string ServerName {get;}

        /// <summary>
        /// The CPU core to which the server is assigned
        /// </summary>
        public uint CoreNumber {get;}

        public override string ToString()
            => $"Server {ServerId}, Core={CoreNumber}";
    }

}