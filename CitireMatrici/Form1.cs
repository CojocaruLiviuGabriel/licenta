﻿using System;
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
        CitireFisier citire = new CitireFisier();
        Normalizare normalizare = new Normalizare();
        Distanta distanta = new Distanta();
        string caleFisierArff;
        List<string> claseTest, claseTraining;
        int[,] dateFisierTest;
        int[,] dateFisierTraining;


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

        private void btnStart_Click(object sender, EventArgs e)
        {




        }

        private void lrLfBtn_Click(object sender, EventArgs e)
        {
            citire.CitesteFisierArff(out dateFisierTest, "../../InputDataArff/MultiClass_Testing_SVM_1309.0.arff");
            citire.CitesteFisierArff(out dateFisierTraining, "../../InputDataArff/MultiClass_Training_SVM_1309.0.arff");
            claseTest = citire.ClaseDinFisier("../../InputDataArff/MultiClass_Testing_SVM_1309.0.arff");
            claseTraining = citire.ClaseDinFisier("../../InputDataArff/MultiClass_Training_SVM_1309.0.arff");
        }

        private void btnCalculNormalizare_Click(object sender, EventArgs e)
        {
            if (rbNormB.Checked)
            {
                normalizare.NormalizareBinara(dateFisierTest);
                normalizare.NormalizareBinara(dateFisierTraining);
            }
            if (rbNormCS.Checked)
            {
                normalizare.NormalizareConrnellSmart(dateFisierTest);
                normalizare.NormalizareConrnellSmart(dateFisierTraining);
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

        private void btnCalcDistante_Click(object sender, EventArgs e)
        {
            List<List<double>> temp;


            if (rbDistE.Checked)
            {
                temp = distanta.DistantaEuclidiana(ref dateFisierTest, ref dateFisierTraining);

            }
            if (rbDisMan.Checked)
            {
                temp = distanta.DistantaManhattan(ref dateFisierTest, ref dateFisierTraining);
            }
            if (rbDisMin.Checked)
            {
                temp = distanta.DistantaMinkowski(ref dateFisierTest, ref dateFisierTraining, Convert.ToInt32(nUdMinkOrder.Value));
            }

        }

        private void lrSfBtn_Click(object sender, EventArgs e)
        {
            citire.CitesteFisierArff(out dateFisierTest, "../../InputDataArff/MultiClass_Testing_SVM_100.0.arff");
            citire.CitesteFisierArff(out dateFisierTraining, "../../InputDataArff/MultiClass_Training_SVM_100.0.arff");
            claseTest = citire.ClaseDinFisier("../../InputDataArff/MultiClass_Testing_SVM_100.0.arff");
            claseTraining = citire.ClaseDinFisier("../../InputDataArff/MultiClass_Training_SVM_100.0.arff");
        }


    }
}
