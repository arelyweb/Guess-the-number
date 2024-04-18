using System;
using System.Diagnostics.Tracing;
using System.Security;
using Microsoft.VisualBasic;

namespace Guess_the_number;

 class Player{
 
   
    public string Nombre { get ; set ; }

     private int _Intento {get; set ; }

    public Player(string nombre)
    {
        Nombre = nombre;
        _Intento = 0;
    }

    public int MakeGuess(){
      
     
        Console.WriteLine($"{Environment.NewLine} {Nombre} ingresa tu intento.");
  
        if( int.TryParse(Console.ReadLine(), out int num) ){
            return num;
        }else{
           Console.WriteLine($"{Environment.NewLine} {Nombre} ingresa un intento válido.");
            return MakeGuess();
        }
    

    }

    public void GetLastGuess(){
      Console.WriteLine($"Tu último intento fue: {_Intento}");
    }


}