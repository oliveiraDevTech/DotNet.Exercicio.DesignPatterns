/// <summary>

/// The 'ConcreteBuilder3' class

/// </summary>

class ScooterBuilder : ConstrutorDoVeiculo

{
    public ScooterBuilder()
    {
        veiculo = new Veiculo("Scooter");
    }

    public override void CriarChassi()
    {
        veiculo["Chassi"] = "Chassi da sScooter";
    }

    public override void CriarMotor()
    {
        veiculo["Motor"] = "50 cc";
    }

    public override void CriarRodas()
    {
        veiculo["Rodas"] = "2";
    }

    public override void CriarPortas()
    {
        veiculo["Portas"] = "0";
    }
}