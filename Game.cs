using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Guess_the_number;

 class Game {
    
   private int numRan {get;set;}
   private Player Player {get;set;} 

    public Game(string jugadora)
    {
        RandomNumberGenerator();
        Player = new Player(jugadora);
        
    }
    /*
    Funcion que genera un numero aleatorio del 1 al 100
    */
    private void RandomNumberGenerator(){
        Random ran= new Random ();
 
            //Genera un numero entre 10 y 100 (101 no se incluye)
           numRan = ran.Next (1,101);
    }
    
    private bool CheckGuess(int numSecreto, int intento){

         bool res= false;

        if (intento == numSecreto){
          Console.WriteLine($"{Environment.NewLine}¡divinaste!, eres un genio.");
          res= true;
        }else if(intento > numSecreto){
          Console.WriteLine($"{Environment.NewLine}El número secreto es menor.");
        }else{
          Console.WriteLine($"{Environment.NewLine}El número secreto es mayor.");
        }
      return res;

    }

    public void inciaJuego(){

       int intento = Player.MakeGuess();

       int x = 5;

       do{
         if (intento == numRan){
          Console.WriteLine($"{Environment.NewLine}¡Adivinaste!, eres un genio.");
          x=0;
        }else if(intento > numRan){
          Console.WriteLine($"{Environment.NewLine}El número secreto es menor.");
          intento = Player.MakeGuess(); 
          x--;
        }else{
          Console.WriteLine($"{Environment.NewLine}El número secreto es mayor.");
          intento = Player.MakeGuess(); 
          x--;
        }
        
       }while(x>0);

    }

}