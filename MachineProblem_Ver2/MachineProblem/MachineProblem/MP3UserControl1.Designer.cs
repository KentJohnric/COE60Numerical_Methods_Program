namespace MachineProblem
{
    partial class MP3UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gaussseidel = new System.Windows.Forms.Button();
            this.crouts = new System.Windows.Forms.Button();
            this.muller = new System.Windows.Forms.Button();
            this.gsUserControl11 = new MachineProblem.GsUserControl1();
            this.mullersUserControl11 = new MachineProblem.MullersUserControl1();
            this.croutsUserControl11 = new MachineProblem.CroutsUserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 5);
            this.panel1.TabIndex = 132;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back.Location = new System.Drawing.Point(324, 51);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(103, 41);
            this.back.TabIndex = 137;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MachineProblem.Properties.Resources.SQRT;
            this.pictureBox1.Location = new System.Drawing.Point(282, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 151;
            this.pictureBox1.TabStop = false;
            // 
            // gaussseidel
            // 
            this.gaussseidel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gaussseidel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gaussseidel.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussseidel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gaussseidel.Image = global::MachineProblem.Properties.Resources.maths;
            this.gaussseidel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gaussseidel.Location = new System.Drawing.Point(3, 51);
            this.gaussseidel.Name = "gaussseidel";
            this.gaussseidel.Size = new System.Drawing.Size(315, 42);
            this.gaussseidel.TabIndex = 150;
            this.gaussseidel.Text = "GAUSS SEIDEL METHOD";
            this.gaussseidel.UseVisualStyleBackColor = false;
            this.gaussseidel.Click += new System.EventHandler(this.gaussseidel_Click);
            // 
            // crouts
            // 
            this.crouts.BackColor = System.Drawing.Color.DarkSlateGray;
            this.crouts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crouts.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crouts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.crouts.Image = global::MachineProblem.Properties.Resources.maths;
            this.crouts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crouts.Location = new System.Drawing.Point(324, 3);
            this.crouts.Name = "crouts";
            this.crouts.Size = new System.Drawing.Size(315, 42);
            this.crouts.TabIndex = 149;
            this.crouts.Text = "CROUT\'S METHOD";
            this.crouts.UseVisualStyleBackColor = false;
            this.crouts.Click += new System.EventHandler(this.crouts_Click);
            // 
            // muller
            // 
            this.muller.BackColor = System.Drawing.Color.DarkSlateGray;
            this.muller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muller.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muller.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.muller.Image = global::MachineProblem.Properties.Resources.maths;
            this.muller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.muller.Location = new System.Drawing.Point(3, 3);
            this.muller.Name = "muller";
            this.muller.Size = new System.Drawing.Size(315, 42);
            this.muller.TabIndex = 148;
            this.muller.Text = "MULLER\'S METHOD";
            this.muller.UseVisualStyleBackColor = false;
            this.muller.Click += new System.EventHandler(this.muller_Click);
            // 
            // gsUserControl11
            // 
            this.gsUserControl11.AutoScroll = true;
            this.gsUserControl11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gsUserControl11.ForeColor = System.Drawing.Color.Transparent;
            this.gsUserControl11.Location = new System.Drawing.Point(1, 108);
            this.gsUserControl11.Name = "gsUserControl11";
            this.gsUserControl11.Size = new System.Drawing.Size(807, 375);
            this.gsUserControl11.TabIndex = 153;
            // 
            // mullersUserControl11
            // 
            this.mullersUserControl11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mullersUserControl11.Location = new System.Drawing.Point(0, 108);
            this.mullersUserControl11.Name = "mullersUserControl11";
            this.mullersUserControl11.Size = new System.Drawing.Size(773, 375);
            this.mullersUserControl11.TabIndex = 152;
            // 
            // croutsUserControl11
            // 
            this.croutsUserControl11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.croutsUserControl11.Location = new System.Drawing.Point(0, 108);
            this.croutsUserControl11.Name = "croutsUserControl11";
            this.croutsUserControl11.Size = new System.Drawing.Size(807, 375);
            this.croutsUserControl11.TabIndex = 154;
            // 
            // MP3UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.croutsUserControl11);
            this.Controls.Add(this.gsUserControl11);
            this.Controls.Add(this.mullersUserControl11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gaussseidel);
            this.Controls.Add(this.crouts);
            this.Controls.Add(this.muller);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel1);
            this.Name = "MP3UserControl1";
            this.Size = new System.Drawing.Size(926, 570);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button gaussseidel;
        private System.Windows.Forms.Button crouts;
        private System.Windows.Forms.Button muller;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MullersUserControl1 mullersUserControl11;
        private GsUserControl1 gsUserControl11;
        private CroutsUserControl1 croutsUserControl11;
    }
}
