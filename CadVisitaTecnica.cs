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
    public partial class CadVisitaTecnica : Form
    {
        public CadVisitaTecnica()
        {
            InitializeComponent();
        }

        //static string url = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Projeto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        /*Rafael*/static string url = "Data Source=DESKTOP-4Q8D704;Initial Catalog=Projeto;User ID=sa;Password=123456";

        SqlConnection cn = new SqlConnection(url);
        SqlConnection cn2 = new SqlConnection(url);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*textBoxChegada2.Enabled = true;
            textBoxCurso2.Enabled = true;
            textBoxDestino2.Enabled = true;
            textBoxOrigem2.Enabled = true;
            textBoxSaida2.Enabled = true;
            textBoxChegada2.Clear();
            textBoxCurso2.Clear();
            textBoxDestino2.Clear();
            textBoxOrigem2.Clear();
            textBoxSaida2.Clear();*/
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void CadVisitaTecnica_Load(object sender, EventArgs e)
        {
            string sqlPart = "SELECT id, name    FROM participantes";
            string sqlViag = "SELECT id, destino FROM visitas";

            try
            {
                // commbobox de participantes
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlPart, cn);
                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                comboBoxPart.DataSource = table;
                comboBoxPart.DisplayMember = "name";
                comboBoxPart.ValueMember = "id";
                comboBoxPart.SelectedIndex = -1;
                cn.Close();

                // commbobox de viagens
                cn2.Open();
                SqlCommand cmdViag = new SqlCommand(sqlViag, cn2);
                DataTable tableViag = new DataTable();
                SqlDataAdapter daViag = new SqlDataAdapter(cmdViag);
                daViag.Fill(tableViag);

                comboBoxViag.DataSource = tableViag;
                comboBoxViag.DisplayMember = "destino";
                comboBoxViag.ValueMember = "id";
                comboBoxViag.SelectedIndex = -1;
                cn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void adicionarParticipantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string sqlInsert = @"INSERT INTO dbo.visitas
                (chegada, saida, origem, destino, curso)
                VALUES(@chegada, @saida, @origem, @destino, @curso)";

                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandText = sqlInsert; //comando recebe o texto do insert



                cm.Parameters.AddWithValue("@chegada", Convert.ToDateTime(textBoxChegada2.Text));
                cm.Parameters.AddWithValue("@saida", Convert.ToDateTime(textBoxSaida2.Text));
                cm.Parameters.AddWithValue("@origem", textBoxOrigem2.Text);
                cm.Parameters.AddWithValue("@destino", textBoxDestino2.Text);
                cm.Parameters.AddWithValue("@curso", textBoxCurso2.Text);

                cm.ExecuteNonQuery(); //executa a querie
                

                MessageBox.Show("Dados cadastrados com sucesso!", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LimparCampos();
                //textBoxNome.Text = sqlInsert;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);


            }
            cn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void comboBoxViag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxViag.SelectedIndex != -1 && comboBoxViag.SelectedIndex != 0)
            {
                try
                {
                    cn.Open();
                    string sql = "SELECT saida, chegada FROM visitas " +
                        " WHERE id = " + comboBoxViag.SelectedValue.ToString() + "; ";
                    SqlCommand cmd2 = new SqlCommand(sql, cn);
                    SqlDataReader dados = cmd2.ExecuteReader();
                    //MessageBox.Show(sql);


                    if (dados.Read())
                    { 
                        cbSaida.Text = Convert.ToString(dados.GetSqlDateTime(0));
                        cbChegada.Text = Convert.ToString(dados.GetSqlDateTime(1));
                    }
                    }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);


                }
                cn.Close();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPart.SelectedIndex != -1 && comboBoxPart.SelectedIndex != 0)
            {
                try
                {
                    cn2.Open();
                    //string sql = "SELECT name, email, cpf, funcao FROM participantes WHERE id = id;";
                    string sql = "SELECT name, email, cpf, funcao FROM participantes" +
                        " WHERE id = " + comboBoxPart.SelectedValue.ToString() + "; ";
                    SqlCommand cmd2 = new SqlCommand(sql, cn2);
                    SqlDataReader dados2 = cmd2.ExecuteReader();
                    //MessageBox.Show("teste " + sql);

                    if (dados2.Read())
                    {
                        textBoxNome.Text  = dados2.GetString(0);
                        textBoxEmail.Text = dados2.GetString(1);
                        textBoxCpf.Text   = dados2.GetString(2);
                        string funcao     = dados2.GetString(3);

                        if (funcao == "al")
                        {
                            textBoxFuncao.Text = "Aluno";
                        } else if (funcao == "pr")
                        {
                            textBoxFuncao.Text = "Professor";
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);


                }
                cn2.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            string id_part = comboBoxPart.SelectedValue.ToString();
            string id_vis  = comboBoxViag.SelectedValue.ToString();
            if (id_part != "" && id_vis != "")
            {
                try
                {

                    string sqlSelect = @"SELECT * FROM part_visitas
                    WHERE id_participante = @id_part AND id_visita = @id_visita";

                    cn.Open();
                    SqlCommand cmm = new SqlCommand(sqlSelect, cn);
                    cmm.Connection = cn;
                    cmm.Parameters.AddWithValue("@id_part", id_part);
                    cmm.Parameters.AddWithValue("@id_visita", id_vis);
                    SqlDataReader dados = cmm.ExecuteReader();
                    if (dados.Read())
                    {
                        MessageBox.Show("Esse participante já está adicionado à essa viagem!!!");
                    }
                    else
                    {
                        cn.Close();
                        cn.Open();

                        string sqlInsert = @"INSERT INTO dbo.part_visitas 
                        (id_participante, id_visita)
                        VALUES(@id_part, @id_visita)";
                        SqlCommand cm = new SqlCommand();
                        cm.Connection = cn;
                        cm.Parameters.AddWithValue("@id_part", id_part);
                        cm.Parameters.AddWithValue("@id_visita", id_vis);

                        cm.CommandText = sqlInsert; //comando recebe o texto do insert


                        cm.ExecuteNonQuery(); //executa a querie
                        cn.Close();

                        MessageBox.Show("Participante inserido com sucesso!", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //textBoxNome.Text = sqlInsert;

                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
