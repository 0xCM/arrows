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
    using static PCG;

    public static partial class PCG
    {

        public class pcg_state<T>
            where T : struct
        {
            public pcg_state()
            {
                oid = (uint)GetHashCode();
            }

            public uint oid {get;}

            public T state;
        }

        public class pcg_state_8 : pcg_state<byte>
        {

        };

        public class pcg_state_16 : pcg_state<ushort>
        {

        };

        public class pcg_state_32 : pcg_state<uint>
        {

        };

        public class pcg_state_64 : pcg_state<ulong>
        {

        };

        public class pcg_state_setseq<T> : pcg_state<T>
            where T : struct
        {
            public T inc;

        }

        public class pcg_state_setseq_8 : pcg_state_setseq<byte>
        {

        };

        public class pcg_state_setseq_16 : pcg_state_setseq<ushort>
        {

        };

        public class pcg_state_setseq_32 : pcg_state_setseq<uint>
        {

        };

        public class pcg_state_setseq_64 : pcg_state_setseq<ulong>
        {

        };
    }

}