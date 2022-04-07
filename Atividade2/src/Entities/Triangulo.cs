using Atividade2.src.Entities.Interface;

namespace Atividade2.src.Entities
{
    internal class Triangulo: ICalculosGerais
    {
        public double Area { get; set; }
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo()
        {
        }

        public Triangulo(double area, double @base, double altura)
        {
            Area = area;
            Base = @base;
            Altura = altura;
        }

        public double CalculoDeArea()
        {
            return Base * Altura / 2;
        }
    }
}
