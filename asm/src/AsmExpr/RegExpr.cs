//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


    /// <summary>
    /// Represents a a register with width of natural type
    /// </summary>
    /// <typeparam name="N">The width type</typeparam>
    public abstract class RegExpr<N,T> : AsmExpr
        where N : ITypeNat, new()
        where T : Enum
    {
        protected RegExpr(T RegId)
        {
            this.RegId = RegId;
            this.Width = (int)new N().value;
        }

        public T RegId {get;}

        public int Width {get;}
    }

    /// <summary>
    /// Represents an 8-bit register
    /// </summary>
    public abstract class Reg8Expr : RegExpr<N8,GpRegId8>
    {
        protected Reg8Expr(GpRegId8 RegId)
            : base(RegId)
        {
        }

    }

    /// <summary>
    /// Represents an 16-bit register
    /// </summary>
    public abstract class Reg16Expr : RegExpr<N16,GpRegId16>
    {

        protected Reg16Expr(GpRegId16 RegId)
            : base(RegId)
        {

        }


    }

    /// <summary>
    /// Represents a 32-bit register
    /// </summary>
    public abstract class Reg32Expr : RegExpr<N32,GpRegId32>
    {
        protected Reg32Expr(GpRegId32 RegId)
            : base(RegId)
        {
        }


    }

    /// <summary>
    /// Represents a 64-bit register
    /// </summary>
    public abstract class Reg64Expr : RegExpr<N64,GpRegId64>
    {
        protected Reg64Expr(GpRegId64 RegId)
            : base(RegId)
        {
        }

        public Reg32Expr Lo {get;}
    }



}
