using Atividade2.src.Entities.Interface;

namespace Atividade2.src.Entities
{
    internal class Quadrado :ICalculosGerais
    {
        public double Lado { get; set; }
        public double Area { get; set; }

        public Quadrado()
        {
        }

        public Quadrado(double lado, double area)
        {
            Lado = lado;
            Area = area;
        }
        

        public double CalculoDeArea()
        {
            return Lado * Lado ;
        }
    }
}
