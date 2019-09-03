/// <summary>

/// The 'ConcreteBuilder2' class

/// </summary>

class CarBuilder : ConstrutorDoVeiculo

{
    public CarBuilder()
    {
        veiculo = new Veiculo("Carro");
    }

    public override void CriarChassi()
    {
        veiculo["Chassi"] = "Chassi do Carro";
    }

    public override void CriarMotor()
    {
        veiculo["Motor"] = "2500 cc";
    }

    public override void CriarRodas()
    {
        veiculo["Rodas"] = "4";
    }

    public override void CriarPortas()
    {
        veiculo["Portas"] = "4";
    }
}