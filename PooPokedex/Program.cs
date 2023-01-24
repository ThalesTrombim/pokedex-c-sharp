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
      Pokemon p = new Pokemon();

      p.Name = "Bulbasauro";
      p.Description = "e um pokemon do tipo planta.";

      p.ShowPokemonData();
      Console.ReadKey();

    }
  }
}