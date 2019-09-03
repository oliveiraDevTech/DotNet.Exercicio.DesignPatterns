/// <summary>

/// The 'Director' class

/// </summary>

class Venda

{
    // Builder uses a complex series of steps

    public void Construtor(ConstrutorDoVeiculo vehicleBuilder)
    {
        vehicleBuilder.CriarChassi();
        vehicleBuilder.CriarMotor();
        vehicleBuilder.CriarRodas();
        vehicleBuilder.CriarPortas();
    }
}