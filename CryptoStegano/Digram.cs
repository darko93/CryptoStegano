namespace CryptoStegano
{
    public class Digram
    {
        private int[] vector;

        public Digram()
        {
            vector = new int[2];
        }

        public Digram(int v0, int v1)
        {
            vector = new int[2] { v0, v1 };
        }

        public void MultiplyBy(int scalar)
        {
            vector[0] *= scalar;
            vector[1] *= scalar;
        }

        public void MultiplyBy(Matrix2x2 matrix)
        {
            int v0 = vector[0];
            int v1 = vector[1];
            vector[0] = v0 * matrix[0, 0] + v1 * matrix[1, 0];
            vector[1] = v0 * matrix[0, 1] + v1 * matrix[1, 1];
        }

        public void Add(Digram digram)
        {
            vector[0] += digram[0];
            vector[1] += digram[1];
        }

        public static Digram operator *(int scalar, Digram digram)
        {
            return new Digram(scalar * digram[0], scalar * digram[1]);
        }

        public static Digram operator +(Digram digram1, Digram digram2)
        {
            return new Digram(digram1[0] + digram2[0], digram1[1] + digram2[1]);
        }

        public static Digram operator *(Digram digram, Matrix2x2 matrix)
        {
            return new Digram(digram[0] * matrix[0, 0] + digram[1] * matrix[1, 0], digram[0] * matrix[0, 1] + digram[1] * matrix[1, 1]);
        }

        public int this[int i]
        {
            get { return vector[i]; }
            set { vector[i] = value; }
        }
    }
}
