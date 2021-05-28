using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    public class MetriciExterne
    {
        double accuracy;
        double precision;
        double recall;
        double trueNegativeRate;
        List<List<double>> metriciPerClasa;

        public MetriciExterne()
        {
            this.accuracy = 0;
            this.precision = 0;
            this.recall = 0;
            this.trueNegativeRate = 0;
        }

        public List<List<double>> CalculMetrici(ConfusionMatrix[] matriciDeEroare)
        {
            metriciPerClasa = new List<List<double>>();

            for (int i = 0; i < matriciDeEroare.Length; i++)
            {
                metriciPerClasa.Add(new List<double>());

                metriciPerClasa[i].Add(Convert.ToDouble((matriciDeEroare[i].TP + matriciDeEroare[i].TN) / (matriciDeEroare[i].TP + matriciDeEroare[i].FN + matriciDeEroare[i].FP + matriciDeEroare[i].TN)));
                metriciPerClasa[i].Add(Convert.ToDouble(matriciDeEroare[i].TP / (matriciDeEroare[i].TP + matriciDeEroare[i].FP)));
                metriciPerClasa[i].Add(Convert.ToDouble(matriciDeEroare[i].TP / (matriciDeEroare[i].TP + matriciDeEroare[i].FN)));
                metriciPerClasa[i].Add(Convert.ToDouble(matriciDeEroare[i].TN / (matriciDeEroare[i].TN + matriciDeEroare[i].FN)));
                
                double auxAcc = (matriciDeEroare[i].TP + matriciDeEroare[i].TN) / (matriciDeEroare[i].TP + matriciDeEroare[i].FN + matriciDeEroare[i].FP + matriciDeEroare[i].TN);
                double auxPr = matriciDeEroare[i].TP / (matriciDeEroare[i].TP + matriciDeEroare[i].FP);
                double auxRe = matriciDeEroare[i].TP / (matriciDeEroare[i].TP + matriciDeEroare[i].FN);
                double auxTrn = matriciDeEroare[i].TN / (matriciDeEroare[i].TN + matriciDeEroare[i].FN);

                accuracy += auxAcc;
                precision += auxPr;
                recall += auxRe;
                trueNegativeRate += auxTrn;
            }

            accuracy = accuracy / matriciDeEroare.Length;
            precision = precision / matriciDeEroare.Length;
            recall = recall / matriciDeEroare.Length;
            trueNegativeRate = trueNegativeRate / matriciDeEroare.Length;

            return metriciPerClasa;
        }
    }
}
