using System;

class Corrida {
  static void Main(string[] args) {
    int numTartarugas = 0;
    int maxVelo = 0;
    int nivelVel = 0;
    String linhaTartaruga = Console.ReadLine();

    while( linhaTartaruga != null){

      String[] tartarugas = linhaTartaruga.Split(" ");
      numTartarugas = Int32.Parse(tartarugas[0]);
      String[] velTartarugas = Console.ReadLine().Split(" ");
      for (int i = 0; i < numTartarugas ; i++){
          if (Int32.Parse(velTartarugas[i]) > maxVelo) { maxVelo = Int32.Parse(velTartarugas[i]); }
      }
      if(maxVelo < 10){ 
        nivelVel = 1; 
      }
      if(maxVelo >= 10 && maxVelo < 20){
        nivelVel = 2; 
      }
      if(maxVelo >= 20){
        nivelVel = 3; 
      }
      
      Console.WriteLine(nivelVel);
      maxVelo = 0;
      linhaTartaruga = Console.ReadLine();
    }
 }
}