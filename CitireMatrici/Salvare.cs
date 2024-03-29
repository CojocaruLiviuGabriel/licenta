﻿using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitireMatrici
{
    public class Salvare
    {
        
        StringBuilder csv = new StringBuilder();
        string[] headerTabel = { "Clasa", "accuracy", "precision", "recall", "true negative rate" };
        public void WriteOutputData(List<List<double>> metrici)
        {
            NumeFisier obj = new NumeFisier();
            obj.ShowDialog();
            string filePath = "../../OutputReports/" + obj.textBox1.Text + ".csv";
            int i = 0;
            for (i = 0; i < 1; i++)
            {
                var line  = string.Format("{0},{1},{2},{3},{4}",headerTabel[i], 
                                                                headerTabel[i+1], 
                                                                headerTabel[i+2],
                                                                headerTabel[i+3],
                                                                headerTabel[i+4]);
                csv.AppendLine(line);
            }


            i = 0;
            for (i = 0; i < Form1.claseUniceTraining.Count; i++)
            {
                var newLine = string.Format("{0},{1},{2},{3},{4}", Form1.claseUniceTraining[i],
                                                                   metrici[i][0].ToString(),
                                                                   metrici[i][1].ToString(),
                                                                   metrici[i][2].ToString(),
                                                                   metrici[i][3].ToString());
                csv.AppendLine(newLine);
            }


            
            var Line = string.Format("{0},{1},{2},{3},{4}", "Medie",
                                                            metrici[i][0].ToString(),
                                                            metrici[i][1].ToString(),
                                                            metrici[i][2].ToString(),
                                                            metrici[i][3].ToString());
            csv.AppendLine(Line);
            File.WriteAllText(filePath, csv.ToString());
        }



    }
}
