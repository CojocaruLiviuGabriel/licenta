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
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
        }

    }
}
