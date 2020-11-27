using System;
using System.Collections.Generic;
using System.IO;

namespace CitireMatrici
{
    class CitireFisier
    {   

        public void CitesteFisierArff(out Int16[,] Matrice, string caleFisier)
        {
            List<string> s = new List<string>();
            uint numarLinii = 0;
            uint numarColoane = 0;

            StreamReader streamReader = new StreamReader(caleFisier);

            string[] linii = streamReader.ReadLine().Split(' ');
            numarLinii = Convert.ToUInt32(linii[1]);
            
            string[] coloane = streamReader.ReadLine().Split(' ');
            numarColoane = Convert.ToUInt32(coloane[1]);

            string linieDinFisier;

            while( (linieDinFisier = streamReader.ReadLine() ) != null)
            {
                if (linieDinFisier.StartsWith("0"))
                {
                    int index = linieDinFisier.IndexOf("#");
                    string aux = linieDinFisier.Substring(0, index);
                    s.Add(aux);
                }
            }

            Matrice = CreateMatrix(s, numarLinii, numarColoane);
        }

        public Int16[,] CreateMatrix(List<string> lines, uint numberOfLines, uint numberOfColumns)
        {
            Int16[,] matrix = new Int16[numberOfLines, numberOfColumns];


            for (var indexLine = 0; indexLine < lines.Count; indexLine++)
            {
                string[] lineSplit = lines[indexLine].Split(' ');

                for (var indexLineSplit = 0; indexLineSplit < lineSplit.Length - 1; indexLineSplit++)
                {
                    string[] valueSplit = lineSplit[indexLineSplit].Split(':');
                    int key = Convert.ToInt32(valueSplit[0]);
                    Int16 value = Convert.ToInt16(valueSplit[1]);

                    matrix[indexLine, key] = value;
                }
            }

            return matrix;
        }

        
    }
}
