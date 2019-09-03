


using System;
/// <summary>
/// The 'ProductB1' class
/// </summary>
class Leao : Carnivoro

{
    public override void Comer(Herbivoro h)
    {
        // Comer Gnu

        Console.WriteLine(this.GetType().Name +
          " come " + h.GetType().Name);
    }
}
