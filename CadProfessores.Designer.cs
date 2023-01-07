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
    partial class CadProfessores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProfessores));
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
            this.textBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMunicipio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.Label();
            this.retornarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.retornarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::Viagens.Properties.Resources.exit;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(733, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 36);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // textBoxDataNasc
            // 
            this.textBoxDataNasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDataNasc.Location = new System.Drawing.Point(198, 240);
            this.textBoxDataNasc.Mask = "00/00/0000";
            this.textBoxDataNasc.Name = "textBoxDataNasc";
            this.textBoxDataNasc.Size = new System.Drawing.Size(87, 20);
            this.textBoxDataNasc.TabIndex = 58;
            this.textBoxDataNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.textBoxDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTel.Location = new System.Drawing.Point(592, 274);
            this.textBoxTel.Mask = "(00)00000-0000";
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(94, 20);
            this.textBoxTel.TabIndex = 57;
            this.textBoxTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label9.Location = new System.Drawing.Point(492, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "Telefone";
            // 
            // textBoxComp
            // 
            this.textBoxComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxComp.Location = new System.Drawing.Point(592, 240);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.Size = new System.Drawing.Size(133, 20);
            this.textBoxComp.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label8.Location = new System.Drawing.Point(492, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Complemento";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBairro.Location = new System.Drawing.Point(592, 204);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(133, 20);
            this.textBoxBairro.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label7.Location = new System.Drawing.Point(492, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Bairro";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label2.Location = new System.Drawing.Point(68, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNome.Location = new System.Drawing.Point(198, 132);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(239, 20);
            this.textBoxNome.TabIndex = 50;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCPF.Location = new System.Drawing.Point(198, 203);
            this.textBoxCPF.Mask = "000,000,000-00";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(87, 20);
            this.textBoxCPF.TabIndex = 49;
            this.textBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.buttonLimpar.Location = new System.Drawing.Point(303, 339);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(113, 29);
            this.buttonLimpar.TabIndex = 48;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click_2);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.button1.Location = new System.Drawing.Point(435, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 47;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(226, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 35);
            this.label6.TabIndex = 46;
            this.label6.Text = "Preencha os campos abaixo";
            // 
            // textBoxMunicipio
            // 
            this.textBoxMunicipio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMunicipio.Location = new System.Drawing.Point(592, 167);
            this.textBoxMunicipio.Name = "textBoxMunicipio";
            this.textBoxMunicipio.Size = new System.Drawing.Size(133, 20);
            this.textBoxMunicipio.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label5.Location = new System.Drawing.Point(492, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Municipio";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Location = new System.Drawing.Point(198, 167);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(239, 20);
            this.textBoxEmail.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label4.Location = new System.Drawing.Point(68, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label3.Location = new System.Drawing.Point(68, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Data Nasc,";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label1.Location = new System.Drawing.Point(70, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "CPF";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label10.Location = new System.Drawing.Point(70, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "Curso";
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCurso.Location = new System.Drawing.Point(198, 274);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(239, 20);
            this.textBoxCurso.TabIndex = 60;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEndereco.Location = new System.Drawing.Point(592, 132);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(133, 20);
            this.textBoxEndereco.TabIndex = 63;
            // 
            // Endereco
            // 
            this.Endereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Endereco.AutoSize = true;
            this.Endereco.BackColor = System.Drawing.Color.Transparent;
            this.Endereco.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.Endereco.Location = new System.Drawing.Point(492, 135);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(62, 16);
            this.Endereco.TabIndex = 62;
            this.Endereco.Text = "Endereco";
            // 
            // retornarToolStripMenuItem
            // 
            this.retornarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.retornarToolStripMenuItem.Name = "retornarToolStripMenuItem";
            this.retornarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.retornarToolStripMenuItem.Text = "Retornar";
            this.retornarToolStripMenuItem.Click += new System.EventHandler(this.retornarToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 77;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retornarToolStripMenuItem1
            // 
            this.retornarToolStripMenuItem1.Name = "retornarToolStripMenuItem1";
            this.retornarToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.retornarToolStripMenuItem1.Text = "Retornar";
            this.retornarToolStripMenuItem1.Click += new System.EventHandler(this.retornarToolStripMenuItem1_Click);
            // 
            // CadProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(789, 387);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.Endereco);
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
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMunicipio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(805, 426);
            this.Name = "CadProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores";
            this.Load += new System.EventHandler(this.CadProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private MaskedTextBox textBoxCPF;
        private Button buttonLimpar;
        private Button button1;
        private Label label6;
        private TextBox textBoxMunicipio;
        private Label label5;
        private TextBox textBoxEmail;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label10;
        private TextBox textBoxCurso;
        private TextBox textBoxEndereco;
        private Label Endereco;
        private ToolStripMenuItem retornarToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem retornarToolStripMenuItem1;
    }
}