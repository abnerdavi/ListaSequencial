using System;

class MainClass {

  //Faça um Programa que peça dois números e imprima a soma
  public static void soma2num(){
    float num1 = pegaNum();
    float num2 = pegaNum();
    
    Console.WriteLine("\nA soma dos numeros informados é {0}\n", (num1+num2));
  }

  //Faça um Programa que peça as 4 notas bimestrais e mostre a média.
  public static void calcMedia(){
    
    float[] notas = new float[4];
    float media=0;
    Console.WriteLine("Digite a seguir, as 4 notas bimestrais, sendo uma de cada vez");
    for(int i=0;i<4;i++){
      notas[i] = pegaNum();
      media = media + notas[i];
    }
    
    media = (float)media/4;

    Console.WriteLine("\nA media das notas informadas é {0}\n",media);
    
  }

  public static float pegaNum(){
    
    Console.Write("Informe um numero (para decimais, use . ):\n>> ");
    float num = float.Parse(Console.ReadLine());
    
    return num;
  }

  public static void Main () {
    int op;
    bool repeat=true;
    while(repeat){

      Console.WriteLine("----- MENU OPCOES ----- ");
      Console.WriteLine("(1) Soma de numeros");
      Console.WriteLine("(2) Media de notas");
      Console.Write("(3) Sair\n-> ");

      op = int.Parse(Console.ReadLine());
      
      switch (op){

        case 1:
          soma2num();
          break;
        case 2:
          calcMedia();
          break;
        case 3:
          repeat = false;
          break;
        default:
          Console.WriteLine("Opcao incorreta!");
          break;

      }
      Console.WriteLine("Pressione qualquer tecla para continuar...");
      Console.ReadKey(true);
      Console.Clear();
    }

  }
}