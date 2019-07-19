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
    using static MklImports;


    public interface IVslSSTask<T> : IMklTask<T>
        where T : struct
    {
        /// <summary>
        /// Specifies the samples/observations over which computation will occur
        /// in row-major order
        /// </summary>
        ReadOnlySpan<T> Samples {get;}

        /// <summary>
        /// Specifies the Dimension of the observation vectors
        /// </summary>
        int Dimension {get;}
    }

    /// <summary>
    /// Represents a summary statistics task
    /// </summary>
    abstract class VslSSTask<T> : MklTask<T>, IVslSSTask<T>
        where T : struct
    {
        public VslSSTask(int Dim,  T[] Samples, bool autofill = false)
        {
            this.Storage = VslSSMatrixStorage.VSL_SS_MATRIX_STORAGE_ROWS;            
            this.Dim = Dim;
            this.Samples = Samples;
            this.SampleCount = Samples.Length / Dim;
            if(autofill)
            {
                this.Weights = new T[SampleCount];
                for(var i=0; i<SampleCount; i++)
                    this.Weights[i] = PrimalInfo.one<T>();

                this.Indices = new int[Dim];
                for(var i=0; i<Dim; i++)
                    this.Indices[i] = i;
            }
            else
            {
                this.Indices = new int[0];
                this.Weights = new T[0];
            }
        }

        public VslSSTask(int Dim,  T[] Samples, T[] Weights, int[] Indices)
        {
            
            this.Storage = VslSSMatrixStorage.VSL_SS_MATRIX_STORAGE_ROWS;
            this.Dim = Dim;
            this.Samples = Samples;
            this.SampleCount = Samples.Length / Dim;
            this.Weights = Weights;
            this.Indices = Indices;

            require(Weights.Length == SampleCount);
        }

        public abstract VslSSStatus Allocate();

        protected int Dim;

        protected int SampleCount;

        protected VslSSMatrixStorage Storage;

        /// <summary>
        /// Defines the observations/samples over which the task will compute
        /// </summary>
        public readonly T[] Samples;
        

        /// <summary>
        /// Defines the weights applied to the sample vectors
        /// </summary>
        public readonly T[] Weights;
                     
        /// <summary>
        /// Specifies the indices of the vector components that will be processed
        /// </summary>             
        public readonly int[] Indices;

        ReadOnlySpan<T> IVslSSTask<T>.Samples 
            => Samples;

        int IVslSSTask<T>.Dimension 
            => Dim;

        public override void Dispose()
        {
            if(Pointer != IntPtr.Zero)
                VSL.vslSSDeleteTask(ref Pointer);
        }
    }

    
 
}