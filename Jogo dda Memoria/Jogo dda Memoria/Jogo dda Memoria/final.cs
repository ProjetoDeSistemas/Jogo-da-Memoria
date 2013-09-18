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
    public partial class final : Form
    {
        Form1 form1;
        public final(Form1 P)
        {
            InitializeComponent();
            form1 = P;
        }

        public final()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 jogo = new Form1();
            jogo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void final_Load(object sender, EventArgs e)
        {

            label2.Text = Convert.ToString(form1.P);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            string strcon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\ranke.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO RANKE (NOME,PONTUACAO) values ('"+textBox1.Text+"', '"+label2.Text+"')", conexao);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sua pontuação foi salva");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!!!" + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            } 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 rank = new Form2();
            rank.Show();
        }


       
    }
}
