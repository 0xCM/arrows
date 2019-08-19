namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public abstract class Literal<T,L>
        where T : Literal<T,L>
    {
        [MethodImpl(Inline)]
        public static implicit operator L(Literal<T,L> src)
            => src.Value;

        public readonly L Value;

        protected Literal(L Value)
            => this.Value = Value;
    }

    public sealed class PermId : Literal<PermId,byte>
    {
        public static byte Define(PermId x0, PermId x1, PermId x2, PermId x3)
            => (byte)(x0 << 0 | x1 << 2 | x2 << 4 | x3 << 6); 

        public static byte Define(byte x0, byte x1, byte x2, byte x3)
            => (byte)(x0 << 0 | x1 << 2 | x2 << 4 | x3 << 6); 

        PermId(byte value)
            : base(value)
            {

            }

    }

}