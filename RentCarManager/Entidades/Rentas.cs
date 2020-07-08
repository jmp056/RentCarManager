using System;
using System.ComponentModel.DataAnnotations;

namespace RentCarManager.Entidades
{
    public class Rentas
    {
        [Key]
        public int RentaId { get; set; }
        public string NombreCliente { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Dias { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public float Precio { get; set; }

        public Rentas()
        {
            RentaId = 0;
            NombreCliente = string.Empty;
            Cedula = string.Empty;
            Celular = string.Empty;
            Direccion = string.Empty;
            FechaRegistro = DateTime.Now;
            Dias = 0;
            FechaInicio = DateTime.Now;
            FechaFinal = DateTime.Now;
            Precio = 0;
        }
    }
}
