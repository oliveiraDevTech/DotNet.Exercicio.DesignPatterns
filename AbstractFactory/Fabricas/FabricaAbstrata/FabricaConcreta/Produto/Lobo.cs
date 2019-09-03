


using System;
/// <summary>
/// The 'ProductB2' class
/// </summary>
class Lobo : Carnivoro

{
    public override void Comer(Herbivoro h)
    {
        // Comer Bisao

        Console.WriteLine(this.GetType().Name +
          " come " + h.GetType().Name);
    }
}