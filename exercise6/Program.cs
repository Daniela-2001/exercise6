namespace exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello, World!"); // Imprime um valor na tela

            Console.ForegroundColor = ConsoleColor.Yellow; //Altera a cor da fonte
            Console.WriteLine("Meu primeiro projeto");

            Console.ReadKey(); // Aguarda o pressionamento de alguma tecla para continuar

            */

            int NumeroDigitado;

            Console.WriteLine("Digite um número");

            NumeroDigitado=Convert.ToInt32(Console.ReadLine()); //Lê e converte para int o número informado

            Console.WriteLine(NumeroDigitado.ToString());

            if (NumeroDigitado % 2 == 0)

            {       
                    //Número par
                    Console.WriteLine("O número informado é PAR");
            }

            else{
                //Número ímpar
                Console.WriteLine("O número informado é ÍMPAR");

            }
            Console.ReadKey(); 

        }
    }
}