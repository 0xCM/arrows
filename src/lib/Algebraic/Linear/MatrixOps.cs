namespace Z0
{
    using System;
    using static zcore;
    using static Traits;

    public readonly struct MatrixOps<N,M,T> : Semiring<Matrix<M,N,T>>
        where M : TypeNat, new()
        where N : TypeNat, new()
    {
        static readonly Semiring<T> Semiring = ops<T,Semiring<T>>();


        public Matrix<M, N, T> zero 
            => throw new NotImplementedException();


        public Matrix<M, N, T> one 
            => throw new NotImplementedException();

        public Addition<Matrix<M, N, T>> addition 
            => Addition<Matrix<M, N, T>>.define(this);

        public Multiplication<Matrix<M, N, T>> multiplication 
            => Multiplication<Matrix<M, N, T>>.define(this);

        public Matrix<M, N, T> add(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
        {
            throw new NotImplementedException();
        }

        public Matrix<M, N, T> distribute(Matrix<M, N, T> lhs, (Matrix<M, N, T> x, Matrix<M, N, T> y) rhs)
        {
            throw new NotImplementedException();
        }

        public Matrix<M, N, T> distribute((Matrix<M, N, T> x, Matrix<M, N, T> y) lhs, Matrix<M, N, T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool eq(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
        {
            throw new NotImplementedException();
        }

        public Matrix<M, N, T> mul(Matrix<M, N, T> a, Matrix<M, N, T> b)
        {
            throw new NotImplementedException();
        }

        public bool neq(Matrix<M, N, T> lhs, Matrix<M, N, T> rhs)
        {
            throw new NotImplementedException();
        }
    }

}