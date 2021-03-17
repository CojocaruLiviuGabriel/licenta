using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    class Distanta
    {
        public List<List<double>> DistantaEuclidiana(int[,] matrice1, int[,] matrice2)
        {
            List<List<int>> ElementeTest = new List<List<int>>();
            List<List<int>> ElementeTraining = new List<List<int>>();
            List<List<double>> distante = new List<List<double>>();
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
                distante.Add(new List<double>());
                distanta = 0;
                for (var i = 0; i < ElementeTraining.Count; i++)
                {

                    for (var j = 0; j < ElementeTraining[i].Count; j++)
                    {
                        
                        distanta += Math.Pow(ElementeTest[k][j] - ElementeTraining[i][j], 2);
                        distanta = Math.Sqrt(distanta);
                        
                    }
                    distante[k].Add(distanta);
                }
            }



            return distante;
        }

        public List<List<double>> DistantaManhattan(int[,] matrice1, int[,] matrice2)
        {
            List<List<int>> ElementeTest = new List<List<int>>();
            List<List<int>> ElementeTraining = new List<List<int>>();
            List<List<double>> distante = new List<List<double>>();
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
                distante.Add(new List<double>());
                distanta = 0;
                for (var i = 0; i < ElementeTraining.Count; i++)
                {

                    for (var j = 0; j < ElementeTraining[i].Count; j++)
                    {
                        distanta += Math.Abs(ElementeTest[k][j] - ElementeTraining[i][j]);
                    }
                    distante[k].Add(distanta);
                }
               
            }

            return distante;
        }

        public double DistantaCosinus(int x1, int y1, int x2, int y2)
        {
            // de facut
            return x1;
        }

        public List<List<double>> DistantaMinkowski(int[,] matrice1, int[,] matrice2, int order)
        {
            List<List<int>> ElementeTest = new List<List<int>>();
            List<List<int>> ElementeTraining = new List<List<int>>();
            List<List<double>> distante = new List<List<double>>();
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
                distante.Add(new List<double>());
                distanta = 0;
                for (var i = 0; i < ElementeTraining.Count; i++)
                {

                    for (var j = 0; j < ElementeTraining[i].Count; j++)
                    {
                        distanta += Math.Pow(Math.Abs(ElementeTest[k][j] - ElementeTraining[i][j]), order);
                        distanta = Math.Pow(distanta, (double)1.0 / order);
                    }
                    distante[k].Add(distanta);
                }
                
                
            }

            return distante;
        }

    }
}
