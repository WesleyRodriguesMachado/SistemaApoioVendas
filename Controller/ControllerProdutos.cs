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
    class ControllerProdutos
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

       
        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT prod.id_produtos, prod.codigo, prod.descricao, prod.unidade, sec.secao, cat.categoria, sub.subcategoria, prod.pagina, prod.imagem FROM produtos prod INNER JOIN secoes sec ON(sec.id_secao = prod.id_secao)INNER JOIN categorias cat ON(cat.id_categoria = prod.id_categoria)INNER JOIN subcategorias sub ON(sub.id_subcategoria = prod.id_subcategoria) order by id_produtos", con.con);

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

        public DataTable Buscar(Produtos dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT prod.id_produtos, prod.codigo, prod.descricao, prod.unidade, sec.secao, cat.categoria, sub.subcategoria, prod.pagina, prod.imagem FROM produtos prod INNER JOIN secoes sec ON(sec.id_secao = prod.id_secao)INNER JOIN categorias cat ON(cat.id_categoria = prod.id_categoria)INNER JOIN subcategorias sub ON(sub.id_subcategoria = prod.id_subcategoria) WHERE prod.codigo LIKE @codigo OR prod.descricao LIKE @descricao OR prod.pagina = @pagina order by id_produtos", con.con);
                sql.Parameters.AddWithValue("@codigo", dados.Codigo);
                sql.Parameters.AddWithValue("@descricao", dados.Descricao);
                sql.Parameters.AddWithValue("@pagina", dados.Pagina);

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

        public DataTable BuscarSecao(Produtos dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT prod.id_produtos, prod.codigo, prod.descricao, prod.unidade, sec.secao, cat.categoria, sub.subcategoria, prod.pagina, prod.imagem FROM produtos prod INNER JOIN secoes sec ON(sec.id_secao = prod.id_secao)INNER JOIN categorias cat ON(cat.id_categoria = prod.id_categoria)INNER JOIN subcategorias sub ON(sub.id_subcategoria = prod.id_subcategoria) WHERE prod.id_secao = @secao order by id_produtos", con.con);
                sql.Parameters.AddWithValue("@secao", dados.Id_secao);
               

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


        public DataTable BuscarCategoria(Produtos dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT prod.id_produtos, prod.codigo, prod.descricao, prod.unidade, sec.secao, cat.categoria, sub.subcategoria, prod.pagina FROM produtos prod INNER JOIN secoes sec ON (sec.id_secao = prod.id_secao) INNER JOIN categorias cat ON (cat.id_categoria = prod.id_categoria) INNER JOIN subcategorias sub ON (sub.id_subcategoria = prod.id_subcategoria) WHERE prod.id_categoria = @categoria", con.con);
                sql.Parameters.AddWithValue("@categoria", dados.Id_categoria);

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
        public DataTable BuscarSubCategoria(Produtos dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT prod.id_produtos, prod.codigo, prod.descricao, prod.unidade, sec.secao, cat.categoria, sub.subcategoria, prod.pagina FROM produtos prod INNER JOIN secoes sec ON (sec.id_secao = prod.id_secao) INNER JOIN categorias cat ON (cat.id_categoria = prod.id_categoria) INNER JOIN subcategorias sub ON (sub.id_subcategoria = prod.id_subcategoria) WHERE prod.id_subcategoria = @subcategoria", con.con);
                sql.Parameters.AddWithValue("@subcategoria", dados.Id_subcategoria);

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


        public void Editar(Produtos dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE produtos SET codigo = @codigo, descricao = @descricao, unidade = @unidade, id_secao = @id_secao, id_categoria = @id_categoria, id_subcategoria = @id_subcategoria, pagina = @pagina, imagem = @imagem   WHERE id_produtos = @id", con.con);
                sql.Parameters.AddWithValue("@codigo", dados.Codigo);
                sql.Parameters.AddWithValue("@descricao", dados.Descricao);
                sql.Parameters.AddWithValue("@unidade", dados.Unidade);
                sql.Parameters.AddWithValue("@id_secao", dados.Id_secao);
                sql.Parameters.AddWithValue("@id_categoria", dados.Id_categoria);
                sql.Parameters.AddWithValue("@id_subcategoria", dados.Id_subcategoria);
                sql.Parameters.AddWithValue("@pagina", dados.Pagina);
                sql.Parameters.AddWithValue("@imagem", dados.Imagem);
                sql.Parameters.AddWithValue("@id", dados.Id_produtos);
                sql.ExecuteNonQuery();

                con.FecharConexao();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(Produtos dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM produtos WHERE id_produtos = @id", con.con);
                sql.Parameters.AddWithValue("@id", dados.Id_produtos);
                sql.ExecuteNonQuery();

                con.FecharConexao();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Inserir(Produtos dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO produtos (codigo, descricao, unidade, id_secao, id_categoria, id_subcategoria, pagina, imagem) VALUES (@codigo, @descricao, @unidade, @id_secao, @id_categoria, @id_subcategoria, @pagina, @imagem)", con.con);

                sql.Parameters.AddWithValue("@codigo", dados.Codigo);
                sql.Parameters.AddWithValue("@descricao", dados.Descricao);
                sql.Parameters.AddWithValue("@unidade", dados.Unidade);
                sql.Parameters.AddWithValue("@id_secao", dados.Id_secao);
                sql.Parameters.AddWithValue("@id_categoria", dados.Id_categoria);
                sql.Parameters.AddWithValue("@id_subcategoria", dados.Id_subcategoria);
                sql.Parameters.AddWithValue("@pagina", dados.Pagina);
                sql.Parameters.AddWithValue("@imagem", dados.Imagem);

                sql.ExecuteNonQuery();

                con.FecharConexao();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //******************** METODOS DE BUSCA ****************************************




    }
}
