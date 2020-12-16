using System.Globalization;

namespace ExProposto137.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculoImposto();

        public override string ToString()
        {
            return Nome + ": $ " + CalculoImposto().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
