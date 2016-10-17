namespace CryptoStegano
{
    public class HillKey
    {
        public Matrix2x2 Matrix { get; private set; }
        public Digram Digram { get; private set; }

        public HillKey(Matrix2x2 matrix, Digram digram)
        {
            Matrix = matrix;
            Digram = digram;
        }

        public bool IsCorrectMod(int n) => Matrix.IsInvertibleMod(n);

        public HillKey GetInverseMod(int n)
        {
            Matrix2x2 inversedMatrix = Matrix.GetInverseMod(n); // New Matrix.
            Digram inversedDigram = -1 * Digram; // New Digram.
            inversedDigram.MultiplyBy(inversedMatrix);
            Ring.Modulo(inversedDigram, n);
            return new HillKey(inversedMatrix, inversedDigram);
        }
    }
}
