namespace CH06_2_1
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_CatShout3);
            this.Controls.Add(this.btn_CatShout2);
            this.Controls.Add(this.btn_CatShout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CatShout;
        private System.Windows.Forms.Button btn_CatShout2;
        private System.Windows.Forms.Button btn_CatShout3;
    }
}

