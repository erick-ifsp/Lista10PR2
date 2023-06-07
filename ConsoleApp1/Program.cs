using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int numm, nmaior, nmenor, q;
            int[] vet;

            Console.WriteLine("digite a quantidade de variaveis:");
            q = int.Parse(Console.ReadLine());
            vet = new int[q];

            float soma = 0;

            Console.WriteLine("digite um numero");
            numm = int.Parse(Console.ReadLine());
            vet[0] = numm;
            nmaior = numm;
            nmenor = numm;

            for (int i = 1; i < q; i++)
            {
                Console.WriteLine("digite um numero");
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i] > nmaior)
                {
                    nmaior = vet[i];
                }
                if (vet[i] < nmenor)
                {
                    nmenor = vet[i];
                }
            }

            for (int i = 0; i < q; i++)
            {
                soma += vet[i];
            }

            Console.WriteLine("O menor numero é: " + nmenor + " e o maior é: " + nmaior + " e a média aritmética é: " + soma / q);
        }

        public static void Exercicio2()
        {
            int t, soma = 0, media = 0;
            int[] vet;

            do
            {
                Console.WriteLine("digite a quantidade de numeros (numero maior que 0)");
                t = int.Parse(Console.ReadLine());
                vet = new int[t];

            } while (t <= 0);

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("digite um numero");
                vet[i] = int.Parse(Console.ReadLine());
                soma = soma + vet[i];
            }
            media = soma / t;

            for (int i = 0; i < t; i++)
            {
                if (vet[i] >= media)
                {
                    Console.WriteLine("os numeros maiores que a média é: " + vet[i]);
                }

            }
        }

        public static void Exercicio3()
        {
            int t, soma = 0, media = 0;
            int[] vet;

            Random rand = new Random();

            do
            {
                Console.WriteLine("digite a quantidade de numeros (numero maior que 0)");
                t = int.Parse(Console.ReadLine());
                vet = new int[t];

            } while (t <= 0);

            for (int i = 0; i < t; i++)
            {
                vet[i] = rand.Next(1, 100);
                soma = soma + vet[i];
            }
            media = soma / t;

            for (int i = 0; i < t; i++)
            {
                if (vet[i] >= media)
                {
                    Console.WriteLine("os numeros maiores que a média é: " + vet[i]);
                }

            }
        }
        public static void Exercicio4()
        {
            string[] vet1;

            Console.WriteLine("digite a quantidade de nomes:");
            int qq = int.Parse(Console.ReadLine());
            vet1 = new string[qq];

            for (int i = 0; i < qq; i++)
            {
                Console.WriteLine("digite os nomes:");
                vet1[i] = Console.ReadLine();

            }

            Console.WriteLine("\n");

            for (int i = qq - 1; i >= 0; i--)
            {
                Console.WriteLine("posicão[{0}] = {1}", i, vet1[i]);
            }
        }
        public static void Exercicio5()
        {
            int t, soma = 0, media = 0, par = 0, imp = 0;
            int[] vet;

            Random rand = new Random();

            do
            {
                Console.WriteLine("digite a quantidade de numeros (numero maior que 0)");
                t = int.Parse(Console.ReadLine());
                vet = new int[t];

            } while (t <= 0);

            for (int i = 0; i < t; i++)
            {
                vet[i] = rand.Next(1, 100);
                if (vet[i] % 2 == 0)
                {
                    par += 1;
                }
                else
                {
                    imp += 1;
                }
            }
            Console.WriteLine("A quantidade de numeros pares é: " + par + " e a quantidade de numeros impares é: " + imp);
        }

            static void Main(string[] args)
            {

                int option;

                do
                {
                    Console.WriteLine("=================MENU=================");
                    Console.WriteLine("para executar o exercício 1 - digite 1");
                    Console.WriteLine("para executar o exercício 2 - digite 2");
                    Console.WriteLine("para executar o exercício 3 - digite 3");
                    Console.WriteLine("para executar o exercício 4 - digite 4");
                    Console.WriteLine("para executar o exercício 5 - digite 5");
                    Console.WriteLine("para sair do programa    -    digite 0");

                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("thank you for using my system!");

                            break;

                        case 1:
                            Exercicio1();

                            break;

                        case 2:
                            Exercicio2();

                            break;

                        case 3:
                            Exercicio3();

                            break;

                        case 4:
                            Exercicio4();

                            break;

                        case 5:
                            Exercicio5();

                            break;

                        default:
                            Console.WriteLine("wrong option!");

                            break;
                    }
                } while (option != 0);
            }
        }
    }


