using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Viagens
{
    partial class CadVisitaTecnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadVisitaTecnica));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btInserir = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxFuncao = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.cbSaida = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbChegada = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBoxPart = new System.Windows.Forms.ComboBox();
            this.comboBoxViag = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxSaida2 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxChegada2 = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCurso2 = new System.Windows.Forms.TextBox();
            this.textBoxDestino2 = new System.Windows.Forms.TextBox();
            this.textBoxOrigem2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Retorno = new System.Windows.Forms.TabControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Retorno.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(254, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Curso ";
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(319, 240);
            this.textBoxCurso.Multiline = true;
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(314, 20);
            this.textBoxCurso.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage2.Controls.Add(this.btInserir);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.textBoxFuncao);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.textBoxCpf);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.textBoxEmail);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBoxNome);
            this.tabPage2.Controls.Add(this.cbSaida);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.cbChegada);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.comboBoxPart);
            this.tabPage2.Controls.Add(this.comboBoxViag);
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adicionar Participantes";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.PaleGreen;
            this.btInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserir.Location = new System.Drawing.Point(357, 357);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(135, 29);
            this.btInserir.TabIndex = 74;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(501, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 21);
            this.label21.TabIndex = 73;
            this.label21.Text = "Participante";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(120, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 21);
            this.label20.TabIndex = 72;
            this.label20.Text = "Visita";
            // 
            // textBoxFuncao
            // 
            this.textBoxFuncao.Location = new System.Drawing.Point(591, 219);
            this.textBoxFuncao.Name = "textBoxFuncao";
            this.textBoxFuncao.Size = new System.Drawing.Size(130, 20);
            this.textBoxFuncao.TabIndex = 71;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label19.Location = new System.Drawing.Point(502, 220);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 16);
            this.label19.TabIndex = 70;
            this.label19.Text = "Função";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(591, 257);
            this.textBoxCpf.Mask = "000,000,000-00";
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(75, 20);
            this.textBoxCpf.TabIndex = 69;
            this.textBoxCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label17.Location = new System.Drawing.Point(502, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 16);
            this.label17.TabIndex = 68;
            this.label17.Text = "CPF";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label18.Location = new System.Drawing.Point(376, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 21);
            this.label18.TabIndex = 67;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(591, 177);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(130, 20);
            this.textBoxEmail.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label16.Location = new System.Drawing.Point(502, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 56;
            this.label16.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label13.Location = new System.Drawing.Point(502, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 16);
            this.label13.TabIndex = 55;
            this.label13.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(591, 137);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(130, 20);
            this.textBoxNome.TabIndex = 54;
            // 
            // cbSaida
            // 
            this.cbSaida.Location = new System.Drawing.Point(219, 132);
            this.cbSaida.Mask = "00/00/0000 90:00";
            this.cbSaida.Name = "cbSaida";
            this.cbSaida.Size = new System.Drawing.Size(78, 20);
            this.cbSaida.TabIndex = 36;
            this.cbSaida.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label14.Location = new System.Drawing.Point(121, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "Saída";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label15.Location = new System.Drawing.Point(121, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "Chegada";
            // 
            // cbChegada
            // 
            this.cbChegada.Location = new System.Drawing.Point(219, 178);
            this.cbChegada.Mask = "00/00/0000 90:00";
            this.cbChegada.Name = "cbChegada";
            this.cbChegada.Size = new System.Drawing.Size(78, 20);
            this.cbChegada.TabIndex = 32;
            this.cbChegada.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::Viagens.Properties.Resources.exit;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(756, 350);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 36);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // comboBoxPart
            // 
            this.comboBoxPart.FormattingEnabled = true;
            this.comboBoxPart.Location = new System.Drawing.Point(502, 86);
            this.comboBoxPart.Name = "comboBoxPart";
            this.comboBoxPart.Size = new System.Drawing.Size(218, 21);
            this.comboBoxPart.TabIndex = 1;
            this.comboBoxPart.SelectedIndexChanged += new System.EventHandler(this.comboBoxPart_SelectedIndexChanged);
            // 
            // comboBoxViag
            // 
            this.comboBoxViag.FormattingEnabled = true;
            this.comboBoxViag.Location = new System.Drawing.Point(120, 86);
            this.comboBoxViag.Name = "comboBoxViag";
            this.comboBoxViag.Size = new System.Drawing.Size(218, 21);
            this.comboBoxViag.TabIndex = 0;
            this.comboBoxViag.SelectedIndexChanged += new System.EventHandler(this.comboBoxViag_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.textBoxSaida2);
            this.tabPage1.Controls.Add(this.textBoxChegada2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxCurso2);
            this.tabPage1.Controls.Add(this.textBoxDestino2);
            this.tabPage1.Controls.Add(this.textBoxOrigem2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(828, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::Viagens.Properties.Resources.exit;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(765, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 36);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBoxSaida2
            // 
            this.textBoxSaida2.Location = new System.Drawing.Point(230, 127);
            this.textBoxSaida2.Mask = "00/00/0000 90:00";
            this.textBoxSaida2.Name = "textBoxSaida2";
            this.textBoxSaida2.Size = new System.Drawing.Size(88, 20);
            this.textBoxSaida2.TabIndex = 29;
            this.textBoxSaida2.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxChegada2
            // 
            this.textBoxChegada2.Location = new System.Drawing.Point(230, 173);
            this.textBoxChegada2.Mask = "00/00/0000 90:00";
            this.textBoxChegada2.Name = "textBoxChegada2";
            this.textBoxChegada2.Size = new System.Drawing.Size(88, 20);
            this.textBoxChegada2.TabIndex = 28;
            this.textBoxChegada2.ValidatingType = typeof(System.DateTime);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.button3.Location = new System.Drawing.Point(279, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 29);
            this.button3.TabIndex = 27;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(425, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 29);
            this.button4.TabIndex = 26;
            this.button4.Text = "Cadastrar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(377, 35);
            this.label7.TabIndex = 25;
            this.label7.Text = "Preencha os campos abaixo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxCurso2
            // 
            this.textBoxCurso2.Location = new System.Drawing.Point(230, 214);
            this.textBoxCurso2.Multiline = true;
            this.textBoxCurso2.Name = "textBoxCurso2";
            this.textBoxCurso2.Size = new System.Drawing.Size(189, 20);
            this.textBoxCurso2.TabIndex = 24;
            // 
            // textBoxDestino2
            // 
            this.textBoxDestino2.Location = new System.Drawing.Point(453, 168);
            this.textBoxDestino2.Multiline = true;
            this.textBoxDestino2.Name = "textBoxDestino2";
            this.textBoxDestino2.Size = new System.Drawing.Size(193, 20);
            this.textBoxDestino2.TabIndex = 22;
            // 
            // textBoxOrigem2
            // 
            this.textBoxOrigem2.Location = new System.Drawing.Point(453, 132);
            this.textBoxOrigem2.Multiline = true;
            this.textBoxOrigem2.Name = "textBoxOrigem2";
            this.textBoxOrigem2.Size = new System.Drawing.Size(193, 20);
            this.textBoxOrigem2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label8.Location = new System.Drawing.Point(132, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Curso ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label9.Location = new System.Drawing.Point(380, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Destino";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(380, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Origem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(132, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Saída";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label12.Location = new System.Drawing.Point(131, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Chegada";
            // 
            // Retorno
            // 
            this.Retorno.Controls.Add(this.tabPage1);
            this.Retorno.Controls.Add(this.tabPage2);
            this.Retorno.Location = new System.Drawing.Point(0, 0);
            this.Retorno.Name = "Retorno";
            this.Retorno.SelectedIndex = 0;
            this.Retorno.Size = new System.Drawing.Size(836, 443);
            this.Retorno.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-4, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(428, 327);
            this.flowLayoutPanel1.TabIndex = 75;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(430, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(402, 327);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // CadVisitaTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(839, 445);
            this.Controls.Add(this.Retorno);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(805, 426);
            this.Name = "CadVisitaTecnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Visita Técnica";
            this.Load += new System.EventHandler(this.CadVisitaTecnica_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Retorno.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label5;
        private TextBox textBoxCurso;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private PictureBox pictureBox2;
        private MaskedTextBox textBoxSaida2;
        private MaskedTextBox textBoxChegada2;
        private Button button3;
        private Button button4;
        private Label label7;
        private TextBox textBoxCurso2;
        private TextBox textBoxDestino2;
        private TextBox textBoxOrigem2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TabControl Retorno;
        private ComboBox comboBoxPart;
        private ComboBox comboBoxViag;
        private PictureBox pictureBox3;
        private Label label14;
        private Label label15;
        private MaskedTextBox cbChegada;
        private MaskedTextBox cbSaida;
        private Label label13;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private Label label16;
        private MaskedTextBox textBoxCpf;
        private Label label17;
        private Label label18;
        private TextBox textBoxFuncao;
        private Label label19;
        private Label label21;
        private Label label20;
        private Button btInserir;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}