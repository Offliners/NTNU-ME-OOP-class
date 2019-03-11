namespace Ch05_03
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
            this.lbl_Point1X = new System.Windows.Forms.Label();
            this.lbl_Point1Y = new System.Windows.Forms.Label();
            this.txt_Point1X = new System.Windows.Forms.TextBox();
            this.txt_Point1Y = new System.Windows.Forms.TextBox();
            this.txt_Point2Y = new System.Windows.Forms.TextBox();
            this.txt_Point2X = new System.Windows.Forms.TextBox();
            this.lbl_Point2Y = new System.Windows.Forms.Label();
            this.lbl_Point2X = new System.Windows.Forms.Label();
            this.lbl_Point1 = new System.Windows.Forms.Label();
            this.lbl_Point2 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txt_Display = new System.Windows.Forms.TextBox();
            this.rbtn_Point1 = new System.Windows.Forms.RadioButton();
            this.rbtn_Point2 = new System.Windows.Forms.RadioButton();
            this.rbtn_TwoPoints = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Point1X
            // 
            this.lbl_Point1X.AutoSize = true;
            this.lbl_Point1X.Location = new System.Drawing.Point(26, 52);
            this.lbl_Point1X.Name = "lbl_Point1X";
            this.lbl_Point1X.Size = new System.Drawing.Size(13, 12);
            this.lbl_Point1X.TabIndex = 0;
            this.lbl_Point1X.Text = "X";
            // 
            // lbl_Point1Y
            // 
            this.lbl_Point1Y.AutoSize = true;
            this.lbl_Point1Y.Location = new System.Drawing.Point(26, 82);
            this.lbl_Point1Y.Name = "lbl_Point1Y";
            this.lbl_Point1Y.Size = new System.Drawing.Size(13, 12);
            this.lbl_Point1Y.TabIndex = 1;
            this.lbl_Point1Y.Text = "Y";
            // 
            // txt_Point1X
            // 
            this.txt_Point1X.Location = new System.Drawing.Point(59, 49);
            this.txt_Point1X.Name = "txt_Point1X";
            this.txt_Point1X.Size = new System.Drawing.Size(100, 22);
            this.txt_Point1X.TabIndex = 2;
            // 
            // txt_Point1Y
            // 
            this.txt_Point1Y.Location = new System.Drawing.Point(59, 79);
            this.txt_Point1Y.Name = "txt_Point1Y";
            this.txt_Point1Y.Size = new System.Drawing.Size(100, 22);
            this.txt_Point1Y.TabIndex = 3;
            // 
            // txt_Point2Y
            // 
            this.txt_Point2Y.Location = new System.Drawing.Point(232, 79);
            this.txt_Point2Y.Name = "txt_Point2Y";
            this.txt_Point2Y.Size = new System.Drawing.Size(100, 22);
            this.txt_Point2Y.TabIndex = 7;
            // 
            // txt_Point2X
            // 
            this.txt_Point2X.Location = new System.Drawing.Point(232, 49);
            this.txt_Point2X.Name = "txt_Point2X";
            this.txt_Point2X.Size = new System.Drawing.Size(100, 22);
            this.txt_Point2X.TabIndex = 6;
            // 
            // lbl_Point2Y
            // 
            this.lbl_Point2Y.AutoSize = true;
            this.lbl_Point2Y.Location = new System.Drawing.Point(199, 82);
            this.lbl_Point2Y.Name = "lbl_Point2Y";
            this.lbl_Point2Y.Size = new System.Drawing.Size(13, 12);
            this.lbl_Point2Y.TabIndex = 5;
            this.lbl_Point2Y.Text = "Y";
            // 
            // lbl_Point2X
            // 
            this.lbl_Point2X.AutoSize = true;
            this.lbl_Point2X.Location = new System.Drawing.Point(199, 52);
            this.lbl_Point2X.Name = "lbl_Point2X";
            this.lbl_Point2X.Size = new System.Drawing.Size(13, 12);
            this.lbl_Point2X.TabIndex = 4;
            this.lbl_Point2X.Text = "X";
            // 
            // lbl_Point1
            // 
            this.lbl_Point1.AutoSize = true;
            this.lbl_Point1.Location = new System.Drawing.Point(57, 22);
            this.lbl_Point1.Name = "lbl_Point1";
            this.lbl_Point1.Size = new System.Drawing.Size(53, 12);
            this.lbl_Point1.TabIndex = 8;
            this.lbl_Point1.Text = "第一個點";
            // 
            // lbl_Point2
            // 
            this.lbl_Point2.AutoSize = true;
            this.lbl_Point2.Location = new System.Drawing.Point(241, 22);
            this.lbl_Point2.Name = "lbl_Point2";
            this.lbl_Point2.Size = new System.Drawing.Size(53, 12);
            this.lbl_Point2.TabIndex = 9;
            this.lbl_Point2.Text = "第二個點";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(243, 77);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(61, 23);
            this.btn_Calculate.TabIndex = 12;
            this.btn_Calculate.Text = "計算";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txt_Display
            // 
            this.txt_Display.Location = new System.Drawing.Point(28, 235);
            this.txt_Display.Multiline = true;
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Display.Size = new System.Drawing.Size(304, 149);
            this.txt_Display.TabIndex = 13;
            // 
            // rbtn_Point1
            // 
            this.rbtn_Point1.AutoSize = true;
            this.rbtn_Point1.Location = new System.Drawing.Point(10, 25);
            this.rbtn_Point1.Name = "rbtn_Point1";
            this.rbtn_Point1.Size = new System.Drawing.Size(143, 16);
            this.rbtn_Point1.TabIndex = 15;
            this.rbtn_Point1.TabStop = true;
            this.rbtn_Point1.Text = "第一個點到原點的距離";
            this.rbtn_Point1.UseVisualStyleBackColor = true;
            // 
            // rbtn_Point2
            // 
            this.rbtn_Point2.AutoSize = true;
            this.rbtn_Point2.Location = new System.Drawing.Point(10, 47);
            this.rbtn_Point2.Name = "rbtn_Point2";
            this.rbtn_Point2.Size = new System.Drawing.Size(143, 16);
            this.rbtn_Point2.TabIndex = 16;
            this.rbtn_Point2.TabStop = true;
            this.rbtn_Point2.Text = "第二個點到原點的距離";
            this.rbtn_Point2.UseVisualStyleBackColor = true;
            // 
            // rbtn_TwoPoints
            // 
            this.rbtn_TwoPoints.AutoSize = true;
            this.rbtn_TwoPoints.Location = new System.Drawing.Point(10, 69);
            this.rbtn_TwoPoints.Name = "rbtn_TwoPoints";
            this.rbtn_TwoPoints.Size = new System.Drawing.Size(107, 16);
            this.rbtn_TwoPoints.TabIndex = 17;
            this.rbtn_TwoPoints.TabStop = true;
            this.rbtn_TwoPoints.Text = "兩點之間的距離";
            this.rbtn_TwoPoints.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_Point1);
            this.groupBox1.Controls.Add(this.rbtn_TwoPoints);
            this.groupBox1.Controls.Add(this.btn_Calculate);
            this.groupBox1.Controls.Add(this.rbtn_Point2);
            this.groupBox1.Location = new System.Drawing.Point(28, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請選擇";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Display);
            this.Controls.Add(this.lbl_Point2);
            this.Controls.Add(this.lbl_Point1);
            this.Controls.Add(this.txt_Point2Y);
            this.Controls.Add(this.txt_Point2X);
            this.Controls.Add(this.lbl_Point2Y);
            this.Controls.Add(this.lbl_Point2X);
            this.Controls.Add(this.txt_Point1Y);
            this.Controls.Add(this.txt_Point1X);
            this.Controls.Add(this.lbl_Point1Y);
            this.Controls.Add(this.lbl_Point1X);
            this.Name = "Form1";
            this.Text = "兩點之間的距離";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Point1X;
        private System.Windows.Forms.Label lbl_Point1Y;
        private System.Windows.Forms.TextBox txt_Point1X;
        private System.Windows.Forms.TextBox txt_Point1Y;
        private System.Windows.Forms.TextBox txt_Point2Y;
        private System.Windows.Forms.TextBox txt_Point2X;
        private System.Windows.Forms.Label lbl_Point2Y;
        private System.Windows.Forms.Label lbl_Point2X;
        private System.Windows.Forms.Label lbl_Point1;
        private System.Windows.Forms.Label lbl_Point2;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txt_Display;
        private System.Windows.Forms.RadioButton rbtn_Point1;
        private System.Windows.Forms.RadioButton rbtn_Point2;
        private System.Windows.Forms.RadioButton rbtn_TwoPoints;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

