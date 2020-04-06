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
    public class ControllerCategorias
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM categorias", con.con);
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

        public void Editar(Categorias dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE categorias SET categoria = @categoria WHERE id_categoria = @id", con.con);
                sql.Parameters.AddWithValue("@categoria", dados.Categoria);
                sql.Parameters.AddWithValue("@id", dados.Id_categoria);
                sql.ExecuteNonQuery();

                con.FecharConexao();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(Categorias dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM categorias WHERE id_categoria = @id", con.con);
                sql.Parameters.AddWithValue("@id", dados.Id_categoria);
                sql.ExecuteNonQuery();

                con.FecharConexao();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Inserir(Categorias dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO categorias (categoria) VALUES (@categoria)", con.con);

                sql.Parameters.AddWithValue("@categoria", dados.Categoria);

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
