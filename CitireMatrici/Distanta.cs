using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    class Distanta
    {
        

        public List<List<double>> DistantaEuclidiana(ref int[,] mTest, ref int[,] mTraining)
        {

            double dist;
            List<List<double>> distante = new List<List<double>>();
            List<double> temp;
            
            dist = 0;


            for (int i = 0; i < mTest.GetLength(0); i++)
            {
                temp = new List<double>();
                for (int j = 0; j < mTraining.GetLength(0); j++)
                {
                    dist = 0;
                    for (int k = 0; k < mTest.GetLength(1); k++)
                    {
                        dist += Math.Pow(mTest[i,k] - mTraining[j,k], 2);

                    }
                    dist = Math.Sqrt(dist);
                    temp.Add(dist);


                }
                distante.Add(temp);
            }



            return distante;
        }

        public List<List<double>> DistantaManhattan(ref int[,] mTest, ref int[,] mTraining)
        {
            double dist;
            List<List<double>> distante = new List<List<double>>();
            List<double> temp;

            dist = 0;


            for (int i = 0; i < mTest.GetLength(0); i++)
            {
                temp = new List<double>();
                for (int j = 0; j < mTraining.GetLength(0); j++)
                {
                    dist = 0;
                    for (int k = 0; k < mTest.GetLength(1); k++)
                    {
                        dist += Math.Abs(mTest[i, k] - mTraining[j, k]);

                    }
                    temp.Add(dist);


                }
                distante.Add(temp);
            }



            return distante;
        }

        public double DistantaCosinus(int x1, int y1, int x2, int y2)
        {
            // de facut
            return x1;
        }

        public List<List<double>> DistantaMinkowski(ref int[,] mTest, ref int[,] mTraining, int order)
        {
            double dist;
            List<List<double>> distante = new List<List<double>>();
            List<double> temp;

            dist = 0;


            for (int i = 0; i < mTest.GetLength(0); i++)
            {
                temp = new List<double>();
                for (int j = 0; j < mTraining.GetLength(0); j++)
                {
                    dist = 0;
                    for (int k = 0; k < mTest.GetLength(1); k++)
                    {
                        dist += Math.Pow(Math.Abs(mTest[i, k] - mTraining[j, k]), order);

                    }
                    dist = Math.Pow(dist, 1.0 / order);
                    temp.Add(dist);


                }
                distante.Add(temp);
            }



            return distante;
        }

    }
}
