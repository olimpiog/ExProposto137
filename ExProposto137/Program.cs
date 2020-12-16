using System;
using System.Collections.Generic;
using ExProposto137.Entities;
using System.Globalization;

namespace ExProposto137
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Console.Write("Entre com o número de contribuintes: ");
            int qtdContribuintes = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= qtdContribuintes; i++)
            {
                Console.WriteLine($"[Dados do contribuinte #{i}]");
                Console.Write("Pessoa (f)ísica ou (j)urídica: ");
                char TipoPessoa = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string Nome = Console.ReadLine();

                Console.Write("Renda Anual: ");
                double RendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               
                if (TipoPessoa == 'f' || TipoPessoa == 'F')
                {
                    Console.Write("Gastos com saúde: ");
                    double GastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoas.Add(new PessoaFisica(Nome, RendaAnual, GastosSaude));                    
                } else
                {
                    Console.Write("Quantidade de funcionários: ");
                    int QtdeFuncionarios = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaJuridica(Nome, RendaAnual, QtdeFuncionarios));
                }
                
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Imposto por contribuinte:");
            double TotalImposto = 0.0;
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
                TotalImposto += pessoa.CalculoImposto();
            }

            Console.WriteLine("");
            Console.WriteLine("TOTAL IMPOSTO: $ " + TotalImposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
