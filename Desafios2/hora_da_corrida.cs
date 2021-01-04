using System;

class HoraDaCorrida {
  public static void Main (string[] args) {
    
    string[] entrada = Console.ReadLine().Split(" ");
    int numeroDeVoltas = int.Parse(entrada[0]);
    int numeroDePlacas = int.Parse(entrada[1]);
    
    int totalDePlacas = numeroDePlacas * numeroDeVoltas;
    
    for(int i = 10; i < 100; i += 10)
    {
      double result = (double)totalDePlacas / 100 * i;
      Console.Write(Math.Ceiling(result) + " ");
    }
  }
}