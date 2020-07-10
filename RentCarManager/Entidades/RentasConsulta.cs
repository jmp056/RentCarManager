using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarManager.Entidades
{
    public class RentasConsulta
    {
        [Key]
        public int RentaId { get; set; }
        public string NombreCliente { get; set; }
        public string Celular { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Version { get; set; }
        public int AnoFabricacion { get; set; }
        public string Placa { get; set; }

        public RentasConsulta()
        {
            RentaId = 0;
            NombreCliente = string.Empty;
            Celular = string.Empty;
            FechaRegistro = DateTime.Now;
            Marca = string.Empty;
            Modelo = string.Empty;
            Version = string.Empty;
            AnoFabricacion = 0;
            Placa = string.Empty;
        }
    }
}
