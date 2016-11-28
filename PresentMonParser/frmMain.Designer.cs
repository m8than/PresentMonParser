namespace PresentMonParser
{
    partial class frmMain
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblAverageR = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl01Low = new System.Windows.Forms.Label();
            this.lbl01LowR = new System.Windows.Forms.Label();
            this.lbl1Low = new System.Windows.Forms.Label();
            this.lbl1LowR = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblMaximumR = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMinimumR = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(190, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(208, 11);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(64, 21);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Browse";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblAverageR
            // 
            this.lblAverageR.AutoSize = true;
            this.lblAverageR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageR.Location = new System.Drawing.Point(6, 16);
            this.lblAverageR.Name = "lblAverageR";
            this.lblAverageR.Size = new System.Drawing.Size(61, 18);
            this.lblAverageR.TabIndex = 2;
            this.lblAverageR.Text = "Average";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.lbl01Low);
            this.groupBox1.Controls.Add(this.lbl01LowR);
            this.groupBox1.Controls.Add(this.lbl1Low);
            this.groupBox1.Controls.Add(this.lbl1LowR);
            this.groupBox1.Controls.Add(this.lblMaximum);
            this.groupBox1.Controls.Add(this.lblMaximumR);
            this.groupBox1.Controls.Add(this.lblMinimum);
            this.groupBox1.Controls.Add(this.lblMinimumR);
            this.groupBox1.Controls.Add(this.lblAverage);
            this.groupBox1.Controls.Add(this.lblAverageR);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // lbl01Low
            // 
            this.lbl01Low.AutoSize = true;
            this.lbl01Low.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl01Low.Location = new System.Drawing.Point(106, 101);
            this.lbl01Low.Name = "lbl01Low";
            this.lbl01Low.Size = new System.Drawing.Size(16, 18);
            this.lbl01Low.TabIndex = 11;
            this.lbl01Low.Text = "0";
            // 
            // lbl01LowR
            // 
            this.lbl01LowR.AutoSize = true;
            this.lbl01LowR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01LowR.Location = new System.Drawing.Point(6, 101);
            this.lbl01LowR.Name = "lbl01LowR";
            this.lbl01LowR.Size = new System.Drawing.Size(73, 18);
            this.lbl01LowR.TabIndex = 10;
            this.lbl01LowR.Text = "0.1% Low";
            // 
            // lbl1Low
            // 
            this.lbl1Low.AutoSize = true;
            this.lbl1Low.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl1Low.Location = new System.Drawing.Point(106, 83);
            this.lbl1Low.Name = "lbl1Low";
            this.lbl1Low.Size = new System.Drawing.Size(16, 18);
            this.lbl1Low.TabIndex = 9;
            this.lbl1Low.Text = "0";
            // 
            // lbl1LowR
            // 
            this.lbl1LowR.AutoSize = true;
            this.lbl1LowR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1LowR.Location = new System.Drawing.Point(6, 83);
            this.lbl1LowR.Name = "lbl1LowR";
            this.lbl1LowR.Size = new System.Drawing.Size(61, 18);
            this.lbl1LowR.TabIndex = 8;
            this.lbl1LowR.Text = "1% Low";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMaximum.Location = new System.Drawing.Point(106, 52);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(16, 18);
            this.lblMaximum.TabIndex = 7;
            this.lblMaximum.Text = "0";
            // 
            // lblMaximumR
            // 
            this.lblMaximumR.AutoSize = true;
            this.lblMaximumR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximumR.Location = new System.Drawing.Point(6, 52);
            this.lblMaximumR.Name = "lblMaximumR";
            this.lblMaximumR.Size = new System.Drawing.Size(73, 18);
            this.lblMaximumR.TabIndex = 6;
            this.lblMaximumR.Text = "Maximum";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMinimum.Location = new System.Drawing.Point(106, 34);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(16, 18);
            this.lblMinimum.TabIndex = 5;
            this.lblMinimum.Text = "0";
            // 
            // lblMinimumR
            // 
            this.lblMinimumR.AutoSize = true;
            this.lblMinimumR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumR.Location = new System.Drawing.Point(6, 34);
            this.lblMinimumR.Name = "lblMinimumR";
            this.lblMinimumR.Size = new System.Drawing.Size(69, 18);
            this.lblMinimumR.TabIndex = 4;
            this.lblMinimumR.Text = "Minimum";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAverage.Location = new System.Drawing.Point(106, 16);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(16, 18);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "0";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 38);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(260, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblInfo.ForeColor = System.Drawing.Color.Crimson;
            this.lblInfo.Location = new System.Drawing.Point(13, 166);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(236, 9);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Lows are calculated with frame times rather than frames per second.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "PresentMonParser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblAverageR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblMaximumR;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMinimumR;
        private System.Windows.Forms.Label lbl01Low;
        private System.Windows.Forms.Label lbl01LowR;
        private System.Windows.Forms.Label lbl1Low;
        private System.Windows.Forms.Label lbl1LowR;
        private System.Windows.Forms.Label lblInfo;
    }
}

