using System;

class Program {
  public static void Main (string[] args)
{ 
     Double maça,preço;
    String entrada;
    //Escreval
    Console.WriteLine("Digite a quantidade de maças");
    //Leia
    entrada=Console.ReadLine();
    //converte a entrada em texto no formato númerico
    maça = Double.Parse(entrada);
//se(num%2=0) entao 
    //C# a comparação é feita com ==
    if(maça >= 12) 
    {  
      preço = maça*1.30;
      Console.WriteLine("O preço da maça e " + preço);
    }
    else
    { preço = maça*1.30;
      
      Console.WriteLine("O preço da maça e " + preço);
    }
    
  }
}