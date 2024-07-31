using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_ejercicio_2
{
    internal class Product
    {
        public int Id { get; set; }
        public string  Name{ get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(int id, string name, double price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }
        public static void AddProducts(List <Product> productsList)
        {
            Console.WriteLine("Ingrese el id del producto que desea ingresar.");
            int id= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del producto.");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto.");
            double price= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de stock del producto.");
            int stock= Convert.ToInt32(Console.ReadLine());
            Product product= new Product(id, name, price, stock);
            productsList.Add(product); //add an object
            Console.WriteLine("El producto ha sido registrado.");
        }
        public static void SearchAProduct(List <Product> productsList)
        {
            Console.WriteLine("Ingrese el id del producto que desee consultar.");
            int searchID= Convert.ToInt32(Console.ReadLine());
            Product search = productsList.Find(p=>p.Id==searchID);
            if (search != null)
            {
                    Console.WriteLine($"ID: {search.Id}, Nombre: {search.Name}, Precio: {search.Price}, Stock: {search.Stock}.");
            }
            else
            {
                Console.WriteLine("El producto no ha sido encontrado.");
            }
        }
        public static void SellAProduct(List<Product> productsList)
        {
            Console.WriteLine("Ingrese el id del producto que desee vender.");
            int searchID = Convert.ToInt32(Console.ReadLine());
            foreach (Product product in productsList)
            {
                if (searchID== product.Id)
                {
                    Console.WriteLine("Ingrese la cantidad de productos que desea vender. ");
                    int sellAmount= Convert.ToInt32(Console.ReadLine());
                    product.Stock= product.Stock-sellAmount;
                }
                else
                {
                    Console.WriteLine("No se ha encontrado el producto.");
                }
            }
        }
        public static void ResupplyStock(List<Product> productsList)
        {
            Console.WriteLine("Ingrese el id del producto que desea reabastecer.");
            int searchID = Convert.ToInt32(Console.ReadLine());
            foreach (Product product in productsList)
            {
                if (searchID == product.Id)
                {
                    Console.WriteLine("Ingrese la cantidad de productos que desea añadir. ");
                    int resupplyAmount = Convert.ToInt32(Console.ReadLine());
                    product.Stock = product.Stock + resupplyAmount;
                    Console.WriteLine($"Se han añadido {resupplyAmount} unidades de producto al stock.");
                }
                else
                {
                    Console.WriteLine("No se ha encontrado el producto.");
                }
            }
        }

    }
}
