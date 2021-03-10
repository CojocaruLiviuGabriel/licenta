using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    class Normalizare
    {

        public void NormalizareBinara(Int16[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                valori.Add(new List<int>());
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                        valori[i].Add(matrix[i, j]);
                    }
                    else
                    {
                        matrix[i, j] = 0;
                        valori[i].Add(matrix[i, j]);
                    }
                }
            }
        }

        public void NormalizareConrnellSmart(Int16[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] mat = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        mat[i, j] = 1 + Math.Log10(1 + Math.Log10((double)matrix[i, j]));
                    }
                    else
                    {
                        mat[i, j] = 0;
                    }
                }
            }
        }

        public void NormalizareNominala(Int16[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] mat = new double[rows, cols];
            double[,] matNormalizata = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        mat[i, j] = matrix[i,j];
                    }
                    else
                    {
                        mat[i, j] = 0;
                    }
                }
            }

            double maxValue = mat.Cast<double>().Max();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matNormalizata[i, j] = mat[i, j] / maxValue;
                }
            }

        }

        public void NormalizareSuma1(Int16[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] mat = new double[rows, cols];
            double[,] matNormalizata = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        mat[i, j] = matrix[i, j];
                    }
                    else
                    {
                        mat[i, j] = 0;
                    }
                }
            }

            double suma = mat.Cast<double>().Sum();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matNormalizata[i, j] = mat[i, j] / suma;
                }
            }
        }

    }
}
