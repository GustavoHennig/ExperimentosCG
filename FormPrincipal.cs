/* 
 * 
 * Autores: 
 * Gustavo Augusto Hennig
 * 
 * Junho de 2008
 * 
 * Distribuído sob os termos da licença GPL.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using ZedGraph;

namespace Trab2_CG
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private Bitmap ImagemEmEscalaCinza;
        private Histograma h = new Histograma();

        private bool mostroumsg = false;
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            if (!mostroumsg)
            {
                MessageBox.Show("O software aceita imagens coloridas, porém serão exibidas somente em escala de cinza.\n(Serão convertidas automaticamente)");
                mostroumsg = true;
            }
            FileDialog fd = new OpenFileDialog();
            fd.Filter = "Arquivos de Imagem (*.jpg;*.jpeg;*.bmp;*.gif;*.png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
            fd.ShowDialog();

            if (fd.FileName != null && File.Exists(fd.FileName))
            {
                AbrirImagem(fd.FileName);
            }

        }

        private void AbrirImagem(string p)
        {
            pictureBox1.Image = Image.FromFile(p);
            ConverteParaCinzaMontaHistograma();

        }
        public Dictionary<Color, long> histograma = new Dictionary<Color, long>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = (Bitmap)this.ImagemEmEscalaCinza.Clone();
            }
            catch (Exception) { 
            
            }
        }

        Graphics grph;


        public void AddHistograma(Color c)
        {
            if (histograma.ContainsKey(c))
            {
                histograma[c]++;
            }
            else
            {
                histograma.Add(c, 1);
            }
        }

        public Color ConverterPB(Color c)
        {

            /*
             verde representa 59% da luminosidade percebida, 
             * enquanto que o vermelho e o 
             * azul representam apenas 30% e 11%, respectivamente.
             */
            if (c.R == c.G && c.G == c.B)
            {
                return c;
            }


            decimal dcor = Convert.ToDecimal(c.G * 0.59);
            dcor += Convert.ToDecimal(c.R * .3);
            dcor += Convert.ToDecimal(c.B * .11);

            int cor = Convert.ToInt32(dcor);

            Color cc;//= new Color();
            if (cor > 255) { cor = 255; }

            cc = Color.FromArgb(((int)(byte)cor), ((int)(byte)cor), ((int)(byte)cor));
            ////cc.se
            //  //  bru

            //cc.R = Convert.ToByte(cor);
            //cc.G = Convert.ToByte(cor);
            //cc.B = Convert.ToByte(cor);
            // c.GetBrightness

            return cc;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }


        void ConverteParaCinzaMontaHistograma()
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            histograma.Clear();

            //pictureBox1.Image.f
            //b.Flags
            progressBar1.Maximum = (int)(b.Height * b.Width / 1024);
            progressBar1.Value = 0;
            long cnt = 0;


            for (int v = 0; v < b.Height; v++)
            {
                for (int h = 0; h < b.Width; h++)
                {
                    b.SetPixel(h, v, ConverterPB(b.GetPixel(h, v)));
                    AddHistograma(b.GetPixel(h, v));
                    cnt++;
                    if (cnt == 1024)
                    {
                        cnt = 0;
                        progressBar1.Value++;
                    }

                }
            }
            //foreach(Point p in pictureBox1.Image.

            ImagemEmEscalaCinza = b;
            pictureBox1.Image = (Image)b.Clone();
            //MessageBox.Show(histograma.Count.ToString());
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Update();
        }

        private void bntAplLimiar_Click(object sender, EventArgs e)
        {

            try
            {
                trackBar1.Value = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception) {
                MessageBox.Show("Você informou um valor inválido, digite números entre 0 e 255");
                return;
            
            
            }


            if (trackBar1.Value < 0 || trackBar1.Value > 255)
            {
                MessageBox.Show("Um erro estranho aconteceu, altere o valor da barra e tente novamente.");
            }
            else
            {

                AplicaLimiar((int)trackBar1.Value);
            }
        }

        void AplicaLimiar(int limiar)
        {

            byte l = (byte)limiar;



            if (ImagemEmEscalaCinza == null)
            {
                MessageBox.Show("Deu um baita erro, clique nuns botões aí pra ver se resolve, hehe!");
                return;
            }

            Bitmap b = (Bitmap)ImagemEmEscalaCinza.Clone();// new Bitmap(pictureBox1.Image);

            //pictureBox1.Image.f
            //b.Flags
            progressBar1.Maximum = (int)(b.Height * b.Width / 1024);
            progressBar1.Value = 0;
            long cnt = 0;


            for (int v = 0; v < b.Height; v++)
            {
                for (int h = 0; h < b.Width; h++)
                {
                    b.SetPixel(h, v, getLimiatedCollor(b.GetPixel(h, v), limiar));

                    cnt++;
                    if (cnt == 1024)
                    {
                        cnt = 0;
                        progressBar1.Value++;
                    }

                }
            }

            //foreach(Point p in pictureBox1.Image.

            //ImagemEmEscalaCinza = b;
            pictureBox1.Image = (Image)b.Clone();





            if (!this.h.IsDisposed)
            {
                this.h.AtualizaGraficoHistograma(histograma, limiar);
            }




            //MessageBox.Show(histograma.Count.ToString());
        }

        private Color getLimiatedCollor(Color c, int limiar)
        {

            if ((int)c.R > limiar)
            {
                return Color.White;
            }
            else
            {
                return Color.Black;
            }
        }

        private void picGraph_Paint(object sender, PaintEventArgs e)
        {

            grph = e.Graphics;
        }



        private void btnShowHist_Click(object sender, EventArgs e)
        {
            if (h.IsDisposed)
            {
                h = new Histograma();
            }
            h.Show();
            h.AtualizaGraficoHistograma(histograma, 500);


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkAutoAplicar.Checked)
            {
                bntAplLimiar_Click(sender, null);
            }
        }

        private void trackBar1_KeyUp(object sender, KeyEventArgs e)
        {
            if (chkAutoAplicar.Checked)
            {
                bntAplLimiar_Click(sender, null);
            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            FileDialog fd = new SaveFileDialog();
            fd.AddExtension  = true;
            fd.Filter = "Arquivos PNG (*.png)|*.png";
            fd.ShowDialog();

            if (fd.FileName != null)
            {
                SalvarImagem(fd.FileName);
            }

        }

        private void SalvarImagem(string p)
        {
            try
            {
                pictureBox1.Image.Save(p);
            }
            catch (Exception e) {
                MessageBox.Show("Não foi possível salvar a imagem: " + e.Message);
            }
        }
    }
}
