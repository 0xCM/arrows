using System;
using System.Runtime.CompilerServices;

class zfunc
{
    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    
    public static bool require(bool condition, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => condition ? condition : throw new Exception($"Condition unsatisfied: line {line}, member {caller} in file {file}");

    public static Exception CountMismatch(int lhs, int rhs, [CallerMemberName] string caller = null,  
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => new Exception($"Count mismatch, {lhs} != {rhs}: line {line}, member {caller} in file {file}");

    public static Exception OutOfRange<T>(T value, T min, T max, [CallerMemberName] string caller = null,  
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => new Exception($"Value {value} is not between {min} and {max}: line {line}, member {caller} in file {file}");
}