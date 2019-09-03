/// <summary>

/// The 'ConcreteFactory1' class

/// </summary>

class AfricaFabrica : ContinenteFabrica

{
    public override Herbivoro CriarHerbivoro()
    {
        return new Gnu();
    }
    public override Carnivoro CriarCarnivoro()
    {
        return new Leao();
    }
}
