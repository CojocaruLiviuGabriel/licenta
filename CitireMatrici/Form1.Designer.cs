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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReadFileTraining = new System.Windows.Forms.Button();
            this.btnReadFileTest = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 32);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReadFileTraining
            // 
            this.btnReadFileTraining.Location = new System.Drawing.Point(12, 61);
            this.btnReadFileTraining.Name = "btnReadFileTraining";
            this.btnReadFileTraining.Size = new System.Drawing.Size(112, 23);
            this.btnReadFileTraining.TabIndex = 2;
            this.btnReadFileTraining.Text = "ReadFileTraining";
            this.btnReadFileTraining.UseVisualStyleBackColor = true;
            this.btnReadFileTraining.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnReadFileTest
            // 
            this.btnReadFileTest.Location = new System.Drawing.Point(12, 90);
            this.btnReadFileTest.Name = "btnReadFileTest";
            this.btnReadFileTest.Size = new System.Drawing.Size(112, 23);
            this.btnReadFileTest.TabIndex = 3;
            this.btnReadFileTest.Text = "ReadFile Test";
            this.btnReadFileTest.UseVisualStyleBackColor = true;
            this.btnReadFileTest.Click += new System.EventHandler(this.btnReadFileTest_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReadFileTest);
            this.Controls.Add(this.btnReadFileTraining);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReadFileTraining;
        private System.Windows.Forms.Button btnReadFileTest;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
    }
}

