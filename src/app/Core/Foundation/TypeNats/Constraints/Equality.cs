namespace Core
{
    using static corefunc;
    using NC = NatConstraints;

    /// <summary>
    /// Provides evidence that K1 == K2
    /// </summary>
    public readonly struct EQ<K1,K2> : NC.EQ<K1,K2>
        where K1: TypeNat, new()
        where K2: TypeNat, new()
    {

    }

    public static class EQ
    {
        public static EQ<K1,K2> require<K1,K2>()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            var k1 = natval<K1>();
            var k2 = natval<K2>();
            demand(k1 == k2);
            return new EQ<K1,K2>();                             
        }
    }

    partial class NatConstraints
    {

        /// <summary>
        /// Characterizes equality between two nats
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        public interface EQ<K1,K2> : NatConstraint<K1,K2>
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            
        }

        /// <summary>
        /// Characterizes inequality between two nats
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        public interface NEQ<K1,K2> : NatConstraint<K1,K2>
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            
        }

    }
}