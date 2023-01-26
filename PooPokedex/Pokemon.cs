using System;
namespace PooPokedex
{
	public class Pokemon
	{
		public Pokemon()
		{
			this.Name = "";
			this.Description = "";
		}

    public Pokemon(string name, string description)
    {
      this.Name = name;
      this.Description = description;
    }

    private string name;

		public string Name {
			get
			{
				return this.name;
			}
			set
			{

        this.name = value;
			}
		}

    private string description;

    public string Description
    {
      get
      {
        return this.description;
      }
      set
      {
        this.description = value;
      }
    }

		public void ShowPokemonData()
		{
			Console.WriteLine("Nome do Pokémon: " + this.Name);
      Console.WriteLine("Descricao do Pokémon: " + this.Description);
    }

    public void ShowPokemonData(Boolean formated)
    {
      if(formated)
      {
        Console.WriteLine("Pokemon: " + this.Name + " - " + this.Description);
      }
      else
      {
        Console.WriteLine("Nome do Pokémon: " + this.Name);
        Console.WriteLine("Descricao do Pokémon: " + this.Description);
      }
    }
  }
}

