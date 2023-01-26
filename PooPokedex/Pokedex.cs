using System;
namespace PooPokedex
{
	public class Pokedex
	{
    public Pokedex()
    {
      this.InitList();
    }
    private List<PokemonPlus> pokemons;

		public List<PokemonPlus> Pokemons
		{
			get { return this.pokemons; }
		}

		private void InitList()
		{
			// Instanciar a lista
			this.pokemons = new List<PokemonPlus>();
      PokemonPlus p = new PokemonPlus("Bulbasauro", "pokémon tipo planta", 100);
      this.pokemons.Add(p);
      p = new PokemonPlus("Mew", "lendario psiquico", 90);
      this.pokemons.Add(p);
      p = new PokemonPlus("Mewtwo", "lendario psiquico", 20);
      this.pokemons.Add(p);
      p = new PokemonPlus("Giratina", "lendario Fantasma", 80);
      this.pokemons.Add(p);
      p = new PokemonPlus("Flygon", "pokemon dragão", 12);
      this.pokemons.Add(p);
      p = new PokemonPlus("Metagross", "pokemon de metal", 50);
      this.pokemons.Add(p);
      p = new PokemonPlus("Muk", "pokemon de metal", 60);
      this.pokemons.Add(p);
      p = new PokemonPlus("Metagross", "pokemon toxico", 59);
      this.pokemons.Add(p);
      p = new PokemonPlus("Metagross", "pokemon toxico", 90);
      this.pokemons.Add(p);
    }

    public void ListPokemons()
    {
      for (int i = 0; i < this.Pokemons.Count; i++)
      {
        Console.WriteLine("Codigo do pokemon: " + i);
        this.Pokemons[i].ShowPokemonData();
      }
    }
	}
}

