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
    public partial class EditarProfessores : Form
    { 
        public int id = 0;
        //static string url = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Projeto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        /*Rafael*/ static string url = "Data Source=DESKTOP-4Q8D704;Initial Catalog=Projeto;User ID=sa;Password=123456";


        SqlConnection cn = new SqlConnection(url);
        SqlConnection cn2 = new SqlConnection(url);

        static SqlDataReader dados2;
        public EditarProfessores()
        {
            InitializeComponent();

        }
       
        
        public void ZeraCampos()
        {
            textBoxNome.Text = "";
            textBoxBairro.Text = "";
            textBoxComp.Text = "";
            textBoxCpf.Text = "";
            textBoxDataNasc.Text = "";
            textBoxEmail.Text = "";
            textBoxEndereco.Text = "";
            textBoxMunicipio.Text = "";
            textBoxTel.Text = "";
            textBoxCurso.Text = "";
            lbCod.Text = "";
        }

        private void EditarProfessores_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string where = "WHERE 1=1 ";

            if (textBoxCpf.Text != "")
            {
                where += " AND cpf like '%" + textBoxCpf.Text + "%'";
            }
            
            if(textBoxNome.Text != "")
            {
                where += " AND name like '%" + textBoxNome.Text + "%'";
            }

            string sql = "SELECT * FROM participantes " + where + " AND funcao = 'pr';";

            try
            {
                cn.Open();
                cn2.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dados = cmd.ExecuteReader();
                
                if (dados.Read())
                {
                    id = dados.GetInt32(0);
                    string nome = dados.GetString(1);
                    string cpf = dados.GetString(2);
                    string email = dados.GetString(3);
                    string nasc = Convert.ToString(dados.GetDateTime(4));
                    string endereco = dados.GetString(5);
                    string municipio = dados.GetString(6);
                    string bairro = dados.GetString(7);
                    string complemento = dados.GetString(8);
                    string telefone = dados.GetString(9);
                    string curso = dados.GetString(10);

                    textBoxNome.Text = nome;
                    textBoxBairro.Text = bairro;
                    textBoxComp.Text = complemento;
                    textBoxDataNasc.Text = nasc;
                    textBoxEmail.Text = email;
                    textBoxEndereco.Text = endereco;
                    textBoxMunicipio.Text = municipio;
                    textBoxTel.Text = telefone;
                    textBoxCurso.Text = curso;
                    lbCod.Text = id.ToString();
                    textBoxCpf.Text = cpf;

                    btnAtualizar.Enabled = true;
                    btnDeletar.Enabled = true;                   
                }
                cn.Close();
                if (dados2 != null)
                {
                    if (dados2.IsClosed == false)
                    {
                        dados2.Close();
                    }
                }

                SqlCommand cmd2 = new SqlCommand(sql, cn2);
                dados2 = cmd2.ExecuteReader();
                dados2.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
            
           
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE participantes WHERE id = " + id + ";";
            cn.Open();

            if (MessageBox.Show("Tem certeza que deseja excluir esse registro?", "Sim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.ExecuteNonQuery(); //executa a querie
                    MessageBox.Show("Aluno excluído com sucesso!", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ZeraCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cn.Close();
            cn2.Close();
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string sqlUpdate = @"UPDATE dbo.participantes SET
                name = @nome, email = @email, nasc =  @data, endereco =  @endereco,municipio = @municipio,
bairro = @bairro, complemento = @comp, telefone = @telefone, curso = @curso WHERE id = @id";

                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.Parameters.AddWithValue("@nome", textBoxNome.Text);
                cm.Parameters.AddWithValue("@bairro", textBoxBairro.Text);
                cm.Parameters.AddWithValue("@comp", textBoxComp.Text);
                cm.Parameters.AddWithValue("@data", textBoxDataNasc.Text);
                cm.Parameters.AddWithValue("@endereco", textBoxEndereco.Text);
                cm.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cm.Parameters.AddWithValue("@municipio", textBoxMunicipio.Text);
                cm.Parameters.AddWithValue("@telefone", textBoxTel.Text);
                cm.Parameters.AddWithValue("@curso", textBoxCurso.Text);
                cm.Parameters.AddWithValue("@id", lbCod.Text);



                cm.CommandText = sqlUpdate; //comando recebe o texto do insert


                cm.ExecuteNonQuery(); //executa a querie
                

                MessageBox.Show("Dados atualizados com sucesso!", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ZeraCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
            cn.Close();
                cn2.Close();
        }

        private void buttonProx_Click(object sender, EventArgs e)
        {
            if (dados2.Read())
            {
                id = dados2.GetInt32(0);
                string nome = dados2.GetString(1);
                string cpf = dados2.GetString(2);
                string email = dados2.GetString(3);
                string nasc = Convert.ToString(dados2.GetDateTime(4));
                string endereco = dados2.GetString(5);
                string municipio = dados2.GetString(6);
                string bairro = dados2.GetString(7);
                string complemento = dados2.GetString(8);
                string telefone = dados2.GetString(9);
                string curso = dados2.GetString(10);

                textBoxNome.Text = nome;
                textBoxBairro.Text = bairro;
                textBoxComp.Text = complemento;
                textBoxDataNasc.Text = nasc;
                textBoxEmail.Text = email;
                textBoxEndereco.Text = endereco;
                textBoxMunicipio.Text = municipio;
                textBoxTel.Text = telefone;
                textBoxCurso.Text = curso;
                lbCod.Text = id.ToString();

                btnAtualizar.Enabled = true;
                btnDeletar.Enabled = true;

            }
        }

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
