namespace MachineProblem
{
    partial class NewtonInterpolationUserControl1
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
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegula_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Window;
            this.label21.Location = new System.Drawing.Point(232, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(284, 25);
            this.label21.TabIndex = 243;
            this.label21.Text = "NEWTON\'S INTERPOLATION";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(255, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 244;
            this.button1.Text = "SOLVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegula_clear
            // 
            this.btnRegula_clear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegula_clear.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegula_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegula_clear.Location = new System.Drawing.Point(395, 28);
            this.btnRegula_clear.Name = "btnRegula_clear";
            this.btnRegula_clear.Size = new System.Drawing.Size(103, 41);
            this.btnRegula_clear.TabIndex = 245;
            this.btnRegula_clear.Text = "CLEAR";
            this.btnRegula_clear.UseVisualStyleBackColor = false;
            this.btnRegula_clear.Click += new System.EventHandler(this.btnRegula_clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(309, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 260;
            this.label4.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(404, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 261;
            this.label2.Text = "F( x)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(47, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 259;
            this.label1.Text = "Enter X:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(130, 130);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(109, 20);
            this.txtX.TabIndex = 258;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(255, 241);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 108);
            this.listBox1.TabIndex = 257;
            // 
            // txtfx5
            // 
            this.txtfx5.Location = new System.Drawing.Point(395, 182);
            this.txtfx5.Name = "txtfx5";
            this.txtfx5.Size = new System.Drawing.Size(80, 20);
            this.txtfx5.TabIndex = 255;
            // 
            // txtfx4
            // 
            this.txtfx4.Location = new System.Drawing.Point(395, 156);
            this.txtfx4.Name = "txtfx4";
            this.txtfx4.Size = new System.Drawing.Size(80, 20);
            this.txtfx4.TabIndex = 254;
            // 
            // txtfx3
            // 
            this.txtfx3.Location = new System.Drawing.Point(395, 130);
            this.txtfx3.Name = "txtfx3";
            this.txtfx3.Size = new System.Drawing.Size(80, 20);
            this.txtfx3.TabIndex = 253;
            // 
            // txtfx2
            // 
            this.txtfx2.Location = new System.Drawing.Point(395, 105);
            this.txtfx2.Name = "txtfx2";
            this.txtfx2.Size = new System.Drawing.Size(80, 20);
            this.txtfx2.TabIndex = 252;
            // 
            // txtfx1
            // 
            this.txtfx1.Location = new System.Drawing.Point(395, 79);
            this.txtfx1.Name = "txtfx1";
            this.txtfx1.Size = new System.Drawing.Size(80, 20);
            this.txtfx1.TabIndex = 251;
            // 
            // txtx5
            // 
            this.txtx5.Location = new System.Drawing.Point(290, 182);
            this.txtx5.Name = "txtx5";
            this.txtx5.Size = new System.Drawing.Size(80, 20);
            this.txtx5.TabIndex = 250;
            // 
            // txtx4
            // 
            this.txtx4.Location = new System.Drawing.Point(290, 156);
            this.txtx4.Name = "txtx4";
            this.txtx4.Size = new System.Drawing.Size(80, 20);
            this.txtx4.TabIndex = 249;
            // 
            // txtx3
            // 
            this.txtx3.Location = new System.Drawing.Point(290, 130);
            this.txtx3.Name = "txtx3";
            this.txtx3.Size = new System.Drawing.Size(80, 20);
            this.txtx3.TabIndex = 248;
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(290, 105);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(80, 20);
            this.txtx2.TabIndex = 247;
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(290, 79);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(80, 20);
            this.txtx1.TabIndex = 246;
            // 
            // NewtonInterpolationUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.listBox1);
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
            this.Controls.Add(this.btnRegula_clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label21);
            this.Name = "NewtonInterpolationUserControl1";
            this.Size = new System.Drawing.Size(807, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegula_clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.ListBox listBox1;
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
    }
}
