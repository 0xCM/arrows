//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inxfunc;

    public static class InXFusionOps
    {
        static readonly PrimalIndex AddLU
            = PrimKinds.index
                (@sbyte: new PrimalFusedBinOp<sbyte>(InX.add),
                @byte: new PrimalFusedBinOp<byte>(InX.add),
                @short: new PrimalFusedBinOp<short>(InX.add),
                @ushort: new PrimalFusedBinOp<ushort>(InX.add),
                @int: new PrimalFusedBinOp<int>(InX.add),
                @uint: new PrimalFusedBinOp<uint>(InX.add),
                @long: new PrimalFusedBinOp<long>(InX.add),
                @ulong: new PrimalFusedBinOp<ulong>(InX.add),
                @float: new PrimalFusedBinOp<float>(InX.add),
                @double:new PrimalFusedBinOp<double>(InX.add)
                );

        static readonly PrimalIndex SumLU
            = PrimKinds.index<object>
                (
                    @short: new PrimalAggOp<short>(InX.sum),
                    @int: new PrimalAggOp<int>(InX.sum),
                    @float: new PrimalAggOp<float>(InX.sum),
                    @double:new PrimalAggOp<double>(InX.sum)
                );


        static readonly PrimalIndex AndLU
            = PrimKinds.index
                (@sbyte: new PrimalFusedBinOp<sbyte>(InX.and),
                @byte: new PrimalFusedBinOp<byte>(InX.and),
                @short: new PrimalFusedBinOp<short>(InX.and),
                @ushort: new PrimalFusedBinOp<ushort>(InX.and),
                @int: new PrimalFusedBinOp<int>(InX.and),
                @uint: new PrimalFusedBinOp<uint>(InX.and),
                @long: new PrimalFusedBinOp<long>(InX.and),
                @ulong: new PrimalFusedBinOp<ulong>(InX.and),
                @float: new PrimalFusedBinOp<float>(InX.and),
                @double:new PrimalFusedBinOp<double>(InX.and)
                );

        static readonly PrimalIndex OrLU
            = PrimKinds.index
                (@sbyte: new PrimalFusedBinOp<sbyte>(InX.or),
                @byte: new PrimalFusedBinOp<byte>(InX.or),
                @short: new PrimalFusedBinOp<short>(InX.or),
                @ushort: new PrimalFusedBinOp<ushort>(InX.or),
                @int: new PrimalFusedBinOp<int>(InX.or),
                @uint: new PrimalFusedBinOp<uint>(InX.or),
                @long: new PrimalFusedBinOp<long>(InX.or),
                @ulong: new PrimalFusedBinOp<ulong>(InX.or),
                @float: new PrimalFusedBinOp<float>(InX.or),
                @double:new PrimalFusedBinOp<double>(InX.or)
                );


        static readonly PrimalIndex XOrLU
            = PrimKinds.index
                (@sbyte: new PrimalFusedBinOp<sbyte>(InX.xor),
                @byte: new PrimalFusedBinOp<byte>(InX.xor),
                @short: new PrimalFusedBinOp<short>(InX.xor),
                @ushort: new PrimalFusedBinOp<ushort>(InX.xor),
                @int: new PrimalFusedBinOp<int>(InX.xor),
                @uint: new PrimalFusedBinOp<uint>(InX.xor),
                @long: new PrimalFusedBinOp<long>(InX.xor),
                @ulong: new PrimalFusedBinOp<ulong>(InX.xor),
                @float: new PrimalFusedBinOp<float>(InX.xor),
                @double:new PrimalFusedBinOp<double>(InX.xor)
                );

        readonly struct Add<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op = AddLU.lookup<T,PrimalFusedBinOp<T>>();
        }

        readonly struct Sum<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalAggOp<T> Op = SumLU.lookup<T,PrimalAggOp<T>>();
        }
        
        readonly struct And<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op = AndLU.lookup<T,PrimalFusedBinOp<T>>();
        }

        readonly struct Or<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op = OrLU.lookup<T,PrimalFusedBinOp<T>>();
        }

        readonly struct XOr<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op = XOrLU.lookup<T,PrimalFusedBinOp<T>>();
        }

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Add<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> add<T>(in Index<T> lhs, in Index<T> rhs)
            where T : struct, IEquatable<T>
                => add<T>()(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalAggOp<T> sum<T>()
            where T : struct, IEquatable<T>
                => Sum<T>.Op;

        [MethodImpl(Inline)]
        public static T sum<T>(in Index<T> src)
            where T : struct, IEquatable<T>
                => sum<T>()(src); 
 
        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> and<T>()
            where T : struct, IEquatable<T>
                => And<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> and<T>(in Index<T> lhs, in Index<T> rhs)
            where T : struct, IEquatable<T>
                => and<T>()(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> or<T>()
            where T : struct, IEquatable<T>
                => Or<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> or<T>(in Index<T> lhs, in Index<T> rhs)
            where T : struct, IEquatable<T>
                => or<T>()(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> xor<T>()
            where T : struct, IEquatable<T>
                => XOr<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> xor<T>(in Index<T> lhs, in Index<T> rhs)
            where T : struct, IEquatable<T>
                => xor<T>()(lhs,rhs);

    }
}