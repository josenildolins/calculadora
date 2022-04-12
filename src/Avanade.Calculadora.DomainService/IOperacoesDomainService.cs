namespace Avanade.Calculadora.DomainService
{
    public interface IOperacoesDomainService
    {
        double Subtrair(double clienteInput, double clienteInput2);

        double Multiplicar(double clienteInput, double clienteInput2);

        double Dividir(double clienteInput, double clienteInput2);

        double Somar(double clienteInput, double clienteInput2);
    }
}
