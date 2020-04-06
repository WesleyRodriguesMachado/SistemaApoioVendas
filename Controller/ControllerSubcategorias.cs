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
    public class ControllerSubcategorias
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM subcategorias", con.con);
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

        public void Editar(SubCategorias dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE subcategorias SET subcategoria = @subcategoria WHERE id_subcategoria = @id", con.con);
                sql.Parameters.AddWithValue("@subcategoria", dados.Subcategoria);
                sql.Parameters.AddWithValue("@id", dados.Id_subcategoria);
                sql.ExecuteNonQuery();

                con.FecharConexao();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(SubCategorias dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM subcategorias WHERE id_subcategoria = @id", con.con);
                sql.Parameters.AddWithValue("@id", dados.Id_subcategoria);
                sql.ExecuteNonQuery();

                con.FecharConexao();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Inserir(SubCategorias dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO subcategorias (subcategoria) VALUES (@categoria)", con.con);

                sql.Parameters.AddWithValue("@categoria", dados.Subcategoria);

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
