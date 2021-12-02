using System;
using System.Globalization;

namespace aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operadorlogico();
            //variavel();
            interpolacao();

        }

        public static void geral()
        {
            String nome = "Pedro";
            int idade = 56;

            Console.WriteLine(nome + " " + idade);

            int a = 10;
            bool resposta = a > 10;
            Console.WriteLine("valor da resposta: " + resposta);
        }

        public static void variaveis() //classe pricipal;
        {
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine("------------");

            a += 2;
            Console.WriteLine(a);
            Console.WriteLine("------------");


            string alfabeto = "ABC";
            alfabeto += "DEF";
            Console.WriteLine(alfabeto);

            Console.WriteLine("------------");

            a = 10; //receber 10.
            a *= 3; //10 * 3;
            Console.WriteLine(a);

        }

        public static void operadoresrelacionais()
        {
            
        } 

        public static void operadorlogico()
        {
            int salario1 = 100;
            int salario2 = 50;
            int salario3 = 200;

            bool resultadosalario = salario1 > salario2 && salario1 > salario3;

            Console.WriteLine(resultadosalario);

            bool resultado2 = salario2 < salario1 || salario2 > salario3;

            Console.WriteLine(resultado2);

            bool resultado3 = !(salario2 > salario3);

            Console.WriteLine(resultado3);
        }
        public static void variavel()
        {
            Console.WriteLine("Entrada de dados");
            Console.WriteLine("Digite o seu nome: ");

            string nomeDoUsuario = Console.ReadLine();

            Console.WriteLine("O nome digitado é: " + nomeDoUsuario); 
        }
        public static void interpolacao()
        {
            int idade = 56;
            double saldo = 10.35784;
            string nome = "Claudia";

            Console.WriteLine("Claudia tem 56 anos e tem saldo 10.35784 reais");

            Console.WriteLine("{0} tem {1} anos e tem saldo igual {2}", nome, idade, saldo);

            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));

            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }

}
