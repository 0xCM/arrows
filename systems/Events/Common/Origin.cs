//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Captures an instant in time with respect to a server/agent
    /// </summary>
    /// <summary>
    /// Uniquely identifies a point in simulation spacetime
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct Origin
    {
        /// <summary>
        /// Constructs an origin from an order pair of location and timestamp
        /// </summary>
        /// <param name="loc">The location of occurence</param>
        /// <param name="time">The time of occurrence</param>
        public static implicit operator Origin((ulong loc, ulong time) src)
            => new Origin(src.loc,src.time);
        
        public Origin(ulong Location, ulong Time)
        {
            this.Location = Location;
            this.Timestamp = Time;
        }

        /// <summary>
        /// A value that uniquely identifies the logical event source
        /// </summary>
        [FieldOffset(0)]
        public readonly ulong Location;

        /// <summary>
        /// The time of occurrence, expressed as number of elapsed units
        /// from some fixed point in time
        /// </summary>
        [FieldOffset(8)]
        public readonly ulong Timestamp;

        public void Deconstruct(out ulong location, out ulong time)
        {
            location = Location;
            time = Timestamp;
        }    
    }
}