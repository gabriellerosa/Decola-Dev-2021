using System;

class Cardapio {
  public static void Main (string[] args) {
    string[] disponivel = Console.ReadLine().Split(" ");
    int ca = int.Parse(disponivel[0]);
    int ba = int.Parse(disponivel[1]);
    int pa = int.Parse(disponivel[2]);
    string[] requisitado = Console.ReadLine().Split(" ");
    int cr = int.Parse(requisitado[0]);
    int br = int.Parse(requisitado[1]);
    int pr = int.Parse(requisitado[2]);
    
    int totalRefeicoesFaltantes = 0;
    
    if (ca - cr < 0)
    {
      totalRefeicoesFaltantes += (ca - cr) * -1;
    }
    
    if (ba - br < 0)
    {
      totalRefeicoesFaltantes += (ba - br) * -1;
    }
    
    if (pa - pr < 0)
    {
     totalRefeicoesFaltantes += (pa - pr) * -1;
    }
  
    Console.WriteLine(totalRefeicoesFaltantes);
  }
}