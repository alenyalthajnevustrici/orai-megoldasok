
namespace Fuggohidak
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelHely = new System.Windows.Forms.Label();
            this.txbHely = new System.Windows.Forms.TextBox();
            this.labelOrszag = new System.Windows.Forms.Label();
            this.txbOrszag = new System.Windows.Forms.TextBox();
            this.labelHossz = new System.Windows.Forms.Label();
            this.txbHossz = new System.Windows.Forms.TextBox();
            this.labelEv = new System.Windows.Forms.Label();
            this.txbEv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStat = new System.Windows.Forms.Label();
            this.rdb2000EsUtan = new System.Windows.Forms.RadioButton();
            this.rdb2000Elott = new System.Windows.Forms.RadioButton();
            this.btnKereses = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.keresésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitásToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás...";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.Megnyitas_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.Kilepes_Click);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.Kereses_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(10, 40);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 372);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBoxHidak_SelectedIndexChanged);
            // 
            // labelHely
            // 
            this.labelHely.AutoSize = true;
            this.labelHely.Location = new System.Drawing.Point(309, 41);
            this.labelHely.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHely.Name = "labelHely";
            this.labelHely.Size = new System.Drawing.Size(40, 17);
            this.labelHely.TabIndex = 4;
            this.labelHely.Text = "Hely:";
            // 
            // txbHely
            // 
            this.txbHely.Location = new System.Drawing.Point(313, 61);
            this.txbHely.Margin = new System.Windows.Forms.Padding(4);
            this.txbHely.Name = "txbHely";
            this.txbHely.ReadOnly = true;
            this.txbHely.Size = new System.Drawing.Size(273, 22);
            this.txbHely.TabIndex = 5;
            // 
            // labelOrszag
            // 
            this.labelOrszag.AutoSize = true;
            this.labelOrszag.Location = new System.Drawing.Point(309, 99);
            this.labelOrszag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrszag.Name = "labelOrszag";
            this.labelOrszag.Size = new System.Drawing.Size(58, 17);
            this.labelOrszag.TabIndex = 6;
            this.labelOrszag.Text = "Ország:";
            // 
            // txbOrszag
            // 
            this.txbOrszag.Location = new System.Drawing.Point(313, 118);
            this.txbOrszag.Margin = new System.Windows.Forms.Padding(4);
            this.txbOrszag.Name = "txbOrszag";
            this.txbOrszag.ReadOnly = true;
            this.txbOrszag.Size = new System.Drawing.Size(273, 22);
            this.txbOrszag.TabIndex = 7;
            // 
            // labelHossz
            // 
            this.labelHossz.AutoSize = true;
            this.labelHossz.Location = new System.Drawing.Point(309, 154);
            this.labelHossz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHossz.Name = "labelHossz";
            this.labelHossz.Size = new System.Drawing.Size(51, 17);
            this.labelHossz.TabIndex = 8;
            this.labelHossz.Text = "Hossz:";
            // 
            // txbHossz
            // 
            this.txbHossz.Location = new System.Drawing.Point(313, 174);
            this.txbHossz.Margin = new System.Windows.Forms.Padding(4);
            this.txbHossz.Name = "txbHossz";
            this.txbHossz.ReadOnly = true;
            this.txbHossz.Size = new System.Drawing.Size(273, 22);
            this.txbHossz.TabIndex = 9;
            // 
            // labelEv
            // 
            this.labelEv.AutoSize = true;
            this.labelEv.Location = new System.Drawing.Point(309, 206);
            this.labelEv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEv.Name = "labelEv";
            this.labelEv.Size = new System.Drawing.Size(28, 17);
            this.labelEv.TabIndex = 10;
            this.labelEv.Text = "Év:";
            // 
            // txbEv
            // 
            this.txbEv.Location = new System.Drawing.Point(313, 226);
            this.txbEv.Margin = new System.Windows.Forms.Padding(4);
            this.txbEv.Name = "txbEv";
            this.txbEv.ReadOnly = true;
            this.txbEv.Size = new System.Drawing.Size(273, 22);
            this.txbEv.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelStat);
            this.groupBox1.Controls.Add(this.rdb2000EsUtan);
            this.groupBox1.Controls.Add(this.rdb2000Elott);
            this.groupBox1.Location = new System.Drawing.Point(305, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(281, 136);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Építés ideje";
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Location = new System.Drawing.Point(7, 95);
            this.labelStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(0, 17);
            this.labelStat.TabIndex = 17;
            // 
            // rdb2000EsUtan
            // 
            this.rdb2000EsUtan.AutoSize = true;
            this.rdb2000EsUtan.Location = new System.Drawing.Point(8, 52);
            this.rdb2000EsUtan.Margin = new System.Windows.Forms.Padding(4);
            this.rdb2000EsUtan.Name = "rdb2000EsUtan";
            this.rdb2000EsUtan.Size = new System.Drawing.Size(267, 21);
            this.rdb2000EsUtan.TabIndex = 1;
            this.rdb2000EsUtan.TabStop = true;
            this.rdb2000EsUtan.Text = "2000-ben és utána épült hidak száma";
            this.rdb2000EsUtan.UseVisualStyleBackColor = true;
            this.rdb2000EsUtan.CheckedChanged += new System.EventHandler(this.rdb2000EsUtan_CheckedChanged);
            // 
            // rdb2000Elott
            // 
            this.rdb2000Elott.AutoSize = true;
            this.rdb2000Elott.Location = new System.Drawing.Point(8, 23);
            this.rdb2000Elott.Margin = new System.Windows.Forms.Padding(4);
            this.rdb2000Elott.Name = "rdb2000Elott";
            this.rdb2000Elott.Size = new System.Drawing.Size(210, 21);
            this.rdb2000Elott.TabIndex = 0;
            this.rdb2000Elott.TabStop = true;
            this.rdb2000Elott.Text = "2000 előtt épült hidak száma";
            this.rdb2000Elott.UseVisualStyleBackColor = true;
            this.rdb2000Elott.CheckedChanged += new System.EventHandler(this.rdb2000Elott_CheckedChanged);
            // 
            // btnKereses
            // 
            this.btnKereses.Location = new System.Drawing.Point(10, 443);
            this.btnKereses.Margin = new System.Windows.Forms.Padding(4);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(267, 37);
            this.btnKereses.TabIndex = 15;
            this.btnKereses.Text = "Keresés az országok között";
            this.btnKereses.UseVisualStyleBackColor = true;
            this.btnKereses.Click += new System.EventHandler(this.BtnKereses_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(319, 443);
            this.btnKilepes.Margin = new System.Windows.Forms.Padding(4);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(267, 37);
            this.btnKilepes.TabIndex = 16;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.Kilepes_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Válassza ki a függőhidak CSV fájlját";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 494);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnKereses);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbEv);
            this.Controls.Add(this.labelEv);
            this.Controls.Add(this.txbHossz);
            this.Controls.Add(this.labelHossz);
            this.Controls.Add(this.txbOrszag);
            this.Controls.Add(this.labelOrszag);
            this.Controls.Add(this.txbHely);
            this.Controls.Add(this.labelHely);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Függőhidak nyilvántartása";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label labelHely;
    private System.Windows.Forms.TextBox txbHely;
    private System.Windows.Forms.Label labelOrszag;
    private System.Windows.Forms.TextBox txbOrszag;
    private System.Windows.Forms.Label labelHossz;
    private System.Windows.Forms.TextBox txbHossz;
    private System.Windows.Forms.Label labelEv;
    private System.Windows.Forms.TextBox txbEv;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rdb2000EsUtan;
    private System.Windows.Forms.RadioButton rdb2000Elott;
    private System.Windows.Forms.Button btnKereses;
    private System.Windows.Forms.Button btnKilepes;
    private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}