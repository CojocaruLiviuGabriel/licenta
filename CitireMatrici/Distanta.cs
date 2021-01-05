using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    class Distanta
    {
        public double DistantaEuclidiana(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        }

        public double DistantaManhattan(double x1, double y1, double x2, double y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }

        public double DistantaCosinus(double x1, double y1, double x2, double y2)
        {
            // de facut
            return x1;
        }

        public double MinkowskiDistance(int order, Int16[] firstPoint, Int16[] secondPoint)
        {
            double sum = 0;
            int dimension = firstPoint.Length;
            for (var i = 0; i < dimension; i++)
            {

                sum += Math.Pow(Math.Abs(firstPoint[i] - secondPoint[i]), order); ;
            }

            return Math.Pow(sum, (double)1 / order);
        }

    }
}
