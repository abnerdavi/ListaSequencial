using System;

class MainClass {

  public static void exibeNumero(float numero){
    Console.WriteLine("O numero informado foi {0}", numero);
  }

  public static void Main () {
    float numero; 
    Console.WriteLine("Digite um numero: ");
    numero = float.Parse(Console.ReadLine());
    exibeNumero(numero);
  }
}