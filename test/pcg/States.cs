namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using uint8_t = System.Byte;
    using int16_t = System.Int16;
    using uint16_t = System.UInt16;
    using int32_t = System.Int32;
    using uint32_t = System.UInt32;
    using uint64_t = System.UInt64;
    using static PCG;

    public static partial class PCG
    {


       public class pcg_state_8 
        {
            public pcg_state_8()
            {
                oid = (uint)GetHashCode();
            }

            public uint oid {get;}
                
            public uint8_t state;
        };

        public class pcg_state_16 
        {
            public pcg_state_16()
            {
                oid = (uint)GetHashCode();
            }

            public uint oid {get;}

            public uint16_t state;
        };

        public class pcg_state_32 
        {
            public pcg_state_32()
            {
                oid = (uint)GetHashCode();
            }

            public uint oid {get;}
            
            public uint32_t state;
        };

        public class pcg_state_64 
        {
            public pcg_state_64()
            {
                oid = (uint)GetHashCode();
            }

            public uint oid {get;}

            public uint64_t state;
        };

        public class pcg_state_setseq_8 
        {
            public uint8_t state;

            public uint8_t inc;
        };

        public class pcg_state_setseq_16 
        {
            public uint16_t state;

            public uint16_t inc;
        };

        public class pcg_state_setseq_32 
        {
            public uint32_t state;

            public uint32_t inc;
        };

        public class pcg_state_setseq_64 
        {

            public uint64_t state;

            public uint64_t inc;
        };


    }

}