namespace CH07_5_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Real1 = new System.Windows.Forms.TextBox();
            this.txt_Imag1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Real2 = new System.Windows.Forms.TextBox();
            this.txt_Imag2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Real3 = new System.Windows.Forms.TextBox();
            this.txt_Imag3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_Real4 = new System.Windows.Forms.TextBox();
            this.txt_Imag4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "實部";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "虛部";
            // 
            // txt_Real1
            // 
            this.txt_Real1.Location = new System.Drawing.Point(64, 20);
            this.txt_Real1.Name = "txt_Real1";
            this.txt_Real1.Size = new System.Drawing.Size(100, 22);
            this.txt_Real1.TabIndex = 2;
            this.txt_Real1.Text = "0";
            // 
            // txt_Imag1
            // 
            this.txt_Imag1.Location = new System.Drawing.Point(264, 20);
            this.txt_Imag1.Name = "txt_Imag1";
            this.txt_Imag1.Size = new System.Drawing.Size(100, 22);
            this.txt_Imag1.TabIndex = 3;
            this.txt_Imag1.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Real1);
            this.groupBox1.Controls.Add(this.txt_Imag1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第一個複數";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(12, 225);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 5;
            this.btn_Calculate.Text = "計算";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Result);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 157);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "計算結果";
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(17, 34);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Result.Size = new System.Drawing.Size(347, 106);
            this.txt_Result.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Real2);
            this.groupBox3.Controls.Add(this.txt_Imag2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 48);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "第二個複數";
            // 
            // txt_Real2
            // 
            this.txt_Real2.Location = new System.Drawing.Point(64, 20);
            this.txt_Real2.Name = "txt_Real2";
            this.txt_Real2.Size = new System.Drawing.Size(100, 22);
            this.txt_Real2.TabIndex = 2;
            this.txt_Real2.Text = "0";
            // 
            // txt_Imag2
            // 
            this.txt_Imag2.Location = new System.Drawing.Point(264, 20);
            this.txt_Imag2.Name = "txt_Imag2";
            this.txt_Imag2.Size = new System.Drawing.Size(100, 22);
            this.txt_Imag2.TabIndex = 3;
            this.txt_Imag2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "實部";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "虛部";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_Real3);
            this.groupBox4.Controls.Add(this.txt_Imag3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 48);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "第三個複數";
            // 
            // txt_Real3
            // 
            this.txt_Real3.Location = new System.Drawing.Point(64, 20);
            this.txt_Real3.Name = "txt_Real3";
            this.txt_Real3.Size = new System.Drawing.Size(100, 22);
            this.txt_Real3.TabIndex = 2;
            this.txt_Real3.Text = "0";
            // 
            // txt_Imag3
            // 
            this.txt_Imag3.Location = new System.Drawing.Point(264, 20);
            this.txt_Imag3.Name = "txt_Imag3";
            this.txt_Imag3.Size = new System.Drawing.Size(100, 22);
            this.txt_Imag3.TabIndex = 3;
            this.txt_Imag3.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "實部";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "虛部";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_Real4);
            this.groupBox5.Controls.Add(this.txt_Imag4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 171);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(406, 48);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "第四個複數";
            // 
            // txt_Real4
            // 
            this.txt_Real4.Location = new System.Drawing.Point(64, 20);
            this.txt_Real4.Name = "txt_Real4";
            this.txt_Real4.Size = new System.Drawing.Size(100, 22);
            this.txt_Real4.TabIndex = 2;
            this.txt_Real4.Text = "0";
            // 
            // txt_Imag4
            // 
            this.txt_Imag4.Location = new System.Drawing.Point(264, 20);
            this.txt_Imag4.Name = "txt_Imag4";
            this.txt_Imag4.Size = new System.Drawing.Size(100, 22);
            this.txt_Imag4.TabIndex = 3;
            this.txt_Imag4.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "實部";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "虛部";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 445);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "複數相乘";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Real1;
        private System.Windows.Forms.TextBox txt_Imag1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Real2;
        private System.Windows.Forms.TextBox txt_Imag2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_Real3;
        private System.Windows.Forms.TextBox txt_Imag3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_Real4;
        private System.Windows.Forms.TextBox txt_Imag4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

