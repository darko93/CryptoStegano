namespace CryptoStegano
{
    public class Matrix2x2
    {
        private int[,] array = null;

        public Matrix2x2()
        {
            array = new int[2, 2];
        }

        public Matrix2x2(int a00, int a01, int a10, int a11)
        {
            array = new int[2, 2] { { a00, a01 }, { a10, a11 } };
        }

        public int Det()
        {
            return array[0, 0] * array[1, 1] - array[1, 0] * array[0, 1];
        }

        public Matrix2x2 GetInverseMod(int n)
        {
            int inversedDet = Ring.Inverse(this.Det(), n);
            Matrix2x2 inversedMatrix = new Matrix2x2(array[1, 1], -array[0, 1], -array[1, 0], array[0, 0]);
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

        public static Matrix2x2 operator *(int scalar, Matrix2x2 matrix)
        {
            return new Matrix2x2(scalar * matrix[0, 0], scalar * matrix[0, 1], scalar * matrix[1, 0], scalar * matrix[1, 1]);
        }

        public int this[int i, int j]
        {
            get { return array[i, j]; }
            set { array[i, j] = value; }
        }
    }
}
