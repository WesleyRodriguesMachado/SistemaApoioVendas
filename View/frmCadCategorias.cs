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
    public partial class frmCadCategorias : Form
    {
        ModelCategoria model = new ModelCategoria();
        string modo;
        public frmCadCategorias()
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

        public void Salvar(Categorias dados)
        {
            try
            {

                dados.Categoria = txtDescricao.Text;

                model.Salvar(dados);

                Listar();

                MessageBox.Show("Registro salvo com Sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

        public void Editar(Categorias dados)
        {
            try
            {
                dados.Id_categoria = Convert.ToInt32(txtId.Text);
                dados.Categoria = txtDescricao.Text;

                model.Editar(dados);



                MessageBox.Show("Registro alterado com Sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar" + ex.Message);
            }
        }

        public void Excluir(Categorias dados)
        {
            try
            {
                dados.Id_categoria = Convert.ToInt32(txtId.Text);

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
                Categorias dados = new Categorias();
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
                Categorias dados = new Categorias();
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
            if (MessageBox.Show("Deseja EXCLUIR a Categoria Selecionada", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Categorias dados = new Categorias();
            Excluir(dados);
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

        private void frmCadCategorias_Load(object sender, EventArgs e)
        {

        }

        //****************************** FIM CONTROLE DOS BOTOES *************************************************************

    }
}
