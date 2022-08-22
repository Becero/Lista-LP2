using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MeuPrimeiroCodigo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
            //Ex8();
            //Ex9();
            //Ex10();
            //Ex11();
            Ex12();
        }
        static void Ex1()
        {
            float salariominimo, salariopadrao;
            double salariosrecebidos;

            Console.WriteLine("Entre com o salario minimo: ");
            salariominimo = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o  seu salario atual: ");
            salariopadrao = float.Parse(Console.ReadLine());

            salariopadrao = salariopadrao * 0.85f; //Toda vez que usar numero fracionado, usar f apos o numero 
            salariosrecebidos = (salariopadrao / salariominimo);

            Console.WriteLine("O salario digitado foi: " + salariominimo);
            Console.WriteLine("o seu salario e: " + salariopadrao);
            Console.WriteLine("Voce recebe {0} salarios:", salariosrecebidos);

            Console.ReadKey();
        }
        static void Ex2()
        {
            float metros, centímetros, milímetros;

            Console.WriteLine("Entre com a medida em metros: ");
            metros = float.Parse(Console.ReadLine());

            centímetros = metros * 100;
            milímetros = metros * 1000;

            Console.WriteLine("A medida digitado foi:{0} centímetros,{1} milimetros", centímetros, milímetros);
            Console.ReadKey();
        }
        static void Ex3()
        {
            //https://www.metric-conversions.org/pt-br/temperatura/fahrenheit-em-celsius.htm*/
            float f1, c2;
            int f, c;

            Console.WriteLine("Entre com a quantidade de graus Fahrenheit: ");
            f1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a quantidade de graus Fahrenheit: ");
            f = int.Parse(Console.ReadLine());

            c2 = (f1 - 32.0f) * (5.0f / 9.0f);
            c = (f - 32) * (5 / 9);
            Console.WriteLine("A temperatura e: " + c2);
            Console.WriteLine("A temperatura e: " + c);

            Console.ReadKey();
        }
        static void Ex4()
        {
            //eu ja havia feito um programa similar meu codigo dele no github https://github.com/Becero/Calculadora-imc/blob/main/calc.js

            float altura, peso, imc;

            Console.WriteLine("Entre com a sua altura em metros:");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o seu peso em quilos (Kg):");
            peso = float.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            if (imc < 18.5)
            {
                Console.WriteLine("IMC {0} Abaixo do peso. ",imc);
            }
            else if (imc < 25)
            {
                Console.WriteLine("IMC {0} peso ideal. Parabens!!! ",imc);
            }
            else if (imc < 30)
            {
                Console.WriteLine("IMC {0} levemente acima do peso ",imc);
            }
            else if (imc < 35)
            {
                Console.WriteLine("IMC {0} com obesidade grau 1 ",imc);
            }
            else if (imc < 40)
            {
                Console.WriteLine("IMC {0} com obesidade grau 2 ",imc);
            }
            else
            {
                Console.WriteLine("IMC {0} com obesidade grau 3, CUIDADO ",imc);
            }
            Console.ReadKey();
        }
        static void Ex5()
        {
            float md1, md2, md3, md;
            int p1, p2, p3, sp;

            Console.WriteLine("Entre com a nota 1:");
            md1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o peso da nota:");
            p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a nota 2:");
            md2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o peso da nota:");
            p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a nota 3:");
            md3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o peso da nota:");
            p3 = int.Parse(Console.ReadLine());

            sp = p1 + p2 + p3;
            md = ((md1 * p1) + (md2 * p2) + (md3 * p3)) / sp;

            Console.WriteLine("A media geral foi {0}, a soma dos pesos e {1}", md, sp);
            Console.ReadKey ();
        }
        static void Ex6()
        {
            int f, m, a;

            Console.WriteLine("May the force be with you\nVamos calcular a fórmula da segunda lei de Newton, e encontrarmos o valor da força:");
            Console.ReadKey();

            Console.WriteLine("Entre com o valor da massa em Kg:\n");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor da aceleração em m/s:\n ");
            a = int.Parse(Console.ReadLine());

            f = m * a;

            Console.WriteLine("O Calculo da Forca foi {0}N:",f);
            Console.ReadKey();
        }
        static void Ex7()
        {
            float salariopadrao,novosalario;

            Console.WriteLine("Entre com o  seu salario atual: ");
            salariopadrao = float.Parse(Console.ReadLine());

            novosalario = salariopadrao + (salariopadrao * (33.7f/100));

            Console.WriteLine("O seu novo salario e:R$" + novosalario);
            Console.ReadKey();
        }
        static void Ex8()
        {
            float real, dolar, total;

            Console.WriteLine("Entre com o valor em Real:");
            real = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do Dolar atual:");
            dolar = float.Parse(Console.ReadLine());
            total = real / dolar;

            Console.WriteLine("Voce tem {0} dolares",total);
            Console.ReadKey(); 
        }
        static void Ex9()
        {
            int n;
            Console.WriteLine("Entre com um valor:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma de {0} com {1} e {2}", (n * 3) - 1, (n * 2) + 1, (n * 3) - 1 + (n * 2) + 1);
            Console.ReadKey();

        }
        static void Ex10()
        {
            int x;
            int a, b, c;
            Console.WriteLine("Entre com um numero de 4 digitos");
            x = int.Parse(Console.ReadLine());
           
            a = (x / 1000);
            x = (x % 1000);
            b = (x / 100);
            x = (x % 100);
            c = (x / 10);
            x = (x % 10);     
             
            Console.Write("{0}\n{1}\n{2}\n{3}",a,b,c,x);
            Console.ReadKey();
        }
        static void Ex11()
        {
            float a,b,c,d;

            Console.WriteLine("Apos o primeiro dia:R$ {0}", a =  1000 - (1000 * 0.124f));
            Console.WriteLine("Apos o segundo dia:R$ {0}", b = a + (a * 0.018f));
            Console.WriteLine("Apos o terceiro dia:R$ {0}", c = b + (b * 0.056f));
            Console.WriteLine("Apos o quarto dia:R$ {0}", d = c - (c * 0.045f));
            Console.ReadKey();
        }
        static void Ex12() {
            float h;
            char s;

            Console.WriteLine("Entre o valor da altura");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu sexo M para masculino e F para feminino");
            s = char.Parse(Console.ReadLine());
            
            if (s == 'M') {
                Console.WriteLine("SEU PESO IDEAL E{0}", (72.7f * h) - 58);
                    }
            else if(s == 'F')
            {
                Console.WriteLine("SEU PESO IDEAL E {0}", (62.1f * h) - 44.7f);
             }
            Console.ReadKey();           
            
          }
    }
}