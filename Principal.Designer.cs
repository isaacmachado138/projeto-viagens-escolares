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
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_visitas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edt_professores = new System.Windows.Forms.Button();
            this.cad_professores = new System.Windows.Forms.Button();
            this.btn_professores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edt_aluno = new System.Windows.Forms.Button();
            this.cad_aluno = new System.Windows.Forms.Button();
            this.btn_alunos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.relatorio = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.btn_visitas);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.relatorio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 449);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btn_visitas
            // 
            this.btn_visitas.BackColor = System.Drawing.Color.Teal;
            this.btn_visitas.FlatAppearance.BorderSize = 0;
            this.btn_visitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visitas.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visitas.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_visitas.Location = new System.Drawing.Point(3, 3);
            this.btn_visitas.Name = "btn_visitas";
            this.btn_visitas.Size = new System.Drawing.Size(249, 48);
            this.btn_visitas.TabIndex = 8;
            this.btn_visitas.Text = "Visitas Técnicas";
            this.btn_visitas.UseVisualStyleBackColor = false;
            this.btn_visitas.Click += new System.EventHandler(this.btn_visitas_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.edt_professores);
            this.panel2.Controls.Add(this.cad_professores);
            this.panel2.Controls.Add(this.btn_professores);
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.MaximumSize = new System.Drawing.Size(253, 125);
            this.panel2.MinimumSize = new System.Drawing.Size(253, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 52);
            this.panel2.TabIndex = 11;
            // 
            // edt_professores
            // 
            this.edt_professores.BackColor = System.Drawing.Color.CadetBlue;
            this.edt_professores.FlatAppearance.BorderSize = 0;
            this.edt_professores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edt_professores.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.edt_professores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edt_professores.Location = new System.Drawing.Point(0, 87);
            this.edt_professores.Name = "edt_professores";
            this.edt_professores.Size = new System.Drawing.Size(255, 38);
            this.edt_professores.TabIndex = 10;
            this.edt_professores.Text = "Editar";
            this.edt_professores.UseVisualStyleBackColor = false;
            this.edt_professores.Click += new System.EventHandler(this.edt_professores_Click);
            // 
            // cad_professores
            // 
            this.cad_professores.BackColor = System.Drawing.Color.CadetBlue;
            this.cad_professores.FlatAppearance.BorderSize = 0;
            this.cad_professores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cad_professores.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.cad_professores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cad_professores.Location = new System.Drawing.Point(0, 49);
            this.cad_professores.Name = "cad_professores";
            this.cad_professores.Size = new System.Drawing.Size(255, 38);
            this.cad_professores.TabIndex = 9;
            this.cad_professores.Text = "Cadastrar";
            this.cad_professores.UseVisualStyleBackColor = false;
            this.cad_professores.Click += new System.EventHandler(this.cad_professores_Click);
            // 
            // btn_professores
            // 
            this.btn_professores.BackColor = System.Drawing.Color.Teal;
            this.btn_professores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_professores.FlatAppearance.BorderSize = 0;
            this.btn_professores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_professores.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.btn_professores.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_professores.Image = global::Viagens.Properties.Resources.Expand_Arrow;
            this.btn_professores.Location = new System.Drawing.Point(0, 0);
            this.btn_professores.Name = "btn_professores";
            this.btn_professores.Size = new System.Drawing.Size(253, 52);
            this.btn_professores.TabIndex = 8;
            this.btn_professores.Text = "Professores";
            this.btn_professores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_professores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_professores.UseVisualStyleBackColor = false;
            this.btn_professores.Click += new System.EventHandler(this.btn_professores_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edt_aluno);
            this.panel1.Controls.Add(this.cad_aluno);
            this.panel1.Controls.Add(this.btn_alunos);
            this.panel1.Location = new System.Drawing.Point(3, 115);
            this.panel1.MaximumSize = new System.Drawing.Size(253, 125);
            this.panel1.MinimumSize = new System.Drawing.Size(253, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 53);
            this.panel1.TabIndex = 8;
            // 
            // edt_aluno
            // 
            this.edt_aluno.BackColor = System.Drawing.Color.CadetBlue;
            this.edt_aluno.FlatAppearance.BorderSize = 0;
            this.edt_aluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edt_aluno.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.edt_aluno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edt_aluno.Location = new System.Drawing.Point(0, 87);
            this.edt_aluno.Name = "edt_aluno";
            this.edt_aluno.Size = new System.Drawing.Size(255, 38);
            this.edt_aluno.TabIndex = 10;
            this.edt_aluno.Text = "Editar";
            this.edt_aluno.UseVisualStyleBackColor = false;
            this.edt_aluno.Click += new System.EventHandler(this.edt_aluno_Click);
            // 
            // cad_aluno
            // 
            this.cad_aluno.BackColor = System.Drawing.Color.CadetBlue;
            this.cad_aluno.FlatAppearance.BorderSize = 0;
            this.cad_aluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cad_aluno.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.cad_aluno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cad_aluno.Location = new System.Drawing.Point(0, 49);
            this.cad_aluno.Name = "cad_aluno";
            this.cad_aluno.Size = new System.Drawing.Size(255, 38);
            this.cad_aluno.TabIndex = 9;
            this.cad_aluno.Text = "Cadastrar";
            this.cad_aluno.UseVisualStyleBackColor = false;
            this.cad_aluno.Click += new System.EventHandler(this.cad_aluno_Click);
            // 
            // btn_alunos
            // 
            this.btn_alunos.BackColor = System.Drawing.Color.Teal;
            this.btn_alunos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_alunos.FlatAppearance.BorderSize = 0;
            this.btn_alunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alunos.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.btn_alunos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_alunos.Image = global::Viagens.Properties.Resources.Expand_Arrow;
            this.btn_alunos.Location = new System.Drawing.Point(0, 0);
            this.btn_alunos.Name = "btn_alunos";
            this.btn_alunos.Size = new System.Drawing.Size(253, 50);
            this.btn_alunos.TabIndex = 8;
            this.btn_alunos.Text = "Alunos";
            this.btn_alunos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alunos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_alunos.UseVisualStyleBackColor = false;
            this.btn_alunos.Click += new System.EventHandler(this.btn_alunos_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(426, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(308, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(416, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 224);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(843, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 41);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // relatorio
            // 
            this.relatorio.BackColor = System.Drawing.Color.Teal;
            this.relatorio.FlatAppearance.BorderSize = 0;
            this.relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.relatorio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorio.ForeColor = System.Drawing.SystemColors.Control;
            this.relatorio.Location = new System.Drawing.Point(3, 174);
            this.relatorio.Name = "relatorio";
            this.relatorio.Size = new System.Drawing.Size(249, 48);
            this.relatorio.TabIndex = 12;
            this.relatorio.Text = "Relatório";
            this.relatorio.UseVisualStyleBackColor = false;
            this.relatorio.Click += new System.EventHandler(this.relatorio_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(921, 447);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(937, 486);
            this.Name = "Principal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viagem Técnica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button edt_aluno;
        private Button cad_aluno;
        private Button btn_alunos;
        private Panel panel2;
        private Button edt_professores;
        private Button cad_professores;
        private Button btn_professores;
        private Button btn_visitas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button relatorio;
    }
}