using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fuggohidak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var orszagok = (from h in Form1.lista
                            orderby h.Orszag
                            select h.Orszag).Distinct();

            foreach (var item in orszagok)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void BtnKeres_Click(object sender, EventArgs e)
        {
            string kivalasztottOrszag = comboBox1.SelectedItem.ToString();

            var talaltHidak = from hid in Form1.lista
                              where hid.Orszag == kivalasztottOrszag
                              orderby hid.Helyezes
                              select hid;

			var talaltHidak1nelHosszabb = from hid in Form1.lista
							  where hid.Orszag == kivalasztottOrszag
                              where hid.Hossz > 1000
							  orderby hid.Helyezes
							  select hid;
            
            richTextBox1.Clear();

            if (checkBox1.Checked)
            {
                if (talaltHidak1nelHosszabb.Any())
                {
				    foreach (var item in talaltHidak1nelHosszabb)
				    {
					    richTextBox1.Text += $"{item.Hid}\r\n";
				    }
                }
                else
                {
					richTextBox1.Text = "Nincs találat.";
				}
			}
            else
            {
                foreach (var item in talaltHidak)
				    {
					    richTextBox1.Text += $"{item.Hid}\r\n";
				    }				
			}
        }

        private void BtnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}