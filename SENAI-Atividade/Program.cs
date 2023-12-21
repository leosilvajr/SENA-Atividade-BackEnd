using SENAI_Atividade;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        float valPag;
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Endereço: ");
        string endereco = Console.ReadLine();

        Console.Write("Pessoa Física(F) OU Pessoa Jurídica(J): ");
        string tipo = Console.ReadLine();

        if (tipo.ToUpper() == "F")
        {
            //Pessoa Fisica
            PessoaFisica pf = new PessoaFisica();
            pf.Nome = nome;
            pf.Endereco = endereco;

            Console.Write("CPF: ");
            pf.CPF = Console.ReadLine();

            Console.Write("RG: ");
            pf.RG = Console.ReadLine();

            Console.Write("Informe Valor de Compra: ");
            valPag = float.Parse(Console.ReadLine());
            pf.PagarImposto(valPag);
            Console.WriteLine();
            Console.WriteLine("--------PESSOA FISICA---------");
            Console.WriteLine($"Nome:............. {pf.Nome}");
            Console.WriteLine($"Endereço:......... {pf.Endereco}");
            Console.WriteLine($"CPF:.............. {pf.CPF}");
            Console.WriteLine($"RG:............... {pf.RG}");
            Console.WriteLine($"Valor Compra:..... {pf.Valor.ToString("C")}");
            Console.WriteLine($"Imposto:.......... {pf.ValorImposto.ToString("C")}");
            Console.WriteLine($"TOTAL:............ {pf.Total.ToString("C")}");
        }

        else if (tipo.ToUpper() == "J")
        {
            //Pessoa Fisica
            PessoaJuridica pj = new PessoaJuridica();
            pj.Nome = nome;
            pj.Endereco = endereco;

            Console.Write("CNPJ: ");
            pj.CNPJ = Console.ReadLine();

            Console.Write("IE: ");
            pj.IE = Console.ReadLine();

            Console.Write("Informe Valor de Compra: ");
            valPag = float.Parse(Console.ReadLine());
            pj.PagarImposto(valPag);
            Console.WriteLine();
            Console.WriteLine("--------PESSOA JURIDICA---------");
            Console.WriteLine($"Nome:............. {pj.Nome}");
            Console.WriteLine($"Endereço:......... {pj.Endereco}");
            Console.WriteLine($"CPF:.............. {pj.CNPJ}");
            Console.WriteLine($"RG:............... {pj.IE}");
            Console.WriteLine($"Valor Compra:..... {pj.Valor.ToString("C")}");
            Console.WriteLine($"Imposto:.......... {pj.ValorImposto.ToString("C")}");
            Console.WriteLine($"TOTAL:............ {pj.Total.ToString("C")}");

        }
        else if(tipo != "F" && tipo != "J")
        {
            Console.WriteLine("ERRO: Você deve informar F / J");
        }
    }
}