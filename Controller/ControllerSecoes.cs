using ApoioVendas.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoioVendas.Controller
{
    public class ControllerSecoes
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM secoes", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Editar(Secoes dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE secoes SET secao = @secao WHERE id_secao = @id", con.con);
                sql.Parameters.AddWithValue("@secao", dados.Secao);
                sql.Parameters.AddWithValue("@id", dados.Id_secao);
                sql.ExecuteNonQuery();

                con.FecharConexao();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(Secoes dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM secoes WHERE id_secao = @id", con.con);
                sql.Parameters.AddWithValue("@id", dados.Id_secao);
                sql.ExecuteNonQuery();

                con.FecharConexao();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Inserir(Secoes dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO secoes (secao) VALUES (@secao)", con.con);

                sql.Parameters.AddWithValue("@secao", dados.Secao);

                sql.ExecuteNonQuery();

                con.FecharConexao();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

}
