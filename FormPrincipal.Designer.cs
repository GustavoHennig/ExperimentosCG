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

namespace ExperimentosCG
{
    partial class FormPrincipal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.bntAplLimiar = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkAutoAplicar = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnShowHist = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiltroRabiscar = new System.Windows.Forms.Button();
            this.numRaio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRaio)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(4, 34);
            this.btnOpenImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(117, 35);
            this.btnOpenImage.TabIndex = 1;
            this.btnOpenImage.Text = "Abrir Imagem";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(18, 169);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 773);
            this.panel1.TabIndex = 2;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(4, 75);
            this.btnOriginal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(206, 35);
            this.btnOriginal.TabIndex = 3;
            this.btnOriginal.Text = "Mostra Imagem Original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntAplLimiar
            // 
            this.bntAplLimiar.Location = new System.Drawing.Point(134, 102);
            this.bntAplLimiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntAplLimiar.Name = "bntAplLimiar";
            this.bntAplLimiar.Size = new System.Drawing.Size(153, 34);
            this.bntAplLimiar.TabIndex = 4;
            this.bntAplLimiar.Text = "Aplica Limiar";
            this.bntAplLimiar.UseVisualStyleBackColor = true;
            this.bntAplLimiar.Click += new System.EventHandler(this.bntAplLimiar_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(9, 28);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Maximum = 255;
            this.trackBar1.MaximumSize = new System.Drawing.Size(900, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(788, 69);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trackBar1_KeyUp);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.chkAutoAplicar);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.bntAplLimiar);
            this.groupBox1.Location = new System.Drawing.Point(218, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(842, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha do Limiar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 26);
            this.textBox1.TabIndex = 8;
            // 
            // chkAutoAplicar
            // 
            this.chkAutoAplicar.AutoSize = true;
            this.chkAutoAplicar.Checked = true;
            this.chkAutoAplicar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoAplicar.Location = new System.Drawing.Point(296, 105);
            this.chkAutoAplicar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutoAplicar.Name = "chkAutoAplicar";
            this.chkAutoAplicar.Size = new System.Drawing.Size(121, 24);
            this.chkAutoAplicar.TabIndex = 7;
            this.chkAutoAplicar.Text = "Auto Aplicar";
            this.chkAutoAplicar.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(9, 5);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(188, 22);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sobre o programa...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnShowHist
            // 
            this.btnShowHist.Location = new System.Drawing.Point(4, 117);
            this.btnShowHist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowHist.Name = "btnShowHist";
            this.btnShowHist.Size = new System.Drawing.Size(206, 35);
            this.btnShowHist.TabIndex = 9;
            this.btnShowHist.Text = "Exibe histograma";
            this.btnShowHist.UseVisualStyleBackColor = true;
            this.btnShowHist.Click += new System.EventHandler(this.btnShowHist_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1,
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 961);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusBar.Size = new System.Drawing.Size(1252, 31);
            this.statusBar.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(225, 25);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(212, 26);
            this.toolStripStatusLabel1.Text = "Gustavo Augusto Hennig";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 34);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.numRaio);
            this.groupBox2.Controls.Add(this.btnFiltroRabiscar);
            this.groupBox2.Location = new System.Drawing.Point(1067, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 154);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro Rabiscar";
            // 
            // btnFiltroRabiscar
            // 
            this.btnFiltroRabiscar.Location = new System.Drawing.Point(28, 87);
            this.btnFiltroRabiscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltroRabiscar.Name = "btnFiltroRabiscar";
            this.btnFiltroRabiscar.Size = new System.Drawing.Size(112, 35);
            this.btnFiltroRabiscar.TabIndex = 5;
            this.btnFiltroRabiscar.Text = "Aplicar";
            this.btnFiltroRabiscar.UseVisualStyleBackColor = true;
            this.btnFiltroRabiscar.Click += new System.EventHandler(this.btnFiltroRabiscar_Click);
            // 
            // numRaio
            // 
            this.numRaio.Location = new System.Drawing.Point(28, 45);
            this.numRaio.Name = "numRaio";
            this.numRaio.Size = new System.Drawing.Size(120, 26);
            this.numRaio.TabIndex = 6;
            this.numRaio.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 992);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnShowHist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpenImage);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Experimentos de Computação Gráfica - Binarização, Histograma, Rabiscar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRaio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button bntAplLimiar;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowHist;
        private System.Windows.Forms.CheckBox chkAutoAplicar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFiltroRabiscar;
        private System.Windows.Forms.NumericUpDown numRaio;
    }
}

