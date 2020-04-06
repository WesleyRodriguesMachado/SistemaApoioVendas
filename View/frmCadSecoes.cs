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
    public partial class frmCadSecoes : Form
    {

        ModelSecoes model = new ModelSecoes();
        String modo;
        public frmCadSecoes()
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

        public void Salvar(Secoes dados)
        {
            try
            {
                
                dados.Secao = txtDescricao.Text;

                model.Salvar(dados);

                Listar();

                MessageBox.Show("Registro salvo com Sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

        public void Editar(Secoes dados)
        {
            try
            {
                dados.Id_secao = Convert.ToInt32(txtId.Text);
                dados.Secao = txtDescricao.Text;

                model.Editar(dados);

               

                MessageBox.Show("Registro alterado com Sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar" + ex.Message);
            }
        }

        public void Excluir(Secoes dados)
        {
            try
            {
                dados.Id_secao = Convert.ToInt32(txtId.Text);

                model.Excluir(dados);

                Listar();

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
            lblInfo.Text = "Voce Está no modo de: " + modo +". Clique para cancelar!";

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
            this.Height = 393;
            groupBox1.Height = 342;
        }

        private void Retrair()
        {
            groupBox1.Height = 285;
            this.Height = 342;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(modo == "CADASTRO")
            {
                if (txtDescricao.Text == "")
                {
                    MessageBox.Show("O Campo SEÇÃO não pode ser vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Secoes dados = new Secoes();
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
                Secoes dados = new Secoes();
                Editar(dados);
                Listar();
                Cancela();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um item para Excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Deseja EXCLUIR Seção Selecionada", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Secoes dados = new Secoes();
            Excluir(dados);
            Cancela();
        }

        private void frmCadSecoes_Load(object sender, EventArgs e)
        {

        }

        private void gpbInfo_Enter(object sender, EventArgs e)
        {

        }


        //****************************** FIM CONTROLE DOS BOTOES*************************************************************
    }
}
