namespace CryptoStegano
{
    public class Digram
    {
        private int[] digram = null;

        public Digram()
        {
            digram = new int[2];
        }

        public Digram(int d0, int d1)
        {
            digram = new int[2] { d0, d1 };
        }

        public void MultiplyBy(int s)
        {
            digram[0] *= s;
            digram[1] *= s;
        }

        public void MultiplyBy(Matrix2 matrix)
        {
            int d0 = digram[0];
            int d1 = digram[1];
            digram[0] = d0 * matrix[0, 0] + d1 * matrix[1, 0];
            digram[1] = d0 * matrix[0, 1] + d1 * matrix[1, 1];
        }

        public void Add(Digram digram)
        {
            this.digram[0] += digram[0];
            this.digram[1] += digram[1];
        }

        public static Digram operator *(int s, Digram digram)
        {
            return new Digram(s * digram[0], s * digram[1]);
        }

        public static Digram operator +(Digram digram1, Digram digram2)
        {
            return new Digram(digram1[0] + digram2[0], digram1[1] + digram2[1]);
        }

        public static Digram operator *(Digram digram, Matrix2 matrix)
        {
            return new Digram(digram[0] * matrix[0, 0] + digram[1] * matrix[1, 0], digram[0] * matrix[0, 1] + digram[1] * matrix[1, 1]);
        }

        public int this[int i]
        {
            get { return digram[i]; }
            set { digram[i] = value; }
        }
    }
}
