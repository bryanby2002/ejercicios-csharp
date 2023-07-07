using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public  class Celular
    {

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }

        public Celular()
        {

        }

        public Celular(int id, String marca, String modelo, double precio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
        }

    }
}
