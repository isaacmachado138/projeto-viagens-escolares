using Viagens.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viagens.Properties;

namespace Viagens
{
    public partial class Principal : Form
    {
        public static Viagens.CadVisitaTecnica Cadastro_de_Visita_Tecnica = new Viagens.CadVisitaTecnica();
        public static Viagens.CadVisitantes Cadastro_de_Visitantes = new Viagens.CadVisitantes();
        public static Viagens.CadProfessores Cadastro_de_Professores = new Viagens.CadProfessores();
        public static Viagens.EditarAluno Editar_Aluno = new Viagens.EditarAluno();
        public static Viagens.EditarProfessores Editar_Professor = new Viagens.EditarProfessores();
        public static Viagens.relatorios Relatorio = new Viagens.relatorios();

        private bool isCollapsed = true;
        private bool isCollapsed2 = true;
        public Principal()
        {
            InitializeComponent();
        }
          
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Login realizado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Cadastro_de_Visita_Tecnica.ShowDialog();

        }

        #region Cadastro Visitantes
        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_de_Visitantes.ShowDialog();
        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Cadastro de Visita Técnica
        private void buttonCadVisita_Click(object sender, EventArgs e)
        {
            Cadastro_de_Visita_Tecnica.ShowDialog();
        }
        #endregion

        #region Sair
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair para a tela de login?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }
        #endregion

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btn_alunos.Image = Resources.Collapse_Arrow;
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else 
            {
                btn_alunos.Image = Resources.Expand_Arrow;
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btn_alunos_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                btn_professores.Image = Resources.Collapse_Arrow;
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                btn_professores.Image = Resources.Expand_Arrow;
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void btn_professores_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void cad_aluno_Click(object sender, EventArgs e)
        {
            Cadastro_de_Visitantes.ShowDialog();
        }

        private void btn_visitas_Click(object sender, EventArgs e)
        {
            Cadastro_de_Visita_Tecnica.ShowDialog();
        }

        private void cad_professores_Click(object sender, EventArgs e)
        {
            Cadastro_de_Professores.ShowDialog();
        }

        private void edt_professores_Click(object sender, EventArgs e)
        {
            Editar_Professor.ShowDialog();
        }
        
        private void edt_aluno_Click(object sender, EventArgs e)
        {
            Editar_Aluno.ShowDialog();
        }

        private void relatorio_Click(object sender, EventArgs e)
        {
            Relatorio.ShowDialog();
        }
    }
}