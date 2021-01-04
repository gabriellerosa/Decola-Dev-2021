using System;

class Pizza {
  public static void Main (string[] args) {
    string[] entrada = Console.ReadLine().Split(" ");
    int numeroDePessoas = int.Parse(entrada[0]);
    int numeroDeDatasConsideradas = int.Parse(entrada[1]);
    
    string dataPossivel = "";
    bool todosPodem = true;
    for(int i = 1; i <= numeroDeDatasConsideradas; i++)
    {
      todosPodem = true;
      string[] entradaDois = Console.ReadLine().Split(" ");
      dataPossivel = entradaDois[0];
      for(int a = 1; a <= numeroDePessoas; a++)
      {
        int convidado = int.Parse(entradaDois[a]);
        if(convidado == 0)
        {
          todosPodem = false;
          break;
        }
      }
      if(todosPodem)
      {
        Console.WriteLine(dataPossivel);
        break;
      }
    }
    
    if(!todosPodem)
      Console.WriteLine("Pizza antes de FdA");
      
  }
}