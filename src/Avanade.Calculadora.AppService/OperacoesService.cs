using Avanade.Calculadora.DomainService;

namespace Avanade.Calculadora.Service
{

    public class OperacoesService : IOperacoesService
    {
        private readonly IOperacoesDomainService _operacoesService;

        public OperacoesService(IOperacoesDomainService operacoesDomainService)
        {
            _operacoesService = operacoesDomainService;
        }

        public double Dividir(double clienteInput, double clienteInput2)
        {
            return _operacoesService.Dividir(clienteInput, clienteInput2);
        }

        public double Multiplicar(double clienteInput, double clienteInput2)
        {
            return _operacoesService.Multiplicar(clienteInput, clienteInput2);
        }

        public double Somar(double clienteInput, double clienteInput2)
        {
            return _operacoesService.Somar(clienteInput, clienteInput2);
        }

        public double Subtrair(double clienteInput, double clienteInput2)
        {
            return _operacoesService.Subtrair(clienteInput, clienteInput2);
        }
    }
}
