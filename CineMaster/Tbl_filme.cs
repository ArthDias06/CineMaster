using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace CineMaster
{

    internal class Tbl_filme
    {
        public int Id_filme { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Classificacao { get; set; }
        public string Sinopse { get; set;}
        DateTime Data_lancamento { get; set; }
        public Tbl_filme()
        {

        }
    }
}
