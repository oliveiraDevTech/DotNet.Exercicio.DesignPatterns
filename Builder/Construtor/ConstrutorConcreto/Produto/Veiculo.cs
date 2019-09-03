


using System;
using System.Collections.Generic;
/// <summary>
/// The 'Product' class
/// </summary>
class Veiculo

{
    private string _TipoDoVeiculo;
    private Dictionary<string, string> _partes =  new Dictionary<string, string>();

    // Constructor

    public Veiculo(string tipoDoVeiculo)
    {
        this._TipoDoVeiculo = tipoDoVeiculo;
    }

    // Indexer

    public string this[string key]
    {
        get { return _partes[key]; }
        set { _partes[key] = value; }
    }

    public void Exibir()
    {
        Console.WriteLine("\n---------------------------");
        Console.WriteLine("Tipo do Veiculo: {0}", _TipoDoVeiculo);
        Console.WriteLine(" Chassi : {0}", _partes["Chassi"]);
        Console.WriteLine(" Motor : {0}", _partes["Motor"]);
        Console.WriteLine(" Rodas: {0}", _partes["Rodas"]);
        Console.WriteLine(" Portas : {0}", _partes["Portas"]);
    }
}