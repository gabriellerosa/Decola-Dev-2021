using System;
using System.Collections.Generic;
using System.Linq;

class Joias {

  static void Main(string[] args) {
    var joias = new List<string>();
    
    while(true) {
      string joia = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(joia))
        joias.Add(joia);
      else
        break;
    }

    var qtd = joias.Distinct().ToList();
    Console.WriteLine(qtd.Count);
  }
}