using ApoioVendas.Entities;
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
    public partial class frmImagem : Form
    {
        public frmImagem()
        {
            InitializeComponent();
        }

        public frmImagem(Produtos img) : this()
        {

            if (img.Imagem == null)
            {

                ptbImagem.Image = Properties.Resources.sem_foto;
                return;
            }



            ptbImagem.Image = byteArrayToImage(img.Imagem);
      
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void ptbImagem_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
