using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    class Distanta
    {
        public double DistantaEuclidiana(int[,] matrice1, int[,] matrice2)
        {

            double distanta = 0;

            for (int i = 0; i < matrice1.Length; i++)
            {
                for (int j = 0; j < matrice1.Length; j++)
                {
                    distanta += Math.Pow(matrice1[i, j] - matrice2[i, j],2);
                }
            }

            distanta = Math.Sqrt(distanta);
            return distanta;
        }

        public double DistantaManhattan(int[,] matrice1, int[,] matrice2)
        {
            double distanta = 0;

            for(int i = 0; i < matrice1.Length; i++)
            {
                for (int j = 0; j < matrice1.Length; j++)
                {
                    distanta += Math.Abs(matrice1[i, j] - matrice2[i, j]);
                }
            }

            return distanta;
        }

        public double DistantaCosinus(int x1, int y1, int x2, int y2)
        {
            // de facut
            return x1;
        }

        public double DistantaMinkowski(int[,] matrice1, int[,] matrice2,int order)
        {

            double distanta = 0;

            for (int i = 0; i < matrice1.Length; i++)
            {
                for (int j = 0; j < matrice1.Length; j++)
                {
                    distanta += Math.Pow(Math.Abs(matrice1[i, j] - matrice2[i, j]),order);
                }
            }


            return Math.Pow(distanta, (double)1 / order);
        }

    }
}
