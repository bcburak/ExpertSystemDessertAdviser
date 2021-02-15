
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
            this.btnAdvice1 = new System.Windows.Forms.Button();
            this.btnAdvice2 = new System.Windows.Forms.Button();
            this.btnAdvice3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdvice1
            // 
            this.btnAdvice1.Location = new System.Drawing.Point(98, 124);
            this.btnAdvice1.Name = "btnAdvice1";
            this.btnAdvice1.Size = new System.Drawing.Size(244, 114);
            this.btnAdvice1.TabIndex = 0;
            this.btnAdvice1.Text = "advise1";
            this.btnAdvice1.UseVisualStyleBackColor = true;
            this.btnAdvice1.Click += new System.EventHandler(this.btnAdvice1_Click);
            // 
            // btnAdvice2
            // 
            this.btnAdvice2.Location = new System.Drawing.Point(369, 124);
            this.btnAdvice2.Name = "btnAdvice2";
            this.btnAdvice2.Size = new System.Drawing.Size(252, 114);
            this.btnAdvice2.TabIndex = 1;
            this.btnAdvice2.Text = "advise2";
            this.btnAdvice2.UseVisualStyleBackColor = true;
            this.btnAdvice2.Click += new System.EventHandler(this.btnAdvice2_Click);
            // 
            // btnAdvice3
            // 
            this.btnAdvice3.Location = new System.Drawing.Point(652, 126);
            this.btnAdvice3.Name = "btnAdvice3";
            this.btnAdvice3.Size = new System.Drawing.Size(258, 112);
            this.btnAdvice3.TabIndex = 2;
            this.btnAdvice3.Text = "advise3";
            this.btnAdvice3.UseVisualStyleBackColor = true;
            this.btnAdvice3.Click += new System.EventHandler(this.btnAdvice3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(62, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sizin için belirlediğimiz öneriler bunlar.Hangisini seçmek istersiniz?";
            // 
            // AdviserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdvice3);
            this.Controls.Add(this.btnAdvice2);
            this.Controls.Add(this.btnAdvice1);
            this.Name = "AdviserForm";
            this.Text = "Öneri Seçimi";
            this.Load += new System.EventHandler(this.AdviserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdvice1;
        private System.Windows.Forms.Button btnAdvice2;
        private System.Windows.Forms.Button btnAdvice3;
        private System.Windows.Forms.Label label1;
    }
}