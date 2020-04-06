using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoioVendas.Entities
{
    public class Produtos
    {
        int id_produtos;
        string codigo;
        string descricao;
        string unidade;
        int id_secao;
        int id_categoria;
        int id_subcategoria;
        string pagina;
        byte[] imagem;
        string secao;
        string categoria;
        string subcategoria;

        public int Id_produtos { get => id_produtos; set => id_produtos = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public int Id_secao { get => id_secao; set => id_secao = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public int Id_subcategoria { get => id_subcategoria; set => id_subcategoria = value; }
        public string Pagina { get => pagina; set => pagina = value; }
        public byte[] Imagem { get => imagem; set => imagem = value; }
        public string Secao { get => secao; set => secao = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Subcategoria { get => subcategoria; set => subcategoria = value; }
    }
}
