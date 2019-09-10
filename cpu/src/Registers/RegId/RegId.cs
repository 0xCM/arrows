//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Pow2;
    using static zfunc;

    public readonly struct RegId<T> 
        where T : Enum
    {
        public static readonly RegId<T> TheOnly = default;
    }

    public static class RegId
    {
        static readonly RegId<GpRegId8> GP8 = RegId<GpRegId8>.TheOnly;

        static readonly RegId<GpRegId16> GP16 = RegId<GpRegId16>.TheOnly;

        static readonly RegId<GpRegId32> GP32 = RegId<GpRegId32>.TheOnly;

        static readonly RegId<GpRegId64> GP64 = RegId<GpRegId64>.TheOnly;

        static readonly RegId<GpRegId> GP = RegId<GpRegId>.TheOnly;

        static readonly RegId<MaskRegId> MASK = RegId<MaskRegId>.TheOnly;

        static readonly RegId<ControlRegId> CONTROL = RegId<ControlRegId>.TheOnly;

        static readonly RegId<XmmRegId> XMM = RegId<XmmRegId>.TheOnly;

        static readonly RegId<YmmRegId> YMM = RegId<YmmRegId>.TheOnly;

        static readonly RegId<ZmmRegId> ZMM = RegId<ZmmRegId>.TheOnly;

        static readonly RegId<MmRegId> MM = RegId<MmRegId>.TheOnly;

        [MethodImpl(Inline)]
        public static XmmRegId xmm(int i)
            =>  (XmmRegId) (((ulong)XmmRegId.xmm0) | ( i == 0 ? 0 : Pow2.pow(i)));
        
        [MethodImpl(Inline)]
        public static GpRegId? ParseGP(string src)
        {            
            if(Enum.TryParse(src,true, out GpRegId reg))
                return reg;
            return null;
        }

    }



}