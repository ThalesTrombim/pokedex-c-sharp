using System;
namespace PooPokedex
{
	public class PokemonPlus : Pokemon
	{
    
		public PokemonPlus():base()
		{
			this.Power = 0;
		}
    public PokemonPlus(string name, string description, int power) : base(name, description)
    {
      this.Power = power;
    }

    public int Power { get; set; }

		public void ShowDataPokemonPlus()
		{
      Console.WriteLine("Nome do Pokémon: " + this.Name);
      Console.WriteLine("Descricao do Pokémon: " + this.Description);
      Console.WriteLine("Poder: " + this.Power);
    }
	}
}
