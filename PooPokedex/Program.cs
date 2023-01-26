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
        resp = Menu();
        switch (resp)
        {
          case 1:
            pokedex.ListPokemons();
            break;
          case 2:
            pokedex.ListPokemons();

            Console.Write("Digite o código do pokémon: ");
            int cod = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            PokemonPlus player = pokedex.Pokemons[cod];

            cod = r.Next(0, pokedex.Pokemons.Count);
            PokemonPlus machine = pokedex.Pokemons[cod];

            Console.WriteLine("Dados dos pokemons");
            Console.WriteLine("Dados do seu pokémon");
            player.ShowDataPokemonPlus();
            Console.WriteLine("Dados do pokémon adversario");
            machine.ShowDataPokemonPlus();
            
            if (player.Power >= machine.Power)
            {
              Console.WriteLine("Voce ganhou");
            }
            else
            {
              Console.WriteLine("Que pena, voce perdeu!");
            }
            break;
          case 0:
            break;
        }
        Console.ReadKey();
        Console.Clear();
      }
     
      Console.ReadKey();
    }

    static int Menu()
    {
      Console.WriteLine("Pokemon - Jogo de batalha");

      Console.WriteLine("0 - Sair da pokedex");
      Console.WriteLine("1 - Listar todos os pokemons");
      Console.WriteLine("2 - Batalhar");
      Console.WriteLine("O que deseja fazer: ");
      int res = Convert.ToInt32(Console.ReadLine());
      return res;
    }
  }
}