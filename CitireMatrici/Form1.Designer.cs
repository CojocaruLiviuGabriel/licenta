namespace CitireMatrici
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.lrSfBtn = new System.Windows.Forms.Button();
            this.rbDistE = new System.Windows.Forms.RadioButton();
            this.rbDisMan = new System.Windows.Forms.RadioButton();
            this.rbDisMin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lrLfBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalculNormalizare = new System.Windows.Forms.Button();
            this.rbNormSum1 = new System.Windows.Forms.RadioButton();
            this.rbNormNom = new System.Windows.Forms.RadioButton();
            this.rbNormB = new System.Windows.Forms.RadioButton();
            this.rbNormCS = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDistCos = new System.Windows.Forms.RadioButton();
            this.nUdMinkOrder = new System.Windows.Forms.NumericUpDown();
            this.btnCalcDistante = new System.Windows.Forms.Button();
            this.gpKNN = new System.Windows.Forms.GroupBox();
            this.btnKNN = new System.Windows.Forms.Button();
            this.tbK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdMinkOrder)).BeginInit();
            this.gpKNN.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(448, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Iesire";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lrSfBtn
            // 
            this.lrSfBtn.Location = new System.Drawing.Point(6, 19);
            this.lrSfBtn.Name = "lrSfBtn";
            this.lrSfBtn.Size = new System.Drawing.Size(187, 23);
            this.lrSfBtn.TabIndex = 6;
            this.lrSfBtn.Text = "Fisiere mici";
            this.lrSfBtn.UseVisualStyleBackColor = true;
            this.lrSfBtn.Click += new System.EventHandler(this.lrSfBtn_Click);
            // 
            // rbDistE
            // 
            this.rbDistE.AutoSize = true;
            this.rbDistE.Location = new System.Drawing.Point(6, 19);
            this.rbDistE.Name = "rbDistE";
            this.rbDistE.Size = new System.Drawing.Size(116, 17);
            this.rbDistE.TabIndex = 7;
            this.rbDistE.TabStop = true;
            this.rbDistE.Text = "Distanta Euclidiana";
            this.rbDistE.UseVisualStyleBackColor = true;
            // 
            // rbDisMan
            // 
            this.rbDisMan.AutoSize = true;
            this.rbDisMan.Location = new System.Drawing.Point(6, 42);
            this.rbDisMan.Name = "rbDisMan";
            this.rbDisMan.Size = new System.Drawing.Size(118, 17);
            this.rbDisMan.TabIndex = 8;
            this.rbDisMan.TabStop = true;
            this.rbDisMan.Text = "Distanta Manhattan";
            this.rbDisMan.UseVisualStyleBackColor = true;
            // 
            // rbDisMin
            // 
            this.rbDisMin.AutoSize = true;
            this.rbDisMin.Location = new System.Drawing.Point(6, 92);
            this.rbDisMin.Name = "rbDisMin";
            this.rbDisMin.Size = new System.Drawing.Size(117, 17);
            this.rbDisMin.TabIndex = 9;
            this.rbDisMin.TabStop = true;
            this.rbDisMin.Text = "Distanta Minkowski";
            this.rbDisMin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lrLfBtn);
            this.groupBox1.Controls.Add(this.lrSfBtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load Files";
            // 
            // lrLfBtn
            // 
            this.lrLfBtn.Location = new System.Drawing.Point(6, 48);
            this.lrLfBtn.Name = "lrLfBtn";
            this.lrLfBtn.Size = new System.Drawing.Size(187, 23);
            this.lrLfBtn.TabIndex = 7;
            this.lrLfBtn.Text = "Fisiere mari";
            this.lrLfBtn.UseVisualStyleBackColor = true;
            this.lrLfBtn.Click += new System.EventHandler(this.lrLfBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalculNormalizare);
            this.groupBox2.Controls.Add(this.rbNormSum1);
            this.groupBox2.Controls.Add(this.rbNormNom);
            this.groupBox2.Controls.Add(this.rbNormB);
            this.groupBox2.Controls.Add(this.rbNormCS);
            this.groupBox2.Location = new System.Drawing.Point(13, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 153);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Normalizari";
            // 
            // btnCalculNormalizare
            // 
            this.btnCalculNormalizare.Location = new System.Drawing.Point(6, 111);
            this.btnCalculNormalizare.Name = "btnCalculNormalizare";
            this.btnCalculNormalizare.Size = new System.Drawing.Size(116, 23);
            this.btnCalculNormalizare.TabIndex = 16;
            this.btnCalculNormalizare.Text = "Aplicare Normalizare";
            this.btnCalculNormalizare.UseVisualStyleBackColor = true;
            this.btnCalculNormalizare.Click += new System.EventHandler(this.btnCalculNormalizare_Click);
            // 
            // rbNormSum1
            // 
            this.rbNormSum1.AutoSize = true;
            this.rbNormSum1.Location = new System.Drawing.Point(6, 88);
            this.rbNormSum1.Name = "rbNormSum1";
            this.rbNormSum1.Size = new System.Drawing.Size(116, 17);
            this.rbNormSum1.TabIndex = 15;
            this.rbNormSum1.TabStop = true;
            this.rbNormSum1.Text = "Normalizare Suma1";
            this.rbNormSum1.UseVisualStyleBackColor = true;
            // 
            // rbNormNom
            // 
            this.rbNormNom.AutoSize = true;
            this.rbNormNom.Location = new System.Drawing.Point(6, 65);
            this.rbNormNom.Name = "rbNormNom";
            this.rbNormNom.Size = new System.Drawing.Size(127, 17);
            this.rbNormNom.TabIndex = 14;
            this.rbNormNom.TabStop = true;
            this.rbNormNom.Text = "Normalizare Nominala";
            this.rbNormNom.UseVisualStyleBackColor = true;
            // 
            // rbNormB
            // 
            this.rbNormB.AutoSize = true;
            this.rbNormB.Location = new System.Drawing.Point(6, 19);
            this.rbNormB.Name = "rbNormB";
            this.rbNormB.Size = new System.Drawing.Size(113, 17);
            this.rbNormB.TabIndex = 12;
            this.rbNormB.TabStop = true;
            this.rbNormB.Text = "Normalizare Binara";
            this.rbNormB.UseVisualStyleBackColor = true;
            // 
            // rbNormCS
            // 
            this.rbNormCS.AutoSize = true;
            this.rbNormCS.Location = new System.Drawing.Point(6, 42);
            this.rbNormCS.Name = "rbNormCS";
            this.rbNormCS.Size = new System.Drawing.Size(154, 17);
            this.rbNormCS.TabIndex = 13;
            this.rbNormCS.TabStop = true;
            this.rbNormCS.Text = "Normalizare Logaritm Dublu";
            this.rbNormCS.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDistCos);
            this.groupBox3.Controls.Add(this.nUdMinkOrder);
            this.groupBox3.Controls.Add(this.btnCalcDistante);
            this.groupBox3.Controls.Add(this.rbDistE);
            this.groupBox3.Controls.Add(this.rbDisMan);
            this.groupBox3.Controls.Add(this.rbDisMin);
            this.groupBox3.Location = new System.Drawing.Point(13, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 162);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distante";
            // 
            // rbDistCos
            // 
            this.rbDistCos.AutoSize = true;
            this.rbDistCos.Location = new System.Drawing.Point(6, 66);
            this.rbDistCos.Name = "rbDistCos";
            this.rbDistCos.Size = new System.Drawing.Size(104, 17);
            this.rbDistCos.TabIndex = 12;
            this.rbDistCos.TabStop = true;
            this.rbDistCos.Text = "Distanta Cosinus";
            this.rbDistCos.UseVisualStyleBackColor = true;
            // 
            // nUdMinkOrder
            // 
            this.nUdMinkOrder.Location = new System.Drawing.Point(130, 89);
            this.nUdMinkOrder.Name = "nUdMinkOrder";
            this.nUdMinkOrder.Size = new System.Drawing.Size(63, 20);
            this.nUdMinkOrder.TabIndex = 11;
            // 
            // btnCalcDistante
            // 
            this.btnCalcDistante.Location = new System.Drawing.Point(6, 115);
            this.btnCalcDistante.Name = "btnCalcDistante";
            this.btnCalcDistante.Size = new System.Drawing.Size(113, 23);
            this.btnCalcDistante.TabIndex = 10;
            this.btnCalcDistante.Text = "Calcul Distante";
            this.btnCalcDistante.UseVisualStyleBackColor = true;
            this.btnCalcDistante.Click += new System.EventHandler(this.btnCalcDistante_Click);
            // 
            // gpKNN
            // 
            this.gpKNN.Controls.Add(this.btnKNN);
            this.gpKNN.Controls.Add(this.tbK);
            this.gpKNN.Controls.Add(this.label1);
            this.gpKNN.Location = new System.Drawing.Point(19, 468);
            this.gpKNN.Name = "gpKNN";
            this.gpKNN.Size = new System.Drawing.Size(200, 100);
            this.gpKNN.TabIndex = 14;
            this.gpKNN.TabStop = false;
            this.gpKNN.Text = "KNN";
            // 
            // btnKNN
            // 
            this.btnKNN.Location = new System.Drawing.Point(7, 62);
            this.btnKNN.Name = "btnKNN";
            this.btnKNN.Size = new System.Drawing.Size(75, 23);
            this.btnKNN.TabIndex = 2;
            this.btnKNN.Text = "KNN";
            this.btnKNN.UseVisualStyleBackColor = true;
            this.btnKNN.Click += new System.EventHandler(this.btnKNN_Click);
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(27, 20);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(66, 20);
            this.tbK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "k";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 605);
            this.Controls.Add(this.gpKNN);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdMinkOrder)).EndInit();
            this.gpKNN.ResumeLayout(false);
            this.gpKNN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button lrSfBtn;
        private System.Windows.Forms.RadioButton rbDistE;
        private System.Windows.Forms.RadioButton rbDisMan;
        private System.Windows.Forms.RadioButton rbDisMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button lrLfBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNormSum1;
        private System.Windows.Forms.RadioButton rbNormNom;
        private System.Windows.Forms.RadioButton rbNormB;
        private System.Windows.Forms.RadioButton rbNormCS;
        private System.Windows.Forms.Button btnCalculNormalizare;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalcDistante;
        private System.Windows.Forms.NumericUpDown nUdMinkOrder;
        private System.Windows.Forms.GroupBox gpKNN;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKNN;
        private System.Windows.Forms.RadioButton rbDistCos;
    }
}

