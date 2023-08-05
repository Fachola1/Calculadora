using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora");
            Console.WriteLine("Opções: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine();

            Console.WriteLine("Digite o número da opção: ");
            int opcaoUsuario = Convert.ToInt32(Console.ReadLine());

            if (opcaoUsuario == 1)
            {
                Somar();
            }

            else if (opcaoUsuario == 2)
            {
                Subtrair();
            }

            else if (opcaoUsuario == 3)
            {
                Multiplicar();
            }

            else
            {
                Dividir();
            }

            int Somar()
            {
                Console.WriteLine("Digite um número: ");
                int numeroUsuario1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                int numeroUsuario2 = Convert.ToInt32(Console.ReadLine());
                return numeroUsuario1 + numeroUsuario2;
            }

            int Subtrair()
            {
                Console.WriteLine("Digite um número: ");
                int numeroUsuario1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                int numeroUsuario2 = Convert.ToInt32(Console.ReadLine());
                return numeroUsuario1 - numeroUsuario2;
            }

            int Multiplicar()
            {
                Console.WriteLine("Digite um número: ");
                int numeroUsuario1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                int numeroUsuario2 = Convert.ToInt32(Console.ReadLine());
                return numeroUsuario1 * numeroUsuario2;
            }

            void Dividir()
            {
                Console.WriteLine("Digite um número: ");
                int numeroUsuario1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                int numeroUsuario2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numeroUsuario1 / numeroUsuario2);
            }

            Console.ReadLine();
        }


    }
}
