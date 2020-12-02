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

namespace ConnectionSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTeste_Click(object sender, EventArgs e)
        {
            try
            {
                string connectioString;
                SqlConnection conexao;
                connectioString = @"Server = DESKTOP-2A8U9LA\SQLEXPRESS; Database = Clientes;Trusted_Connection=Tru";
                conexao = new SqlConnection(connectioString);
                conexao.Open();
                MessageBox.Show("Connection Open!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao se conectar no banco de dados \n"+
                    "Verificar os dados informados" + erro);
            }
        }
    }
}
