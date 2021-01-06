using System;

class QuadradoeCubo {

  static void Main(string[] args) {
    int n = Int32.Parse(Console.ReadLine());
	
    for (int i = 1; i <= n; i++) 
    {
        var dobro = i * i;
        var cubo = dobro * i;
        Console.WriteLine(i + " " + dobro + " " + cubo);
    }
  }
}