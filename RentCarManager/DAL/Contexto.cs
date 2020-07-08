using RentCarManager.Entidades;
using System.Data.Entity;

namespace RentCarManager.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Rentas> Rentas { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}
