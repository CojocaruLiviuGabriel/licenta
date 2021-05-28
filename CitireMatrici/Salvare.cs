using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    public class Salvare
    {
        private FileInfo file;

        public void test()
        {
            var pack = new ExcelPackage(file);
            var ws = pack.Workbook.Worksheets.Add("text");

            ws.Cells["A1"].Value = "";
            ExcelChart chart = ws.Drawings.AddChart("ch", eChartType.ColumnClustered);            
        }
    }
}
