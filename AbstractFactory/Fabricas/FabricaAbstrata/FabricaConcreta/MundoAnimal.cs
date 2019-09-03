/// <summary>

/// Classe Cliente

/// </summary>

class MundoAnimal

{
    private Herbivoro _herbivoro;
    private Carnivoro _carnivoro;

    // Construtor

    public MundoAnimal(ContinenteFabrica fabrica)
    {
        _herbivoro = fabrica.CriarHerbivoro();
        _carnivoro = fabrica.CriarCarnivoro();
    }

    public void CadeiaAlimentar()
    {
        _carnivoro.Comer(_herbivoro);
    }
}