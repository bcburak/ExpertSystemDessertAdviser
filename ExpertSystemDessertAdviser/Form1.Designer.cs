
namespace ExpertSystemDessertAdviser
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Evet Lütfen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yemek yanında tatlı ister misin?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userDropdown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(657, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 66);
            this.panel1.TabIndex = 2;
            // 
            // userDropdown
            // 
            this.userDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userDropdown.FormattingEnabled = true;
            this.userDropdown.Location = new System.Drawing.Point(54, 17);
            this.userDropdown.Name = "userDropdown";
            this.userDropdown.Size = new System.Drawing.Size(161, 28);
            this.userDropdown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox userDropdown;
        private System.Windows.Forms.Label label2;
    }
}

