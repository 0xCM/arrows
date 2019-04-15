//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.CompilerServices;
    
    
    using static zcore;

    /// <summary>
    /// Identifies a location in memory
    /// </summary>
    public struct MemoryIndex
    {
        [MethodImpl(Inline)]
        public MemoryIndex(int TotalLen, int PartLen, int CellIndex = 0, int PartIndex = 0)
        {
            this.TotalLen = TotalLen;
            this.PartLen = PartLen;
            this.PartIndex = PartIndex;
            this.CellIndex = CellIndex;
        }

        /// <summary>
        /// The total lenth of the memory over which the index is defined
        /// </summary>
        public int TotalLen {get;}

        /// <summary>
        /// Th length of each segment in the partition
        /// </summary>
        public int PartLen {get;}

        /// <summary>
        /// The cell-relative index
        /// </summary>
        public int CellIndex;

        /// <summary>
        /// The part-relative index
        /// </summary>
        public int PartIndex;

        /// <summary>
        /// Determines whether the index as moved past the end
        /// of the memory allocation
        /// </summary>
        public bool Finished
        {
            [MethodImpl(Inline)]
            get => CellIndex >= TotalLen;
        }
            
        /// <summary>
        /// Increments the index by 1 cell and the part index by 1, if necessary
        /// </summary>
        [MethodImpl(Inline)]
        public void NextCell()
        {
            CellIndex++;
            if((CellIndex - 1) % PartLen == 0)
                PartIndex++;
        }

        /// <summary>
        /// Increments the index by 1 part and thus the cell index is incremented 
        /// by the length of a part
        /// </summary>
        [MethodImpl(Inline)]
        public void NextPart()
        {
            PartIndex++;
            CellIndex += PartLen;
        }

        /// <summary>
        /// Advances the index cellwise until depletion, invoking an index action at each increment
        /// </summary>
        /// <param name="f">The index action that receives the cell-level and part-level index</param>
        public void IterateCells(Action<int,int> f)
        {
            while(!Finished)
            {
                f(CellIndex, PartIndex);
                NextCell();
            }
        }

        /// <summary>
        /// Advances the index partwise until depletion, invoking an index action at each increment
        /// </summary>
        /// <param name="f">The index action that receives the cell-level and part-level index</param>
        public void IterateParts(Action<int,int> f)
        {
            while(!Finished)
            {
                f(CellIndex, PartIndex);
                NextPart();
            }
        }

        public override string ToString()
            => (CellIndex,PartIndex).Format();

    }

    /// <summary>
    /// Represents a 0-based segment of contiguous/linear memory for which an 
    /// equispaced partition is defined
    /// </summary>
    public readonly struct MemoryPartition
    {
        [MethodImpl(Inline)]
        public static MemoryPartition define(int totalLen, int segLen)
            => new MemoryPartition(totalLen, segLen);

        public MemoryPartition(int totalLen, int segLen)
        {
            if(totalLen % segLen != 0)
                throw new Exception($"Memory segment specification error: {segLen} does not evenly divide {totalLen}");
            
            this.TotalLength = totalLen;
            this.PartLength = segLen;
            this.PartCount = TotalLength / PartLength;
        }

        /// <summary>
        /// Gets a new base-initialied memory index
        /// </summary>
        public MemoryIndex GetIndex()
            => new MemoryIndex(TotalLength, PartLength);

        /// <summary>
        /// The length of a partition segment
        /// </summary>
        public int PartLength {get;}
        
        /// <summary>
        /// The total memory length
        /// </summary>
        public int TotalLength {get;}

        /// <summary>
        /// The total number of parts
        /// </summary>
        public int PartCount {get;}            
    }
}

