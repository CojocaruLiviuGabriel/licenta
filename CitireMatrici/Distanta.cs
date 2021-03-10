using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    class Distanta
    {
        public List<double> DistantaEuclidiana(int[,] matrice1, int[,] matrice2)
        {
            List<List<int>> ElementeTest = new List<List<int>>();
            List<List<int>> ElementeTraining = new List<List<int>>();
            List<double> distante = new List<double>();
            double distanta;

            for (var i = 0; i < matrice1.GetLength(0); i++)
            {
                ElementeTest.Add(new List<int>());
                for (var j = 0; j < matrice1.GetLength(1); j++)
                {
                    ElementeTest[i].Add(matrice1[i, j]);
                }
            }

            for (var i = 0; i < matrice2.GetLength(0); i++)
            {
                ElementeTraining.Add(new List<int>());
                for (var j = 0; j < matrice2.GetLength(1); j++)
                {
                    ElementeTraining[i].Add(matrice2[i, j]);
                }
            }

            for (var k = 0; k < ElementeTest.Count; k++)
            {
                distanta = 0;
                for (var i = 0; i < ElementeTraining.Count; i++)
                {
                    

                    for (var j = 0; j < ElementeTraining[i].Count; j++)
                    {
                        distanta += Math.Pow(ElementeTest[k][j] - ElementeTraining[i][j],2);
                    }

                   

                }
                distanta = Math.Sqrt(distanta);
                distante.Add(distanta);
            }



            return distante;
        }

        public double DistantaManhattan(int[,] matrice1, int[,] matrice2)
        {
            double distanta = 0;

            for (int i = 0; i < matrice1.Length; i++)
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

        public double DistantaMinkowski(int[,] matrice1, int[,] matrice2, int order)
        {

            double distanta = 0;

            for (int i = 0; i < matrice1.Length; i++)
            {
                for (int j = 0; j < matrice1.Length; j++)
                {
                    distanta += Math.Pow(Math.Abs(matrice1[i, j] - matrice2[i, j]), order);
                }
            }


            return Math.Pow(distanta, (double)1 / order);
        }

    }
}
