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
    }
}
