namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Globalization;
    using System.Linq;

    using static zfunc;

    /// <summary>
    /// Classifies the precision with which <see cref="DateTime"/> value should be interpreted
    /// </summary>
    public enum DateTimeAccuracy
    {
        /// <summary>
        /// Specifies that only the date part is meaningful
        /// </summary>
        Date,
        /// <summary>
        /// Specifies that the date and hour components are meaningful
        /// </summary>
        Hour,
        /// <summary>
        /// Specifies that the date, hour and minute components are meaningful
        /// </summary>
        Minute,
        /// <summary>
        /// Specifies that the date, hour, minute and second components are meaningful
        /// </summary>
        Second,
        /// <summary>
        /// Specifies that the time represented by a <see cref="DateTime"/> value 
        /// has millisecond accuracy
        /// </summary>
        Millisecond
    }

}