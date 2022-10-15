using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:
            Console.WriteLine("Digite qual operação você deseja realizar:\n1- Soma\n2- Subtração\n3_ Multiplicação\n4- Divisão");
            char escolha = char.Parse(Console.ReadLine());

            if(escolha == '1')
            {
                Soma();

            }else if(escolha == '2')
            {
                Subitracao();
            }else if (escolha == '3')
            {
                Multiplicacao();
            }else if (escolha == '4')
            {
                Divisao();
            }
            else
            {
                Console.WriteLine("Valor invalido, digite uma valor valido(1,2,3 ou 4)");
                goto inicio;
            }



            Console.ReadLine();

        }

        static void Soma()
        {
            Console.Write("Digite o primeiro valor a ser somado: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor a ser somado: ");
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine("O resultado da soma é: " + soma);


        }

        static void Subitracao()
        {
            Console.Write("Digite o primeiro valor da subtração: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor da subtração: ");
            int b = int.Parse(Console.ReadLine());

            int subitracao = a - b;

            Console.WriteLine("O resultado da subitração é: " + subitracao);

        }

        static void Multiplicacao()
        {
            Console.Write("Digite o primeiro valor da multiplicação: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor da multiplicação: ");
            int b = int.Parse(Console.ReadLine());

            int multiplicacao = a * b;

            Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);

        }

        static void Divisao()
        {
            Console.Write("Digite o valor do Numerador da divisão: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor do Denominador da divisão: ");
            float b = float.Parse(Console.ReadLine());

            float divisao = a / b;

            Console.WriteLine("O resultado da divisão é: " + divisao);
        }
    }
}
