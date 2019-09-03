/// <summary>

/// The 'ConcreteBuilder1' class

/// </summary>

class MotoConstrutor : ConstrutorDoVeiculo

{
    public MotoConstrutor()
    {
        veiculo = new Veiculo("Moto");
    }

    public override void CriarChassi()
    {
        veiculo["Chassi"] = "Chassi da Moto";
    }

    public override void CriarMotor()
    {
        veiculo["Motor"] = "500 cc";
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