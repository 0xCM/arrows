//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static zfunc;


    public interface ICpuReg
    {
        
    }

    public interface ICpuReg<N> : ICpuReg
        where N : ITypeNat, INatPow2, new()
    {
        static readonly BitSize BW =new N().value;

        static readonly ByteSize BZ = new ByteSize(BW/8);
        
        BitSize BitWidth 
        { 
            [MethodImpl(Inline)]
            get => BW;
        }

        ByteSize ByteSize 
        { 
            [MethodImpl(Inline)]
            get => BZ;
        }

    }

    public interface ICpuReg<N, T> : ICpuReg<N>
        where N : ITypeNat, INatPow2, new()
        where T : struct
    {
    }

    public interface ICpuReg8 : ICpuReg<N8, ushort>
    {

    }

    public interface ICpuReg16 : ICpuReg<N16, ushort>
    {

    }

    public interface ICpuReg32 : ICpuReg<N32, uint>
    {

    }

    public interface ICpuReg64 : ICpuReg<N64,ulong>
    {

    }

    public interface ICpuReg128 : ICpuReg<N128>
    {

    }

    public interface ICpuReg256 : ICpuReg<N256>
    {

    }

    public interface ICpuReg512 : ICpuReg<N512>
    {

    }

    public interface IGpReg : ICpuReg
    {
        GpRegId Id {get;}   
    }

    public interface IGpReg<N,R,T> : ICpuReg<N,T>, IGpReg
        where N : ITypeNat, INatPow2, new()
        where R : struct, ICpuReg
        where T : struct
    {        

    }

    public interface IGpReg64<R> : IGpReg<N64, R, ulong>
        where R : struct, ICpuReg 
    {        
        byte Lo8 {get; set;}
        
        ushort Lo16 {get; set;}

        uint Lo32 {get; set;}        
    }

    public interface IGpReg32<R> : IGpReg<N32, R, uint>
        where R : struct, ICpuReg 
    {        
        byte Lo8 {get; set;}
        
        ushort Lo16 {get; set;}        
    }

    public interface IGpReg16<R> : IGpReg<N16, R, ushort>
        where R : struct, ICpuReg 
    {        
        byte Lo8 {get; set;}                
    }

    public interface IGpReg8<R> : IGpReg<N8, R, byte>
        where R : struct, ICpuReg 
    {        
        
    }

    public interface IMMReg : ICpuReg
    {

        ref T Cell<T>(int index)      
            where T : unmanaged;        


        Bit this[BitPos r] {get;}            
    }

   
}