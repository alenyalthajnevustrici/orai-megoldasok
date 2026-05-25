using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Fuggohidak
{
    public partial class Form1 : Form
    {
        public static List<Fuggohid> lista = new List<Fuggohid>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Megnyitas_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lista.Clear();
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string elsosor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    Fuggohid sor = new Fuggohid(sr.ReadLine());
                    lista.Add(sor);
                    listBox1.Items.Add(sor.Hid);
                }
                sr.Dispose();
            }
        }

        private void ListBoxHidak_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hid = lista[listBox1.SelectedIndex];
            txbHely.Text = hid.Hely;
            txbOrszag.Text = hid.Orszag;
            txbHossz.Text = hid.Hossz.ToString();
            txbEv.Text = hid.Ev.ToString();
        }

        private void BtnKereses_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 keresesForm = new Form2();
            keresesForm.ShowDialog();
            keresesForm.Dispose();
            this.Show();
        }

        private void Kereses_Click(object sender, EventArgs e)
        {
            BtnKereses_Click(sender, e);
        }

        private void Kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdb2000Elott_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2000Elott.Checked)
            {
                var elotte = (from hid in lista
                              where hid.Ev < 2000
                              select hid).Count();
                labelStat.Text = $"2000 előtt épült hidak száma: {elotte}";
            }
        }

        private void rdb2000EsUtan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2000EsUtan.Checked)
            {
                var utana = (from hid in lista
                             where hid.Ev >= 2000
                             select hid).Count();
                labelStat.Text = $"2000-ben és utána épült hidak száma: {utana}";
            }
        }
    }

    public class Fuggohid
    {
        public string Helyezes { get; set; }
        public string Hid { get; set; }
        public string Hely { get; set; }
        public string Orszag { get; set; }
        public int Hossz { get; set; }
        public int Ev { get; set; }

        public Fuggohid(string sor)
        {
            string[] reszek = sor.Split('\t');
            Helyezes = reszek[0];
            Hid = reszek[1];
            Hely = reszek[2];
            Orszag = reszek[3];
            Hossz = Convert.ToInt32(reszek[4]);
            Ev = Convert.ToInt32(reszek[5]);
        }
    }
}