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
    public partial class frmProdutos : Form
    {

        ModelProdutos model = new ModelProdutos();
        ModelSecoes modelS = new ModelSecoes();
        ModelCategoria modelC = new ModelCategoria();
        ModelSubcategoria modelSub = new ModelSubcategoria();
        public frmProdutos()
        {
            InitializeComponent();
            Listar();
        }

        private void Totaliza()
        {
            int total = dgvProdutos.Rows.Count - 1;

            lblTotal.Text = total.ToString();

        }

        private void Listar()
        {
            try
            {
                dgvProdutos.DataSource = model.Listar();

                dgvProdutos.Columns[0].Visible = false;
                dgvProdutos.Columns[8].Visible = false;
                dgvProdutos.Columns[7].Visible = false;

                dgvProdutos.Columns[1].HeaderText = "Código";
                dgvProdutos.Columns[2].HeaderText = "Descrição";
                dgvProdutos.Columns[3].HeaderText = "Embalagem";
                dgvProdutos.Columns[4].HeaderText = "Seção";
                dgvProdutos.Columns[5].HeaderText = "Categoria";
                dgvProdutos.Columns[6].HeaderText = "Sub-Categoria";
                dgvProdutos.Columns[7].HeaderText = "Pagina";

                dgvProdutos.Columns[1].Width = 60;
                dgvProdutos.Columns[2].Width = 300;
                dgvProdutos.Columns[3].Width = 45;
                dgvProdutos.Columns[4].Width = 180;
                dgvProdutos.Columns[5].Width = 180;
                dgvProdutos.Columns[6].Width = 180;

                Totaliza();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }


        private void PreencherComboBusca()
        {

            cboBuscar.Visible = true;

            if (rdbSecao.Checked == true)
            {
                cboBuscar.DataSource = modelS.Listar();
                cboBuscar.ValueMember = "id_secao";
                cboBuscar.DisplayMember = "secao";
            }

            if (rdbCategoria.Checked == true)
            {
                cboBuscar.DataSource = modelC.Listar();
                cboBuscar.ValueMember = "id_categoria";
                cboBuscar.DisplayMember = "categoria";
            }

            if (rdbSubcategoria.Checked == true)
            {
                cboBuscar.DataSource = modelSub.Listar();
                cboBuscar.ValueMember = "id_subcategoria";
                cboBuscar.DisplayMember = "subcategoria";
            }


        }

        public void Buscar(Produtos dado)
        {
            try
            {
                dado.Codigo = txtBusca.Text;
                dado.Descricao = txtBusca.Text;
                dado.Pagina = txtBusca.Text;

                dgvProdutos.DataSource = model.Buscar(dado);
                Totaliza();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }
        public void BuscarSecao(Produtos dado)
        {
            try
            {
                dado.Id_secao = Convert.ToInt32(cboBuscar.SelectedValue);


                dgvProdutos.DataSource = model.BuscarSecao(dado);

                Totaliza();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados frmProdutos" + ex.Message);
            }
        }

        public void BuscarCategoria(Produtos dado)
        {
            try
            {
                dado.Id_categoria = Convert.ToInt32(cboBuscar.SelectedValue);


                dgvProdutos.DataSource = model.BuscarCategoria(dado);

                Totaliza();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados frmProdutos" + ex.Message);
            }
        }

        public void BuscarSubCategoria(Produtos dado)
        {
            try
            {
                dado.Id_subcategoria = Convert.ToInt32(cboBuscar.SelectedValue);


                dgvProdutos.DataSource = model.BuscarSubCategoria(dado);

                Totaliza();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados frmProdutos" + ex.Message);
            }
        }


        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdbPagina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbSecao_CheckedChanged(object sender, EventArgs e)
        {

            PreencherComboBusca();
            txtBusca.Enabled = false;
            Listar();
        }

        private void rdbCategoria_CheckedChanged(object sender, EventArgs e)
        {

            PreencherComboBusca();
            txtBusca.Enabled = false;
            Listar();
        }

        private void rdbSubcategoria_CheckedChanged(object sender, EventArgs e)
        {

            PreencherComboBusca();
            txtBusca.Enabled = false;
            Listar();
        }

        private void rdbCodigo_CheckedChanged_1(object sender, EventArgs e)
        {
            txtBusca.Visible = true;
            cboBuscar.Visible = false;
            txtBusca.Enabled = true;
        }

        private void rdbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtBusca.Visible = true;
            cboBuscar.Visible = false;
            txtBusca.Enabled = true;
        }

        private void rdbPagina_CheckedChanged_1(object sender, EventArgs e)
        {
            txtBusca.Visible = true;
            cboBuscar.Visible = false;
            txtBusca.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Produtos dados = new Produtos();
            Buscar(dados);

        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text == "")
            {
                Listar();
                return;
            }
            Produtos dados = new Produtos();
            Buscar(dados);
        }

        private void BuscarCombos()
        {
            Produtos dados = new Produtos();
            if (rdbSecao.Checked == true)
            {

                BuscarSecao(dados);
            }

            if (rdbCategoria.Checked == true)
            {

                BuscarCategoria(dados);
            }
            if (rdbSubcategoria.Checked == true)
            {

                BuscarSubCategoria(dados);
            }
        }


        private void cboBuscar_SelectionChangeCommitted(object sender, EventArgs e)
        {

            BuscarCombos();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void txturl_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] imagem = (byte[])dgvProdutos.CurrentRow.Cells[8].Value;
                MemoryStream ms = new MemoryStream(imagem);
                ptbImagem.Image = System.Drawing.Image.FromStream(ms);

            }
            catch (Exception)
            {

                ptbImagem.Image = Properties.Resources.sem_foto;

            }

        }

        private void txturl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Produtos dados = new Produtos();
                dados.Id_produtos = Convert.ToInt32(dgvProdutos.CurrentRow.Cells[0].Value); //.ToString();
                dados.Codigo = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                dados.Descricao = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
                dados.Unidade = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
                dados.Secao = dgvProdutos.CurrentRow.Cells[4].Value.ToString();
                dados.Categoria = dgvProdutos.CurrentRow.Cells[5].Value.ToString();
                dados.Subcategoria = dgvProdutos.CurrentRow.Cells[6].Value.ToString();
                dados.Pagina = dgvProdutos.CurrentRow.Cells[7].Value.ToString();

                try
                {
                    byte[] imagem = (byte[])dgvProdutos.CurrentRow.Cells[8].Value;
                    MemoryStream ms = new MemoryStream(imagem);
                    ptbImagem.Image = System.Drawing.Image.FromStream(ms);
                    dados.Imagem = imagem;
                }
                catch (Exception)
                {

                    ptbImagem.Image = Properties.Resources.sem_foto;

                }

                frmCadProdutos frm = new frmCadProdutos(dados);
                frm.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Nenhum Registro Selecionado");
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void ptbImagem_MouseHover(object sender, EventArgs e)
        {
            Produtos img = new Produtos();

            try
            {
                byte[] imagem = (byte[])dgvProdutos.CurrentRow.Cells[8].Value;
                MemoryStream ms = new MemoryStream(imagem);
                ptbImagem.Image = System.Drawing.Image.FromStream(ms);
                img.Imagem = imagem;
            }
            catch (Exception)
            {

                ptbImagem.Image = Properties.Resources.sem_foto;

            }

            frmImagem frm = new frmImagem(img);
            frm.ShowDialog();
        
           

        }

        private void ptbImagem_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }       
}
