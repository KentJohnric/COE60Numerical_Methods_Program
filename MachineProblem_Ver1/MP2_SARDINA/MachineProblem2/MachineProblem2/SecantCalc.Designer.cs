namespace MachineProblem2
{
    partial class frmSecant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecant));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lBoxSecant_fx2 = new System.Windows.Forms.ListBox();
            this.lBoxSecant_fx1 = new System.Windows.Forms.ListBox();
            this.lBoxSecant_fx0 = new System.Windows.Forms.ListBox();
            this.lBoxSecant_x2 = new System.Windows.Forms.ListBox();
            this.lBoxSecant_x1 = new System.Windows.Forms.ListBox();
            this.lBoxSecant_x0 = new System.Windows.Forms.ListBox();
            this.btnSecant_back = new System.Windows.Forms.Button();
            this.btnSecant_clear = new System.Windows.Forms.Button();
            this.btnSecant_solve = new System.Windows.Forms.Button();
            this.txtBoxSecant_k = new System.Windows.Forms.TextBox();
            this.txtBoxSecant_x1 = new System.Windows.Forms.TextBox();
            this.txtBoxSecant_x2 = new System.Windows.Forms.TextBox();
            this.txtBoxSecant_x3 = new System.Windows.Forms.TextBox();
            this.txtBoxSecant_int2 = new System.Windows.Forms.TextBox();
            this.txtBoxSecant_int1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(211, 124);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 18);
            this.label12.TabIndex = 85;
            this.label12.Text = "k";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(491, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 18);
            this.label11.TabIndex = 84;
            this.label11.Text = "f(x1)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(400, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 83;
            this.label10.Text = "f(x2)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(307, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 82;
            this.label9.Text = "f(x0)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(227, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 81;
            this.label8.Text = "x1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(133, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 18);
            this.label7.TabIndex = 80;
            this.label7.Text = "x2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(42, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "x0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(355, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(237, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 77;
            this.label4.Text = "x^2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(119, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 76;
            this.label3.Text = "x^3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "x1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "x0";
            // 
            // lBoxSecant_fx2
            // 
            this.lBoxSecant_fx2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lBoxSecant_fx2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxSecant_fx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_fx2.FormattingEnabled = true;
            this.lBoxSecant_fx2.ItemHeight = 18;
            this.lBoxSecant_fx2.Location = new System.Drawing.Point(385, 238);
            this.lBoxSecant_fx2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lBoxSecant_fx2.Name = "lBoxSecant_fx2";
            this.lBoxSecant_fx2.Size = new System.Drawing.Size(84, 200);
            this.lBoxSecant_fx2.TabIndex = 73;
            // 
            // lBoxSecant_fx1
            // 
            this.lBoxSecant_fx1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lBoxSecant_fx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxSecant_fx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_fx1.FormattingEnabled = true;
            this.lBoxSecant_fx1.ItemHeight = 18;
            this.lBoxSecant_fx1.Location = new System.Drawing.Point(477, 238);
            this.lBoxSecant_fx1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lBoxSecant_fx1.Name = "lBoxSecant_fx1";
            this.lBoxSecant_fx1.Size = new System.Drawing.Size(84, 200);
            this.lBoxSecant_fx1.TabIndex = 72;
            // 
            // lBoxSecant_fx0
            // 
            this.lBoxSecant_fx0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lBoxSecant_fx0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxSecant_fx0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_fx0.FormattingEnabled = true;
            this.lBoxSecant_fx0.ItemHeight = 18;
            this.lBoxSecant_fx0.Location = new System.Drawing.Point(293, 238);
            this.lBoxSecant_fx0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lBoxSecant_fx0.Name = "lBoxSecant_fx0";
            this.lBoxSecant_fx0.Size = new System.Drawing.Size(84, 200);
            this.lBoxSecant_fx0.TabIndex = 71;
            // 
            // lBoxSecant_x2
            // 
            this.lBoxSecant_x2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lBoxSecant_x2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxSecant_x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_x2.FormattingEnabled = true;
            this.lBoxSecant_x2.ItemHeight = 18;
            this.lBoxSecant_x2.Location = new System.Drawing.Point(109, 238);
            this.lBoxSecant_x2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lBoxSecant_x2.Name = "lBoxSecant_x2";
            this.lBoxSecant_x2.Size = new System.Drawing.Size(84, 200);
            this.lBoxSecant_x2.TabIndex = 70;
            // 
            // lBoxSecant_x1
            // 
            this.lBoxSecant_x1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lBoxSecant_x1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxSecant_x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_x1.FormattingEnabled = true;
            this.lBoxSecant_x1.ItemHeight = 18;
            this.lBoxSecant_x1.Location = new System.Drawing.Point(201, 238);
            this.lBoxSecant_x1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lBoxSecant_x1.Name = "lBoxSecant_x1";
            this.lBoxSecant_x1.Size = new System.Drawing.Size(84, 200);
            this.lBoxSecant_x1.TabIndex = 69;
            // 
            // lBoxSecant_x0
            // 
            this.lBoxSecant_x0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lBoxSecant_x0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxSecant_x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxSecant_x0.FormattingEnabled = true;
            this.lBoxSecant_x0.ItemHeight = 18;
            this.lBoxSecant_x0.Location = new System.Drawing.Point(17, 238);
            this.lBoxSecant_x0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lBoxSecant_x0.Name = "lBoxSecant_x0";
            this.lBoxSecant_x0.Size = new System.Drawing.Size(84, 200);
            this.lBoxSecant_x0.TabIndex = 68;
            // 
            // btnSecant_back
            // 
            this.btnSecant_back.BackColor = System.Drawing.Color.Black;
            this.btnSecant_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecant_back.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecant_back.ForeColor = System.Drawing.Color.White;
            this.btnSecant_back.Location = new System.Drawing.Point(445, 83);
            this.btnSecant_back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSecant_back.Name = "btnSecant_back";
            this.btnSecant_back.Size = new System.Drawing.Size(116, 33);
            this.btnSecant_back.TabIndex = 67;
            this.btnSecant_back.Text = "Back";
            this.btnSecant_back.UseVisualStyleBackColor = false;
            this.btnSecant_back.Click += new System.EventHandler(this.btnSecant_back_Click);
            // 
            // btnSecant_clear
            // 
            this.btnSecant_clear.BackColor = System.Drawing.Color.Black;
            this.btnSecant_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecant_clear.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecant_clear.ForeColor = System.Drawing.Color.White;
            this.btnSecant_clear.Location = new System.Drawing.Point(245, 152);
            this.btnSecant_clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSecant_clear.Name = "btnSecant_clear";
            this.btnSecant_clear.Size = new System.Drawing.Size(138, 53);
            this.btnSecant_clear.TabIndex = 66;
            this.btnSecant_clear.Text = "Clear";
            this.btnSecant_clear.UseVisualStyleBackColor = false;
            this.btnSecant_clear.Click += new System.EventHandler(this.btnSecant_clear_Click);
            // 
            // btnSecant_solve
            // 
            this.btnSecant_solve.BackColor = System.Drawing.Color.Black;
            this.btnSecant_solve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecant_solve.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecant_solve.ForeColor = System.Drawing.Color.White;
            this.btnSecant_solve.Location = new System.Drawing.Point(76, 152);
            this.btnSecant_solve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSecant_solve.Name = "btnSecant_solve";
            this.btnSecant_solve.Size = new System.Drawing.Size(161, 53);
            this.btnSecant_solve.TabIndex = 65;
            this.btnSecant_solve.Text = "Solve";
            this.btnSecant_solve.UseVisualStyleBackColor = false;
            this.btnSecant_solve.Click += new System.EventHandler(this.btnSecant_solve_Click);
            // 
            // txtBoxSecant_k
            // 
            this.txtBoxSecant_k.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxSecant_k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecant_k.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSecant_k.Location = new System.Drawing.Point(237, 122);
            this.txtBoxSecant_k.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxSecant_k.Name = "txtBoxSecant_k";
            this.txtBoxSecant_k.Size = new System.Drawing.Size(60, 24);
            this.txtBoxSecant_k.TabIndex = 64;
            this.txtBoxSecant_k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxSecant_x1
            // 
            this.txtBoxSecant_x1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxSecant_x1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecant_x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSecant_x1.Location = new System.Drawing.Point(374, 90);
            this.txtBoxSecant_x1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxSecant_x1.Name = "txtBoxSecant_x1";
            this.txtBoxSecant_x1.Size = new System.Drawing.Size(60, 24);
            this.txtBoxSecant_x1.TabIndex = 63;
            this.txtBoxSecant_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxSecant_x2
            // 
            this.txtBoxSecant_x2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxSecant_x2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecant_x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSecant_x2.Location = new System.Drawing.Point(287, 90);
            this.txtBoxSecant_x2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxSecant_x2.Name = "txtBoxSecant_x2";
            this.txtBoxSecant_x2.Size = new System.Drawing.Size(60, 24);
            this.txtBoxSecant_x2.TabIndex = 62;
            this.txtBoxSecant_x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxSecant_x3
            // 
            this.txtBoxSecant_x3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxSecant_x3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecant_x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSecant_x3.Location = new System.Drawing.Point(169, 90);
            this.txtBoxSecant_x3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxSecant_x3.Name = "txtBoxSecant_x3";
            this.txtBoxSecant_x3.Size = new System.Drawing.Size(60, 24);
            this.txtBoxSecant_x3.TabIndex = 61;
            this.txtBoxSecant_x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxSecant_int2
            // 
            this.txtBoxSecant_int2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxSecant_int2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecant_int2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSecant_int2.Location = new System.Drawing.Point(51, 103);
            this.txtBoxSecant_int2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxSecant_int2.Name = "txtBoxSecant_int2";
            this.txtBoxSecant_int2.Size = new System.Drawing.Size(60, 24);
            this.txtBoxSecant_int2.TabIndex = 60;
            this.txtBoxSecant_int2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxSecant_int1
            // 
            this.txtBoxSecant_int1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxSecant_int1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecant_int1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSecant_int1.Location = new System.Drawing.Point(51, 75);
            this.txtBoxSecant_int1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxSecant_int1.Name = "txtBoxSecant_int1";
            this.txtBoxSecant_int1.Size = new System.Drawing.Size(60, 24);
            this.txtBoxSecant_int1.TabIndex = 59;
            this.txtBoxSecant_int1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 33);
            this.textBox1.TabIndex = 86;
            this.textBox1.Text = "Secant Method Calculator";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(568, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // frmSecant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBoxSecant_fx2);
            this.Controls.Add(this.lBoxSecant_fx1);
            this.Controls.Add(this.lBoxSecant_fx0);
            this.Controls.Add(this.lBoxSecant_x2);
            this.Controls.Add(this.lBoxSecant_x1);
            this.Controls.Add(this.lBoxSecant_x0);
            this.Controls.Add(this.btnSecant_back);
            this.Controls.Add(this.btnSecant_clear);
            this.Controls.Add(this.btnSecant_solve);
            this.Controls.Add(this.txtBoxSecant_k);
            this.Controls.Add(this.txtBoxSecant_x1);
            this.Controls.Add(this.txtBoxSecant_x2);
            this.Controls.Add(this.txtBoxSecant_x3);
            this.Controls.Add(this.txtBoxSecant_int2);
            this.Controls.Add(this.txtBoxSecant_int1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSecant";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxSecant_fx2;
        private System.Windows.Forms.ListBox lBoxSecant_fx1;
        private System.Windows.Forms.ListBox lBoxSecant_fx0;
        private System.Windows.Forms.ListBox lBoxSecant_x2;
        private System.Windows.Forms.ListBox lBoxSecant_x1;
        private System.Windows.Forms.ListBox lBoxSecant_x0;
        private System.Windows.Forms.Button btnSecant_back;
        private System.Windows.Forms.Button btnSecant_clear;
        private System.Windows.Forms.Button btnSecant_solve;
        private System.Windows.Forms.TextBox txtBoxSecant_k;
        private System.Windows.Forms.TextBox txtBoxSecant_x1;
        private System.Windows.Forms.TextBox txtBoxSecant_x2;
        private System.Windows.Forms.TextBox txtBoxSecant_x3;
        private System.Windows.Forms.TextBox txtBoxSecant_int2;
        private System.Windows.Forms.TextBox txtBoxSecant_int1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}