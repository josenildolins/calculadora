namespace Avanade.Calculadora.DomainService
{
    public class OperacoesDomainService : IOperacoesDomainService
    {

        public double Dividir( double clienteInput, double clienteInput2)
        {
            double result = clienteInput / clienteInput2;

            return result;
        }

        public double Multiplicar(double clienteInput, double clienteInput2)
        {
            double result = clienteInput * clienteInput2;

            return result;
        }

        public double Somar(double clienteInput, double clienteInput2)
        {
            double result = clienteInput + clienteInput2;

            return result;
        }

        public double Subtrair(double clienteInput, double clienteInput2)
        {
            double result = clienteInput - clienteInput2;

            return result;
        }
    }
}