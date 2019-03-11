namespace CH06_5_1
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
            this.txt_ShoutNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_AmoutOfCats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CatName = new System.Windows.Forms.TextBox();
            this.btn_Contest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ShoutNum
            // 
            this.txt_ShoutNum.Location = new System.Drawing.Point(152, 33);
            this.txt_ShoutNum.Name = "txt_ShoutNum";
            this.txt_ShoutNum.Size = new System.Drawing.Size(100, 22);
            this.txt_ShoutNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "叫聲次數";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_AmoutOfCats);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_SignUp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_CatName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ShoutNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "貓咪叫聲大賽報名";
            // 
            // txt_AmoutOfCats
            // 
            this.txt_AmoutOfCats.Location = new System.Drawing.Point(154, 135);
            this.txt_AmoutOfCats.Name = "txt_AmoutOfCats";
            this.txt_AmoutOfCats.Size = new System.Drawing.Size(98, 22);
            this.txt_AmoutOfCats.TabIndex = 9;
            this.txt_AmoutOfCats.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "已報名貓數";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(152, 76);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(100, 23);
            this.btn_SignUp.TabIndex = 7;
            this.btn_SignUp.Text = "報名";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "名字";
            // 
            // txt_CatName
            // 
            this.txt_CatName.Location = new System.Drawing.Point(8, 33);
            this.txt_CatName.Name = "txt_CatName";
            this.txt_CatName.Size = new System.Drawing.Size(100, 22);
            this.txt_CatName.TabIndex = 5;
            // 
            // btn_Contest
            // 
            this.btn_Contest.Location = new System.Drawing.Point(109, 215);
            this.btn_Contest.Name = "btn_Contest";
            this.btn_Contest.Size = new System.Drawing.Size(75, 23);
            this.btn_Contest.TabIndex = 6;
            this.btn_Contest.Text = "開始比賽";
            this.btn_Contest.UseVisualStyleBackColor = true;
            this.btn_Contest.Click += new System.EventHandler(this.btn_Contest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Contest);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "貓咪叫聲大賽";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ShoutNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_AmoutOfCats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CatName;
        private System.Windows.Forms.Button btn_Contest;
    }
}

