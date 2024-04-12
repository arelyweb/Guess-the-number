using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Guess_the_number;

 class Game {
    

    private int numSecret;
    
   public int NumSecret
    {
        get { return numSecret; }
        set { numSecret = value; }
    }
    
    public Game(int ns)
    {
        this.NumSecret = ns;
        Player py = new Player("John");
        
    }
    /*
    Funcion que genera un numero aleatorio del 1 al 100
    */
   public static int GeneraNumAleatorio(){
    
        Random numRan= new Random ();
 
            //Genera un numero entre 10 y 100 (101 no se incluye)
            return numRan.Next (0,101);

    }

    public static void inciaJuego(int numSecreto){

        int x = 1;
        bool res;

        do{ 
        Console.WriteLine($"{Environment.NewLine}Ingresa tu {x.ToString()}° intento.");
        string intento = Console.ReadLine();  
        res = Player.MakeGuess(numSecreto,Int32.Parse(intento));
        x++;
       }while(x<4 && !res);
       
       Console.WriteLine($"{Environment.NewLine}EL número secreto era {numSecreto}");
         
    }

}