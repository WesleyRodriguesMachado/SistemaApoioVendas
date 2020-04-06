using ApoioVendas.Controller;
using ApoioVendas.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApoioVendas.Model
{
    //Classe Modelo para os produtos
    public class ModelProdutos
    {
        ControllerProdutos controller = new ControllerProdutos();
        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = controller.Listar();
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
                DataTable dt = new DataTable();
                dt = controller.Buscar(dados);
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
                DataTable dt = new DataTable();
                dt = controller.BuscarSecao(dados);
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
                DataTable dt = new DataTable();
                dt = controller.BuscarCategoria(dados);
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
                DataTable dt = new DataTable();
                dt = controller.BuscarSubCategoria(dados);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Salvar(Produtos dados)
        {
            try
            {
                controller.Inserir(dados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }

        public void Editar(Produtos dados)
        {
            try
            {
                controller.Editar(dados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar " + ex.Message);
            }
        }

        public void Excluir(Produtos dados)
        {
            try
            {
                controller.Excluir(dados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }


        //******************** METODOS DE BUSCA ****************************************






    }

}
