﻿namespace Laboratorio_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool menu = true;
            List<Product> productsList = new List<Product>();
            while (menu)
            {
                Console.Clear();
                ShowMenu();
                option= Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.Clear ();
                            Console.ReadKey();
                            break;
                        }
                }

            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Registrar productos.");
        }
    }
}