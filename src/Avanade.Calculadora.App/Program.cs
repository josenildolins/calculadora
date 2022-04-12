using Avanade.Calculadora.DomainService;
using Avanade.Calculadora.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Avanade.Calculadora.AppService
{
    public class Program
    {
        static void Main(string[] args)
        {

            var ServiceProvider = new ServiceCollection()
                .AddSingleton<IOperacoesService, OperacoesService>()
                .AddSingleton<IOperacoesDomainService, OperacoesDomainService>()
                .BuildServiceProvider();

            Console.WriteLine("Escolha o tipo de operação:");
            Console.WriteLine("");
            Console.WriteLine("Escolha 1 para somar");
            Console.WriteLine("Escolha 2 para subtrair");
            Console.WriteLine("Escolha 3 para multiplicar");
            Console.WriteLine("Escolha 4 para dividir");
            var TipoOperacao = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite o valor1");
            double clienteInput = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o valor2");
            double clienteInput2 = double.Parse(Console.ReadLine());

            var operacoes = ServiceProvider.GetService<IOperacoesService>();
            double result = 0;

            switch (TipoOperacao)
            {
                case "1":
                    result = operacoes.Somar(clienteInput, clienteInput2);
                    break;
                case "2":
                    result = operacoes.Subtrair(clienteInput, clienteInput2);
                    break;
                case "3":
                    result = operacoes.Multiplicar(clienteInput, clienteInput2);
                    break;
                case "4":
                    result = operacoes.Dividir(clienteInput, clienteInput2);
                    break;
            }

            Console.WriteLine("Resultado" + " = " + result);
        }
    }
}