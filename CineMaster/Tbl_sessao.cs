using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineMaster
{
    internal class Tbl_sessao
    {
        public int Id_sessao { get; set; }
        public int Filme { get; set; }
        public TimeSpan Horario_sessao { get; set; }
        public int Num_sala {  get; set; }
        public Tbl_sessao()
        { 
        }
    }
}
