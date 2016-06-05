namespace ApCalculator.GUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDeltaUC = new System.Windows.Forms.Label();
            this.lblThetaMax = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblt = new System.Windows.Forms.Label();
            this.lblTau = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDeltaLC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.rboExposureTIme = new System.Windows.Forms.RadioButton();
            this.rboGuideStarAngle = new System.Windows.Forms.RadioButton();
            this.rboMaxFieldRotation = new System.Windows.Forms.RadioButton();
            this.rboTargetDeclination = new System.Windows.Forms.RadioButton();
            this.rboMaxFocalLength = new System.Windows.Forms.RadioButton();
            this.rboAlignmentError = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThetaMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeltaLC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeltaUP = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1511, 1023);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1495, 976);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(3, 27);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(494, 564);
            this.txtResult.TabIndex = 19;
            this.txtResult.Text = "Select the desired parameter to solve for and fill in all the other parameters. T" +
    "hen calculate  the reamining parameter.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDeltaUC);
            this.groupBox4.Controls.Add(this.lblThetaMax);
            this.groupBox4.Controls.Add(this.lblF);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lblt);
            this.groupBox4.Controls.Add(this.lblTau);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lblDeltaLC);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 672);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(843, 257);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Equation Details";
            // 
            // lblDeltaUC
            // 
            this.lblDeltaUC.AutoSize = true;
            this.lblDeltaUC.Location = new System.Drawing.Point(571, 144);
            this.lblDeltaUC.Name = "lblDeltaUC";
            this.lblDeltaUC.Size = new System.Drawing.Size(137, 37);
            this.lblDeltaUC.TabIndex = 21;
            this.lblDeltaUC.Text = "DeltaUC";
            // 
            // lblThetaMax
            // 
            this.lblThetaMax.AutoSize = true;
            this.lblThetaMax.Location = new System.Drawing.Point(136, 114);
            this.lblThetaMax.Name = "lblThetaMax";
            this.lblThetaMax.Size = new System.Drawing.Size(195, 37);
            this.lblThetaMax.TabIndex = 13;
            this.lblThetaMax.Text = "ThetaMax = ";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(450, 144);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(37, 37);
            this.lblF.TabIndex = 20;
            this.lblF.Text = "F";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "45000";
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Location = new System.Drawing.Point(372, 144);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(26, 37);
            this.lblt.TabIndex = 19;
            this.lblt.Text = "t";
            // 
            // lblTau
            // 
            this.lblTau.AutoSize = true;
            this.lblTau.Location = new System.Drawing.Point(438, 77);
            this.lblTau.Name = "lblTau";
            this.lblTau.Size = new System.Drawing.Size(62, 37);
            this.lblTau.TabIndex = 15;
            this.lblTau.Text = "tau";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(447, 37);
            this.label11.TabIndex = 18;
            this.label11.Text = "-------------------------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 37);
            this.label9.TabIndex = 16;
            this.label9.Text = "cos";
            // 
            // lblDeltaLC
            // 
            this.lblDeltaLC.AutoSize = true;
            this.lblDeltaLC.Location = new System.Drawing.Point(608, 77);
            this.lblDeltaLC.Name = "lblDeltaLC";
            this.lblDeltaLC.Size = new System.Drawing.Size(127, 37);
            this.lblDeltaLC.TabIndex = 17;
            this.lblDeltaLC.Text = "deltaLC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdCalculate);
            this.groupBox2.Controls.Add(this.rboExposureTIme);
            this.groupBox2.Controls.Add(this.rboGuideStarAngle);
            this.groupBox2.Controls.Add(this.rboMaxFieldRotation);
            this.groupBox2.Controls.Add(this.rboTargetDeclination);
            this.groupBox2.Controls.Add(this.rboMaxFocalLength);
            this.groupBox2.Controls.Add(this.rboAlignmentError);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtThetaMax);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTau);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDeltaLC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtF);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDeltaUP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 594);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parmeters";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(43, 509);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(148, 54);
            this.cmdCalculate.TabIndex = 18;
            this.cmdCalculate.Text = "Caclulate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // rboExposureTIme
            // 
            this.rboExposureTIme.AutoSize = true;
            this.rboExposureTIme.Location = new System.Drawing.Point(62, 235);
            this.rboExposureTIme.Name = "rboExposureTIme";
            this.rboExposureTIme.Size = new System.Drawing.Size(27, 26);
            this.rboExposureTIme.TabIndex = 17;
            this.rboExposureTIme.TabStop = true;
            this.rboExposureTIme.UseVisualStyleBackColor = true;
            this.rboExposureTIme.CheckedChanged += new System.EventHandler(this.rboExposureTIme_CheckedChanged);
            // 
            // rboGuideStarAngle
            // 
            this.rboGuideStarAngle.AutoSize = true;
            this.rboGuideStarAngle.Location = new System.Drawing.Point(62, 426);
            this.rboGuideStarAngle.Name = "rboGuideStarAngle";
            this.rboGuideStarAngle.Size = new System.Drawing.Size(27, 26);
            this.rboGuideStarAngle.TabIndex = 16;
            this.rboGuideStarAngle.TabStop = true;
            this.rboGuideStarAngle.UseVisualStyleBackColor = true;
            this.rboGuideStarAngle.CheckedChanged += new System.EventHandler(this.rboGuideStarAngle_CheckedChanged);
            // 
            // rboMaxFieldRotation
            // 
            this.rboMaxFieldRotation.AutoSize = true;
            this.rboMaxFieldRotation.Location = new System.Drawing.Point(62, 358);
            this.rboMaxFieldRotation.Name = "rboMaxFieldRotation";
            this.rboMaxFieldRotation.Size = new System.Drawing.Size(27, 26);
            this.rboMaxFieldRotation.TabIndex = 15;
            this.rboMaxFieldRotation.TabStop = true;
            this.rboMaxFieldRotation.UseVisualStyleBackColor = true;
            this.rboMaxFieldRotation.CheckedChanged += new System.EventHandler(this.rboMaxFieldRotation_CheckedChanged);
            // 
            // rboTargetDeclination
            // 
            this.rboTargetDeclination.AutoSize = true;
            this.rboTargetDeclination.Location = new System.Drawing.Point(62, 184);
            this.rboTargetDeclination.Name = "rboTargetDeclination";
            this.rboTargetDeclination.Size = new System.Drawing.Size(27, 26);
            this.rboTargetDeclination.TabIndex = 14;
            this.rboTargetDeclination.TabStop = true;
            this.rboTargetDeclination.UseVisualStyleBackColor = true;
            this.rboTargetDeclination.CheckedChanged += new System.EventHandler(this.rboTargetDeclination_CheckedChanged);
            // 
            // rboMaxFocalLength
            // 
            this.rboMaxFocalLength.AutoSize = true;
            this.rboMaxFocalLength.Location = new System.Drawing.Point(62, 299);
            this.rboMaxFocalLength.Name = "rboMaxFocalLength";
            this.rboMaxFocalLength.Size = new System.Drawing.Size(27, 26);
            this.rboMaxFocalLength.TabIndex = 3;
            this.rboMaxFocalLength.TabStop = true;
            this.rboMaxFocalLength.UseVisualStyleBackColor = true;
            this.rboMaxFocalLength.CheckedChanged += new System.EventHandler(this.rboSolveForMaxFocalLength_CheckedChanged);
            // 
            // rboAlignmentError
            // 
            this.rboAlignmentError.AutoSize = true;
            this.rboAlignmentError.Location = new System.Drawing.Point(62, 128);
            this.rboAlignmentError.Name = "rboAlignmentError";
            this.rboAlignmentError.Size = new System.Drawing.Size(27, 26);
            this.rboAlignmentError.TabIndex = 13;
            this.rboAlignmentError.TabStop = true;
            this.rboAlignmentError.UseVisualStyleBackColor = true;
            this.rboAlignmentError.CheckedChanged += new System.EventHandler(this.rboSolveForAlignmentError_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 29);
            this.label12.TabIndex = 13;
            this.label12.Text = "Parameter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Solve For This";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(416, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "Max Permitted Alignmment Erro in am";
            // 
            // txtThetaMax
            // 
            this.txtThetaMax.Location = new System.Drawing.Point(644, 121);
            this.txtThetaMax.Name = "txtThetaMax";
            this.txtThetaMax.Size = new System.Drawing.Size(100, 35);
            this.txtThetaMax.TabIndex = 10;
            this.txtThetaMax.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Field Rotation in um (tau)";
            // 
            // txtTau
            // 
            this.txtTau.Location = new System.Drawing.Point(640, 356);
            this.txtTau.Name = "txtTau";
            this.txtTau.Size = new System.Drawing.Size(100, 35);
            this.txtTau.TabIndex = 1;
            this.txtTau.Text = "9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target Declination in Degrees (delta)";
            // 
            // txtDeltaLC
            // 
            this.txtDeltaLC.Location = new System.Drawing.Point(641, 170);
            this.txtDeltaLC.Name = "txtDeltaLC";
            this.txtDeltaLC.Size = new System.Drawing.Size(100, 35);
            this.txtDeltaLC.TabIndex = 3;
            this.txtDeltaLC.Text = "35";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Exposure Time in Minutes (t)";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(641, 235);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 35);
            this.txtT.TabIndex = 5;
            this.txtT.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max FL  in mm (F)";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(641, 290);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 35);
            this.txtF.TabIndex = 7;
            this.txtF.Text = "655";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Guide Star Angle in Degree";
            // 
            // txtDeltaUP
            // 
            this.txtDeltaUP.Location = new System.Drawing.Point(641, 427);
            this.txtDeltaUP.Name = "txtDeltaUP";
            this.txtDeltaUP.Size = new System.Drawing.Size(100, 35);
            this.txtDeltaUP.TabIndex = 9;
            this.txtDeltaUP.Text = "3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1495, 976);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Location = new System.Drawing.Point(887, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 594);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 1023);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "133Parsecs.com Astrophotography Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeltaLC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeltaUP;
        private System.Windows.Forms.Label lblDeltaUC;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDeltaLC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblThetaMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtThetaMax;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rboAlignmentError;
        private System.Windows.Forms.RadioButton rboMaxFocalLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rboTargetDeclination;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rboExposureTIme;
        private System.Windows.Forms.RadioButton rboGuideStarAngle;
        private System.Windows.Forms.RadioButton rboMaxFieldRotation;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

