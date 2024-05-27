using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dim.Fornecedor.BO
{
    public class Fornecedor
    {
        public int Codigo { get; set; }
        public int CNPJ { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set;  }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int CEP { get; set; }
    }
}
