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
    public class ModelSubcategoria
    {
        ControllerSubcategorias controller = new ControllerSubcategorias();

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

        public void Salvar(SubCategorias dados)
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

        public void Editar(SubCategorias dados)
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

        public void Excluir(SubCategorias dados)
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
    }
}
