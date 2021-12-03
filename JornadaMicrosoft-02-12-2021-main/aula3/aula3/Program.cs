using System;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   condicaoIf();
            //escolha();
            //enquanto();
            para();
        }

        static public void para()
        {
            int numero;
            for (numero = 1; numero <= 100; numero++)
            {
                Console.WriteLine(numero);
            }

        }

        static public void enquanto()
        {
            Console.WriteLine("Digite um numero:");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;

            while (numero != 0)
            {
                soma += soma;
                numero = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(soma);
        }

        static public void escolha()
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            switch (hora)
            {
                case < 12: Console.WriteLine("Bom dia!"); break;
                case < 18: Console.WriteLine("Boa tarde!"); break;
                default: Console.WriteLine("Boa noite!"); break;

            }
        }

        static public void condicaoIf()
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }

            if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }

            if (hora >= 18)
            {
                Console.WriteLine("Boa noite!");
            }

        }


    }
}
