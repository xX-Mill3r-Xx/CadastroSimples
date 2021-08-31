using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace CadastroSimples
{
    public partial class Form1 : Form
    {
        Banco banco = new Banco();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista.Rows.Clear();
            string bancoDado = Application.StartupPath + @"\db\banco.sdf";
            string str = "DataSource = " + bancoDado + "; Password = '1234'";
            banco.StringConection(bancoDado, str);
            SqlCeConnection conexao = new SqlCeConnection(str);
            try
            {
                string query = "SELECT * FROM cadastro";
                DataTable dados = new DataTable();
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, str);
                conexao.Open();
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            ////////////////////////////
            btn_Inserir.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Buscar.Enabled = false;
            txt_Email.Enabled = false;
            txt_Nome.Enabled = false;
            txt_ID.ReadOnly = true;
            lista.Enabled = false;
            //string bancoDado = Application.StartupPath + @"\db\banco.sdf";
            //string str = "DataSource = " + bancoDado + "; Password = '1234'";
            banco.StringConection(bancoDado, str);
            SqlCeEngine db = new SqlCeEngine(str);
            if (File.Exists(bancoDado))
            {
                lb_Status.ForeColor = Color.Green;
                lb_Status.Text = "Conectado";
            }

            if (File.Exists(bancoDado))
            {
                abrirConexãoToolStripMenuItem.Enabled = false;
            }

            if (File.Exists(bancoDado))
            {
                criarTabelaToolStripMenuItem.Enabled = false;
            }

            db.Dispose();
        }

        private void novoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Editar.Text = "Edtar";
            txt_Nome.Clear();
            txt_Email.Clear();
            txt_ID.Clear();
            txt_Nome.Enabled = true;
            txt_Email.Enabled = true;
            btn_Inserir.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Buscar.Enabled = false;
            btn_Excluir.Enabled = false;
            lista.Enabled = true;
            txt_Nome.Focus();
            
        }

        private void buscarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Editar.Text = "Edtar";
            txt_Nome.Enabled = true;
            txt_Email.Enabled = false;
            btn_Buscar.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Inserir.Enabled = false;
            lista.Enabled = true;
            txt_Nome.Focus();
        }

        private void editarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Editar.Text = "Salvar Edção";
            txt_Nome.Enabled = true;
            txt_Email.Enabled = true;
            btn_Buscar.Enabled = false;
            btn_Editar.Enabled = true;
            btn_Excluir.Enabled = false;
            btn_Inserir.Enabled = false;
            lista.Enabled = true;
            txt_Nome.Focus();
        }

        private void excluirRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Editar.Text = "Edtar";
            txt_Nome.Enabled = true;
            txt_Email.Enabled = false;
            btn_Buscar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = true;
            btn_Inserir.Enabled = false;
            lista.Enabled = true;
            txt_Nome.Focus();
        }

        private void abrirConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bancoDado = Application.StartupPath + @"\db\banco.sdf";
            string str = "DataSource = " + bancoDado + "; Password = '1234'";
            banco.StringConection(bancoDado, str);
            SqlCeEngine db = new SqlCeEngine(str);
            if (!File.Exists(bancoDado))
            {
                db.CreateDatabase();
                lb_Status.ForeColor = Color.Green;
                lb_Status.Text = "Conectado";
            }

            if (File.Exists(bancoDado))
            {
                abrirConexãoToolStripMenuItem.Enabled = false;
            }

            db.Dispose();
            SqlCeConnection conexao = new SqlCeConnection(str);
            try
            {
                conexao.Open();
                MessageBox.Show("Conexão estabelecida com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de conexão "+ ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void criarTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bancoDado = Application.StartupPath + @"\db\banco.sdf";
            string str = "DataSource = " + bancoDado + "; Password = '1234'";
            banco.StringConection(bancoDado, str);
            SqlCeConnection conexao = new SqlCeConnection(str);

            if (File.Exists(bancoDado))
            {
                criarTabelaToolStripMenuItem.Enabled = false;
            }

            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE cadastro (id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50));";
                comando.ExecuteNonQuery();
                comando.Dispose();
                MessageBox.Show("Tabela criada  com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            string bancoDado = Application.StartupPath + @"\db\banco.sdf";
            string str = "DataSource = " + bancoDado + "; Password = '1234'";
            banco.StringConection(bancoDado, str);
            SqlCeConnection conexao = new SqlCeConnection(str);
            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                int id = new Random(DateTime.Now.Millisecond).Next(1, 1000);
                string nome = txt_Nome.Text;
                string email = txt_Email.Text;
                if(nome == "" && email == "")
                {
                    MessageBox.Show("Os campos não podem ser vazios");
                    return;
                }
                comando.CommandText = "INSERT INTO cadastro VALUES("+ id +", '"+ nome +"', '"+ email +"');";
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro incluido na base de dados");
                lista.Rows.Add(id, nome, email);
                txt_Email.Clear();
                txt_Nome.Clear();
                txt_ID.Clear();
                comando.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            lista.Rows.Clear();
            string bancoDado = Application.StartupPath + @"\db\banco.sdf";
            string str = "DataSource = " + bancoDado + "; Password = '1234'";
            banco.StringConection(bancoDado, str);
            SqlCeConnection conexao = new SqlCeConnection(str);
            try
            {
                string query = "SELECT * FROM cadastro";
                string nome = txt_Nome.Text;
                if(nome != "")
                {
                    query = "SELECT * FROM cadastro WHERE nome LIKE '%" + nome + "%'";
                    
                }
                //txt_Nome.Clear();
                DataTable dados = new DataTable();
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, str);
                conexao.Open();
                adaptador.Fill(dados);
                foreach(DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de conexão " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            
            string bancoDado = Application.StartupPath + @"\db\banco.sdf";
            string str = "DataSource = " + bancoDado + "; Password = '1234'";
            banco.StringConection(bancoDado, str);
            SqlCeConnection conexao = new SqlCeConnection(str);
            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                int id = int.Parse(txt_ID.Text);
                string nome = txt_Nome.Text;
                string email = txt_Email.Text;
                string query = "UPDATE cadastro SET nome = '"+nome+"', email = '"+email+"' WHERE id LIKE '"+id+"'";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                lista.Refresh();
                txt_ID.Clear();
                txt_Email.Clear();
                txt_Nome.Clear();
                //txt_ID.Clear();
                comando.Dispose();

                string query2 = "SELECT * FROM cadastro";
                nome = txt_Nome.Text;
                if (nome != "")
                {
                    query = "SELECT * FROM cadastro WHERE nome LIKE '%" + nome + "%'";
                }
                txt_Nome.Clear();
                MessageBox.Show("Registro alterado no banco de dados do sistema.");
                DataTable dados = new DataTable();
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query2, str);
                //conexao.Open();
                lista.Rows.Clear();
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de conexão " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void lista_SelectionChanged(object sender, EventArgs e)
        {
            //lista.Refresh();
            //txt_ID.Text = lista.SelectedRows[0].Cells[0].Value.ToString();
            //txt_Nome.Text = lista.SelectedRows[0].Cells[1].Value.ToString();
            //txt_Email.Text = lista.SelectedRows[0].Cells[2].Value.ToString();
            //lista.Rows.Clear();
        }

        private void lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = lista.SelectedRows[0].Cells[0].Value.ToString();
            txt_Nome.Text = lista.SelectedRows[0].Cells[1].Value.ToString();
            txt_Email.Text = lista.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            string bancoDado = Application.StartupPath + @"\db\banco.sdf";
            string str = "DataSource = " + bancoDado + "; Password = '1234'";
            banco.StringConection(bancoDado, str);
            SqlCeConnection conexao = new SqlCeConnection(str);

            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                int id = (int)lista.SelectedRows[0].Cells[0].Value;
                DialogResult res = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res == DialogResult.Yes)
                {
                    comando.CommandText = "DELETE FROM cadastro WHERE id = '"+id+"'";
                }
                else
                {
                    return;
                }
                comando.ExecuteNonQuery();
                txt_Email.Clear();
                txt_ID.Clear();
                txt_Nome.Clear();

                string query = "SELECT * FROM cadastro";
                DataTable dados = new DataTable();
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, str);
                lista.Rows.Clear();
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de conexão " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
