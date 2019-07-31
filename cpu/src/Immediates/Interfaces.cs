//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static zfunc;


    public interface IImm
    {
        AsmImmInfo Description {get;}   
    }

    /// <summary>
    /// Characterizes an immediate
    /// </summary>
    public interface IImm<T> : IImm
        where T : struct
    {
        /// <summary>
        /// Specifies the size of the immediate
        /// </summary>
        BitSize Width
        {
            [MethodImpl(Inline)]
            get => Unsafe.SizeOf<T>()*8;
        }

        /// <summary>
        /// Specifies the size of the source value from which the immediate was defined
        /// </summary>
        BitSize SrcWidth
        {
            [MethodImpl(Inline)]
            get => IsSignExtended ? BitSize.Define(8) : Width;
        }

        /// <summary>
        /// Specifies whether the immediate is sign-extended
        /// </summary>
        bool IsSignExtended
        {
            [MethodImpl(Inline)]
            get => PrimalInfo.signed<T>();
        }

        /// <summary>
        /// Specifies a label for the immedate that has the form imm{BitWidth}
        /// </summary>
        string Label
        {
            get => $"imm{Width}";
        }

        /// <summary>
        /// The value of the immediate constant
        /// </summary>
        T Value {get;}

    } 

    public interface IImm<I,T> : IImm<T>
        where I:struct
        where T:struct
    {
        I Redefine(T src);   
    }



}
