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
                try
                {
                    ShowMenu();
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Product.AddProducts(productsList);
                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                Product.SearchAProduct(productsList);
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                Product.SellAProduct(productsList);
                                Console.ReadKey();
                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
                                Product.ResupplyStock(productsList);
                                Console.ReadKey();
                                break;
                            }
                        case 5:
                            {
                                Console.Clear();
                                Product.UpdatePrices(productsList);
                                Console.ReadKey();
                                break;
                            }
                        case 6:
                            {
                                menu = false;
                                break;
                            }
                    }
                }
                catch (Exception ex) { Console.WriteLine($"Debe ingresar un numero del 1 al 6. " + ex.Message); Console.ReadKey(); }
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Registrar productos.");
            Console.WriteLine("2. Consultar producto.");
            Console.WriteLine("3. Vender productos.");
            Console.WriteLine("4. Reabastecer prodcuto.");
            Console.WriteLine("5. Actualizar precio.");
            Console.WriteLine("6. Salir.");
        }
    }
}