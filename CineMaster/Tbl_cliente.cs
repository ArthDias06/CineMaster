using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineMaster
{
    internal class Tbl_cliente
    {
        public int Id_cliente {  get; set; }
        public string Nome_cliente { get; set; }
        public string Tipo_cliente { get; set; }
        public DateTime Data_nascimento {  get; set; }
        public string Email {  get; set; }
        public string Senha { get; set; }
        public string Telefone {  get; set; }
        public string Cpf { get; set; }
        public Tbl_cliente()
        {
        }
    }
}
