namespace MachineProblem3
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MullerBTN = new System.Windows.Forms.Button();
            this.CroutsBTN = new System.Windows.Forms.Button();
            this.GSBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MullerBTN
            // 
            this.MullerBTN.Font = new System.Drawing.Font("SF UI Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MullerBTN.Location = new System.Drawing.Point(221, 62);
            this.MullerBTN.Name = "MullerBTN";
            this.MullerBTN.Size = new System.Drawing.Size(280, 53);
            this.MullerBTN.TabIndex = 1;
            this.MullerBTN.Text = "Muller\'s Method";
            this.MullerBTN.UseVisualStyleBackColor = true;
            this.MullerBTN.Click += new System.EventHandler(this.MullerBTN_Click);
            // 
            // CroutsBTN
            // 
            this.CroutsBTN.Font = new System.Drawing.Font("SF UI Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CroutsBTN.Location = new System.Drawing.Point(221, 121);
            this.CroutsBTN.Name = "CroutsBTN";
            this.CroutsBTN.Size = new System.Drawing.Size(280, 53);
            this.CroutsBTN.TabIndex = 2;
            this.CroutsBTN.Text = "Crout\'s Method";
            this.CroutsBTN.UseVisualStyleBackColor = true;
            this.CroutsBTN.Click += new System.EventHandler(this.CroutsBTN_Click);
            // 
            // GSBTN
            // 
            this.GSBTN.Font = new System.Drawing.Font("SF UI Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GSBTN.Location = new System.Drawing.Point(221, 180);
            this.GSBTN.Name = "GSBTN";
            this.GSBTN.Size = new System.Drawing.Size(280, 53);
            this.GSBTN.TabIndex = 3;
            this.GSBTN.Text = "Gauss-Seidel Method";
            this.GSBTN.UseVisualStyleBackColor = true;
            this.GSBTN.Click += new System.EventHandler(this.GSBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECT WHAT METHOD YOU WANT TO USE";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GSBTN);
            this.Controls.Add(this.CroutsBTN);
            this.Controls.Add(this.MullerBTN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MullerBTN;
        private System.Windows.Forms.Button CroutsBTN;
        private System.Windows.Forms.Button GSBTN;
        private System.Windows.Forms.Label label1;
    }
}

