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
    partial class EditarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarAluno));
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
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.buttonProx = new System.Windows.Forms.Button();
            this.lbCod = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(78, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 63;
            this.label10.Text = "Curso";
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(194, 311);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(278, 23);
            this.textBoxCurso.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(821, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 41);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxDataNasc
            // 
            this.textBoxDataNasc.Location = new System.Drawing.Point(194, 268);
            this.textBoxDataNasc.Mask = "00/00/0000";
            this.textBoxDataNasc.Name = "textBoxDataNasc";
            this.textBoxDataNasc.Size = new System.Drawing.Size(63, 23);
            this.textBoxDataNasc.TabIndex = 60;
            this.textBoxDataNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.textBoxDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(477, 370);
            this.textBoxTel.Mask = "(00)00000-0000";
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(84, 23);
            this.textBoxTel.TabIndex = 59;
            this.textBoxTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(361, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Telefone";
            // 
            // textBoxComp
            // 
            this.textBoxComp.Location = new System.Drawing.Point(635, 316);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.Size = new System.Drawing.Size(155, 23);
            this.textBoxComp.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(519, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Complemento";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(635, 273);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(155, 23);
            this.textBoxBairro.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(519, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Bairro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(194, 89);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(278, 23);
            this.textBoxNome.TabIndex = 52;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.buttonBuscar.Location = new System.Drawing.Point(389, 127);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 34);
            this.buttonBuscar.TabIndex = 71;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(549, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 48;
            // 
            // textBoxMunicipio
            // 
            this.textBoxMunicipio.Location = new System.Drawing.Point(635, 228);
            this.textBoxMunicipio.Name = "textBoxMunicipio";
            this.textBoxMunicipio.Size = new System.Drawing.Size(155, 23);
            this.textBoxMunicipio.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(519, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Municipio";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(194, 227);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(278, 23);
            this.textBoxEmail.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(78, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(78, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Data Nasc,";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retornarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 41;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(560, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 65;
            this.label11.Text = "CPF";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(635, 84);
            this.textBoxCpf.Mask = "000,000,000-00";
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(87, 23);
            this.textBoxCpf.TabIndex = 66;
            this.textBoxCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(344, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(330, 25);
            this.label12.TabIndex = 67;
            this.label12.Text = "Preencha CPF ou Nome para buscar";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(635, 188);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(155, 23);
            this.textBoxEndereco.TabIndex = 69;
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.BackColor = System.Drawing.Color.Transparent;
            this.Endereco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Endereco.Location = new System.Drawing.Point(519, 189);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(64, 17);
            this.Endereco.TabIndex = 68;
            this.Endereco.Text = "Endereco";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(821, 229);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 34);
            this.btnDeletar.TabIndex = 71;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(821, 189);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 34);
            this.btnAtualizar.TabIndex = 71;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // buttonProx
            // 
            this.buttonProx.BackColor = System.Drawing.Color.Lavender;
            this.buttonProx.Location = new System.Drawing.Point(486, 127);
            this.buttonProx.Name = "buttonProx";
            this.buttonProx.Size = new System.Drawing.Size(75, 34);
            this.buttonProx.TabIndex = 71;
            this.buttonProx.Text = "Próximo";
            this.buttonProx.UseVisualStyleBackColor = false;
            this.buttonProx.Click += new System.EventHandler(this.buttonProx_Click);
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.BackColor = System.Drawing.Color.Transparent;
            this.lbCod.Location = new System.Drawing.Point(194, 177);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(0, 15);
            this.lbCod.TabIndex = 103;
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCod.Location = new System.Drawing.Point(78, 177);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(54, 17);
            this.labelCod.TabIndex = 102;
            this.labelCod.Text = "Código:";
            // 
            // EditarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(921, 447);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.buttonProx);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.label12);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(937, 486);
            this.Name = "EditarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Aluno";
            this.Load += new System.EventHandler(this.EditarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Label label11;
        private MaskedTextBox textBoxCpf;
        private Label label12;
        private TextBox textBoxEndereco;
        private Label Endereco;
        private Button btnDeletar;
        private Button btnAtualizar;
        private Button buttonProx;
        private Label lbCod;
        private Label labelCod;
    }
}