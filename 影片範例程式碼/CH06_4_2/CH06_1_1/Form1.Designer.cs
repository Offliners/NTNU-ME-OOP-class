namespace CH06_4_2
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
            this.btn_CatShout = new System.Windows.Forms.Button();
            this.btn_CatShout2 = new System.Windows.Forms.Button();
            this.btn_CatShout3 = new System.Windows.Forms.Button();
            this.txt_ShoutNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CatShout
            // 
            this.btn_CatShout.Location = new System.Drawing.Point(30, 29);
            this.btn_CatShout.Name = "btn_CatShout";
            this.btn_CatShout.Size = new System.Drawing.Size(75, 23);
            this.btn_CatShout.TabIndex = 0;
            this.btn_CatShout.Text = "咪咪";
            this.btn_CatShout.UseVisualStyleBackColor = true;
            this.btn_CatShout.Click += new System.EventHandler(this.btn_CatShout_Click);
            // 
            // btn_CatShout2
            // 
            this.btn_CatShout2.Location = new System.Drawing.Point(30, 75);
            this.btn_CatShout2.Name = "btn_CatShout2";
            this.btn_CatShout2.Size = new System.Drawing.Size(75, 23);
            this.btn_CatShout2.TabIndex = 1;
            this.btn_CatShout2.Text = "大肥貓";
            this.btn_CatShout2.UseVisualStyleBackColor = true;
            this.btn_CatShout2.Click += new System.EventHandler(this.btn_CatShout2_Click);
            // 
            // btn_CatShout3
            // 
            this.btn_CatShout3.Location = new System.Drawing.Point(30, 123);
            this.btn_CatShout3.Name = "btn_CatShout3";
            this.btn_CatShout3.Size = new System.Drawing.Size(75, 23);
            this.btn_CatShout3.TabIndex = 2;
            this.btn_CatShout3.Text = "凱蒂";
            this.btn_CatShout3.UseVisualStyleBackColor = true;
            this.btn_CatShout3.Click += new System.EventHandler(this.btn_CatShout3_Click);
            // 
            // txt_ShoutNum
            // 
            this.txt_ShoutNum.Location = new System.Drawing.Point(152, 49);
            this.txt_ShoutNum.Name = "txt_ShoutNum";
            this.txt_ShoutNum.Size = new System.Drawing.Size(100, 22);
            this.txt_ShoutNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "叫聲次數";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ShoutNum);
            this.Controls.Add(this.btn_CatShout3);
            this.Controls.Add(this.btn_CatShout2);
            this.Controls.Add(this.btn_CatShout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CatShout;
        private System.Windows.Forms.Button btn_CatShout2;
        private System.Windows.Forms.Button btn_CatShout3;
        private System.Windows.Forms.TextBox txt_ShoutNum;
        private System.Windows.Forms.Label label1;
    }
}

