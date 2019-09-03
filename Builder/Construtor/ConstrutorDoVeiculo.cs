/// <summary>

/// The 'Builder' abstract class

/// </summary>

abstract class ConstrutorDoVeiculo

{
    //protected Veiculo veiculo;

    protected Veiculo veiculo  { get; set; }

    // Gets vehicle instance


    public Veiculo trazerVeiculo() => veiculo; 
   
    // Abstract build methods

    public abstract void CriarChassi();
    public abstract void CriarMotor();
    public abstract void CriarRodas();
    public abstract void CriarPortas();
}