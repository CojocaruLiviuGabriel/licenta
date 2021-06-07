using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    public class ConfusionMatrix
    {
        //clasa reala - DA
        private double TruePositive; //clasa predicitonata DA
        private double FalseNegative; //clasa predicitonata NU

        //clasa reala - NU
        private double FalsePositive; //clasa predicitonata DA
        private double TrueNegative; //clasa predicitonata NU

        public double TP { get => TruePositive; set => TruePositive = value; }
        public double FN { get => FalseNegative; set => FalseNegative = value; }
        public double FP { get => FalsePositive; set => FalsePositive = value; }
        public double TN { get => TrueNegative; set => TrueNegative = value; }

        public ConfusionMatrix(double truePositive, double falseNegative, double falsePositive, double trueNegative)
        {
            TruePositive = truePositive;
            FalseNegative = falseNegative;
            FalsePositive = falsePositive;
            TrueNegative = trueNegative;
        }

        public ConfusionMatrix() { }
        public ConfusionMatrix[] confusionMatrices(List<string> clasaReala,
                                                          List<List<Tuple<string, double>>> distantaSortataCuClasa)

        {
            //array cu matrici de eroare
            ConfusionMatrix[] matriciDeEroare = new ConfusionMatrix[Form1.claseUniceTraining.Count];

            //Initializare matrici de eroare pentru clase
            for (int i = 0; i < Form1.claseUniceTraining.Count; i++)
            {
                matriciDeEroare[i] = new ConfusionMatrix(0, 0, 0, 0);
            }


            for (int i = 0; i < distantaSortataCuClasa.Count; i++)
            {
                for (int j = 0; j < Form1.claseUniceTraining.Count; j++)
                {

                    if (Form1.claseUniceTraining[j].Equals(clasaReala[i]))
                    {
                        if (clasaReala[i].Equals(distantaSortataCuClasa[i][0].Item1))
                        {
                            matriciDeEroare[j].TP++;
                        }
                        else
                        {
                            matriciDeEroare[j].FN++;
                        }
                    }
                    else
                    {
                        if (Form1.claseUniceTraining[j].Equals(distantaSortataCuClasa[i][0].Item1))
                        {
                            matriciDeEroare[j].FP++;
                        }
                        else
                        {
                            matriciDeEroare[j].TN++;
                        }
                    }


                }
            }

            return matriciDeEroare;
        }

        public bool checkIfAllElementsAreEqual(int[] freqArr)
        {
            int first = freqArr[0];

            for (int i = 1; i < freqArr.Length; i++)
            {
                if (freqArr[i] != first)
                {
                    return false;
                }
            }

            return true;
        }

    }
}


/*bool prediction = clasaPredictionata[tuples[i][0].Item1] == clasaReala[i];

if (clasaPredictionata[tuples[i][0].Item1] == clasaReala[i])
{
    if(prediction == true)
    {
        matrici[i].TruePositive++;
    }
    else
    {
        matrici[i].TrueNegative++;
    }
}
else
{
    if(prediction == true)
    {
        matrici[i].FalsePositive++;
    }
    else
    {
        matrici[i].FalseNegative++;
    }
}*/
