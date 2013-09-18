using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Jogo_dda_Memoria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string strcon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\ranke.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("select NOME , PONTUACAO from  RANKE order by pontuacao desc", conexao);

            try //Tenta executar o que estiver abaixo
            {
                conexao.Open(); // abre a conexão com o banco   
                cmd.ExecuteNonQuery(); // executa cmd
                /*Pronto após o cmd.ExecuteNonQuery(); selecionamos tudo o que tinha dentro do banco, agora os passos seguintes irão exibir as informações para que o usuário possa vê-las    */
                SqlDataAdapter da = new SqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
                DataSet ds = new DataSet();
                da.SelectCommand = cmd; // adapta cmd ao projeto
                da.Fill(ds); // preenche todas as informações dentro do DataSet                                          
                dataGridView1.DataSource = ds; //Datagridview recebe ds já preenchido
                dataGridView1.DataMember = ds.Tables[0].TableName;  /*Agora Datagridview exibe o banco de dados*/
            }
            catch (Exception)
            {
                MessageBox.Show("Não Localizado!!!"); /*Se ocorer algum erro será informado em um msgbox*/
                throw;
            }
            finally
            {
                conexao.Close(); /* Se tudo ocorrer bem fecha a conexão com o banco da dados, sempre é bom fechar a conexão após executar até o final o que nos interessa, isso pode evitar problemas futuros */
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
