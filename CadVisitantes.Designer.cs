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
    partial class CadVisitantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadVisitantes));
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.retornarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxComp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(194, 252);
            this.textBoxCPF.Mask = "000,000,000-00";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(83, 23);
            this.textBoxCPF.TabIndex = 28;
            this.textBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonLimpar.Location = new System.Drawing.Point(796, 122);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 34);
            this.buttonLimpar.TabIndex = 27;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(796, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(354, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Preencha os campos abaixo";
            // 
            // textBoxMunicipio
            // 
            this.textBoxMunicipio.Location = new System.Drawing.Point(621, 211);
            this.textBoxMunicipio.Name = "textBoxMunicipio";
            this.textBoxMunicipio.Size = new System.Drawing.Size(155, 23);
            this.textBoxMunicipio.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(505, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Municipio";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(194, 210);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(278, 23);
            this.textBoxEmail.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(78, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(78, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data Nasc.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "CPF";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retornarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retornarToolStripMenuItem
            // 
            this.retornarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.retornarToolStripMenuItem.Name = "retornarToolStripMenuItem";
            this.retornarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.retornarToolStripMenuItem.Text = "Retornar";
            this.retornarToolStripMenuItem.Click += new System.EventHandler(this.retornarToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(194, 170);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(278, 23);
            this.textBoxNome.TabIndex = 29;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(621, 253);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(155, 23);
            this.textBoxBairro.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(505, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Bairro";
            // 
            // textBoxComp
            // 
            this.textBoxComp.Location = new System.Drawing.Point(621, 295);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.Size = new System.Drawing.Size(155, 23);
            this.textBoxComp.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(505, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Complemento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(505, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Telefone";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(621, 341);
            this.textBoxTel.Mask = "(00)00000-0000";
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(84, 23);
            this.textBoxTel.TabIndex = 36;
            this.textBoxTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxDataNasc
            // 
            this.textBoxDataNasc.Location = new System.Drawing.Point(194, 295);
            this.textBoxDataNasc.Mask = "00/00/0000";
            this.textBoxDataNasc.Name = "textBoxDataNasc";
            this.textBoxDataNasc.Size = new System.Drawing.Size(83, 23);
            this.textBoxDataNasc.TabIndex = 37;
            this.textBoxDataNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.textBoxDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(821, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 41);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(78, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Curso";
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(194, 341);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(278, 23);
            this.textBoxCurso.TabIndex = 39;
            this.textBoxCurso.TextChanged += new System.EventHandler(this.textBoxCurso_TextChanged);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(621, 170);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(155, 23);
            this.textBoxEndereco.TabIndex = 65;
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.BackColor = System.Drawing.Color.Transparent;
            this.Endereco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Endereco.Location = new System.Drawing.Point(505, 171);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(64, 17);
            this.Endereco.TabIndex = 64;
            this.Endereco.Text = "Endereço";
            // 
            // CadVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(921, 447);
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
            this.MinimumSize = new System.Drawing.Size(937, 486);
            this.Name = "CadVisitantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Visitantes";
            this.Load += new System.EventHandler(this.CadVisitantes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem retornarToolStripMenuItem;
        private Label label2;
        private TextBox textBoxNome;
        private TextBox textBoxBairro;
        private Label label7;
        private TextBox textBoxComp;
        private Label label8;
        private Label label9;
        private MaskedTextBox textBoxTel;
        private MaskedTextBox textBoxDataNasc;
        private PictureBox pictureBox1;
        private Label label10;
        private TextBox textBoxCurso;
        private TextBox textBoxEndereco;
        private Label Endereco;
    }
}