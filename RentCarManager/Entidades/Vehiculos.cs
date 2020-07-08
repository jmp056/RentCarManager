using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarManager.Entidades
{
    class Vehiculos
    {
       [Key]
        public int VehiculoId { get; set; }
        public string Chasis { get; set; }
        public string Matricula { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Version { get; set; }
        public DateTime AnoFabricacion { get; set; }
        public float Precio { get; set; }
        public int Estado { get; set; }

        public Vehiculos()
        {
            VehiculoId = 0;
            Chasis = string.Empty;
            Matricula = string.Empty;
            Placa = string.Empty;
            Marca = string.Empty;
            Modelo = string.Empty;
            Version = string.Empty;
            AnoFabricacion = DateTime.Now;
            Precio = 0;
            Estado = 0;
        }
    }
}
