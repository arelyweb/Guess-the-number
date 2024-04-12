using System.Security.Cryptography.X509Certificates;

namespace Guess_the_number;

class Program
{
  
    static void Main(string[] args)
    {
      int numRan = Game.GeneraNumAleatorio();
      Console.WriteLine("Reglas del juego:Tienes dos intentos para adivinar el número ");
      Console.WriteLine("y se te indicará que tan cerca o lejos quedaste. ¡SUERTE!");
      
      Game.inciaJuego(numRan);
     
      Console.Write($"{Environment.NewLine}Press any key to exit...");
      Console.ReadKey(true);
    }
    
  
}
