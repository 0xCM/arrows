//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;    
    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;
    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;
    
    using static zfunc; 
    using static As;

    partial class x86
    {

        ///<intrinsic>unsigned int _andn_u32 (unsigned int a, unsigned int b) ANDN r32a, r32b, reg/m32</intrinsic>
        [MethodImpl(Inline)]
        public static uint _andn_u32(uint a, uint b)
            => AndNot(a,b);

        ///<intrinsic>unsigned __int64 _andn_u64 (unsigned __int64 a, unsigned __int64 b) ANDN r64a, r64b, reg/m64
        [MethodImpl(Inline)]
        public static ulong _andn_u64(ulong a, ulong b)
            => AndNot(a,b);

        ///<intrinsic>unsigned int _blsi_u32 (unsigned int a) BLSI reg, reg/m32</intrinsic>
        [MethodImpl(Inline)]
        public static uint _blsi_u32(uint a)
            => ExtractLowestSetBit(a);

        ///<intrinsic>unsigned __int64 _blsi_u64 (unsigned __int64 a) BLSI reg, reg/m64
        [MethodImpl(Inline)]
        public static ulong _blsi_u64(ulong a)
            => ExtractLowestSetBit(a);
        
        ///<intrinsic>unsigned int _blsr_u32 (unsigned int a) BLSR reg, reg/m32</intrinsic>
        [MethodImpl(Inline)]
        public static uint _blsr_u32(uint a)
            => ResetLowestSetBit(a);

        ///<intrinsic>unsigned __int64 _blsr_u64 (unsigned __int64 a) BLSR reg, reg/m64
        [MethodImpl(Inline)]
        public static ulong _blsr_u64(ulong a)
            => ResetLowestSetBit(a);

        ///<intrinsic>int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32</intrinsic>
        [MethodImpl(Inline)]
        public static uint _mm_tzcnt_32(uint a)
            => TrailingZeroCount(a);

        ///<intrinsic>__int64 _mm_tzcnt_64 (unsigned __int64 a) TZCNT reg, reg/m64
        [MethodImpl(Inline)]
        public static ulong _mm_tzcnt_64(ulong a)
            => TrailingZeroCount(a);

        ///<intrinsic>unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32</intrinsic>
        [MethodImpl(Inline)]
        public static uint _blsmsk_u32(uint a)
            => GetMaskUpToLowestSetBit(a);

        ///<intrinsic>unsigned __int64 _blsmsk_u64 (unsigned __int64 a) BLSMSK reg, reg/m64
        [MethodImpl(Inline)]
        public static ulong _blsmsk_u64(ulong a)
            => GetMaskUpToLowestSetBit(a);

        ///<intrinsic>unsigned int _mulx_u32 (unsigned int a, unsigned int b, unsigned int* hi) MULX r32a, r32b, reg/m32</intrinsic>
        [MethodImpl(Inline)]
        public static uint _mulx_u32(uint a, uint b)
            => MultiplyNoFlags(a,b);

        ///<intrinsic>unsigned int _mulx_u32 (unsigned int a, unsigned int b, unsigned int* hi) MULX r32a, r32b, reg/m32</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe uint _mulx_u32(uint a, uint b, ref uint low)
            => MultiplyNoFlags(a,b, refptr(ref low));

        ///<intrinsic>unsigned __int64 _mulx_u64 (unsigned __int64 a, unsigned __int64 b, unsigned __int64* hi) MULX r64a, r64b, reg/m64</intrinsic>
        [MethodImpl(Inline)]
        public static ulong _mulx_u64(ulong a, ulong b)
            => MultiplyNoFlags(a,b);

        ///<intrinsic>unsigned __int64 _mulx_u64 (unsigned __int64 a, unsigned __int64 b, unsigned __int64* hi) MULX r64a, r64b, reg/m64</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ulong _mulx_u64(ulong a, ulong b, ref ulong low)
            => MultiplyNoFlags(a,b, refptr(ref low));

        ///<intrinsic>unsigned int _pdep_u32 (unsigned int a, unsigned int mask) PDEP r32a, r32b, reg/m32</intrinsic>
        [MethodImpl(Inline)]
        public static uint _pdep_u32(uint a, uint mask)
            => ParallelBitDeposit(a,mask);
        
        ///<intrinsic>unsigned __int64 _pdep_u64 (unsigned __int64 a, unsigned __int64 mask) PDEP r64a, r64b, reg/m64 </intrinsic>
        [MethodImpl(Inline)]
        public static ulong _pdep_u64(ulong a, ulong mask)
            => ParallelBitDeposit(a,mask);

        ///<intrinsic>unsigned int _pext_u32 (unsigned int a, unsigned int mask) PEXT r32a, r32b, reg/m32</intrinsic>
        [MethodImpl(Inline)]
        public static uint _pext_u32(uint a, uint mask)
            => ParallelBitExtract(a, mask);

        ///<intrinsic>unsigned __int64 _pext_u64 (unsigned __int64 a, unsigned __int64 mask) PEXT r64a, r64b, reg/m64 </intrinsic>
        [MethodImpl(Inline)]
        public static ulong _pext_u64(ulong a, ulong mask)
            => ParallelBitExtract(a,mask);

        ///<intrinsic>unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b</intrinsic>
        [MethodImpl(Inline)]
        public static uint _bextr_u32(uint a, byte start, byte len)
            => BitFieldExtract(a, start, len);

        ///<intrinsic>unsigned __int64 _bextr_u64 (unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b
        [MethodImpl(Inline)]
        public static ulong _bextr_u64(ulong a, byte start, byte len)
            => BitFieldExtract(a,start,len);

        ///<intrinsic>unsigned int _bextr2_u32 (unsigned int a, unsigned int control) BEXTR r32a, reg/m32, r32b</intrinsic>
        [MethodImpl(Inline)]
        public static uint _bextr2_u32(uint a, ushort control)
            => BitFieldExtract(a, control);        

        ///<intrinsic>unsigned __int64 _bextr2_u64 (unsigned __int64 a, unsigned __int64 control) BEXTR r64a, reg/m64, r64b
        [MethodImpl(Inline)]
        public static ulong _bextr2_u64(ulong a, ushort control)
            => BitFieldExtract(a, control);

        ///<intrinsic>unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b</intrinsic>
        [MethodImpl(Inline)]
        public static uint _bzhi_u32(uint a, uint index)
            => ZeroHighBits(a, index);

        ///<intrinsic>unsigned __int64 _bzhi_u64 (unsigned __int64 a, unsigned int index) BZHI r64a, reg/m32, r64b</intrinsic>
        [MethodImpl(Inline)]
        public static ulong _bzhi_u64(ulong a, ulong index)
            => ZeroHighBits(a,index);

    }
}




