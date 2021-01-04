  
using System;

class Dobby {
  public static void Main (string[] args) {
    var minutosRes = int.Parse(Console.ReadLine());
    string[] entrada = Console.ReadLine().Split(" ");
    int minutosPresenteA = int.Parse(entrada[0]);
    int minutosPresenteB = int.Parse(entrada[1]);
    
    int tempoTotal = minutosPresenteA + minutosPresenteB;

    if (tempoTotal > minutosRes)
      Console.WriteLine("Deixa para amanha!");
    else
      Console.WriteLine("Farei hoje!");
    
   
  }
}