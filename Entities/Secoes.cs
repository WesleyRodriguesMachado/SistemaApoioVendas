using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoioVendas.Entities
{
     public class Secoes
    {
        int id_secao;
        string secao;

        public int Id_secao { get => id_secao; set => id_secao = value; }
        public string Secao { get => secao; set => secao = value; }
    }
}
