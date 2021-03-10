using System;
using System.Collections.Generic;
using System.IO;

namespace CitireMatrici
{
    class CitireFisier
    {

        public void CitesteFisierArff(out int[,] Matrice, string caleFisier)
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

            while ((linieDinFisier = streamReader.ReadLine()) != null)
            {
                if ((linieDinFisier.StartsWith("@")) || (linieDinFisier.StartsWith("#")) || (linieDinFisier == ""))
                {
                    //Nu fa nimic, nu imi introdu in lista de string
                }
                else
                {
                    int index = linieDinFisier.IndexOf("#");
                    string aux = linieDinFisier.Substring(0, index);
                    s.Add(aux);
                }
            }

            Matrice = CreateMatrix(s, numarLinii, numarColoane);
        }

        public int[,] CreateMatrix(List<string> lines, uint numberOfLines, uint numberOfColumns)
        {
            int[,] matrix = new int[numberOfLines, numberOfColumns];


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

        public List<string> ClaseDinFisier(string caleFisier)
        {
            List<string> temp = new List<string>();
            StreamReader streamReader = new StreamReader(caleFisier);

            string linieDinFisier;

            while ((linieDinFisier = streamReader.ReadLine()) != null)
            {
                if (!linieDinFisier.StartsWith("@") && !linieDinFisier.StartsWith("#") && linieDinFisier.Contains("c"))
                {
                    int index = linieDinFisier.IndexOf("#");
                    string[] aux = linieDinFisier.Substring(index + 1).Split();
                    temp.Add(aux[1]);
                }
            }

            return temp;
        }


    }
}
