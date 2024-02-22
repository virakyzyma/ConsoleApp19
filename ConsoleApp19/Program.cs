namespace ConsoleApp19
{

    internal class Program
    {
        static void Main()
        {
            Matrix matrix = new Matrix(new int[,] { { 9, 9, 9 }, { 4, 4, 4 } });
            Matrix matrix2 = new Matrix(new int[,] { { 7, 7, 7 }, { 6, 6, 6 } });
            Matrix matrix3 = matrix + matrix2;
        }
    }
    class Matrix
    {
        public Matrix(int[,] array)
        {
            Array = array;
        }
        public int[,] Array { get; private set; }
        public static Matrix operator +(Matrix matrix, Matrix matrix2)
        {
            int[,] arraySum = new int[matrix.Array.GetLength(0), matrix.Array.GetLength(1)];
            if (matrix.Array.Length == matrix2.Array.Length)
            {
                for (int i = 0; i < matrix.Array.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.Array.GetLength(1); j++)
                    {
                        arraySum[i, j] = matrix.Array[i, j] + matrix2.Array[i, j];
                    }
                }
                return new Matrix(arraySum);
            }
            else
            {
                throw new Exception("Array have different lengts");
            }
        }
        public static Matrix operator -(Matrix matrix, Matrix matrix2)
        {
            int[,] arraySum = new int[matrix.Array.GetLength(0), matrix.Array.GetLength(1)];
            if (matrix.Array.Length == matrix2.Array.Length)
            {
                for (int i = 0; i < matrix.Array.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.Array.GetLength(1); j++)
                    {
                        arraySum[i, j] = matrix.Array[i, j] - matrix2.Array[i, j];
                    }
                }
                return new Matrix(arraySum);
            }
            else
            {
                throw new Exception("Array have different lengts");
            }
        }
    }

}