namespace CryptoStegano
{
    public class Matrix2
    {
        private int[,] array = null;

        public Matrix2()
        {
            array = new int[2, 2];
        }

        public Matrix2(int a00, int a01, int a10, int a11)
        {
            array = new int[2, 2] { { a00, a01 }, { a10, a11 } };
        }

        public int Det()
        {
            return array[0, 0] * array[1, 1] - array[1, 0] * array[0, 1];
        }

        public Matrix2 GetInverseMod(int n)
        {
            int inversedDet = Ring.Inverse(this.Det(), n);
            Matrix2 inversedMatrix = new Matrix2(array[1, 1], -array[0, 1], -array[1, 0], array[0, 0]);
            inversedMatrix.MultiplyBy(inversedDet);
            Ring.Modulo(inversedMatrix, n);
            return inversedMatrix;
        }

        public bool IsInvertibleMod(int n) =>
            Det().IsInvertibleMod(n);

        public void MultiplyBy(int s)
        {
            array[0, 0] *= s;
            array[0, 1] *= s;
            array[1, 0] *= s;
            array[1, 1] *= s;
        }

        public static Matrix2 operator *(int s, Matrix2 matrix)
        {
            return new Matrix2(s * matrix[0, 0], s * matrix[0, 1], s * matrix[1, 0], s * matrix[1, 1]);
        }

        public int this[int i, int j]
        {
            get { return array[i, j]; }
            set { array[i, j] = value; }
        }
    }
}
