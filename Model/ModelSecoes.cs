﻿using ApoioVendas.Controller;
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
    public class ModelSecoes
    {
        ControllerSecoes controller = new ControllerSecoes();

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

        public void Salvar(Secoes dados)
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

        public void Editar(Secoes dados)
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

        public void Excluir(Secoes dados)
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
