namespace CryptoStegano
{
    static class Ring
    {
        const int n = 256;
        public static int N => n;

        public static bool IsInvertibleMod(this int a, int n) => Inverse(a, n) != 0;

        public static int Modulo(int a, int n)
        {
            a = a % n;
            return a < 0 ? n + a : a;
        }

        public static void Modulo(Digram digram, int n)
        {
            digram[0] = Modulo(digram[0], n);
            digram[1] = Modulo(digram[1], n);
        }

        public static void Modulo(Matrix2x2 matrix, int n)
        {
            matrix[0, 0] = Modulo(matrix[0, 0], n);
            matrix[0, 1] = Modulo(matrix[0, 1], n);
            matrix[1, 0] = Modulo(matrix[1, 0], n);
            matrix[1, 1] = Modulo(matrix[1, 1], n);
        }

        public static int Inverse(int a, int n) // rozszerzony algorytm Euklidesa
        {
            a = Modulo(a, n); // bo algorytm źle działa dla wielu liczb ujemnych, np. -1, -9, -19, -21, -25, ...
            // można to sprawdzić w pętli - stworzyć podobną funkcję Inverse2, ale bez tej linijki i porównać wartości obu funkcji 
            // albo usunąć tą linijkę, a w Inverse2 dać (byte)a
            // równoważne: a = (byte)a, dla n=256
            int q, r, u0 = 1, u1 = 0, v0 = 0, v1 = 1, uv, nCopy = n;
            while (a != 0)
            {
                q = n / a;
                r = n % a;
                uv = u0 - q * u1;
                u0 = u1; u1 = uv;
                uv = v0 - q * v1;
                v0 = v1; v1 = uv;
                n = a;
                a = r;
            }
            if (n == 1) // n = NWD(a,n);
            {
                if (v0 > 0) return v0; // v0 = a', gdy v0 > 0
                else return nCopy + v0; // n - v0 = a', gdy v0 < 0
            }
            else return 0;
        }
    }
}
