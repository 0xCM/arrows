//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public class ShiftTest : UnitTest<ShiftTest>
    {
        const int Samples = Pow2.T04;

        void Shift<T>(Orientation dir, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {            
            var x = lhs.Replicate();

            if(dir == Orientation.Left)
            {
                for(var i=0; i< Samples; i++)
                {
                    gbits.shiftl(ref x[i], rhs[i]);
                    Claim.eq(x[i], gbits.shiftl(lhs[i],rhs[i]));
                }
            }
            else
            {
                for(var i=0; i< Samples; i++)
                {
                    gbits.shiftr(ref x[i], rhs[i]);
                    Claim.eq(x[i], gbits.shiftr(lhs[i],rhs[i]));
                }
            }
        }

        public void ShiftI8()
        {
            var lhs = Random.Array<sbyte>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<sbyte>.BitSize));            

            Shift<sbyte>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq((sbyte)(lhs[i] << rhs[i]), math.shiftl(lhs[i], rhs[i])));
    
            Shift<sbyte>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq((sbyte)(lhs[i] >> rhs[i]), math.shiftr(lhs[i], rhs[i])));    
        }

        public void ShiftU8()
        {
            var lhs = Random.Array<byte>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<byte>.BitSize));            

            Shift<byte>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq((byte)(lhs[i] << rhs[i]), math.shiftl(lhs[i], rhs[i])));
    
            Shift<byte>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq((byte)(lhs[i] >> rhs[i]), math.shiftr(lhs[i], rhs[i])));    
        }

        public void ShiftI32()
        {
            var lhs = Random.Array<int>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<int>.BitSize));            

            Shift<int>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], math.shiftl(lhs[i], rhs[i])));
    
            Shift<int>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], math.shiftr(lhs[i], rhs[i])));
        }

        public void ShiftU32()
        {
            var lhs = Random.Array<uint>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<uint>.BitSize));            

            Shift<uint>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], math.shiftl(lhs[i], rhs[i])));
    
            Shift<uint>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], math.shiftr(lhs[i], rhs[i])));

        }
        public void ShiftI64()
        {
            var lhs = Random.Array<long>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<long>.BitSize));            

            Shift<long>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], math.shiftl(lhs[i], rhs[i])));
    
            Shift<long>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], math.shiftr(lhs[i], rhs[i])));
        }

        public void ShiftU64()
        {
            var lhs = Random.Array<ulong>(Samples);            
            var rhs = Random.Array<int>(Samples, closed(0, (int)SizeOf<ulong>.BitSize));            

            Shift<ulong>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], math.shiftl(lhs[i], rhs[i])));
    
            Shift<ulong>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], math.shiftr(lhs[i], rhs[i])));
        }

    }
}