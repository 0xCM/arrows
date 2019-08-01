//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;




    public static partial class asm
    {
        public abstract class Reg<N>
            where N : ITypeNat, new()
        {
            protected Reg(string Name)
            {
                this.Name = Name;
            }

            public string Name {get;}
        }

        public abstract class Reg8 : Reg<N8>
        {

            protected Reg8(string Name)
                : base(Name)
            {
            }

        }

        public abstract class Reg16 : Reg<N16>
        {

            protected Reg16(string Name, Reg8 Lo, Reg8 Hi = null)
                : base(Name)
            {
                this.Lo = Lo;
                this.Hi = Hi;
            }

            public Reg8 Lo {get;}

            public Option<Reg8> Hi {get;}

        }

        public abstract class Reg32 : Reg<N32>
        {
            protected Reg32(string Name, Reg16 Lo)
                : base(Name)
            {
            }

            public Reg16 Lo {get;}

        }

        public abstract class Reg64 : Reg<N64>
        {
            protected Reg64(string Name, Reg32 Lo)
                : base(Name)
            {
            }

            public Reg32 Lo {get;}
        }




    }


}