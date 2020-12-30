namespace MachineProblem4
{
    partial class LinearRegressionClac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearRegressionClac));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtfx5 = new System.Windows.Forms.TextBox();
            this.txtfx4 = new System.Windows.Forms.TextBox();
            this.txtfx3 = new System.Windows.Forms.TextBox();
            this.txtfx2 = new System.Windows.Forms.TextBox();
            this.txtfx1 = new System.Windows.Forms.TextBox();
            this.txtx5 = new System.Windows.Forms.TextBox();
            this.txtx4 = new System.Windows.Forms.TextBox();
            this.txtx3 = new System.Windows.Forms.TextBox();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Linear Regression";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "X";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(151, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "F( x)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 160);
            this.listBox1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(39, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 43);
            this.button1.TabIndex = 26;
            this.button1.Text = "COMPUTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfx5
            // 
            this.txtfx5.Location = new System.Drawing.Point(138, 350);
            this.txtfx5.Name = "txtfx5";
            this.txtfx5.Size = new System.Drawing.Size(88, 20);
            this.txtfx5.TabIndex = 25;
            // 
            // txtfx4
            // 
            this.txtfx4.Location = new System.Drawing.Point(138, 324);
            this.txtfx4.Name = "txtfx4";
            this.txtfx4.Size = new System.Drawing.Size(88, 20);
            this.txtfx4.TabIndex = 24;
            // 
            // txtfx3
            // 
            this.txtfx3.Location = new System.Drawing.Point(138, 298);
            this.txtfx3.Name = "txtfx3";
            this.txtfx3.Size = new System.Drawing.Size(88, 20);
            this.txtfx3.TabIndex = 23;
            // 
            // txtfx2
            // 
            this.txtfx2.Location = new System.Drawing.Point(138, 272);
            this.txtfx2.Name = "txtfx2";
            this.txtfx2.Size = new System.Drawing.Size(88, 20);
            this.txtfx2.TabIndex = 22;
            // 
            // txtfx1
            // 
            this.txtfx1.Location = new System.Drawing.Point(138, 246);
            this.txtfx1.Name = "txtfx1";
            this.txtfx1.Size = new System.Drawing.Size(88, 20);
            this.txtfx1.TabIndex = 21;
            // 
            // txtx5
            // 
            this.txtx5.Location = new System.Drawing.Point(16, 350);
            this.txtx5.Name = "txtx5";
            this.txtx5.Size = new System.Drawing.Size(88, 20);
            this.txtx5.TabIndex = 20;
            // 
            // txtx4
            // 
            this.txtx4.Location = new System.Drawing.Point(16, 324);
            this.txtx4.Name = "txtx4";
            this.txtx4.Size = new System.Drawing.Size(88, 20);
            this.txtx4.TabIndex = 19;
            // 
            // txtx3
            // 
            this.txtx3.Location = new System.Drawing.Point(16, 298);
            this.txtx3.Name = "txtx3";
            this.txtx3.Size = new System.Drawing.Size(88, 20);
            this.txtx3.TabIndex = 18;
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(16, 272);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(88, 20);
            this.txtx2.TabIndex = 17;
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(16, 246);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(88, 20);
            this.txtx1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // LinearRegressionClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfx5);
            this.Controls.Add(this.txtfx4);
            this.Controls.Add(this.txtfx3);
            this.Controls.Add(this.txtfx2);
            this.Controls.Add(this.txtfx1);
            this.Controls.Add(this.txtx5);
            this.Controls.Add(this.txtx4);
            this.Controls.Add(this.txtx3);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "LinearRegressionClac";
            this.Text = "LinearRegressionClac";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfx5;
        private System.Windows.Forms.TextBox txtfx4;
        private System.Windows.Forms.TextBox txtfx3;
        private System.Windows.Forms.TextBox txtfx2;
        private System.Windows.Forms.TextBox txtfx1;
        private System.Windows.Forms.TextBox txtx5;
        private System.Windows.Forms.TextBox txtx4;
        private System.Windows.Forms.TextBox txtx3;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}