using ApoioVendas.Entities;
using ApoioVendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApoioVendas.View
{
    public partial class frmCadSubCategoria : Form
    {
        ModelSubcategoria model = new ModelSubcategoria();
        string modo;
        public frmCadSubCategoria()
        {
            InitializeComponent();
            Listar();
        }

        //****************************** INICIO METODOS DO CRUD *************************************************************

        public void Listar()
        {
            try
            {
                dgv.DataSource = model.Listar();

                dgv.Columns[0].HeaderText = "ID";
                dgv.Columns[1].HeaderText = "DESCRIÇÃO";
                dgv.Columns[0].Width = 25;
                dgv.Columns[1].Width = 250;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar dados" + ex.Message);
            }
        }

        public void Salvar(SubCategorias dados)
        {
            try
            {

                dados.Subcategoria = txtDescricao.Text;

                model.Salvar(dados);

                Listar();

                MessageBox.Show("Registro salvo com Sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

        public void Editar(SubCategorias dados)
        {
            try
            {
                dados.Id_subcategoria = Convert.ToInt32(txtId.Text);
                dados.Subcategoria = txtDescricao.Text;

                model.Editar(dados);



                MessageBox.Show("Registro alterado com Sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar" + ex.Message);
            }
        }

        public void Excluir(SubCategorias dados)
        {
            try
            {
                dados.Id_subcategoria = Convert.ToInt32(txtId.Text);

                model.Excluir(dados);



                MessageBox.Show("Registro excluido com Sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir" + ex.Message);
            }
        }



        //****************************** FIM METODOS DO CRUD ****************************************************************





        //****************************** INICIO METODOS DE CONTROLE *************************************************************

        private string Modos(string modo)
        {
            lblInfo.Text = "Voce Está no modo de: " + modo + ". Clique para cancelar!";

            return modo;
        }

        private void Cancela()
        {
            txtDescricao.Enabled = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = false;

            txtDescricao.Text = "";
            txtId.Text = "";

            Retrair();

        }

        private void Expandir()
        {
            this.Height = 360;
            groupBox1.Height = 300;
        }

        private void Retrair()
        {
            groupBox1.Height = 250;
            this.Height = 310;

        }



        //****************************** FIM METODOS DE CONTROLE *************************************************************










        //****************************** INICIO CONTROLE DOS BOTOES *************************************************************


        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            btnSalvar.Visible = true;
            gpbInfo.Visible = true;

            txtDescricao.Text = "";
            txtId.Text = "";

            Expandir();

            modo = "CADASTRO";
            Modos(modo);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (modo == "CADASTRO")
            {
                if (txtDescricao.Text == "")
                {
                    MessageBox.Show("O Campo CATEGORIA não pode ser vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SubCategorias dados = new SubCategorias();
                Salvar(dados);
                Listar();
                Cancela();
            }

            if (modo == "EDIÇÃO")
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Selecione na tabela um registro para edição!");
                    return;
                }
                SubCategorias dados = new SubCategorias();
                Editar(dados);
                Listar();
                Cancela();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um item para Excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Deseja EXCLUIR a Subategoria Selecionada", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            SubCategorias dados = new SubCategorias();
            Excluir(dados);
            Listar();
            Cancela();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = dgv.CurrentRow.Cells[1].Value.ToString();

            txtDescricao.Enabled = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = true;

            Expandir();

            modo = "EDIÇÃO";
            Modos(modo);
        }

    

        //****************************** FIM CONTROLE DOS BOTOES *************************************************************




    }
}
