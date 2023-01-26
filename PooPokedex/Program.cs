using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPokedex
{
  class Program
  {
    static void Main(string[] args)
    {
      Pokedex pokedex = new Pokedex();
      int resp = 100;

      while (resp != 0)
      {
        switch (resp)
        {
          case 1:
            pokedex.ListPokemons();
            break;
          case 0:
            Console.ReadKey();
            break;
        }
        Console.ReadKey();
        Console.Clear();
      }
     
      Console.ReadKey();
    }

    static int Menu()
    {
      Console.WriteLine("Pokedex - Agenda pokemon");

      Console.WriteLine("0 - Sair da pokedex");
      Console.WriteLine("1 - Listar todos os pokemons");
      Console.WriteLine("O que deseja fazer: ");
      int res = Convert.ToInt32(Console.ReadLine());
      return res;
    }
  }
}