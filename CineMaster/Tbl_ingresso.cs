using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineMaster
{
    internal class Tbl_ingresso
    {
        public int Id_ingresso {  get; set; }
        public int Fk_id_cliente {  get; set; }
        public int Fk_sessao {  get; set; }
        public int filme {  get; set; }
        public double Preco {  get; set; }
        public Tbl_ingresso()
        {

        }
    }
}
