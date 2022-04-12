namespace Avanade.Calculadora.Service
{
    public interface IOperacoesService
    {
        double Somar(double clienteInput, double clienteInput2);

        double Subtrair(double clienteInput, double clienteInput2);

        double Multiplicar(double clienteInput, double clienteInput2);

        double Dividir(double clienteInput, double clienteInput2);
    }
}
