using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lista4_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float exercicio;

            Console.WriteLine("======Menu======");
            Console.WriteLine("exercicio 1 - Digite1");
            Console.WriteLine("exercicio 2 - Digite2");
            Console.WriteLine("exercicio 3 - Digite3");
            Console.WriteLine("exercicio 4 - Digite4");
            Console.WriteLine("exercicio 5 _ Digite5");
            Console.WriteLine("exercicio 6 - Digite6");
            Console.WriteLine("exercicio 7 - Digite7");

            exercicio = float.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 1:

                    Console.WriteLine("A afirmação é falsa, não é possível atribuir uma variável float a uma variável int mas é possível fazer a operação inversa. ");
                    Console.WriteLine("Segue exemplos abaixo:");

                    int num1;
                    float num2;

                    num1 = num2;
                    num2 = num1;

                    Console.WriteLine("No exemplo acima podemos ver que a variavel n2 não pode ser atribuaida a variavel n1, mas a variavel n1 pode ser atribuida a n2");

                    break;

                case 2:

                    Console.WriteLine("A deferença entre os dois é que Console.Read é usado para ler apenas um carácter já o Console.ReadLine é usado para ler uma linha inteira. ");

                    break ;

                case 3:

                    Console.WriteLine("Presisamos utilizar o parse para confirmar se a o valor digitado é compativel com o tipo de variavel no qual esta sendo atribuido.");

                    break;

                case 4:

                    Console.WriteLine("O objetivo do programa é verificar se o valor digitado é par e maior que 10.");
                    Console.WriteLine("se for realizada a entrada do valor 8 e valor 27 o programa ira gerar a mensagem 2.");
                    Console.WriteLine("Ja se for realizada a entrada do valor 28 o programa ira gerar a mensagem 1. ");


                    break;

                case 5:

                    break;

                case 6:

                    int num;

                    Console.WriteLine("Digite um numero:");

                    if (num % 5 == 0 && num % 3 == 0 && num % 10 == 00)
                    
                        Console.WriteLine("o numero é divisivel po 3, 5 e 10.");
                    




             













            }
            break;
        }
    }
}
