//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public static class TypNatX
    {
        public static bool Eq(this ITypeNat lhs, ITypeNat rhs)
            => lhs.value == rhs.value;

        public static bool Gt(this ITypeNat lhs, ITypeNat rhs)
            => lhs.value > rhs.value;

        public static bool GtEq(this ITypeNat lhs, ITypeNat rhs)
            => lhs.value >= rhs.value;

        public static bool Lt(this ITypeNat lhs, ITypeNat rhs)
            => lhs.value < rhs.value;

        public static bool LtEq(this ITypeNat lhs, ITypeNat rhs)
            => lhs.value <= rhs.value;

    }

}