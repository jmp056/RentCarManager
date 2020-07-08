using System;
using System.ComponentModel.DataAnnotations;

namespace RentCarManager.Entidades
{
    public class Rentas
    {
        [Key]
        public int RentaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Dias { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public float Precio { get; set; }

        public Rentas()
        {
            RentaId = 0;
            FechaRegistro = DateTime.Now;
            Dias = 0;
            FechaInicio = DateTime.Now;
            FechaFinal = DateTime.Now;
            Precio = 0;
        }
    }
}
