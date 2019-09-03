
/// <summary>

/// The 'ConcreteFactory2' class

/// </summary>

class AmericaFabrica : ContinenteFabrica

{
    public override Herbivoro CriarHerbivoro()
    {
        return new Bisao();
    }
    public override Carnivoro CriarCarnivoro()
    {
        return new Lobo();
    }
}