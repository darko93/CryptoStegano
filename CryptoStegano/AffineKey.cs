namespace CryptoStegano
{
    class AffineKey
    {
        public int A { get; private set; }
        public int B { get; private set; }

        public AffineKey(int a, int b)
        {
            A = a;
            B = b;
        }

        public AffineKey GetInverseMod(int n)
        {
            int inversedA = Ring.Inverse(A, n);
            int inversedB = Ring.Modulo(n - inversedA * B, n);
            return new AffineKey(inversedA, inversedB);
        }

        public bool IsCorrectMod(int n) => Ring.Inverse(A, Ring.N) != 0;
    }
}
