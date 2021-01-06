using System;

class Ultrapassando {

  static void Main(string[] args){
    
        int r = Int32.Parse(Console.ReadLine());
        int v = 0;
        int soma = 0;
        int conta = 0;

        while (v <= r){
            v = Int32.Parse(Console.ReadLine());
        }

        while (soma <= v){
            soma += r;
            r++;
            conta++;
        }
        Console.WriteLine(conta);
  }

}