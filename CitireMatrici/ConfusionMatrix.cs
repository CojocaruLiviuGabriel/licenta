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
        private int TruePositive; //clasa predicitonata DA
        private int FalseNegative; //clasa predicitonata NU

        //clasa reala - NU
        private int FalsePositive; //clasa predicitonata DA
        private int TrueNegative; //clasa predicitonata NU

        public int TP { get => TruePositive; set => TruePositive = value; }
        public int FN { get => FalseNegative; set => FalseNegative = value; }
        public int FP { get => FalsePositive; set => FalsePositive = value; }
        public int TN { get => TrueNegative; set => TrueNegative = value; }

        public ConfusionMatrix(int truePositive, int falseNegative, int falsePositive, int trueNegative)
        {
            TruePositive = truePositive;
            FalseNegative = falseNegative;
            FalsePositive = falsePositive;
            TrueNegative = trueNegative;
        }

        public static ConfusionMatrix[] confusionMatrices(List<string> clasaReala, 
                                                   List<string> clasaPredictionata, 
                                                   List<List<Tuple<int,double>>> tuples)
        {
            ConfusionMatrix[] matrici = new ConfusionMatrix[clasaReala.Count];

            for(var i = 0; i < clasaReala.Count; i++)
            {
                matrici[i] = new ConfusionMatrix(0, 0, 0, 0);
            }

            for(var i = 0; i < tuples.Count; i++)
            {
                for (var j = 0; j < tuples.Count; j++)
                {
                    bool prediction = clasaPredictionata[tuples[i][0].Item1] == clasaReala[i];

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
                    }
                    
                }
            }

            return matrici;
        }


        public void test(List<List<Tuple<int, double>>> tuples)
        {
            for(var i = 0; i < tuples.Count; i++)
            {
               for(var j = 0; j < tuples[i].Count; j++)
                {
                    var x = tuples[i][j].Item1;
                }
            }
        }
    }
}
