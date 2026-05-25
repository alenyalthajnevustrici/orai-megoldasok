namespace Fuggohidak
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnKeres = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.labelOrszag = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(107, 86);
            this.btnKeres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(120, 37);
            this.btnKeres.TabIndex = 1;
            this.btnKeres.Text = "Keresés";
            this.btnKeres.UseVisualStyleBackColor = true;
            this.btnKeres.Click += new System.EventHandler(this.BtnKeres_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(253, 86);
            this.btnBezar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(120, 37);
            this.btnBezar.TabIndex = 2;
            this.btnBezar.Text = "Bezárás";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.BtnBezar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 196);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(357, 245);
            this.richTextBox1.TabIndex = 3;
            // 
            // labelOrszag
            // 
            this.labelOrszag.AutoSize = true;
            this.labelOrszag.Location = new System.Drawing.Point(16, 41);
            this.labelOrszag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrszag.Name = "labelOrszag";
            this.labelOrszag.Size = new System.Drawing.Size(58, 17);
            this.labelOrszag.TabIndex = 4;
            this.labelOrszag.Text = "Ország:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 151);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "1 km-nél hosszabbak";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 457);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelOrszag);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Keresés ország szerint";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.Label labelOrszag;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}