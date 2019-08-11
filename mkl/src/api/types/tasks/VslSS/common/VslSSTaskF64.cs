//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    sealed class VslSSTaskF64 : VslSSTask<double>
    {
        public static VslSSTaskF64 Define(int Dim, double[] Samples)
        {
            var task = new VslSSTaskF64(Dim, Samples);
            task.Allocate().AutoThrow();
            return task;
        }

        public VslSSTaskF64(int Dim, double[] Samples)
            : base(Dim, Samples)
        {

        }

        public VslSSTaskF64(int Dim,  double[] Samples, double[] Weights, int[] Indices)
            : base(Dim, Samples, Weights, Indices)
        {

        }

        public unsafe override VslSSStatus Allocate()
        {
            if(Weights.Length == 0 && Indices.Length == 0)
                return VSL.vsldSSNewTask(ref Pointer, ref Dim, ref SampleCount, ref Storage, ref Samples[0]);
            else if(Weights.Length != 0 && Indices.Length == 0)
                return VSL.vsldSSNewTask(ref Pointer, ref Dim, ref SampleCount, ref Storage, ref Samples[0], ref Weights[0]);
            else if(Weights.Length != 0 && Indices.Length != 0)
                return VSL.vsldSSNewTask(ref Pointer, ref Dim, ref SampleCount, ref Storage, ref Samples[0], ref Weights[0], ref Indices[0]);
            else
                return VSL.vsldSSNewTask(ref Pointer, ref Dim, ref SampleCount, ref Storage, ref Samples[0], null, ref Indices[0]);
        }            
    }

}