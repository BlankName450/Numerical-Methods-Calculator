
namespace Numerics_Project
{
    partial class GaussElimination
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_00 = new System.Windows.Forms.TextBox();
            this.txt_01 = new System.Windows.Forms.TextBox();
            this.txt_02 = new System.Windows.Forms.TextBox();
            this.txt_03 = new System.Windows.Forms.TextBox();
            this.txt_10 = new System.Windows.Forms.TextBox();
            this.txt_11 = new System.Windows.Forms.TextBox();
            this.txt_12 = new System.Windows.Forms.TextBox();
            this.txt_13 = new System.Windows.Forms.TextBox();
            this.txt_23 = new System.Windows.Forms.TextBox();
            this.txt_22 = new System.Windows.Forms.TextBox();
            this.txt_21 = new System.Windows.Forms.TextBox();
            this.txt_20 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_m32 = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_m31 = new System.Windows.Forms.TextBox();
            this.txt_m21 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_sum = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_x3 = new System.Windows.Forms.TextBox();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_r00 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_r21 = new System.Windows.Forms.TextBox();
            this.txt_r01 = new System.Windows.Forms.TextBox();
            this.txt_r20 = new System.Windows.Forms.TextBox();
            this.txt_r02 = new System.Windows.Forms.TextBox();
            this.txt_r22 = new System.Windows.Forms.TextBox();
            this.txt_r03 = new System.Windows.Forms.TextBox();
            this.txt_r13 = new System.Windows.Forms.TextBox();
            this.txt_r10 = new System.Windows.Forms.TextBox();
            this.txt_r23 = new System.Windows.Forms.TextBox();
            this.txt_r11 = new System.Windows.Forms.TextBox();
            this.txt_r12 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 75);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(60, 44);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.Location = new System.Drawing.Point(1187, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(65, 58);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gauss-Elimination";
            // 
            // txt_00
            // 
            this.txt_00.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_00.Location = new System.Drawing.Point(68, 202);
            this.txt_00.Multiline = true;
            this.txt_00.Name = "txt_00";
            this.txt_00.Size = new System.Drawing.Size(71, 24);
            this.txt_00.TabIndex = 3;
            this.txt_00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_01
            // 
            this.txt_01.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_01.Location = new System.Drawing.Point(166, 202);
            this.txt_01.Multiline = true;
            this.txt_01.Name = "txt_01";
            this.txt_01.Size = new System.Drawing.Size(71, 24);
            this.txt_01.TabIndex = 4;
            this.txt_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_02
            // 
            this.txt_02.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_02.Location = new System.Drawing.Point(278, 202);
            this.txt_02.Multiline = true;
            this.txt_02.Name = "txt_02";
            this.txt_02.Size = new System.Drawing.Size(74, 24);
            this.txt_02.TabIndex = 5;
            this.txt_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_03
            // 
            this.txt_03.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_03.Location = new System.Drawing.Point(400, 202);
            this.txt_03.Multiline = true;
            this.txt_03.Name = "txt_03";
            this.txt_03.Size = new System.Drawing.Size(74, 24);
            this.txt_03.TabIndex = 7;
            this.txt_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_10
            // 
            this.txt_10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_10.Location = new System.Drawing.Point(68, 257);
            this.txt_10.Multiline = true;
            this.txt_10.Name = "txt_10";
            this.txt_10.Size = new System.Drawing.Size(71, 24);
            this.txt_10.TabIndex = 8;
            this.txt_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_11
            // 
            this.txt_11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_11.Location = new System.Drawing.Point(166, 257);
            this.txt_11.Multiline = true;
            this.txt_11.Name = "txt_11";
            this.txt_11.Size = new System.Drawing.Size(71, 24);
            this.txt_11.TabIndex = 9;
            this.txt_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_12
            // 
            this.txt_12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_12.Location = new System.Drawing.Point(278, 257);
            this.txt_12.Multiline = true;
            this.txt_12.Name = "txt_12";
            this.txt_12.Size = new System.Drawing.Size(74, 24);
            this.txt_12.TabIndex = 10;
            this.txt_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_13
            // 
            this.txt_13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_13.Location = new System.Drawing.Point(400, 257);
            this.txt_13.Multiline = true;
            this.txt_13.Name = "txt_13";
            this.txt_13.Size = new System.Drawing.Size(74, 24);
            this.txt_13.TabIndex = 11;
            this.txt_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_23
            // 
            this.txt_23.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_23.Location = new System.Drawing.Point(400, 310);
            this.txt_23.Multiline = true;
            this.txt_23.Name = "txt_23";
            this.txt_23.Size = new System.Drawing.Size(74, 24);
            this.txt_23.TabIndex = 15;
            this.txt_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_22
            // 
            this.txt_22.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_22.Location = new System.Drawing.Point(278, 310);
            this.txt_22.Multiline = true;
            this.txt_22.Name = "txt_22";
            this.txt_22.Size = new System.Drawing.Size(74, 24);
            this.txt_22.TabIndex = 14;
            this.txt_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_21
            // 
            this.txt_21.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_21.Location = new System.Drawing.Point(166, 310);
            this.txt_21.Multiline = true;
            this.txt_21.Name = "txt_21";
            this.txt_21.Size = new System.Drawing.Size(71, 24);
            this.txt_21.TabIndex = 13;
            this.txt_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_20
            // 
            this.txt_20.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_20.Location = new System.Drawing.Point(68, 310);
            this.txt_20.Multiline = true;
            this.txt_20.Name = "txt_20";
            this.txt_20.Size = new System.Drawing.Size(71, 24);
            this.txt_20.TabIndex = 12;
            this.txt_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_m32);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.txt_m31);
            this.panel2.Controls.Add(this.txt_00);
            this.panel2.Controls.Add(this.txt_m21);
            this.panel2.Controls.Add(this.txt_01);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btn_sum);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_02);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_03);
            this.panel2.Controls.Add(this.txt_x3);
            this.panel2.Controls.Add(this.txt_10);
            this.panel2.Controls.Add(this.txt_x2);
            this.panel2.Controls.Add(this.txt_11);
            this.panel2.Controls.Add(this.txt_x1);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txt_12);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txt_23);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txt_13);
            this.panel2.Controls.Add(this.txt_22);
            this.panel2.Controls.Add(this.txt_20);
            this.panel2.Controls.Add(this.txt_21);
            this.panel2.Controls.Add(this.txt_r00);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_r21);
            this.panel2.Controls.Add(this.txt_r01);
            this.panel2.Controls.Add(this.txt_r20);
            this.panel2.Controls.Add(this.txt_r02);
            this.panel2.Controls.Add(this.txt_r22);
            this.panel2.Controls.Add(this.txt_r03);
            this.panel2.Controls.Add(this.txt_r13);
            this.panel2.Controls.Add(this.txt_r10);
            this.panel2.Controls.Add(this.txt_r23);
            this.panel2.Controls.Add(this.txt_r11);
            this.panel2.Controls.Add(this.txt_r12);
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 558);
            this.panel2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(854, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 55;
            this.label3.Text = "Result :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 54;
            this.label2.Text = "Enter Matrix :";
            // 
            // txt_m32
            // 
            this.txt_m32.Enabled = false;
            this.txt_m32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_m32.Location = new System.Drawing.Point(929, 468);
            this.txt_m32.Name = "txt_m32";
            this.txt_m32.Size = new System.Drawing.Size(78, 30);
            this.txt_m32.TabIndex = 53;
            this.txt_m32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(528, 250);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(93, 49);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_m31
            // 
            this.txt_m31.Enabled = false;
            this.txt_m31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_m31.Location = new System.Drawing.Point(929, 414);
            this.txt_m31.Name = "txt_m31";
            this.txt_m31.Size = new System.Drawing.Size(78, 30);
            this.txt_m31.TabIndex = 52;
            this.txt_m31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_m21
            // 
            this.txt_m21.Enabled = false;
            this.txt_m21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_m21.Location = new System.Drawing.Point(929, 366);
            this.txt_m21.Name = "txt_m21";
            this.txt_m21.Size = new System.Drawing.Size(78, 30);
            this.txt_m21.TabIndex = 51;
            this.txt_m21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(856, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "M3-2 :";
            // 
            // btn_sum
            // 
            this.btn_sum.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_sum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sum.ForeColor = System.Drawing.Color.White;
            this.btn_sum.Location = new System.Drawing.Point(301, 421);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(173, 83);
            this.btn_sum.TabIndex = 23;
            this.btn_sum.Text = "Calculate";
            this.btn_sum.UseVisualStyleBackColor = false;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(856, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 49;
            this.label11.Text = "M3-1 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(856, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 23);
            this.label12.TabIndex = 48;
            this.label12.Text = "M2-1 :";
            // 
            // txt_x3
            // 
            this.txt_x3.Enabled = false;
            this.txt_x3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_x3.Location = new System.Drawing.Point(1080, 469);
            this.txt_x3.Name = "txt_x3";
            this.txt_x3.Size = new System.Drawing.Size(76, 30);
            this.txt_x3.TabIndex = 47;
            this.txt_x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_x2
            // 
            this.txt_x2.Enabled = false;
            this.txt_x2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_x2.Location = new System.Drawing.Point(1080, 415);
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.Size = new System.Drawing.Size(76, 30);
            this.txt_x2.TabIndex = 46;
            this.txt_x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_x1
            // 
            this.txt_x1.Enabled = false;
            this.txt_x1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_x1.Location = new System.Drawing.Point(1080, 366);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.Size = new System.Drawing.Size(76, 30);
            this.txt_x1.TabIndex = 45;
            this.txt_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(1031, 472);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 23);
            this.label19.TabIndex = 44;
            this.label19.Text = "X3 :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1031, 421);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 23);
            this.label18.TabIndex = 43;
            this.label18.Text = "X2 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1024, 366);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 23);
            this.label17.TabIndex = 42;
            this.label17.Text = " X1 :";
            // 
            // txt_r00
            // 
            this.txt_r00.Enabled = false;
            this.txt_r00.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r00.Location = new System.Drawing.Point(854, 202);
            this.txt_r00.Multiline = true;
            this.txt_r00.Name = "txt_r00";
            this.txt_r00.Size = new System.Drawing.Size(65, 24);
            this.txt_r00.TabIndex = 23;
            this.txt_r00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(754, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "A/B :";
            // 
            // txt_r21
            // 
            this.txt_r21.Enabled = false;
            this.txt_r21.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r21.Location = new System.Drawing.Point(943, 310);
            this.txt_r21.Multiline = true;
            this.txt_r21.Name = "txt_r21";
            this.txt_r21.Size = new System.Drawing.Size(64, 24);
            this.txt_r21.TabIndex = 32;
            this.txt_r21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_r01
            // 
            this.txt_r01.Enabled = false;
            this.txt_r01.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r01.Location = new System.Drawing.Point(943, 202);
            this.txt_r01.Multiline = true;
            this.txt_r01.Name = "txt_r01";
            this.txt_r01.Size = new System.Drawing.Size(64, 24);
            this.txt_r01.TabIndex = 24;
            this.txt_r01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_r20
            // 
            this.txt_r20.Enabled = false;
            this.txt_r20.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r20.Location = new System.Drawing.Point(854, 310);
            this.txt_r20.Multiline = true;
            this.txt_r20.Name = "txt_r20";
            this.txt_r20.Size = new System.Drawing.Size(65, 24);
            this.txt_r20.TabIndex = 31;
            this.txt_r20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_r02
            // 
            this.txt_r02.Enabled = false;
            this.txt_r02.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r02.Location = new System.Drawing.Point(1037, 202);
            this.txt_r02.Multiline = true;
            this.txt_r02.Name = "txt_r02";
            this.txt_r02.Size = new System.Drawing.Size(64, 24);
            this.txt_r02.TabIndex = 25;
            this.txt_r02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_r22
            // 
            this.txt_r22.Enabled = false;
            this.txt_r22.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r22.Location = new System.Drawing.Point(1037, 310);
            this.txt_r22.Multiline = true;
            this.txt_r22.Name = "txt_r22";
            this.txt_r22.Size = new System.Drawing.Size(64, 24);
            this.txt_r22.TabIndex = 33;
            this.txt_r22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_r03
            // 
            this.txt_r03.Enabled = false;
            this.txt_r03.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r03.Location = new System.Drawing.Point(1118, 202);
            this.txt_r03.Multiline = true;
            this.txt_r03.Name = "txt_r03";
            this.txt_r03.Size = new System.Drawing.Size(66, 24);
            this.txt_r03.TabIndex = 26;
            this.txt_r03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_r13
            // 
            this.txt_r13.Enabled = false;
            this.txt_r13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r13.Location = new System.Drawing.Point(1118, 257);
            this.txt_r13.Multiline = true;
            this.txt_r13.Name = "txt_r13";
            this.txt_r13.Size = new System.Drawing.Size(66, 24);
            this.txt_r13.TabIndex = 30;
            this.txt_r13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_r10
            // 
            this.txt_r10.Enabled = false;
            this.txt_r10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r10.Location = new System.Drawing.Point(854, 257);
            this.txt_r10.Multiline = true;
            this.txt_r10.Name = "txt_r10";
            this.txt_r10.Size = new System.Drawing.Size(65, 24);
            this.txt_r10.TabIndex = 27;
            this.txt_r10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_r23
            // 
            this.txt_r23.Enabled = false;
            this.txt_r23.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r23.Location = new System.Drawing.Point(1118, 310);
            this.txt_r23.Multiline = true;
            this.txt_r23.Name = "txt_r23";
            this.txt_r23.Size = new System.Drawing.Size(66, 24);
            this.txt_r23.TabIndex = 34;
            this.txt_r23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_r11
            // 
            this.txt_r11.Enabled = false;
            this.txt_r11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r11.Location = new System.Drawing.Point(943, 257);
            this.txt_r11.Multiline = true;
            this.txt_r11.Name = "txt_r11";
            this.txt_r11.Size = new System.Drawing.Size(64, 24);
            this.txt_r11.TabIndex = 28;
            this.txt_r11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_r12
            // 
            this.txt_r12.Enabled = false;
            this.txt_r12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_r12.Location = new System.Drawing.Point(1037, 257);
            this.txt_r12.Multiline = true;
            this.txt_r12.Name = "txt_r12";
            this.txt_r12.Size = new System.Drawing.Size(64, 24);
            this.txt_r12.TabIndex = 29;
            this.txt_r12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 642);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1255, 10);
            this.panel3.TabIndex = 24;
            // 
            // GaussElimination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 636);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GaussElimination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gauss Elimination";
            this.Load += new System.EventHandler(this.GaussElimination_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_00;
        private System.Windows.Forms.TextBox txt_01;
        private System.Windows.Forms.TextBox txt_02;
        private System.Windows.Forms.TextBox txt_03;
        private System.Windows.Forms.TextBox txt_10;
        private System.Windows.Forms.TextBox txt_11;
        private System.Windows.Forms.TextBox txt_12;
        private System.Windows.Forms.TextBox txt_13;
        private System.Windows.Forms.TextBox txt_23;
        private System.Windows.Forms.TextBox txt_22;
        private System.Windows.Forms.TextBox txt_21;
        private System.Windows.Forms.TextBox txt_20;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_r00;
        private System.Windows.Forms.TextBox txt_r01;
        private System.Windows.Forms.TextBox txt_r02;
        private System.Windows.Forms.TextBox txt_r03;
        private System.Windows.Forms.TextBox txt_r10;
        private System.Windows.Forms.TextBox txt_r11;
        private System.Windows.Forms.TextBox txt_r12;
        private System.Windows.Forms.TextBox txt_r23;
        private System.Windows.Forms.TextBox txt_r13;
        private System.Windows.Forms.TextBox txt_r22;
        private System.Windows.Forms.TextBox txt_r20;
        private System.Windows.Forms.TextBox txt_r21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_x3;
        private System.Windows.Forms.TextBox txt_x2;
        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.TextBox txt_m32;
        private System.Windows.Forms.TextBox txt_m31;
        private System.Windows.Forms.TextBox txt_m21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}