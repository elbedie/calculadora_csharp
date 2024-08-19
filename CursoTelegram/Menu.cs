using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Menu
    {
        public static void MensagemBoasVindas()
        {
            string boasVindas = "A calculadora virtual permite fazer algumas operações como: adição, subtração, multiplicação e divisão";
            Console.WriteLine("> Seja bem-vindo! <");
            Console.WriteLine(boasVindas);
            int numLetras = boasVindas.Length;
            Console.WriteLine(new string('-', numLetras)); // o método "new string (caractere, quantidade)" permite multiplicar um caractere pela quantidade desejada
        }
        public static void ExibirMenu()

        {
            while (true)
            {
                Console.Write("Selecione o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Selecione o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Qual operação deseja fazer?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Console.WriteLine("Insira a opção desejada: ");
                int operacao = Convert.ToInt32(Console.ReadLine()!);
                double resultado = 0;

                switch (operacao)
                {

                    case 1:
                        resultado = Operacoes.Adicao(num1, num2);
                        Console.WriteLine($"O resultado da adição é: {resultado}");
                        break;
                    case 2:
                        resultado = Operacoes.Subtracao(num1, num2);
                        Console.WriteLine($"O resultado da subtração é: {resultado}");
                        break;
                    case 3:
                        resultado = Operacoes.Multiplicacao(num1, num2);
                        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                        break;
                    case 4:
                        resultado = Operacoes.Divisao(num1, num2);
                        Console.WriteLine($"O resultado da divisão é: {resultado}");
                        break;
                    default:
                        Console.WriteLine("Opção não existe!");
                        break;
                }
                
                
                int sairOuRetornar;
                while (true)
                {
                    Console.WriteLine("Digite 0 para sair do programa ou 1 para retornar ao menu");
                    sairOuRetornar = Convert.ToInt32(Console.ReadLine());
                    if (sairOuRetornar == 0)
                    {
                        Console.WriteLine("Encerrando o programa!");
                        return;
                    }
                    else if (sairOuRetornar == 1)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida! Tente novamente.");
                    }
                }
            }
        }
            
    }
}
