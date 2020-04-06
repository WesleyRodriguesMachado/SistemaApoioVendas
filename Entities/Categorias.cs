using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoioVendas.Entities
{
    public class Categorias
    {
        int id_categoria;
        string categoria;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
