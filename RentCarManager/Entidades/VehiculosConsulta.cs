using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarManager.Entidades
{
    public class VehiculosConsulta
    {
        [Key]
        public int VehiculoId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Version { get; set; }
        public int AnoFabricacion { get; set; }
        public string Placa { get; set; }
        public string Estado { get; set; }
        public float Precio { get; set; }

        public VehiculosConsulta()
        {
            VehiculoId = 0;
            Marca = string.Empty;
            Modelo = string.Empty;
            Version = string.Empty;
            AnoFabricacion = 0;
            Placa = string.Empty;
            Estado = string.Empty;
            Precio = 0;
        }
    }
}
