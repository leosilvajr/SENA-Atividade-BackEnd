using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAI_Atividade
{
    public class PessoaJuridica : Clientes
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }

        //Polimorfismo
        public override void PagarImposto(float valor)
        {
            this.Valor = valor;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}
