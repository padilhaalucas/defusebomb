using System;

namespace BombExercise
{
  class ProgramDefuse
  {
    public static void Main(string[] args)
    {
      string WireInput;
      String[] WireInputOptions = new string[4];

      int x;
      bool defused = true;

      for (x = 0; x < WireInputOptions.Length; x++)
      {
        Console.WriteLine("Escolha o fio a ser cortado: ");
        WireInput = (Console.ReadLine().ToLower().Trim()); // Padronizar em minúsculo, os caracteres e "Limpar" a string
        if (WireInput == "branco" || WireInput == "verde" || WireInput == "vermelho" || WireInput == "preto" || WireInput == "laranja" || WireInput == "roxo")
          WireInputOptions[x] = WireInput; // Validação para entradas não expectadas
        else
        {
          Console.WriteLine("Escolha um fio existente");
        }
      }
      for (x = 0; x < 2; x++)
      {
        if (WireInputOptions[x] == "branco")
        {
          if((WireInputOptions[x+1] == "branco") || (WireInputOptions[x+1] == "preto"))
          {
            Console.WriteLine("A bomba explodiu!");
            defused = false;
            break;
          }
        }
        if (WireInputOptions[x] == "vermelho")
        {
          if ((WireInputOptions[x + 1] != "verde"))
          {
            Console.WriteLine("A bomba explodiu!");
            defused = false;
            break;
          }
        }

        if (WireInputOptions[x] == "preto")
        {
          if ((WireInputOptions[x + 1] == "branco") || (WireInputOptions[x + 1] == "verde") || (WireInputOptions[x + 1] == "laranja"))
          {
            Console.WriteLine("A bomba explodiu!");
            defused = false;
            break;
          }
        }

        if (WireInputOptions[x] == "laranja")
        {
          if ((WireInputOptions[x + 1] != "vermelho") || (WireInputOptions[x + 1] != "preto"))
          {
            Console.WriteLine("A bomba explodiu!");
            defused = false;
            break;
          }
        }

        if (WireInputOptions[x] == "verde")
        {
          if ((WireInputOptions[x + 1] != "laranja") || (WireInputOptions[x + 1] != "branco"))
          {
            Console.WriteLine("A bomba explodiu!");
            defused = false;
            break;
          }
        }
        if (WireInputOptions[x] == "roxo")
        {
          if ((WireInputOptions[x + 1] == "roxo") || (WireInputOptions[x + 1] == "verde") || (WireInputOptions[x + 1] == "laranja") || (WireInputOptions[x + 1] == "branco"))
          {
            Console.WriteLine("A bomba explodiu!");
            defused = false;
            break;
          }
        }
      }
      if (defused == true)
      {
        Console.WriteLine("A bomba foi desarmada.");
      }
    }
  }
}
