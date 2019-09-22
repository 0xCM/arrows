//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static Reg;
    using static As;

    partial class Asm
    {
        /// <summary>
        /// PXOR xmm, xmm/m128
        /// </summary>
        /// <param name="xmm0">The left operand</param>
        /// <param name="xmm1">The right operand</param>
        /// <remarks>
        /// 0000h sub rsp,18h                   
        /// 0004h vzeroupper                    
        /// 0007h vlddqu xmm0,xmmword ptr [rdx] 
        /// 000bh vlddqu xmm1,xmmword ptr [r8]  
        /// 0010h vpxor xmm0,xmm0,xmm1          
        /// 0014h vmovapd [rsp],xmm0            
        /// 0019h vmovdqu xmm0,xmmword ptr [rsp]
        /// 001eh vmovdqu xmmword ptr [rcx],xmm0
        /// 0022h mov rax,rcx                   
        /// 0025h add rsp,18h                   
        /// 0029h ret                           
        /// </remarks>
        [MethodImpl(Inline)]
        public static XMM pxor(XMM xmm0, XMM xmm1)        
            => Xor(vload<ulong>(ref xmm0), vload<ulong>(ref xmm1));        

        /// <summary>
        /// </summary>
        /// <param name="ymm0"></param>
        /// <param name="ymm1"></param>
        /// <remarks>
        /// 0000h vzeroupper           
        /// 0003h xchg ax,ax           
        /// 0005h vmovupd ymm0,[rdx]   
        /// 0009h vpxor ymm0,ymm0,[r8] 
        /// 000eh vmovupd [rcx],ymm0   
        /// 0012h mov rax,rcx          
        /// 0015h vzeroupper           
        /// 0018h ret                  
        /// </remarks>
        [MethodImpl(Inline)]
        static Vector256<ulong> vpxor_ref(Vector256<ulong> ymm0, Vector256<ulong> ymm1)        
            => Xor(ymm0, ymm1); 

        /// <summary>
        /// 0000h sub rsp,38h                   
        /// 0004h vzeroupper                    
        /// 0007h vlddqu ymm0,ymmword ptr [rdx] 
        /// 000bh vlddqu ymm1,ymmword ptr [r8]  
        /// 0010h vpxor ymm0,ymm0,ymm1          
        /// 0014h vmovupd [rsp],ymm0            
        /// 0019h vmovdqu xmm0,xmmword ptr [rsp]
        /// 001eh vmovdqu xmmword ptr [rcx],xmm0
        /// 0022h vmovdqu xmm0,xmmword ptr [rsp+10h]; 
        /// 0028h vmovdqu xmmword ptr [rcx+10h],xmm0;
        /// 002dh mov rax,rcx                   
        /// 0030h vzeroupper                    
        /// 0033h add rsp,38h                   
        /// 0037h ret                           
        /// </summary>
        /// <param name="ymm0"></param>
        /// <param name="ymm1"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static YMM vpxor(YMM ymm0, YMM ymm1)        
            => Xor(vload<ulong>(ref ymm0), vload<ulong>(ref ymm1));        

        [MethodImpl(Inline)]
        public static ref YMM vpxor(YMM ymm0, YMM ymm1, ref YMM ymm2)        
        {   
            ymm2  = Xor(vload<ulong>(ref ymm0), vload<ulong>(ref ymm1));
            return ref ymm2;
        }        

        [MethodImpl(Inline)]
        public static ref Vector256<ulong> vpxor(YMM ymm0, YMM ymm1, out Vector256<ulong> ymm2)        
        {
            ymm2 = Xor(vload<ulong>(ref ymm0), vload<ulong>(ref ymm1));        
            return ref ymm2;
        }            
 
        /*
        
        
        
         */
    }
}