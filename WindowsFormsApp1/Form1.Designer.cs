﻿namespace WindowsFormsApp1
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
            this.karnaughMap1 = new WindowsFormsApp1.KarnaughMap();
            this.SuspendLayout();
            // 
            // karnaughMap1
            // 
            this.karnaughMap1.Location = new System.Drawing.Point(260, 85);
            this.karnaughMap1.Name = "karnaughMap1";
            this.karnaughMap1.OutputVariable = null;
            this.karnaughMap1.Size = new System.Drawing.Size(50, 50);
            this.karnaughMap1.TabIndex = 0;
            this.karnaughMap1.InputVariables.Add("A");
            this.karnaughMap1.InputVariables.Add("B");
            this.karnaughMap1.InputVariables.Add("C");
            this.karnaughMap1.InputVariables.Add("D");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.karnaughMap1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private KarnaughMap karnaughMap1;
    }
}

