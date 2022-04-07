using Atividade2.src.Entities.Interface;

namespace Atividade2.src.Entities
{
    internal class Retangulo :ICalculosGerais
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public int Area { get; set; }

        public Retangulo()
        {
        }

        public Retangulo(double @base, double altura, int area)
        {
            Base = @base;
            Altura = altura;
            Area = area;
        }

        public double CalculoDeArea()
        {
            return Base * Altura;
        }
    }
}
