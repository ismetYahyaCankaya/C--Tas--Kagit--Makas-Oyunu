using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class tasKagirMakasForm : Form
    {
        public tasKagirMakasForm()
        {
            InitializeComponent();
        }

        public int secim,skor=0,skorPc=0;

        

        public void tkmpc() 
        {
            Random rastgele=new Random();
            secim=rastgele.Next(3);
            if (secim == 0) { tkmPic.ImageLocation = "C:\\Users\\yahya\\Desktop\\ödev-1\\TasKagitMakas\\TasKagitMakas\\resimler\\tas.png"; }
            else if (secim == 1) { tkmPic.ImageLocation = "C:\\Users\\yahya\\Desktop\\ödev-1\\TasKagitMakas\\TasKagitMakas\\resimler\\kagit.png"; }
            else { tkmPic.ImageLocation = "C:\\Users\\yahya\\Desktop\\ödev-1\\TasKagitMakas\\TasKagitMakas\\resimler\\makas.png"; }
        }
        public void skorYenile()
        {
            skorLabel.Text = "Oyuncu Skor: " + skor.ToString();
            skorPcLabel.Text = "Pc Skor: " + skorPc.ToString();
        }
        public void kontrol() 
        {
            skorYenile();
            if (skor==100 || skorPc == 100) 
            {
                if (skor == 100){MessageBox.Show("Oyuncu Kazandı.");}
                else { MessageBox.Show("Pc Kazandı."); }
                skor = 0; skorPc = 0;
            }      
        }
        private void secimTas_Click(object sender, EventArgs e)
        {
            tkmpc();
            if (secim == 0){durumLabel.Text = "Beraberlik.";}
            else if (secim == 1){durumLabel.Text = "Oyuncu Kazandı"; skor += 10;}
            else{durumLabel.Text = "PC Kazandı."; skorPc += 10;}
            kontrol();
        }

        private void secimKagit_Click(object sender, EventArgs e)
        {
            tkmpc();
            if (secim == 0) {durumLabel.Text = "Oyuncu Kazandı"; skor += 10;}
            else if (secim == 1) {durumLabel.Text = "Beraberlik.";}
            else {durumLabel.Text = "PC Kazandı."; skorPc += 10;}
            kontrol();
        }

        private void secimMakas_Click(object sender, EventArgs e)
        {
            tkmpc();
            if (secim == 0) {durumLabel.Text = "PC Kazandı."; skorPc += 10;}
            else if (secim == 1) {durumLabel.Text = "Oyuncu Kazandı"; skor += 10;}
            else {durumLabel.Text = "Beraberlik.";}
            kontrol();
        }


    }
}
