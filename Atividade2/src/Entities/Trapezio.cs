using Atividade2.src.Entities.Interface;

namespace Atividade2.src.Entities
{
    internal class Trapezio : ICalculosGerais
    {
        public double Area { get; set; }
        public double BaseMenor { get; set; }
        public double BaseMaior { get; set; }
        public double Altura { get; set; }

        public Trapezio()
        {
        }

        public Trapezio(double area, double baseMenor, double baseMaior, double altura)
        {
            Area = area;
            BaseMenor = baseMenor;
            BaseMaior = baseMaior;
            Altura = altura;
        }

        public double CalculoDeArea()
        {
            return (BaseMenor + BaseMenor) * Altura /2;
        }
    }
}
