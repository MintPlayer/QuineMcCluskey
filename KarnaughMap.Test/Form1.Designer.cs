﻿namespace KarnaughMap.Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.karnaughMap1 = new KarnaughMap();
            this.btnRandomFill = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lstLoopOnes = new System.Windows.Forms.ListBox();
            this.lstLoopZeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // karnaughMap1
            // 
            this.karnaughMap1.Location = new System.Drawing.Point(250, 51);
            this.karnaughMap1.Name = "karnaughMap1";
            this.karnaughMap1.OutputVariable = "X";
            this.karnaughMap1.TabIndex = 0;
            this.karnaughMap1.InputVariables.Add("A");
            this.karnaughMap1.InputVariables.Add("B");
            this.karnaughMap1.InputVariables.Add("C");
            this.karnaughMap1.KarnaughMapSolved += KarnaughMap1_KarnaughMapSolved;
            // 
            // btnRandomFill
            // 
            this.btnRandomFill.Click += BtnRandomFill_Click;
            this.btnRandomFill.Location = new System.Drawing.Point(13, 13);
            this.btnRandomFill.Name = "btnRandomFill";
            this.btnRandomFill.Size = new System.Drawing.Size(150, 25);
            this.btnRandomFill.TabIndex = 1;
            this.btnRandomFill.Text = "Random fill";
            this.btnRandomFill.UseVisualStyleBackColor = true;
            // 
            // btnSolve
            // 
            this.btnSolve.Click += BtnSolve_Click; ;
            this.btnSolve.Location = new System.Drawing.Point(183, 13);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(150, 25);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            //
            // lstLoopOnes
            //
            this.lstLoopOnes.Location = new System.Drawing.Point(20, 50);
            this.lstLoopOnes.Name = "lstLoopOnes";
            this.lstLoopOnes.Size = new System.Drawing.Size(200, 300);
            this.lstLoopOnes.TabIndex = 3;
            //
            // lstLoopZeros
            //
            this.lstLoopZeros.Location = new System.Drawing.Point(20, 365);
            this.lstLoopZeros.Name = "lstLoopOnes";
            this.lstLoopZeros.Size = new System.Drawing.Size(200, 300);
            this.lstLoopZeros.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandomFill);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.karnaughMap1);
            this.Controls.Add(this.lstLoopOnes);
            this.Controls.Add(this.lstLoopZeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }
        #endregion

        private KarnaughMap karnaughMap1;
        private System.Windows.Forms.Button btnRandomFill;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.ListBox lstLoopOnes;
        private System.Windows.Forms.ListBox lstLoopZeros;
    }
}

