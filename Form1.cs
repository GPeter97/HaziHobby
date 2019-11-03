using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HobbyHazi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void UjHobby()
        {
            string ad = hobbybox.Text;
            listBox1.Items.Add(ad);
        }

        private void HozzadasG_Click(object sender, EventArgs e)
        {
            UjHobby();
        }
        public void AdatokMetese()
        {
            string nem = "";
            if (ferfi.Checked)
            {
                nem = "Férfi";
            }
            if (no.Checked)
            {
                nem = "Nő";
            }
            string textbox = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                textbox += listBox1.Items[i] + ",";
            }
            int kedvenchobby = listBox1.SelectedIndex;
            textbox = textbox.TrimEnd(',');
            string ertek = "";
            ertek += nevbox.Text + ";" + nem + ";" + dateTimePicker1.Value + ";" + kedvenchobby + ";" + textbox;
            DialogResult eredmeny = SaveFileDialog.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string file_nev;
                file_nev = SaveFileDialog.FileName;
                using (var file = File.CreateText(file_nev))
                {
                    file.Write(ertek);
                }
            }
        }

        private void MentesG_Click(object sender, EventArgs e)
        {
            AdatokMetese();
        }
        public void AdatokBetoltese()
        {
            DialogResult eredmeny = OpenFileDialog.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string file_nave = OpenFileDialog.FileName;
                using (var file = File.OpenText(file_nave))
                {
                    string sor = file.ReadLine();
                    string[] adatok = sor.Split(';');
                    string[] hobbik = adatok[adatok.Length - 1].Split(',');
                    nevbox.Text = adatok[0];
                    DateTime asd;

                    if (DateTime.TryParse(adatok[2], out asd) == true)
                    {
                        dateTimePicker1.Value = asd;
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Today;
                    }
                    if (adatok[1] == "Ferfi")
                    {
                        ferfi.Checked = true;
                        no.Checked = false;
                    }
                    else
                    {
                        ferfi.Checked = false;
                        no.Checked = true;
                    }

                    listBox1.Items.Clear();
                    for (int i = 0; i < hobbik.Length; i++)
                    {
                        listBox1.Items.Add(hobbik[i]);
                    }
                    listBox1.SetSelected(int.Parse(adatok[3]), true);
                }
            }

        }

        private void BetoltesG_Click(object sender, EventArgs e)
        {
            AdatokBetoltese();
        }
      
    }
}
