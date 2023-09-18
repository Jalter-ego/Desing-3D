﻿using System;
namespace DiseñoRepisa
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game = new Game(800, 600)) // Crea una instancia de la clase Game
            {
                game.Run(60.0); // Ejecuta la aplicación de juego
            }
        }
    }
}
