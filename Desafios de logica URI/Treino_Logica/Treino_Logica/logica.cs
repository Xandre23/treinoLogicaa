﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class logica
    {
        public static void ex1000()
        {
            Console.Write("Hello World!");

        }
        public static void ex1001()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int x = a + b;

            Console.WriteLine("X = " + x);
        }
        public static void ex1002()
        {
            double pi = 3.14159;


            double raio = Convert.ToDouble(Console.ReadLine());

            double a = pi * (raio * raio);

            Console.WriteLine("A=" + a.ToString("0.0000"));
        }
        public static void ex1003()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int soma = a + b;
            Console.WriteLine("SOMA = " + soma);
        }
        public static void ex1004()
        {
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int prod = valor1 * valor2;

            Console.WriteLine("PROD = " + prod);
        }
        public static void ex1005()
        {
            const double a = 3.5;
            const double b = 7.5;

            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 * a + nota2 * b) / (a + b);

            Console.WriteLine("MEDIA = " + media.ToString("0.00000"));
        }
        public static void ex1006()
        {
            const double a = 2;
            const double b = 3;
            const double c = 5;

            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 * a + nota2 * b + nota3 * c) / (a + b + c);

            Console.WriteLine("MEDIA = " + media.ToString("0.0"));
        }
        public static void ex1007()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int diff = a * b - c * d;

            Console.WriteLine("DIFERENCA = " + diff);
        }
        public static void ex1008()
        {
            Console.WriteLine("************* Informações do funcionario ****************");
            int numero = Convert.ToInt32(Console.ReadLine());
            double horastrab = Convert.ToDouble(Console.ReadLine());
            double valor = Convert.ToDouble(Console.ReadLine());

            double salario = horastrab * valor;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("0.00"));
        }
        public static void ex1009()
        {
            string nome = Convert.ToString(Console.ReadLine());
            double salario = Convert.ToDouble(Console.ReadLine());
            double vendas = Convert.ToDouble(Console.ReadLine());

            double comissao = salario + vendas * 0.15;

            Console.WriteLine("TOTAL = R$ " + comissao.ToString("0.00"));
        }
        public static void ex1010()
        {
            //diff
            int codigoUm, quantidadeUm;
            double valorUm;
            int codigoDois, quantidadeDois;
            double valorDois;
            double soma;

            string[] vetUm = Console.ReadLine().Split(' ');
            string[] vetDois = Console.ReadLine().Split(' ');

            codigoUm = int.Parse(vetUm[0]);
            quantidadeUm = int.Parse(vetUm[1]);
            valorUm = double.Parse(vetUm[2]);

            codigoDois = int.Parse(vetDois[0]);
            quantidadeDois = int.Parse(vetDois[1]);
            valorDois = double.Parse(vetDois[2]);

            soma = (quantidadeUm * valorUm) + (quantidadeDois * valorDois);

            Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("0.00"));
        }
         public static void ex1011()
        {
         // valor do raio
        Console.WriteLine("valor de seu raio (R): ");
        double valorRaio = double.Parse(Console.ReadLine());

        double volumeEsfera = (4 * 3.14159 * Math.Pow(valorRaio, 3)) / 3;

        Console.WriteLine("VOLUME = " + volumeEsfera.ToString("F3"));
        }
        
        public static void ex1012()
        {
            string[] vet = Console.ReadLine().Split(' ');

        double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
        double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
        double c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
        double areaTriangulo = (a * c)/ 2;
        double circuloRaio = (c * c) * 3.14159;
        double areaTrapezio = ((a + b) * c) / 2;
        double areaQuadrado = b * b;
        double areaRetangulo = a * b;
            
       Console.WriteLine("TRIANGULO: "+ areaTriangulo.ToString("N3"), CultureInfo.InvariantCulture);
       Console.WriteLine("CIRCULO: "+ circuloRaio.ToString("#.000"), CultureInfo.InvariantCulture);  //formatação diferente, pois o urijudge só aceita assim.
       Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("N3"), CultureInfo.InvariantCulture);
       Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("N3"), CultureInfo.InvariantCulture);
       Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("N3"), CultureInfo.InvariantCulture);
        }
            public static void ex1013()
        {
              string[] vet = Console.ReadLine().Split(' ');

        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);
        int c = int.Parse(vet[2]);

        int MaiorAB = 0;
        MaiorAB=(a+b+Math.Abs(a - b))/2;

        if (MaiorAB > c)
        {
            Console.WriteLine(MaiorAB + " eh o maior");
            }
        else
        {
            Console.WriteLine(c + " eh o maior");
        }   
    }
           public static void ex1014()
        {
         int totalPercorrido = int.Parse(Console.ReadLine());
          double combustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

        double consumoMedio = (int)totalPercorrido / (double)combustivelGasto;

        Console.WriteLine(consumoMedio.ToString("#.000") + " km/l");
        }
        
             public static void ex1015()
        {
       string[] ponto1 = Console.ReadLine().Split(' ');

        double x1 = double.Parse(ponto1[0], CultureInfo.InvariantCulture);
        double y1 = double.Parse(ponto1[1], CultureInfo.InvariantCulture);


        string[] ponto2 = Console.ReadLine().Split(' ');

        double x2 = double.Parse(ponto2[0], CultureInfo.InvariantCulture);
        double y2 = double.Parse(ponto2[1], CultureInfo.InvariantCulture);

        double distancia = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));

        Console.WriteLine(distancia.ToString("N4"), CultureInfo.InvariantCulture);
        }
         public static void ex1016()
        {
        Console.WriteLine("distância (em Km)");
        int distancia = int.Parse(Console.ReadLine());

        int tempo = distancia * 2;

        Console.WriteLine(tempo + " minutos");
        }
        public static void ex1017()
        {
        Console.WriteLine("Tempo gasto em horas: ");
        int tmpGasto = int.Parse(Console.ReadLine());
        Console.WriteLine("Velocidade média durante a mesma em km/h:  ");
        int veloMedia = int.Parse(Console.ReadLine());

        double litros = tmpGasto * veloMedia;
        double media = litros / 12;
            
        Console.WriteLine(media.ToString("N3"));
        }
        
         public static void ex1018()
        {
         //exercicio confuso.

        int valorLido, nota100, nota50, nota20, nota10, nota5, nota2, nota1;

        valorLido = int.Parse(Console.ReadLine());

        Console.WriteLine(valorLido);

        nota100 = valorLido / 100;
        valorLido = valorLido% 100;

        nota50 = valorLido / 50;
        valorLido = valorLido % 50;

        nota20 = valorLido / 20;
        valorLido = valorLido % 20;

        nota10 = valorLido / 10;
        valorLido = valorLido % 10;

        nota5 = valorLido / 5;
        valorLido = valorLido % 5;

        nota2 = valorLido / 2;
        valorLido = valorLido % 2;

        nota1 = valorLido / 1;
        valorLido = valorLido % 1;

        
        Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
        Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
        Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
        Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
        Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
        Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
        Console.WriteLine(nota1 + " nota(s) de R$ 1,00");
        }
        
        
        static void Main(string[] args)
        {
            int escolha;

            do
            {
                Console.WriteLine("\n\t| 0 para sair |\nDigite o programa desejado:");
                escolha = Convert.ToInt32(Console.ReadLine());
                Console.Write("--------------------\n");
                if (escolha == 0)
                {
                    Console.WriteLine("Obrigado por utilizar nosso programa");
                    break;
                }
                switch (escolha)
                {
                    case 0:
                        logica.ex1000();
                        break;
                    case 1:
                        logica.ex1001();
                        break;
                    case 2:
                        logica.ex1002();
                        break;
                    case 3:
                        logica.ex1003();
                        break;
                    case 4:
                        logica.ex1004();
                        break;
                    case 5:
                        logica.ex1005();
                        break;
                    case 6:
                        logica.ex1006();
                        break;
                    case 7:
                        logica.ex1007();
                        break;
                    case 8:
                        logica.ex1008();
                        break;
                    case 9:
                        logica.ex1009();
                        break;
                    case 10:
                        logica.ex1010();
                        break;
                     case 11:
                        logica.ex1011();
                        break;
                    case 12:
                        logica.ex1012();
                        break;
                    case 13:
                        logica.ex1013();
                        break;
                    case 14:
                        logica.ex1014();
                        break;
                    case 15:
                        logica.ex1015();
                        break;
                    case 16:
                        logica.ex1016();
                        break;
                     case 17:
                        logica.ex1017();
                        break;
                      case 18:
                        logica.ex1018();
                        break;
                        
                    default:
                        Console.Write("Opção Invalida");
                        break;
                }



            } while (escolha != 0);



        }
    }
}

