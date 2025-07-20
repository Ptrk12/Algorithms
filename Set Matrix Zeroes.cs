namespace Algorithms
{
    internal class Set_Matrix_Zeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                var rowMatrix = matrix[i];
                int top = 0;
                int down = 0;
                int left = 0;
                int right = 0;

                if (!rowMatrix.Contains(0))
                    continue;
                else
                {
                    for (int j = 0; j < rowMatrix.Length; j++)
                    {
                        if (matrix[i][j] == 0)
                        {
                            top = i - 1;
                            down = i + 1;
                            left = j - 1;
                            right = j + 1;

                            if (top == 0 && matrix[top][j] != 0)
                            {
                                matrix[top][j] = -99;
                            }
                            if (down == matrix.Length - 1 && matrix[down][j] != 0)
                            {
                                matrix[down][j] = -99;
                            }
                            if (left == 0 && matrix[i][left] != 0)
                            {
                                matrix[i][left] = -99;
                            }
                            if (right == rowMatrix.Length - 1 && matrix[i][right] != 0)
                            {
                                matrix[i][right] = -99;
                            }

                            if (top != -1)
                            {
                                while (top != 0 && matrix[top][j] != 0)
                                {
                                    matrix[top][j] = -99;
                                    top--;
                                }
                                if (top == 0 && matrix[top][j] != 0)
                                {
                                    matrix[top][j] = -99;
                                }
                            }

                            while (down != matrix.Length && matrix[down][j] != 0)
                            {
                                matrix[down][j] = -99;
                                down++;
                            }
                            if (down == matrix.Length - 1 && matrix[down][j] != 0)
                            {
                                matrix[down][j] = -99;
                            }
                            if (left != -1)
                            {
                                while (left != 0 && matrix[i][left] != 0)
                                {
                                    matrix[i][left] = -99;
                                    left--;
                                }
                                if (left == 0 && matrix[i][left] != 0)
                                {
                                    matrix[i][left] = -99;
                                }
                            }

                            if (right < rowMatrix.Length - 1)
                            {
                                while (right != rowMatrix.Length - 1 && matrix[i][right] != 0)
                                {
                                    matrix[i][right] = -99;
                                    right++;
                                }
                                if (right == rowMatrix.Length - 1 && matrix[i][right] != 0)
                                {
                                    matrix[i][right] = -99;
                                }
                            }

                        }
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == -99)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            PrintMatrix(matrix);
        }
        private void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
