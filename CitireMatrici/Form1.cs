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
        CitireFisier citire = new CitireFisier();
        string caleFisierArff;
        Int16[,] dateFisier;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "arff files (*.arff) | *.arff";
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
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
            citire.CitesteFisierArff(out dateFisier, caleFisierArff);
        }
    }
}
