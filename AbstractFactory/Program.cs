using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{

    /// <summary>

    /// MainApp startup class for Real-World

    /// Abstract Factory Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        public static void Main()
        {
            // Create and run the African animal world

            ContinenteFabrica africa = new AfricaFabrica();
            MundoAnimal mundo = new MundoAnimal(africa);
            mundo.CadeiaAlimentar();

            // Create and run the American animal world

            ContinenteFabrica america = new AmericaFabrica();
            mundo = new MundoAnimal(america);
            mundo.CadeiaAlimentar();

            // Wait for user input

            Console.ReadKey();
        }
    }
















}



