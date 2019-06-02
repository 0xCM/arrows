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
            var y = rhs;

            if(dir == Orientation.Left)
            {
                for(var i=0; i< Samples; i++)
                {
                    gmath.shiftl(ref x[i], rhs[i]);
                    Claim.eq(x[i], gmath.shiftl(lhs[i],rhs[i]));
                }
            }
            else
            {
                for(var i=0; i< Samples; i++)
                {
                    gmath.shiftr(ref x[i], rhs[i]);
                    Claim.eq(x[i], gmath.shiftr(lhs[i],rhs[i]));
                }
            }
        }

        public void ShiftI8()
        {
            var lhs = Randomizer.Array<sbyte>(Samples);            
            var rhs = Randomizer.Array<int>(Samples, closed(0, SizeOf<sbyte>.BitSize));            

            Shift<sbyte>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq((sbyte)(lhs[i] << rhs[i]), math.shiftl(lhs[i], rhs[i])));
    
            Shift<sbyte>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq((sbyte)(lhs[i] >> rhs[i]), math.shiftr(lhs[i], rhs[i])));
    

        }

        public void ShiftU8()
        {
            var lhs = Randomizer.Array<byte>(Samples);            
            var rhs = Randomizer.Array<int>(Samples, closed(0, SizeOf<byte>.BitSize));            

            Shift<byte>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq((byte)(lhs[i] << rhs[i]), math.shiftl(lhs[i], rhs[i])));
    
            Shift<byte>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq((byte)(lhs[i] >> rhs[i]), math.shiftr(lhs[i], rhs[i])));
    

        }

        public void ShiftI32()
        {
            var lhs = Randomizer.Array<int>(Samples);            
            var rhs = Randomizer.Array<int>(Samples, closed(0, SizeOf<int>.BitSize));            

            Shift<int>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], math.shiftl(lhs[i], rhs[i])));
    
            Shift<int>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], math.shiftr(lhs[i], rhs[i])));
    

        }

        public void ShiftU32()
        {
            var lhs = Randomizer.Array<uint>(Samples);            
            var rhs = Randomizer.Array<int>(Samples, closed(0, SizeOf<uint>.BitSize));            

            Shift<uint>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], math.shiftl(lhs[i], rhs[i])));
    
            Shift<uint>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], math.shiftr(lhs[i], rhs[i])));

        }
        public void ShiftI64()
        {
            var lhs = Randomizer.Array<long>(Samples);            
            var rhs = Randomizer.Array<int>(Samples, closed(0, SizeOf<long>.BitSize));            

            Shift<long>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], math.shiftl(lhs[i], rhs[i])));
    
            Shift<long>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], math.shiftr(lhs[i], rhs[i])));

        }

        public void ShiftU64()
        {
            var lhs = Randomizer.Array<ulong>(Samples);            
            var rhs = Randomizer.Array<int>(Samples, closed(0, SizeOf<ulong>.BitSize));            

            Shift<ulong>(Orientation.Left, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] << rhs[i], math.shiftl(lhs[i], rhs[i])));
    
            Shift<ulong>(Orientation.Right, lhs, rhs);        
            iter(Samples, i => Claim.eq(lhs[i] >> rhs[i], math.shiftr(lhs[i], rhs[i])));


        }


    }

}