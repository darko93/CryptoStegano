namespace CryptoStegano
{
    public class HillKey : IKey<HillKey>
    {
        public Matrix2 Matrix { get; private set; }
        public Digram Digram { get; private set; }

        public HillKey(Matrix2 matrix, Digram digram)
        {
            Matrix = matrix;
            Digram = digram;
        }

        public bool IsInvertibleMod(int n) => Matrix.IsInvertibleMod(n);

        public HillKey GetInverseMod(int n)
        {
            Matrix2 inversedMatrix = Matrix.GetInverseMod(n); // New Matrix.
            Digram inversedDigram = -1 * Digram; // New Digram.
            inversedDigram.MultiplyBy(inversedMatrix);
            Ring.Modulo(inversedDigram, n);
            return new HillKey(inversedMatrix, inversedDigram);
        }
    }
}
