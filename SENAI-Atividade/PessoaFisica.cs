using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAI_Atividade
{
    public class PessoaFisica : Clientes
        //PessoaFisica é uma SubClasse de Clientes : Herança
    {
        public string CPF { get; set; }
        public string RG { get; set; }
    }
}
