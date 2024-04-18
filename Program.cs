using System.Security.Cryptography.X509Certificates;

namespace Guess_the_number;

class Program
{
  
    static void Main(string[] args)
    {
      Console.WriteLine("Reglas del juego:Tienes dos intentos para adivinar el número del 1 al 100");
      Console.WriteLine("y se te indicará que tan cerca o lejos quedaste. ¡SUERTE!");
      Console.WriteLine("Ingresa tu nombre:");
      string? nombre = Console.ReadLine();
      
      Game iJuego = new(nombre);
      iJuego.inciaJuego();
     
      Console.Write($"{Environment.NewLine}Press any key to exit...");
      Console.ReadKey(true);
    }
    
  
}
