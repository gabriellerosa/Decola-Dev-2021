using System;
using System.Text.RegularExpressions;

class Rodizio {
  public static void Main (string[] args) {
    var qtd = int.Parse(Console.ReadLine());
    
    for(int i = 1; i <= qtd; i++)
    {
      string placa = Console.ReadLine();
      var padraoCorreto = new Regex("[A-Z]{3}[0-9]{4}");
      
      if (string.IsNullOrWhiteSpace(placa)
          || placa.Length != 8
          || !placa.Contains("-"))
      {
        Console.WriteLine("FALHA");
        continue;
      } 
      
      placa = placa.Replace("-", "").Trim();
      if (!padraoCorreto.IsMatch(placa)) 
      {
        Console.WriteLine("FALHA");
        continue;
      }
      
      int finalDaPlaca = int.Parse(placa.Substring(6,1));

      switch (finalDaPlaca)
      {
          case 1:
              Console.WriteLine("SEGUNDA");
              break;
          case 2:
              Console.WriteLine("SEGUNDA");
              break;
          case 3:
              Console.WriteLine("TERCA");
              break;
          case 4:
              Console.WriteLine("TERCA");
              break;
          case 5:
              Console.WriteLine("QUARTA");
              break;
          case 6:
              Console.WriteLine("QUARTA");
              break;
          case 7:
              Console.WriteLine("QUINTA");
              break;
          case 8:
              Console.WriteLine("QUINTA");
              break;
          case 9:
              Console.WriteLine("SEXTA");
              break;
          case 0:
              Console.WriteLine("SEXTA");
              break;
        }
    }
  }
}