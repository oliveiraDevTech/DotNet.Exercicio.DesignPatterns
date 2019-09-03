

using System;
using System.Collections.Generic;

namespace Builder
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// Builder Design Pattern.

    /// </summary>

    public class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        public static void Main()
        {
            ConstrutorDoVeiculo construtor;

            // Create shop with vehicle builders

            Venda venda = new Venda();

            // Construct and display vehicles

            construtor = new ScooterBuilder();
            venda.Construtor(construtor);
            construtor.trazerVeiculo().Exibir();

            construtor = new CarBuilder();
            venda.Construtor(construtor);
            construtor.trazerVeiculo().Exibir();

            construtor = new MotoConstrutor();
            venda.Construtor(construtor);
            construtor.trazerVeiculo().Exibir();

            // Wait for user

            Console.ReadKey();
        }
    }

           

}