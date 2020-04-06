using ApoioVendas.Entities;
using ApoioVendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApoioVendas.View
{
    public partial class frmCadProdutos : Form
    {

        ModelProdutos model = new ModelProdutos();
        ModelSecoes modelS = new ModelSecoes();
        ModelCategoria modelC = new ModelCategoria();
        ModelSubcategoria modelSub = new ModelSubcategoria();

        string modo;
        public frmCadProdutos()
        {
            InitializeComponent();
            PreencherSecoes();
            PreencherCategorias();
            PreencherSubCategorias();
        }

        public frmCadProdutos(Produtos dados ) : this()
        {
            txtId.Text = dados.Id_produtos.ToString();
            txtDescricao.Text = dados.Descricao;
            txtCodigo.Text = dados.Codigo;
            txtPagina.Text = dados.Pagina;
            txtEmbalagem.Text = dados.Unidade;
            cboSecao.Text = dados.Secao;
            cboCategoria.Text = dados.Categoria;
            cboSubcategoria.Text = dados.Subcategoria;

            btnPesquisar.Visible = false;
            btnExcluir.Visible = true;

            modo = "EDIÇÃO";
            lblModo.Text = Modos(modo);

            HabilitarControles();


            if (dados.Imagem == null)
            {

                ptbImagem.Image = Properties.Resources.sem_foto;
                return;
            }
           
          

            ptbImagem.Image = byteArrayToImage(dados.Imagem);




        }
        //************************** INICIO METODOS CONTROLES FORMULARIO **********************************

        private void HabilitarControles()
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            txtEmbalagem.Enabled = true;
            gpbDadosAdic.Enabled = true;
            lblModo.Visible = true;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;

        }

        private void Cancelar()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            txtEmbalagem.Enabled = false;
            gpbDadosAdic.Enabled = false;
            lblModo.Visible = false;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;


        }

        private void PreencherSecoes()
        {
            cboSecao.DataSource = modelS.Listar();
            cboSecao.ValueMember = "id_secao";
            cboSecao.DisplayMember = "secao";
        }

        private void PreencherCategorias()
        {
            cboCategoria.DataSource = modelC.Listar();
            cboCategoria.ValueMember = "id_categoria";
            cboCategoria.DisplayMember = "categoria";
        }

        private void PreencherSubCategorias()
        {
            cboSubcategoria.DataSource = modelSub.Listar();
            cboSubcategoria.ValueMember = "id_subcategoria";
            cboSubcategoria.DisplayMember = "subcategoria";
        }
        private string Modos(string modo)
        {
           //string retorno =  "Modo de " + modo + " Clique no botão para cancelar.";
            return "Modo de " + modo + " Clique no botão para cancelar.";
        }

        


        //************************** FIM METODOS CONTROLES FORMULARIO *************************************

        //----------------------------------------------------------------------------------------------------//

        //************************** INICIO METODOS DO CRUD ************************************************
        private void Salvar(Produtos dado)
        {

            try
            {
                dado.Codigo = txtCodigo.Text;
                dado.Descricao = txtDescricao.Text;
                dado.Unidade = txtEmbalagem.Text;
                dado.Pagina = txtPagina.Text;
                dado.Id_secao = Convert.ToInt32(cboSecao.SelectedValue);
                dado.Id_categoria = Convert.ToInt32(cboCategoria.SelectedValue);
                dado.Id_subcategoria = Convert.ToInt32(cboSubcategoria.SelectedValue);
                dado.Imagem = Img();

                model.Salvar(dado);

                MessageBox.Show("Produto Salvo com Sucesso!!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }

        public void Editar(Produtos dado)
        {

            try
            {
                dado.Id_produtos = Convert.ToInt32(txtId.Text);
                dado.Codigo = txtCodigo.Text;
                dado.Descricao = txtDescricao.Text;
                dado.Unidade = txtEmbalagem.Text;
                dado.Pagina = txtPagina.Text;
                dado.Id_secao = Convert.ToInt32(cboSecao.SelectedValue);
                dado.Id_categoria = Convert.ToInt32(cboCategoria.SelectedValue);
                dado.Id_subcategoria = Convert.ToInt32(cboSubcategoria.SelectedValue);
                dado.Imagem = Img();

                model.Editar(dado);
                MessageBox.Show("Registro Editado com Sucesso!");
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
                dados.Id_produtos = Convert.ToInt32(txtId.Text);
                model.Excluir(dados);
                MessageBox.Show("Registro excluido com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }

        }

        private byte[] Img()
        {
            byte[] imagem_byte = null;

            if (txtUrl.Text == "")
            {

                return null;


            }

            FileStream fs = new FileStream(this.txtUrl.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }

          private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        //************************** FIM METODOS METODOS DO CRUD *******************************************

        //----------------------------------------------------------------------------------------------------//

        //************************** INICIO CONTROLES DOS BOTOES *********************************************
        private void btnNovo_Click(object sender, EventArgs e)
        {
             modo = "CADASTRO";
            lblModo.Text = Modos(modo);
            HabilitarControles();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produtos dados = new Produtos();
            if(txtCodigo.Text == "" || txtDescricao.Text == "" || txtPagina.Text == "")
            {
                MessageBox.Show("Os campos 'CÓDIGO', 'DESCRIÇÃO' e 'PAGINA não podem ser vazios!");
                return;
            }
            try
            {
                if (modo == "CADASTRO")
                {
                    Salvar(dados);
                    Cancelar();


                }
                

                if(modo == "EDIÇÃO")
                {
                    Editar(dados);
                 
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar Produto!!!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Produto selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Produtos dados = new Produtos();
            Excluir(dados);
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(modo == "EDIÇÃO")
            {
                this.Close();
                return;
            }

            Cancelar();
              
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.ShowDialog();

        }

        private void ptbImagem_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

           
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtUrl.Text = foto;
                ptbImagem.ImageLocation = foto;
            }
            else
            {
                ptbImagem.Image = Properties.Resources.sem_foto;
            }

           
        }






        //************************** FIM  CONTROLES DOS BOTOES ***********************************************
    }
}
