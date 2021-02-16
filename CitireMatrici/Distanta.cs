using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    class Distanta
    {
        public double DistantaEuclidiana(double[,] matrice1, double[,] matrice2)
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

        public double DistantaManhattan(double[,] matrice1, double[,] matrice2)
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

        public double DistantaCosinus(double x1, double y1, double x2, double y2)
        {
            // de facut
            return x1;
        }

        public double DistantaMinkowski(double[,] matrice1, double[,] matrice2,int order)
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
