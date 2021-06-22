using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitireMatrici
{
    public partial class Form1 : Form
    {
        public static int k;
        CitireFisier citire = new CitireFisier();
        Normalizare normalizare = new Normalizare();
        Distanta distanta = new Distanta();
        KNN kNN = new KNN();
        MetriciExterne externe = new MetriciExterne();
        List<List<double>> metrici = new List<List<double>>();
        ConfusionMatrix cn = new ConfusionMatrix();
        Salvare s = new Salvare();
        string caleFisierArff;
        public static List<string> claseTest, claseTraining, claseUniceTest, claseUniceTraining;
        double[,] dateFisierTest;
        double[,] dateFisierTraining;
        List<List<double>> distante;
        List<List<Tuple<string, double>>> distanteSortateCuIndex = new List<List<Tuple<string, double>>>();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "arff files (*.arff) | *.arff";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caleFisierArff = openFileDialog.FileName;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            citire.CitesteFisierArff(out dateFisierTraining, caleFisierArff);
            claseTraining = citire.ClaseDinFisier(caleFisierArff);
        }

        private void btnReadFileTest_Click(object sender, EventArgs e)
        {
            citire.CitesteFisierArff(out dateFisierTest, caleFisierArff);
            claseTest = citire.ClaseDinFisier(caleFisierArff);
        }

        private void lrLfBtn_Click(object sender, EventArgs e)
        {
            citire.CitesteFisierArff(out dateFisierTest, "../../InputDataArff/MultiClass_Testing_SVM_1309.0.arff");
            citire.CitesteFisierArff(out dateFisierTraining, "../../InputDataArff/MultiClass_Training_SVM_1309.0.arff");
            claseTest = citire.ClaseDinFisier("../../InputDataArff/MultiClass_Testing_SVM_1309.0.arff");
            claseTraining = citire.ClaseDinFisier("../../InputDataArff/MultiClass_Training_SVM_1309.0.arff");
            claseUniceTest = citire.ClaseDinFisierTopiceUnice("../../InputDataArff/MultiClass_Testing_SVM_100.0.arff");
            claseUniceTraining = citire.ClaseDinFisierTopiceUnice("../../InputDataArff/MultiClass_Training_SVM_100.0.arff");
        }

        private void lrSfBtn_Click(object sender, EventArgs e)
        {
            citire.CitesteFisierArff(out dateFisierTest, "../../InputDataArff/MultiClass_Testing_SVM_100.0.arff");
            citire.CitesteFisierArff(out dateFisierTraining, "../../InputDataArff/MultiClass_Training_SVM_100.0.arff");
            claseTest = citire.ClaseDinFisier("../../InputDataArff/MultiClass_Testing_SVM_100.0.arff");
            claseTraining = citire.ClaseDinFisier("../../InputDataArff/MultiClass_Training_SVM_100.0.arff");
            claseUniceTest = citire.ClaseDinFisierTopiceUnice("../../InputDataArff/MultiClass_Testing_SVM_100.0.arff");
            claseUniceTraining = citire.ClaseDinFisierTopiceUnice("../../InputDataArff/MultiClass_Training_SVM_100.0.arff");
        }

        private void btnCalculNormalizare_Click(object sender, EventArgs e)
        {
            if (dateFisierTest == null && dateFisierTraining == null)
            {
                MessageBox.Show("Mai intai trebuie citite datele!");
            }
            else
            {


                if (rbNormB.Checked)
                {
                    normalizare.NormalizareBinara(dateFisierTest);
                    normalizare.NormalizareBinara(dateFisierTraining);
                }
                if (rbNormCS.Checked)
                {
                    normalizare.NormalizareCornellSmart(dateFisierTest);
                    normalizare.NormalizareCornellSmart(dateFisierTraining);
                }
                if (rbNormNom.Checked)
                {
                    normalizare.NormalizareNominala(dateFisierTest);
                    normalizare.NormalizareNominala(dateFisierTraining);
                }
                if (rbNormSum1.Checked)
                {
                    normalizare.NormalizareSuma1(dateFisierTest);
                    normalizare.NormalizareSuma1(dateFisierTraining);
                }
            }
        }

        private void btnCalcDistante_Click(object sender, EventArgs e)
        {
            if (rbDistE.Checked)
            {
                distante = distanta.DistantaMinkowski(ref dateFisierTest, ref dateFisierTraining, 2);
            }
            if (rbDisMan.Checked)
            {
                distante = distanta.DistantaMinkowski(ref dateFisierTest, ref dateFisierTraining, 1);
            }
            if (rbDisMin.Checked)
            {
                distante = distanta.DistantaMinkowski(ref dateFisierTest, ref dateFisierTraining, Convert.ToInt32(nUdMinkOrder.Value));
            }
            if (rbDistCos.Checked)
            {
                distante = distanta.DistantaCosinus(ref dateFisierTest, ref dateFisierTraining);
            }
        }

        private void btnKNN_Click(object sender, EventArgs e)
        {
            k = Convert.ToInt32(tbK.Text);
            distanteSortateCuIndex = kNN.sorteazaDistanaDupaIndex(ref distante,k);
            cn.freqClase(distanteSortateCuIndex);
           // cn.confusionMatrices(claseTest,distanteSortateCuIndex);
            metrici = externe.CalculMetrici(cn.confusionMatrices(claseTest, distanteSortateCuIndex));
            s.WriteOutputData(metrici);
        }

        
    }
}
