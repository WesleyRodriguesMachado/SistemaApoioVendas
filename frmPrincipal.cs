using ApoioVendas.Relatorios;
using ApoioVendas.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApoioVendas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void seçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadSecoes frm = new frmCadSecoes();
            frm.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCategorias frm = new frmCadCategorias();
            frm.ShowDialog();
        }

        private void subCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadSubCategoria frm = new frmCadSubCategoria();
            frm.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            frmCadProdutos frm = new frmCadProdutos();
            frm.ShowDialog();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Form1 frm = new Form1();
            frm.ShowDialog();
        }




    }
}
