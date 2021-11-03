using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, n3, n4, media;
            string result;

            Console.WriteLine("-- Média 4 Notas--\n");

            Console.WriteLine("Digite as suas notas abaixo.");
            
            Console.Write("Nota 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            n4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if(n1 < 0 || n1 > 10 
            || n2 < 0 || n2 > 10 
            || n3 < 0 || n3 > 10 
            || n4 < 0 || n4 > 10 ){
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Digite apenas notas entre 0 e 10.");
                Console.ResetColor();
            
            }
            else
            {
                
                media = (n1 + n2 + n3 + n4) / 4;

                if(media < 5.0){
                    result = "Reprovado";
                }
                else if(media < 6.0){
                    result = "Recuperação";
                }
                else{
                    result = "Aprovado";
                }

                Console.Write($"Você ficou com a media {media:N2}. Resultado: ");
                
                if(result == "Reprovado"){
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if(result == "Recuperação"){
                     Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else{
                     Console.ForegroundColor = ConsoleColor.Green;
                }
                
                Console.WriteLine($"{result}.");
                Console.ResetColor();
            }

        }
    }
}
