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
            this.cbox_Select = new System.Windows.Forms.ComboBox();
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
            this.btn_Calculate.Location = new System.Drawing.Point(271, 123);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(61, 23);
            this.btn_Calculate.TabIndex = 12;
            this.btn_Calculate.Text = "計算";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txt_Display
            // 
            this.txt_Display.Location = new System.Drawing.Point(59, 207);
            this.txt_Display.Multiline = true;
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Display.Size = new System.Drawing.Size(273, 128);
            this.txt_Display.TabIndex = 13;
            // 
            // cbox_Select
            // 
            this.cbox_Select.FormattingEnabled = true;
            this.cbox_Select.Items.AddRange(new object[] {
            "第一個點到原點的距離",
            "第二個點到原點的距離",
            "兩點之間的距離"});
            this.cbox_Select.Location = new System.Drawing.Point(28, 123);
            this.cbox_Select.Name = "cbox_Select";
            this.cbox_Select.Size = new System.Drawing.Size(213, 20);
            this.cbox_Select.TabIndex = 14;
            this.cbox_Select.Text = "請選擇";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 396);
            this.Controls.Add(this.cbox_Select);
            this.Controls.Add(this.txt_Display);
            this.Controls.Add(this.btn_Calculate);
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
        private System.Windows.Forms.ComboBox cbox_Select;
    }
}

