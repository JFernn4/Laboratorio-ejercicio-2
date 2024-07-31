namespace Laboratorio_ejercicio_2
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
                            Product.AddProducts(productsList);
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear ();
                            Product.SearchAProduct(productsList);
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear ();
                            Product.SellAProduct(productsList);
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            foreach (Product product in productsList)
                            {
                                Console.WriteLine($"Stock {product.Stock} Nombre: {product.Name}");
                            }
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
                }

            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Registrar productos.");
            Console.WriteLine("2. Consultar producto.");
            Console.WriteLine("3. Vender productos.");
            Console.WriteLine("4. Reabastecer prodcuto.");
        }
    }
}