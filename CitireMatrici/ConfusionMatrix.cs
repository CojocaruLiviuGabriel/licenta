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
        private int TruePositive { get; set; } //clasa predicitonata DA
        private int FalseNegative { get; set; } //clasa predicitonata NU

        //clasa reala - NU
        private int FalsePositive{get;set;} //clasa predicitonata DA
        private int TrueNegative { get; set; } //clasa predicitonata NU

        public ConfusionMatrix(int truePositive, int falseNegative, int falsePositive, int trueNegative)
        {
            TruePositive = truePositive;
            FalseNegative = falseNegative;
            FalsePositive = falsePositive;
            TrueNegative = trueNegative;
        }

        public ConfusionMatrix[] confusionMatrices(List<string> clasaReala, List<string> clasaPredictionata)
        {
            ConfusionMatrix[] matrici = new ConfusionMatrix[clasaReala.Count];

            for(var i = 0; i < matrici.Length; i++)
            {
                for(var j = 0; j < matrici.Length; j++)
                {

                }
            }

            return matrici;
        }
    }
}
