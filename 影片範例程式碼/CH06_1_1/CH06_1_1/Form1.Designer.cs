﻿namespace CH06_1_1
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
            this.SuspendLayout();
            // 
            // btn_CatShout
            // 
            this.btn_CatShout.Location = new System.Drawing.Point(30, 29);
            this.btn_CatShout.Name = "btn_CatShout";
            this.btn_CatShout.Size = new System.Drawing.Size(75, 23);
            this.btn_CatShout.TabIndex = 0;
            this.btn_CatShout.Text = "貓叫";
            this.btn_CatShout.UseVisualStyleBackColor = true;
            this.btn_CatShout.Click += new System.EventHandler(this.btn_CatShout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_CatShout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CatShout;
    }
}

