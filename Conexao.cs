using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApoioVendas
{
    public class Conexao
    {
        string conexao = "SERVER=localhost; DATABASE=catalogo_real; UID=root; PWD=;";

        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao conectar!" + ex.Message);
            }
        }
        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao fechar!" + ex.Message);
            }
        }
    }
}