namespace MachineProblem
{
    partial class Mp4UserControl1
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
            this.back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.centeredFiniteUserControl11 = new MachineProblem.CenteredFiniteUserControl1();
            this.simpsonRuleUserControl11 = new MachineProblem.SimpsonRuleUserControl1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gaussseidel = new System.Windows.Forms.Button();
            this.crouts = new System.Windows.Forms.Button();
            this.muller = new System.Windows.Forms.Button();
            this.linearRegressionUserControl11 = new MachineProblem.LinearRegressionUserControl1();
            this.newtonInterpolationUserControl11 = new MachineProblem.NewtonInterpolationUserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back.Location = new System.Drawing.Point(645, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(103, 41);
            this.back.TabIndex = 151;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 5);
            this.panel1.TabIndex = 157;
            // 
            // centeredFiniteUserControl11
            // 
            this.centeredFiniteUserControl11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.centeredFiniteUserControl11.Location = new System.Drawing.Point(0, 102);
            this.centeredFiniteUserControl11.Name = "centeredFiniteUserControl11";
            this.centeredFiniteUserControl11.Size = new System.Drawing.Size(807, 375);
            this.centeredFiniteUserControl11.TabIndex = 159;
            // 
            // simpsonRuleUserControl11
            // 
            this.simpsonRuleUserControl11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.simpsonRuleUserControl11.Location = new System.Drawing.Point(0, 102);
            this.simpsonRuleUserControl11.Name = "simpsonRuleUserControl11";
            this.simpsonRuleUserControl11.Size = new System.Drawing.Size(807, 375);
            this.simpsonRuleUserControl11.TabIndex = 158;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MachineProblem.Properties.Resources.SQRT1;
            this.pictureBox1.Location = new System.Drawing.Point(203, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 156;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::MachineProblem.Properties.Resources.maths;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(324, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(424, 42);
            this.button1.TabIndex = 155;
            this.button1.Text = "NEWTON\'S INTERPOLATION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.gaussseidel.TabIndex = 154;
            this.gaussseidel.Text = "CENTERED FINITE";
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
            this.crouts.TabIndex = 153;
            this.crouts.Text = "LINEAR REGRESSION";
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
            this.muller.TabIndex = 152;
            this.muller.Text = "SIMPSON\'S 3/8 RULE";
            this.muller.UseVisualStyleBackColor = false;
            this.muller.Click += new System.EventHandler(this.muller_Click);
            // 
            // linearRegressionUserControl11
            // 
            this.linearRegressionUserControl11.AutoScroll = true;
            this.linearRegressionUserControl11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.linearRegressionUserControl11.Location = new System.Drawing.Point(0, 102);
            this.linearRegressionUserControl11.Name = "linearRegressionUserControl11";
            this.linearRegressionUserControl11.Size = new System.Drawing.Size(807, 375);
            this.linearRegressionUserControl11.TabIndex = 160;
            // 
            // newtonInterpolationUserControl11
            // 
            this.newtonInterpolationUserControl11.AutoScroll = true;
            this.newtonInterpolationUserControl11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newtonInterpolationUserControl11.Location = new System.Drawing.Point(0, 102);
            this.newtonInterpolationUserControl11.Name = "newtonInterpolationUserControl11";
            this.newtonInterpolationUserControl11.Size = new System.Drawing.Size(807, 375);
            this.newtonInterpolationUserControl11.TabIndex = 161;
            // 
            // Mp4UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.newtonInterpolationUserControl11);
            this.Controls.Add(this.linearRegressionUserControl11);
            this.Controls.Add(this.centeredFiniteUserControl11);
            this.Controls.Add(this.simpsonRuleUserControl11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gaussseidel);
            this.Controls.Add(this.crouts);
            this.Controls.Add(this.muller);
            this.Controls.Add(this.back);
            this.Name = "Mp4UserControl1";
            this.Size = new System.Drawing.Size(756, 324);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gaussseidel;
        private System.Windows.Forms.Button crouts;
        private System.Windows.Forms.Button muller;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private SimpsonRuleUserControl1 simpsonRuleUserControl11;
        private CenteredFiniteUserControl1 centeredFiniteUserControl11;
        private LinearRegressionUserControl1 linearRegressionUserControl11;
        private NewtonInterpolationUserControl1 newtonInterpolationUserControl11;
    }
}
