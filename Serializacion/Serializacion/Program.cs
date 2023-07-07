using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Serializacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Celular> celulares = new List<Celular>()
            {
                new Celular(1, "Samsung", "s22", 3500),
                new Celular(2, "xiaomi", "mi12", 2000),
                new Celular(3, "Apple", "14 pro", 5000),
                new Celular(4, "Motorola", "e30", 1000),
                new Celular(5, "Samsung", "s22", 3500),
                new Celular(6, "xiaomi", "mi12", 3500),
                new Celular(7, "Apple", "14 pro", 2342),
                new Celular(8, "Motorola", "e30", 4532)
            };

            var option = new JsonSerializerOptions { WriteIndented = true };

            foreach(Celular c in celulares)
            {
                String json = JsonSerializer.Serialize(c, option);
                Console.WriteLine(json);
            }

            Console.ReadLine();
        }
    }
}
