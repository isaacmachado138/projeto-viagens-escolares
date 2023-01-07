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
    partial class EditarProfessores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProfessores));
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxComp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMunicipio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.retornarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonProx = new System.Windows.Forms.Button();
            this.labelCod = new System.Windows.Forms.Label();
            this.lbCod = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(691, 221);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(64, 29);
            this.btnAtualizar.TabIndex = 98;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.btnDeletar.Location = new System.Drawing.Point(691, 261);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(64, 29);
            this.btnDeletar.TabIndex = 97;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(522, 214);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(133, 20);
            this.textBoxEndereco.TabIndex = 96;
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.BackColor = System.Drawing.Color.Transparent;
            this.Endereco.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.Endereco.Location = new System.Drawing.Point(423, 215);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(62, 16);
            this.Endereco.TabIndex = 95;
            this.Endereco.Text = "Endereco";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(563, 94);
            this.textBoxCpf.Mask = "000,000,000-00";
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(83, 20);
            this.textBoxCpf.TabIndex = 93;
            this.textBoxCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label11.Location = new System.Drawing.Point(509, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 92;
            this.label11.Text = "CPF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label10.Location = new System.Drawing.Point(45, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 91;
            this.label10.Text = "Curso";
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(144, 325);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(239, 20);
            this.textBoxCurso.TabIndex = 90;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Viagens.Properties.Resources.exit;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(723, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 36);
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // textBoxDataNasc
            // 
            this.textBoxDataNasc.Location = new System.Drawing.Point(144, 288);
            this.textBoxDataNasc.Mask = "00/00/0000";
            this.textBoxDataNasc.Name = "textBoxDataNasc";
            this.textBoxDataNasc.Size = new System.Drawing.Size(72, 20);
            this.textBoxDataNasc.TabIndex = 88;
            this.textBoxDataNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.textBoxDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(387, 371);
            this.textBoxTel.Mask = "(00)00000-0000";
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(73, 20);
            this.textBoxTel.TabIndex = 87;
            this.textBoxTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(287, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 86;
            this.label9.Text = "Telefone";
            // 
            // textBoxComp
            // 
            this.textBoxComp.Location = new System.Drawing.Point(522, 325);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.Size = new System.Drawing.Size(133, 20);
            this.textBoxComp.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label8.Location = new System.Drawing.Point(423, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "Complemento";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(522, 287);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(133, 20);
            this.textBoxBairro.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label7.Location = new System.Drawing.Point(423, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "Bairro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label2.Location = new System.Drawing.Point(89, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(188, 91);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(239, 20);
            this.textBoxNome.TabIndex = 80;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(335, 127);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(92, 29);
            this.buttonBuscar.TabIndex = 79;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.Location = new System.Drawing.Point(600, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 78;
            // 
            // textBoxMunicipio
            // 
            this.textBoxMunicipio.Location = new System.Drawing.Point(522, 248);
            this.textBoxMunicipio.Name = "textBoxMunicipio";
            this.textBoxMunicipio.Size = new System.Drawing.Size(133, 20);
            this.textBoxMunicipio.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label5.Location = new System.Drawing.Point(423, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Municipio";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(144, 248);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(239, 20);
            this.textBoxEmail.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label4.Location = new System.Drawing.Point(45, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label3.Location = new System.Drawing.Point(45, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "Data Nasc,";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retornarToolStripMenuItem
            // 
            this.retornarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.retornarToolStripMenuItem.Name = "retornarToolStripMenuItem";
            this.retornarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.retornarToolStripMenuItem.Text = "Retornar";
            this.retornarToolStripMenuItem.Click += new System.EventHandler(this.retornarToolStripMenuItem_Click);
            // 
            // buttonProx
            // 
            this.buttonProx.BackColor = System.Drawing.Color.Lavender;
            this.buttonProx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProx.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProx.Location = new System.Drawing.Point(448, 127);
            this.buttonProx.Name = "buttonProx";
            this.buttonProx.Size = new System.Drawing.Size(92, 29);
            this.buttonProx.TabIndex = 99;
            this.buttonProx.Text = "Próximo";
            this.buttonProx.UseVisualStyleBackColor = false;
            this.buttonProx.Click += new System.EventHandler(this.buttonProx_Click);
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.labelCod.Location = new System.Drawing.Point(45, 203);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(49, 16);
            this.labelCod.TabIndex = 100;
            this.labelCod.Text = "Código:";
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.BackColor = System.Drawing.Color.Transparent;
            this.lbCod.Location = new System.Drawing.Point(166, 162);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(0, 13);
            this.lbCod.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(265, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(335, 24);
            this.label12.TabIndex = 94;
            this.label12.Text = "Preencha CPF ou Nome para buscar";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(789, 160);
            this.flowLayoutPanel1.TabIndex = 102;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // EditarProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(789, 413);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.buttonProx);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDataNasc);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxComp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMunicipio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(805, 426);
            this.Name = "EditarProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Professor";
            this.Load += new System.EventHandler(this.EditarProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAtualizar;
        private Button btnDeletar;
        private TextBox textBoxEndereco;
        private Label Endereco;
        private MaskedTextBox textBoxCpf;
        private Label label11;
        private Label label10;
        private TextBox textBoxCurso;
        private PictureBox pictureBox1;
        private MaskedTextBox textBoxDataNasc;
        private MaskedTextBox textBoxTel;
        private Label label9;
        private TextBox textBoxComp;
        private Label label8;
        private TextBox textBoxBairro;
        private Label label7;
        private Label label2;
        private TextBox textBoxNome;
        private Button buttonBuscar;
        private Label label6;
        private TextBox textBoxMunicipio;
        private Label label5;
        private TextBox textBoxEmail;
        private Label label4;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem retornarToolStripMenuItem;
        private Button buttonProx;
        private Label labelCod;
        private Label lbCod;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}