using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoioVendas.Entities
{
    public class SubCategorias
    {
        int id_subcategoria;
        string subcategoria;

        public int Id_subcategoria { get => id_subcategoria; set => id_subcategoria = value; }
        public string Subcategoria { get => subcategoria; set => subcategoria = value; }
    }
}
