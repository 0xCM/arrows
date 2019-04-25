//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inxfunc;



    public static class Vector128Delegates
    {
        static readonly PrimalIndex Add = PrimKinds.index
            (@sbyte : new Vector128BinOp<sbyte>(Avx2.Add), 
             @byte : new Vector128BinOp<byte>(Avx2.Add),  
             @short : new Vector128BinOp<short>(Avx2.Add),
             @ushort : new Vector128BinOp<ushort>(Avx2.Add),
             @int : new Vector128BinOp<int>(Avx2.Add),
             @uint : new Vector128BinOp<uint>(Avx2.Add),
             @long : new Vector128BinOp<long>(Avx2.Add),
             @ulong : new Vector128BinOp<ulong>(Avx2.Add),
             @float : new Vector128BinOp<float>(Avx2.Add),
             @double : new Vector128BinOp<double>(Avx2.Add)
             );


        [MethodImpl(Inline)]
        public static Vector128BinOp<T> add<T>()
           where T : struct, IEquatable<T>
                => Add.lookup<T,Vector128BinOp<T>>();

    }

}