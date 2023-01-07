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
    public partial class CadVisitantes : Form
    {
        public CadVisitantes()
        {
            InitializeComponent();
        }

        //static string url = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Projeto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        /*Rafael*/static string url = "Data Source=DESKTOP-4Q8D704;Initial Catalog=Projeto;User ID=sa;Password=123456";

        SqlConnection cn = new SqlConnection(url);

        
        public void LimparCampos()
        {
            textBoxNome.Enabled = true;
            textBoxBairro.Enabled = true;
            textBoxComp.Enabled = true;
            textBoxCPF.Enabled = true;
            textBoxDataNasc.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxMunicipio.Enabled = true;
            textBoxTel.Enabled = true;
            textBoxNome.Clear();
            textBoxBairro.Clear();
            textBoxComp.Clear();
            textBoxCPF.Clear();
            textBoxDataNasc.Clear();
            textBoxEmail.Clear();
            textBoxEndereco.Clear();
            textBoxMunicipio.Clear();
            textBoxTel.Clear();
            textBoxCurso.Clear();
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxCPF.Text == "___.___.___-__" || textBoxDataNasc.Text == "__/__/____" || textBoxEmail.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            string nome = textBoxNome.Text;
            string bairro = textBoxBairro.Text;
            string comp = textBoxComp.Text;
            string cpf = textBoxCPF.Text;
            string data = textBoxDataNasc.Text;
            string email = textBoxEmail.Text;
            string endereco = textBoxEndereco.Text;
            string municipio = textBoxMunicipio.Text;
            string telefone = textBoxTel.Text;
            string curso = textBoxCurso.Text;

            /*****INSERCAO DOS DADOS - INI *****/
            try
            {
                cn.Open();

                string sqlInsert = @"INSERT INTO dbo.participantes 
                (name, cpf, email, nasc, endereco ,municipio, bairro, complemento, telefone, curso, funcao)
                VALUES(@nome, @cpf, @email, @data, @endereco, @municipio, @bairro, @comp, @telefone, @curso, 'al')";
                //MessageBox.Show(sqlInsert);
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;

                cm.Parameters.AddWithValue("@nome", textBoxNome.Text);
                cm.Parameters.AddWithValue("@bairro", textBoxBairro.Text);
                cm.Parameters.AddWithValue("@comp", textBoxComp.Text);
                cm.Parameters.AddWithValue("@cpf", textBoxCPF.Text);
                cm.Parameters.AddWithValue("@data", textBoxDataNasc.Text);
                cm.Parameters.AddWithValue("@endereco", textBoxEndereco.Text);
                cm.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cm.Parameters.AddWithValue("@municipio", textBoxMunicipio.Text);
                cm.Parameters.AddWithValue("@telefone", textBoxTel.Text);
                cm.Parameters.AddWithValue("@curso", textBoxCurso.Text);


                cm.CommandText = sqlInsert; //comando recebe o texto do insert
                cm.ExecuteNonQuery(); //executa a querie
                cn.Close();

                MessageBox.Show("Dados cadastrados com sucesso!", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                //textBoxNome.Text = sqlInsert;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);


            }

            /*****INSERCAO DOS DADOS - FIM *****/
        }

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }
        private void CadVisitantes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCurso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
