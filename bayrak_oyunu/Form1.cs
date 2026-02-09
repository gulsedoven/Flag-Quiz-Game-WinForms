using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace bayrak_oyunu
{
    public partial class Form1: Form
    {
        List<string> flags = new List<string>();
        string chosenFlag;
        int totalQuestions = 0, totalCorrects = 0;

        void YeniBayrak()
        {
            Random r = new Random();
            int index = r.Next(0, flags.Count);
            chosenFlag = flags[index];
            Image image = Image.FromFile("Bayraklar/" + chosenFlag + ".png");

            bayrak_picturebox.Image = image;
            ListeyiOlustur();
        }
        void BayrakSec()
        {
            dogruulke_textbox.Text = chosenFlag;
            gonder_buton.Enabled = false;
            sonraki_buton.Enabled = true;
            if (chosenFlag == ulkeler_combobox.Text)
            {
                totalCorrects += 1;
            }
            totalQuestions += 1;
            PuanGuncelle();
            flags.Remove(chosenFlag);
            if (flags.Count == 0)
            {
                DialogResult result = MessageBox.Show("Doğru bilinen: " + puan_textbox.Text, "Oyun Bitti", MessageBoxButtons.OK);
                YeniOyun();
            }
        }

        void PuanGuncelle()
        {
            puan_textbox.Text = totalCorrects + "/" + totalQuestions;
        }

        void BayraklariAl()
        {
            string[] files = Directory.GetFiles("Bayraklar");
            foreach (string file in files)
                flags.Add(Path.GetFileNameWithoutExtension(file));
        }
        void ListeyiOlustur()
        {
            ulkeler_combobox.Items.Clear();
            ulkeler_combobox.Items.AddRange(flags.ToArray());
        }
        void YeniOyun()
        {
            gonder_buton.Enabled = true;
            sonraki_buton.Enabled = false;
            dogruulke_textbox.Text = "";
            ulkeler_combobox.Text = "";
            totalCorrects = totalQuestions = 0;
            PuanGuncelle();
            BayraklariAl();
            YeniBayrak();
        }

        private void gonder_buton_Click(object sender, EventArgs e)
        {
            BayrakSec();
        }
        
        private void sonraki_buton_Click(object sender, EventArgs e)
        {
            gonder_buton.Enabled = true;
            sonraki_buton.Enabled = false;
            dogruulke_textbox.Text = "";
            YeniBayrak();
        }

        public Form1()
        {
            InitializeComponent();
            YeniOyun();
        }

      
    }
}
