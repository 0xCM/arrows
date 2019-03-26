using System;
using System.Globalization;
using Z0;

partial class zcore
{
    /// <summary>
    /// Constructs a date from an integer in the form YYYYMMDD
    /// </summary>
    /// <param name="d">The integer representing the date</param>
    /// <returns></returns>
    public static Date date(int d) 
        => DateTime.ParseExact(d.ToString(), "yyyyMMdd", CultureInfo.CurrentCulture);

}