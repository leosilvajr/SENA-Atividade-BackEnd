using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAI_Atividade
{
    public class Clientes
    {
        //Encapsulamento
        //Set       - Alterar Conteudo
        //Get       - Ler conteudo
        //protected - Proteger 
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float Valor { get; protected set; }
        public float ValorImposto { get; protected set; }
        public float Total { get; protected set; }

        //Virtual ou Abstract - Possibilita ser reescrito
        public virtual void PagarImposto(float valor)
        {
            this.Valor = valor;
            this.ValorImposto = this.Valor * 10 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }

    }
}
