using System;
using System.Security;
using Microsoft.VisualBasic;

namespace Guess_the_number;

 class Player{

    private string nombre;
    private int intento;
   
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

     public int Intento
    {
        get { return intento; }
        set { intento = value; }
    }

    public Player(string nombre)
    {
        this.Nombre = nombre;
        this.Intento = 0;
    }

    public static bool MakeGuess(int numSecreto,int intento){

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


}