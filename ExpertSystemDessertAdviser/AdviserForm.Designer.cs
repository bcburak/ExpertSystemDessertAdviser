﻿
namespace ExpertSystemDessertAdviser
{
    partial class AdviserForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 114);
            this.button1.TabIndex = 0;
            this.button1.Text = "advise1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 111);
            this.button2.TabIndex = 1;
            this.button2.Text = "advise2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 111);
            this.button3.TabIndex = 2;
            this.button3.Text = "advise3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(62, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sizin için belirlediğimiz öneriler bunlar.Hangisini seçmek istersiniz?";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(444, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Yenile ???";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AdviserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 536);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdviserForm";
            this.Text = "Öneri Seçimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}