using System;
namespace PooPokedex
{
	public class Pokedex
	{
    public Pokedex()
    {
      this.InitList();
    }
    private List<Pokemon> pokemons;

		public List<Pokemon> Pokemons
		{
			get { return this.pokemons; }
		}

		private void InitList()
		{
			// Instanciar a lista
			this.pokemons = new List<Pokemon>();
      Pokemon p = new Pokemon("Bulbasauro", "pokémon tipo planta");
      this.pokemons.Add(p);
      p = new Pokemon("Mew", "lendario psiquico");
      this.pokemons.Add(p);
      p = new Pokemon("Mewtwo", "lendario psiquico");
      this.pokemons.Add(p);
      p = new Pokemon("Giratina", "lendario Fantasma");
      this.pokemons.Add(p);
      p = new Pokemon("Flygon", "pokemon dragão");
      this.pokemons.Add(p);
      p = new Pokemon("Metagross", "pokemon de metal");
      this.pokemons.Add(p);
      p = new Pokemon("Muk", "pokemon de metal");
      this.pokemons.Add(p);
      p = new Pokemon("Metagross", "pokemon toxico");
      this.pokemons.Add(p);
      p = new Pokemon("Metagross", "pokemon toxico");
      this.pokemons.Add(p);
    }

    public void ListPokemons()
    {
      for (int i = 0; i < this.Pokemons.Count; i++)
      {
        this.Pokemons[i].ShowPokemonData();
      }
    }
	}
}

