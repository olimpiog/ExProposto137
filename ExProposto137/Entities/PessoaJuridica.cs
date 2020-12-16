using System;
using System.Collections.Generic;
using System.Text;

namespace ExProposto137.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalculoImposto()
        {
            if (NumeroFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            } else
            {
                return RendaAnual * 0.16;
            }

        }
    }
}
