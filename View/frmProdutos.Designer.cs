namespace ApoioVendas.View
{
    partial class frmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptbImagem = new System.Windows.Forms.PictureBox();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.rdbSubcategoria = new System.Windows.Forms.RadioButton();
            this.rdbCategoria = new System.Windows.Forms.RadioButton();
            this.rdbSecao = new System.Windows.Forms.RadioButton();
            this.rdbPagina = new System.Windows.Forms.RadioButton();
            this.rdbDescricao = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 162);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(952, 454);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txturl_CellDoubleClick);
            this.dgvProdutos.SelectionChanged += new System.EventHandler(this.txturl_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gpbFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lbl);
            this.groupBox3.Location = new System.Drawing.Point(582, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 134);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "label1";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(62, 21);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(115, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Produtos Encontrados.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptbImagem);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ptbImagem
            // 
            this.ptbImagem.Location = new System.Drawing.Point(6, 11);
            this.ptbImagem.Name = "ptbImagem";
            this.ptbImagem.Size = new System.Drawing.Size(236, 117);
            this.ptbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagem.TabIndex = 2;
            this.ptbImagem.TabStop = false;
            this.ptbImagem.MouseLeave += new System.EventHandler(this.ptbImagem_MouseLeave);
            this.ptbImagem.MouseHover += new System.EventHandler(this.ptbImagem_MouseHover);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.btnAtualizar);
            this.gpbFiltro.Controls.Add(this.cboBuscar);
            this.gpbFiltro.Controls.Add(this.txtBusca);
            this.gpbFiltro.Controls.Add(this.rdbSubcategoria);
            this.gpbFiltro.Controls.Add(this.rdbCategoria);
            this.gpbFiltro.Controls.Add(this.rdbSecao);
            this.gpbFiltro.Controls.Add(this.rdbPagina);
            this.gpbFiltro.Controls.Add(this.rdbDescricao);
            this.gpbFiltro.Controls.Add(this.rdbCodigo);
            this.gpbFiltro.Location = new System.Drawing.Point(260, 12);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(316, 134);
            this.gpbFiltro.TabIndex = 0;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(244, 19);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(40, 40);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cboBuscar
            // 
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Location = new System.Drawing.Point(6, 91);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(303, 21);
            this.cboBuscar.TabIndex = 7;
            this.cboBuscar.Visible = false;
            this.cboBuscar.SelectedIndexChanged += new System.EventHandler(this.cboBuscar_SelectedIndexChanged);
            this.cboBuscar.SelectionChangeCommitted += new System.EventHandler(this.cboBuscar_SelectionChangeCommitted);
            // 
            // txtBusca
            // 
            this.txtBusca.Enabled = false;
            this.txtBusca.Location = new System.Drawing.Point(6, 91);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(303, 20);
            this.txtBusca.TabIndex = 6;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // rdbSubcategoria
            // 
            this.rdbSubcategoria.AutoSize = true;
            this.rdbSubcategoria.Location = new System.Drawing.Point(146, 55);
            this.rdbSubcategoria.Name = "rdbSubcategoria";
            this.rdbSubcategoria.Size = new System.Drawing.Size(92, 17);
            this.rdbSubcategoria.TabIndex = 5;
            this.rdbSubcategoria.TabStop = true;
            this.rdbSubcategoria.Text = "Sub-Categoria";
            this.rdbSubcategoria.UseVisualStyleBackColor = true;
            this.rdbSubcategoria.CheckedChanged += new System.EventHandler(this.rdbSubcategoria_CheckedChanged);
            // 
            // rdbCategoria
            // 
            this.rdbCategoria.AutoSize = true;
            this.rdbCategoria.Location = new System.Drawing.Point(70, 55);
            this.rdbCategoria.Name = "rdbCategoria";
            this.rdbCategoria.Size = new System.Drawing.Size(70, 17);
            this.rdbCategoria.TabIndex = 4;
            this.rdbCategoria.TabStop = true;
            this.rdbCategoria.Text = "Categoria";
            this.rdbCategoria.UseVisualStyleBackColor = true;
            this.rdbCategoria.CheckedChanged += new System.EventHandler(this.rdbCategoria_CheckedChanged);
            // 
            // rdbSecao
            // 
            this.rdbSecao.AutoSize = true;
            this.rdbSecao.Location = new System.Drawing.Point(6, 55);
            this.rdbSecao.Name = "rdbSecao";
            this.rdbSecao.Size = new System.Drawing.Size(56, 17);
            this.rdbSecao.TabIndex = 3;
            this.rdbSecao.TabStop = true;
            this.rdbSecao.Text = "Seção";
            this.rdbSecao.UseVisualStyleBackColor = true;
            this.rdbSecao.CheckedChanged += new System.EventHandler(this.rdbSecao_CheckedChanged);
            // 
            // rdbPagina
            // 
            this.rdbPagina.AutoSize = true;
            this.rdbPagina.Location = new System.Drawing.Point(149, 19);
            this.rdbPagina.Name = "rdbPagina";
            this.rdbPagina.Size = new System.Drawing.Size(58, 17);
            this.rdbPagina.TabIndex = 2;
            this.rdbPagina.TabStop = true;
            this.rdbPagina.Text = "Página";
            this.rdbPagina.UseVisualStyleBackColor = true;
            this.rdbPagina.CheckedChanged += new System.EventHandler(this.rdbPagina_CheckedChanged_1);
            // 
            // rdbDescricao
            // 
            this.rdbDescricao.AutoSize = true;
            this.rdbDescricao.Location = new System.Drawing.Point(70, 19);
            this.rdbDescricao.Name = "rdbDescricao";
            this.rdbDescricao.Size = new System.Drawing.Size(73, 17);
            this.rdbDescricao.TabIndex = 1;
            this.rdbDescricao.TabStop = true;
            this.rdbDescricao.Text = "Descrição";
            this.rdbDescricao.UseVisualStyleBackColor = true;
            this.rdbDescricao.CheckedChanged += new System.EventHandler(this.rdbDescricao_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(6, 19);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdbCodigo.TabIndex = 0;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged_1);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: CONSULTA PRODUTOS ::";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbPagina;
        private System.Windows.Forms.RadioButton rdbDescricao;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.RadioButton rdbSubcategoria;
        private System.Windows.Forms.RadioButton rdbCategoria;
        private System.Windows.Forms.RadioButton rdbSecao;
        private System.Windows.Forms.PictureBox ptbImagem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnAtualizar;
    }
}